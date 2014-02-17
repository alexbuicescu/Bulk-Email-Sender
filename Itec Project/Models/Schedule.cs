using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SessionId { get; set; }
        [ForeignKey("SessionId"), Display(Name = "Session")]
        public Session Session { get; set; }

        public DateTime StartOn { get; set; }
    }
}
