using Itec_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Itec_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.SetInitializer<DataContext>(null);
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            try
            {
                using (var context = new DataContext())
                {
                    context.Database.CreateIfNotExists();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error: Cannot connect to database. Check if you have Sql Compact Edition v4.0 .", ex);
            }
            if(args.Length > 0)            
                ExecSchedule(args);
                
            Thread th = new Thread(new ThreadStart(checkForLaunch));
            th.Start();
            while (!th.IsAlive) ;

            if (args.Length == 0)
                Application.Run(new MainForm());

            
        }
        static void ExecSchedule(string[] args)
        {
            String sessionName = args[0];
            String date = args[1];
            DataContext db = new DataContext();
            if (date != "" && sessionName != "")
            {
                Session session = db.Sessions.Where(s => s.Name == sessionName).FirstOrDefault();
                if(session == null) return;
                
                DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                dtfi.ShortDatePattern = "HH:mm dd/MM/yyyy";
                dtfi.DateSeparator = "/";
                DateTime objDate = Convert.ToDateTime(date, dtfi);

                Schedule a = new Schedule();
                a.Session = session;
                a.StartOn = objDate;
                db.Schedules.Add(a);
                db.SaveChanges();

                
            }
            else
                if (sessionName != "")
                {
                    Session session = db.Sessions.Where(s => s.Name == sessionName).FirstOrDefault();
                    if (session == null) return;
                    session.Start();
                }
        }
        private static void checkForLaunch()
        {
            
            TimeSpan dt = new TimeSpan();
            DataContext db = new DataContext();
            foreach (Schedule s in db.Schedules.Include(sc => sc.Session))
            {
                if (s.StartOn <= DateTime.Now)
                {
                    s.Session.Start();
                    db.Schedules.Remove(s);
                }
            }
            db.SaveChanges();
            if (!db.Schedules.Any()) return;
            DateTime minDate = new DateTime();
            foreach (Schedule s in db.Schedules)
            {
                if (s.StartOn < minDate)
                    minDate = s.StartOn;
            }
            dt = minDate - DateTime.Now;
            Thread.Sleep(dt);
            checkForLaunch();
        }
    }
    
}