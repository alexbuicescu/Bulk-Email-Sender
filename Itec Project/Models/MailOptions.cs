using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{
    public class MailOptions
    {
        public int EmailsNumber { get; set; }
        public int MinTime { get; set; }
        public int MaxTime { get; set; }
        public bool UseCounter { get; set; }
        public bool UseRandomSubject { get; set; }
        public bool UseRandomMessage { get; set; }
        public bool IsHtml { get; set; }

        [NotMapped]
        public int ElapsingTime
        {
            get { return (new Random()).Next(MinTime, MaxTime); }
        }
    }
}
