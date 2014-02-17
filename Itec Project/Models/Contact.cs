using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is mandatory.")]
        [MaxLength(800, ErrorMessage = "A name can't have more than 800 characters.")]
        public string Name { get; set; }

        [Required, MaxLength(320, ErrorMessage = "An email address can't have more than 320 characters.")]
        public string Email { get; set; }

        public int EmailsNumber { get; set; }

        public override string ToString()
        {
            return Name + " <" + Email + ">";
        }
        public bool Validate()
        {
            if(Name.Length == 0)
                throw new UserException("The name is mandatory.");
            if (Name.Length > 800)
                throw new UserException("A name can't have more than 800 characters.");
            if(Email.Length == 0)
                throw new UserException("The e-mail address is mandatory.");
            if (Email.Length > 320)
                throw new UserException("A e-mail address can't have more than 320 characters.");
            if (!Helper.CheckEmailAddress(Email))
                throw new UserException("The e-mail address is incorrect.");
            return true;
        }       
    }
}
