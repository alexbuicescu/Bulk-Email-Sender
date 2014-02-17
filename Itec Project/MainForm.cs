using Itec_Project.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Itec_Project
{
    public partial class MainForm : Form
    {
        public Session Session;
        public DataContext db = new DataContext();

        public MainForm()
        {
            InitializeComponent();
            InitSession();
            LoadSessionsToolStrip();

            FromTextBox.Text = SMTPCredentials.Default.Username;
            UsernameTextBox.Text = SMTPCredentials.Default.Username;
            PasswordTextBox.Text = SMTPCredentials.Default.Password;
            PortTextBox.Value = SMTPCredentials.Default.Port;
            AddressTextBox.Text = SMTPCredentials.Default.Server;

            RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            add.SetValue("Bulk Email Sender (by TM Studios)", Application.StartupPath + @"\Itec Project.exe");
        }
        private void InitSession(Session session = null)
        {
            ResetFields();
            if (session == null)
                Session = new Session()
                {
                    Contacts = new ObservableCollection<Contact>(),
                    Attachments = new ObservableCollection<Attachment>()
                };
            else
            {
                Session = session;
                if (Session.Contacts == null)
                    Session.GetContacts();
                if (Session.Attachments == null)
                    Session.GetAttachments();
                FillFields();
            }
            ListOfTheContacts.DataSource = Session.Contacts;
            ListOfTheAttachments.DataSource = Session.Attachments;

            Session.Contacts.CollectionChanged += ToEmailsList_CollectionChanged;
            Session.Attachments.CollectionChanged += AttachmentsList_CollectionChanged;
        }
        private void FillFields()
        {
            SessionNameTextBox.Text = Session.Name;
            FromTextBox.Text = Session.From;

            ListOfTheContacts.DataSource = null;
            ListOfTheContacts.DataSource = Session.Contacts;

            ListOfTheAttachments.DataSource = null;
            ListOfTheAttachments.DataSource = Session.Attachments;

            SubjectTextBox.Text = Session.Subject;
            MessageRichTextBox.Text = Session.Message;

            EmailsNumberTextBox.Value = Session.MailOptions.EmailsNumber;
            MinTimeTextBox.Value = Session.MailOptions.MinTime;
            MaxTimeTextBox.Value = Session.MailOptions.MaxTime;

            CounterCheckBox.Checked = Session.MailOptions.UseCounter;
            RandomSubjectCheckBox.Checked = Session.MailOptions.UseRandomSubject;
            RandomMessageCheckBox.Checked = Session.MailOptions.UseRandomMessage;
            IsHtmlCheckBox.Checked = Session.MailOptions.IsHtml;

            SmtpRadioButton.Checked = true;
            ExchangeRadioButton.Checked = false;
            AddressTextBox.Text = Session.SmtpSettings.Address;
            PortTextBox.Value = Session.SmtpSettings.Port;
            UsernameTextBox.Text = Session.SmtpSettings.User;
            PasswordTextBox.Text = Session.SmtpSettings.Password;
        }
        private void ResetFields()
        {
            SessionNameTextBox.ResetText();
            FromTextBox.ResetText();

            progressBar1.Value = 0;
            LabelPercentage.Text = "0%";
            //Session.Attachments = new ObservableCollection<Attachment>();
            //Session.Contacts = new ObservableCollection<Contact>();

            //ListOfTheContacts.DataSource = null;           
            //ListOfTheAttachments.DataSource = null;

            SubjectTextBox.ResetText();
            MessageRichTextBox.ResetText();

            EmailsNumberTextBox.Value = EmailsNumberTextBox.Minimum;
            MinTimeTextBox.Value = MinTimeTextBox.Minimum;
            MaxTimeTextBox.Value = MaxTimeTextBox.Minimum;

            CounterCheckBox.Checked = true;
            RandomSubjectCheckBox.Checked = true;
            RandomMessageCheckBox.Checked = true;
            IsHtmlCheckBox.Checked = false;

            SmtpRadioButton.Checked = true;
            ExchangeRadioButton.Checked = false;
            AddressTextBox.ResetText();
            UsernameTextBox.ResetText();
            PasswordTextBox.ResetText();

            
        }
        private void LoadSessionsToolStrip()
        {
            List<ToolStripItem> items = new List<ToolStripItem>();
            openToolStripMenuItem.DropDownItems.Clear();
            foreach (Session s in db.Sessions)
                AddToolStripItem(s);            
            openToolStripMenuItem.Enabled = db.Sessions.Any();
        }
        private void AddToolStripItem(Session s)
        {
            ToolStripItem item = new ToolStripMenuItem();
            item.Text = s.Name;
            item.Click += SessionToolStripMenuItem_Click;
            openToolStripMenuItem.DropDownItems.Add(item);
        }
        void SessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripMenuItem;
            if (item == null) return;
            Session session = db.Sessions.Where(s => s.Name == item.Text).FirstOrDefault();
            if (session == null) return;
            
            InitSession(session);           
        }       

        void AttachmentsList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ListOfTheAttachments.DataSource = null;
            ListOfTheAttachments.DataSource = Session.Attachments;
        }
        void ToEmailsList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ListOfTheContacts.DataSource = null;
            ListOfTheContacts.DataSource = Session.Contacts;
        }

        private void SeeContactListButton_Click(object sender, EventArgs e)
        {
            ContactListForm cont = new ContactListForm(this);
            cont.Show();
        }
        private void SeeAllAttachmentsButton_Click(object sender, EventArgs e)
        {
            AttachmentsListForm at = new AttachmentsListForm(this);
            at.Show();
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FillSession();
                Session.Validate();

                if (Session.Id == 0)
                {
                    db.Sessions.Add(Session);
                    db.SaveChanges();
                    LoadSessionsToolStrip();
                }

                Session.LinkContacts(db);
                Session.LinkAttachments(db);
                MessageBox.Show("Session saved.");
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        private void FillSession()
        {
            Session.Name = SessionNameTextBox.Text;
            Session.From = FromTextBox.Text;
            Session.Subject = SubjectTextBox.Text;
            Session.Message = MessageRichTextBox.Text;
            Session.MailOptions = new MailOptions()
            {
                EmailsNumber = Convert.ToInt32(EmailsNumberTextBox.Value),
                MinTime = Convert.ToInt32(MinTimeTextBox.Value),
                MaxTime = Convert.ToInt32(MaxTimeTextBox.Value),
                UseCounter = CounterCheckBox.Checked,
                UseRandomSubject = RandomSubjectCheckBox.Checked,
                UseRandomMessage = RandomMessageCheckBox.Checked,
                IsHtml = IsHtmlCheckBox.Checked
            };
            Session.SmtpSettings = new SmtpServerSettings()
            {
                Address = AddressTextBox.Text,
                Port = Convert.ToInt32(PortTextBox.Value),
                User = UsernameTextBox.Text,
                Password = PasswordTextBox.Text
            };
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitSession();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetStringForm fm = new GetStringForm(this);
                FillSession();
                Session.Validate();
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public void SaveAs(string name)
        {
            try
            {
                if (Session.Id == 0)
                    throw new UserException("The current session isn't saved. You still can use it.");
                FillSession();

                Session a = new Session(Session, 0);
                a.Name = name;

                db.Sessions.Add(a);
                db.SaveChanges();

                a.LinkContacts(db);
                a.LinkAttachments(db);
                Session = a;
                FillFields();
                LoadSessionsToolStrip();
                MessageBox.Show(String.Format("Session saved as {0}.", name));
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session.Id != 0)
                {
                    Session.Delete(db);
                    LoadSessionsToolStrip();                    
                }
                InitSession();
                MessageBox.Show("Session deleted successfully.");
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        double percentage = 0;
        bool changed = false;
        int lastEmailIndex = 0, increment = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            percentage = (double)(progressBar1.Maximum * Session.sentEmailsSoFar / Session.MailOptions.EmailsNumber);
            if (percentage < 0)
            {
                percentage = 0;
            }
            int currMailIndex = Convert.ToInt32((double)percentage / (progressBar1.Maximum / Session.MailOptions.EmailsNumber));

            ///Daca a trimis deja un mail si nu a terminat de incarcat progress barul, modific timerul
            if (progressBar1.Value < currMailIndex * progressBar1.Maximum / Session.MailOptions.EmailsNumber -
                        progressBar1.Maximum / Session.MailOptions.EmailsNumber &&
                currMailIndex != lastEmailIndex)
            {
                increment *= 2;
                lastEmailIndex = currMailIndex;
            }


            if (percentage > progressBar1.Value && progressBar1.Value < progressBar1.Maximum)
            {
                if (progressBar1.Value + increment < progressBar1.Maximum)
                {
                    progressBar1.Value += increment;
                }
                else
                {
                    progressBar1.Value = progressBar1.Maximum - 1;
                }
            }
            LabelPercentage.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100.0).ToString() + "%";

            System.Diagnostics.Debug.WriteLine(progressBar1.Value + " " + percentage + " " + Session.sentEmailsSoFar + " " + Session.MailOptions.EmailsNumber);

            if (Session.MailOptions.EmailsNumber + 1 == Session.sentEmailsSoFar)
            {
                progressBar1.Value = progressBar1.Maximum;
                //progressBar1.Value = 0;
                LabelPercentage.Text = "100%";
                timer1.Stop();
                StopButton.Enabled = !StopButton.Enabled;
                StartButton.Enabled = !StartButton.Enabled;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Session.Stop();
            StopButton.Enabled = !StopButton.Enabled;
            StartButton.Enabled = !StartButton.Enabled;
            LabelPercentage.Text = "0%";
            progressBar1.Value = 0;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Validate();
                Session.LinkContacts(db);
                Session.LinkAttachments(db);
                Session.Start();
                if (Session.MailOptions.EmailsNumber > 1000)
                {
                    progressBar1.Maximum = Session.MailOptions.EmailsNumber;
                }
                else
                {
                    progressBar1.Maximum = 1000;
                }
                StopButton.Enabled = !StopButton.Enabled;
                StartButton.Enabled = !StartButton.Enabled;
                progressBar1.Value = 0;
                LabelPercentage.Text = "0%";
                timer1.Start();
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void schedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remote r = new Remote();
            r.Show();
        }
    }
}
