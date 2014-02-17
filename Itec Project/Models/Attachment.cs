using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace Itec_Project.Models
{
    [Table("Attachments")]
    public class Attachment
    {
        public Attachment() { }

        public Attachment(Attachment a, int newId = -1)
        {
            Id = newId == -1 ? a.Id : newId;
            SessionId = a.SessionId;
            OriginalFileName = a.OriginalFileName;
            FullFileName = a.FullFileName;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SessionId { get; set; }
        [ForeignKey("SessionId"), Display(Name = "Session")]
        public Session Session { get; set; }

        public string OriginalFileName { get; set; }

        [Required(ErrorMessage = "The path is mandatory.")]
        public string FullFileName { get; set; }

        public override string ToString()
        {
            return OriginalFileName.Substring(OriginalFileName.LastIndexOf('\\') + 1);
        }
        public string ShortFileName()
        {
            return FullFileName.Substring(FullFileName.LastIndexOf('\\') + 1);
        }
        public System.Net.Mail.Attachment ToMailAttachment()
        {
            string prettyname = this.ToString();
            prettyname = prettyname.Substring(0, prettyname.LastIndexOf('.'));

            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(Helper.AttachmentsFolder + FullFileName, MediaTypeNames.Application.Octet);
            ContentDisposition disposition = attachment.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(Helper.AttachmentsFolder + FullFileName);
            disposition.ModificationDate = File.GetLastWriteTime(Helper.AttachmentsFolder + FullFileName);
            disposition.ReadDate = File.GetLastAccessTime(Helper.AttachmentsFolder + FullFileName);
            disposition.FileName = Path.GetFileName(prettyname);
            disposition.Size = new FileInfo(Helper.AttachmentsFolder + FullFileName).Length;
            disposition.DispositionType = DispositionTypeNames.Attachment;
            return attachment;
        }
    }
}
