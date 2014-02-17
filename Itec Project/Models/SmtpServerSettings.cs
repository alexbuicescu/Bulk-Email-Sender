using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Itec_Project.Models
{
    public class SmtpServerSettings
    {
        public SmtpServerSettings() { }

        public string Address { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public SmtpClient GetSmtpClient()
        {
            return new SmtpClient()
            {
                Host = Address,
                Port = Port,
                Credentials = new System.Net.NetworkCredential(User, Password),
                EnableSsl = true
            };
        }
    }
}
