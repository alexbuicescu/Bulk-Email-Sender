using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Collections.Generic;
using System.Net.Mime;
using System.Windows.Forms;

namespace Itec_Project.Models
{
    [Table("Sessions")]
    public class Session
    {
        public Session() { }
        public Session(Session s, int newId = -1)
        {
            Id = newId == -1 ? s.Id : newId;
            Name = s.Name;
            From = s.From;
            Subject = s.Subject;
            Message = s.Message;
            MailOptions = s.MailOptions;
            SmtpSettings = s.SmtpSettings;
            Contacts = s.Contacts;
            Attachments = new ObservableCollection<Attachment>();
            foreach (Attachment a in s.Attachments)
            {
                Attachment at = new Attachment(a, 0);
                at.SessionId = Id;
                Attachments.Add(at);
            }
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is mandatory.")]
        [MaxLength(800, ErrorMessage = "The session name can't have more than 800 characters.")]
        public string Name { get; set; }

        [Required, MaxLength(320, ErrorMessage = "An email address can't have more than 320 character.")]
        public string From { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }

        public MailOptions MailOptions { get; set; }
        public SmtpServerSettings SmtpSettings { get; set; }
        
        [NotMapped]
        public ObservableCollection<Contact> Contacts { get; set; }
        [NotMapped]
        public ObservableCollection<Attachment> Attachments { get; set; }

        public void GetContacts(DataContext db = null)
        {
            if (db == null) db = new DataContext();
            Contacts = new ObservableCollection<Contact>();
            foreach (SessionContact sc in db.SessionContacts.Where(s => s.SessionId == Id).Include(s => s.Contact))
                Contacts.Add(sc.Contact);
        }
        public void GetAttachments(DataContext db = null)
        {
            if (db == null) db = new DataContext();
            Attachments = new ObservableCollection<Attachment>();
            foreach (Attachment att in db.Attachments.Where(s => s.SessionId == Id))
                Attachments.Add(att);
        }

        public override string ToString()
        {
            return Name;
        }

        public bool Validate()
        {
            if (Name == null || Name == string.Empty)
                throw new UserException("You have to enter a name for session.");
            if (Name.Length > 800)
                throw new UserException("The session name can't have more than 800 characters.");
            if ((new DataContext()).Sessions.Where(s => s.Name == Name && s.Id != Id).Any())
                throw new UserException(String.Format("A session named '{0}' already exists. Please enter a different name.", Name));

            if (From == null || From == string.Empty)
                throw new UserException("The e-mail address is mandatory.");
            if (From.Length > 300)
                throw new UserException("A e-mail address can't have more than 320 characters.");
            if (!Helper.CheckEmailAddress(From))
                throw new UserException("The 'From' e-mail address is incorrect.");

            if (!MailOptions.UseRandomSubject && (Subject == null || Subject == string.Empty))
                throw new UserException("You have to enter a subject.");
            if (!MailOptions.UseRandomMessage && (Message == null || Message == string.Empty))
                throw new UserException("You have to enter a message.");

            if (Contacts.Count() == 0)
                throw new UserException("You have to add at least one contact.");

            if (MailOptions.MinTime >= MailOptions.MaxTime)
                throw new UserException("MinTime has to be smaller than MaxTime.");

            if (SmtpSettings.Address == null || SmtpSettings.Address == string.Empty)
                throw new UserException("You have to enter an address.");
            if (SmtpSettings.Port <= 0)
                throw new UserException("You have to enter a valid port.");

            if (SmtpSettings.User != null && SmtpSettings.User != string.Empty)
                if (SmtpSettings.Password == null || SmtpSettings.Password == string.Empty)
                    throw new UserException("You have to enter a password.");            
            return true;
        }

        public void LinkContacts(DataContext db = null)
        {
            if (db == null) db = new DataContext();
            if (Contacts == null) GetContacts(db);
            foreach (SessionContact sc_exitent in db.SessionContacts.Where(sc => sc.SessionId == Id))
            {
                if (!Contacts.Where(c => c.Id == sc_exitent.ContactId).Any())
                    db.SessionContacts.Remove(sc_exitent);
            }
            db.SaveChanges();
            foreach (Contact contact in Contacts)
            {
                Contact co = db.Contacts.Where(c => c.Email == contact.Email).FirstOrDefault();
                if (!db.SessionContacts.Where(sc => sc.SessionId == Id && sc.ContactId == contact.Id).Any())
                {
                    SessionContact sc = new SessionContact()
                    {
                        ContactId = co.Id,
                        SessionId = Id
                    };
                    db.SessionContacts.Add(sc);
                }
            }
            db.SaveChanges();
        }
        public void LinkAttachments(DataContext db = null)
        {
            if (db == null) db = new DataContext();
            if (Attachments == null) GetAttachments(db);
            foreach (Attachment db_attachment in db.Attachments.Where(a => a.SessionId == Id))
            {
                if (!Attachments.Where(c => c.Id == db_attachment.Id).Any())
                {
                    db.Attachments.Remove(db_attachment);
                    Helper.DeleteAttachmentFromDisk(db_attachment);
                }
            }
            db.SaveChanges();
            foreach (Attachment attachment in Attachments)
            {
                if (attachment.Id == 0)
                {
                    string new_name = string.Format("{0}-{1}-{2}", Id, (new Random()).Next(1, 1000).ToString(), attachment.ToString());
                    Helper.WriteToDiskAs(attachment.OriginalFileName, Helper.AttachmentsFolder + new_name);
                    attachment.FullFileName = new_name;
                    attachment.SessionId = Id;
                    db.Attachments.Add(attachment);
                }
                else
                {
                    Attachment db_attachment = db.Attachments.Find(attachment.Id);
                    if (File.Exists(db_attachment.OriginalFileName))
                        if (Helper.FileBase64(Helper.AttachmentsFolder + db_attachment.FullFileName)
                            != Helper.FileBase64(db_attachment.OriginalFileName))
                            Helper.WriteToDiskAs(attachment.OriginalFileName, Helper.AttachmentsFolder + db_attachment.FullFileName);
                }
                db.SaveChanges(); 
            }
        }
        public void Delete(DataContext db = null)
        {
            foreach (SessionContact sc in db.SessionContacts.Where(s => s.SessionId == Id))
            {
                db.SessionContacts.Remove(sc);
            }
            foreach (Attachment at in db.Attachments.Where(a => a.SessionId == Id))
            {
                db.Attachments.Remove(at);
                Helper.DeleteAttachmentFromDisk(at);
            }
            Session session = db.Sessions.Find(Id);
            if (session != null)
                db.Sessions.Remove(session);

            db.SaveChanges();
        }

        private SmtpClient client;
        public int sentEmailsSoFar;
        private Thread thread;
        public void Start()
        {
            client = SmtpSettings.GetSmtpClient();
            thread = new Thread(new ThreadStart(this.SendEmails));
            thread.Start();
            while (!thread.IsAlive) ;
        }
        public void Stop()
        {
            if (thread == null) return;
            thread.Abort();
            sentEmailsSoFar = 0;
        }

        private void SendEmails()
        {
            try
            {
                DateTime dt = DateTime.Now;
                string RandomSubject = MailOptions.UseRandomSubject ? Helper.getRandomText() : "";
                string RandomMessage = MailOptions.UseRandomMessage ? Helper.getRandomText(50) : "";

                for (int i = 0; i < MailOptions.EmailsNumber; i++)
                {
                    try
                    {
                        sentEmailsSoFar++;
                        client.Send(GetMail(RandomSubject, RandomMessage, i));
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(string.Format("Email #{0} failed. Error: {1}", i, ex.Message));
                    }
                    if (MailOptions.EmailsNumber > 1)
                        System.Threading.Thread.Sleep(MailOptions.ElapsingTime);
                    
                }
                //MessageBox.Show("Finished in " + (DateTime.Now - dt).TotalMilliseconds.ToString());
                sentEmailsSoFar++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed sending emails");
                System.Diagnostics.Debug.WriteLine(string.Format("Failed sending emails. Error: {0}", ex.Message));
            }
        }
        public MailMessage GetMail(string RandomSubject = "", string RandomMessage = "", int CurrentEmail = 0)
        {
            MailMessage mm = new MailMessage()
            {
                From = new MailAddress(From),
                Subject = MailOptions.UseRandomSubject ? Subject + " " + RandomSubject : Subject,
                IsBodyHtml = MailOptions.IsHtml,
                Body = MailOptions.UseRandomMessage ? Message + "\n" + RandomMessage : Message
            };
            if (MailOptions.UseCounter)
                mm.Subject = string.Format("[{0}] {1}", CurrentEmail, Subject);
            foreach (Contact c in Contacts)
                mm.To.Add(new MailAddress(c.Email, c.Name));

            foreach (Attachment a in Attachments)
                mm.Attachments.Add(a.ToMailAttachment());

            return mm;
        }
    }    
}
