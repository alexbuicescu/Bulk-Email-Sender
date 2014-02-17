using Itec_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Itec_Project
{
    public partial class GetStringForm : Form
    {       
        public MainForm principal;
        public GetStringForm(Form mainForm)
        {
            InitializeComponent();
            principal = mainForm as MainForm;
            principal.Hide();
            this.Show();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext();
            string Name = MainTextBox.Text;
            if (db.Sessions.Where(s => s.Name == Name).Any())
                MessageBox.Show(String.Format("A session named '{0}' already exists. Please enter a different name.", Name));
            else
            {
                this.Hide();
                principal.Show();
                principal.SaveAs(Name);
            }
        }
    }
}
