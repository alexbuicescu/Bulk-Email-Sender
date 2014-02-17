using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using Itec_Project.Models;

namespace Itec_Project
{
    public partial class Remote : Form
    {
        public List<DateTime> theFullScheduleTimes = new List<DateTime>();
        private DataContext db = new DataContext();

        public Remote()
        {
            InitializeComponent();
            dateTimePickerSchedule.Format = DateTimePickerFormat.Custom;
            dateTimePickerSchedule.CustomFormat = "hh:mm tt dd/MM/yyyy";
            SessionsComboBox.DataSource = db.Sessions.ToList();
            dateTimePickerSchedule.MinDate = DateTime.Now;

            loadScheduleList();
        }

        Thread th;       

        private void checkForLaunch()
        {
            TimeSpan dt = new TimeSpan();
            
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

        private void SchedulesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            foreach (ListViewItem item in SchedulesList.Items)
            {
                item.Selected = true;
            }
        }

        private void loadScheduleList()
        {
            SchedulesList.Items.Clear();
            foreach (Schedule s in db.Schedules.Include(sc => sc.Session).OrderBy(sc => sc.StartOn))
            {
                ListViewItem item1 = new ListViewItem(s.Session.ToString());
                item1.SubItems.Add(s.StartOn.ToString("hh:mm tt dd/MM/yyyy"));

                SchedulesList.Items.AddRange(new ListViewItem[] { item1 });
            }
        }
       
        private void SchedulesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (SchedulesList.SelectedItems.Count != 0)
                {
                    foreach (ListViewItem item in SchedulesList.SelectedItems)
                    {
                        Schedule a = new Schedule();
                        foreach (Schedule sc in db.Schedules.Include(s => s.Session))
                        {
                            if (sc.Session.Name == item.Text && sc.StartOn.ToString("hh:mm tt dd/MM/yyyy") == item.SubItems[1].Text)
                            {
                                a = sc;
                                break;
                            }
                        }
                        db.Schedules.Remove(a);
                        db.SaveChanges();                        
                        item.Remove();
                    }
                }
            }

            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in SchedulesList.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Schedule a = new Schedule();
                a.Session = db.Sessions.Where(s => s.Name == SessionsComboBox.Text).FirstOrDefault();
                a.StartOn = dateTimePickerSchedule.Value;
                if (a.Session != null)
                {
                    db.Schedules.Add(a);
                    db.SaveChanges();
                }
                loadScheduleList();
                SessionsComboBox.DataSource = db.Sessions.ToList();
                dateTimePickerSchedule.MinDate = DateTime.Now;
                if (db.Schedules.Count() > 0)
                {
                    Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    if(th != null) th.Abort();
                    th = new Thread(new ThreadStart(this.checkForLaunch));
                    th.Start();
                    while (!th.IsAlive) ;
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
