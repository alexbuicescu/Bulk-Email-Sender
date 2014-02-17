using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{
    [Table("SessionContacts")]
    public class SessionContact
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SessionId { get; set; }
        [ForeignKey("SessionId"), Display(Name = "Session")]
        public Session Session { get; set; }

        public int ContactId { get; set; }
        [ForeignKey("ContactId"), Display(Name = "Contact")]
        public Contact Contact { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
