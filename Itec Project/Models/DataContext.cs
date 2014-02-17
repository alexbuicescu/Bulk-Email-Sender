using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{    
    public class DataContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<SessionContact> SessionContacts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DataContext() : base(Properties.Settings.Default.bulk_email_senderConnectionString) { }
    }
}
