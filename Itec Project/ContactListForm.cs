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
    public partial class ContactListForm : Form
    {
        List<Button> theDisplayedContactList = new List<Button>();
        List<Button> theSelectedContacts = new List<Button>();

        public MainForm principalForm = null;

        public ContactListForm(Form inlocuie)
        {
            InitializeComponent();
            principalForm = inlocuie as MainForm;
            loadButtons();
        }

        //seteaza culoarea daca exista deja
        public void loadButtons()
        {
            int xFirst = PrototypeContactButton.Location.X;
            int yFirst = PrototypeContactButton.Location.Y;

            Button but;
            foreach (Contact contact in principalForm.db.Contacts)
            {
                addOneButton(out but, xFirst, yFirst);
                but.Text = contact.ToString();
                if (principalForm != null && principalForm.Session != null && principalForm.Session.Contacts != null)
                    if (principalForm.Session.Contacts.Where(c => c.Email == contact.Email).Any())
                    {
                        but.BackColor = Color.YellowGreen;
                    }
                theDisplayedContactList.Add(but);

                yFirst = theDisplayedContactList[theDisplayedContactList.Count - 1].Location.Y + PrototypeContactButton.Size.Height + 5;

                but = null;
            }
        }

        void addOneButton(out Button butonul, int xCord, int yCord)
        {
            butonul = new Button();
            butonul.Location = new System.Drawing.Point(xCord, yCord);
            butonul.Size = new System.Drawing.Size(PrototypeContactButton.Size.Width, PrototypeContactButton.Size.Height);
            butonul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            butonul.AutoSize = true;
            butonul.BackColor = System.Drawing.Color.CornflowerBlue;
            butonul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butonul.UseVisualStyleBackColor = true;
            butonul.Click += new System.EventHandler(this.clickedContact);
            PanelContacts.Controls.Add(butonul);
        }

        private void PrototypeContactButton_Click(object sender, EventArgs e)
        {
        }

        Color theColorOfPressedButton, theColorToChangeTo, darkColor, lightColor;
        bool isLight = false;

        private void clickedContact(object sender, EventArgs e)
        {
            ///get the button
            Button theClickedButton = (Button)sender;

            theColorOfPressedButton = theClickedButton.BackColor;

            ///check which color is which
            getColors(theColorOfPressedButton, out darkColor, out lightColor, out theColorToChangeTo);

            ///if ctrl was hold or mouse middle button
            if (ModifierKeys == Keys.Control || ModifierKeys == Keys.MButton)
            {
                ///if the button is not pressed
                if (!isLight)
                {
                    theClickedButton.BackColor = theColorToChangeTo;
                    theSelectedContacts.Add(theClickedButton);
                }
                else
                    ///if the button is pressed
                    if (isLight)
                    {
                        theClickedButton.BackColor = theColorToChangeTo;
                        theSelectedContacts.Remove(theClickedButton);
                    }
            }
            else
                if (ModifierKeys != Keys.Control && ModifierKeys != Keys.MButton)
                {
                    ///if the button is not pressed
                    if (!isLight)
                    {
                        Color eachDark, eachLight, changeTo;
                        ///empty the list
                        for (int i = 0; i < theSelectedContacts.Count; i++)
                        {
                            getColors(theSelectedContacts[i].BackColor, out eachDark, out eachLight, out changeTo);
                            theSelectedContacts[i].BackColor = eachDark;
                        }
                        theSelectedContacts.Clear();

                        ///select the button
                        theClickedButton.BackColor = theColorToChangeTo;
                        theSelectedContacts.Add(theClickedButton);
                    }
                    else
                        ///if the button is pressed
                        if (isLight)
                        {
                            bool isMore = false;
                            ///daca sunt mai multe butoane selectate atunci deselecteaza pe toate si selecteaza pe cel apasat
                            if (theSelectedContacts.Count > 1)
                            {
                                isMore = true;
                            }

                            Color eachDark, eachLight, changeTo;
                            ///empty the list
                            for (int i = 0; i < theSelectedContacts.Count; i++)
                            {
                                getColors(theSelectedContacts[i].BackColor, out eachDark, out eachLight, out changeTo);
                                theSelectedContacts[i].BackColor = eachDark;
                            }
                            theSelectedContacts.Clear();

                            ///are there any more buttons pressed???
                            if (!isMore)
                            {
                                theClickedButton.BackColor = darkColor;
                                theSelectedContacts.Remove(theClickedButton);
                            }
                            else
                                if (isMore)
                                {
                                    theClickedButton.BackColor = lightColor;
                                    theSelectedContacts.Add(theClickedButton);
                                }
                        }
                }
        }

        private void getColors(Color input, out Color dark, out Color light, out Color changeTo)
        {
            if (input == Color.CornflowerBlue)
            {
                changeTo = Color.LightSteelBlue; dark = Color.CornflowerBlue; light = Color.LightSteelBlue;
                isLight = false;
            }
            else
                if (input == Color.LightSteelBlue)
                {
                    changeTo = Color.CornflowerBlue; dark = Color.CornflowerBlue; light = Color.LightSteelBlue;
                    isLight = true;
                }
                else
                    if (input == Color.YellowGreen)
                    {
                        changeTo = Color.LightGreen; dark = Color.YellowGreen; light = Color.LightGreen;
                        isLight = false;
                    }
                    else
                        if (input == Color.LightGreen)
                        {
                            changeTo = Color.YellowGreen; dark = Color.YellowGreen; light = Color.LightGreen;
                            isLight = true;
                        }
                        else
                        {
                            changeTo = Color.White;
                            light = Color.White;
                            dark = Color.White;
                        }
        }

        private void AddNewContactButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact() { Name = NewContactName.Text, Email = NewContactEmail.Text };
                contact.Validate();
                if (principalForm.db.Contacts.Where(c => c.Email == contact.Email).Count() > 0)
                    throw new UserException("The contact already exists.");

                Button but;
                Point lastPoint = new Point();
                try
                {
                    lastPoint = theDisplayedContactList[theDisplayedContactList.Count - 1].Location;
                    lastPoint.Y += PrototypeContactButton.Size.Height + 5;
                }
                ///it enters catch if there is no name in the contact list
                catch
                {
                    lastPoint = PrototypeContactButton.Location;
                }
                addOneButton(out but, lastPoint.X, lastPoint.Y);
                but.Text = contact.ToString();
                theDisplayedContactList.Add(but);

                but = null;

                principalForm.db.Contacts.Add(contact);
                principalForm.db.SaveChanges();
                ResetFields();
                MessageBox.Show(contact.Name + " was added to yours contact list.", "Success");
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        private void ResetFields()
        {
            NewContactEmail.ResetText(); NewContactName.ResetText();
        }
        private void AddToMail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < theSelectedContacts.Count; i++)
            {
                if (theSelectedContacts[i].BackColor == Color.LightSteelBlue ||
                    theSelectedContacts[i].BackColor == Color.CornflowerBlue)
                {
                    Contact contact = GetContactByFullTextFromSession(theSelectedContacts[i].Text);
                    if (!principalForm.Session.Contacts.Contains(contact))
                        principalForm.Session.Contacts.Add(contact);
                }
                theSelectedContacts[i].BackColor = Color.LightGreen;
            }
        }

        private Contact GetContactByFullText(string fulltext)
        {
            return GetContactByEmail(getShortedString(fulltext));
        }
        private Contact GetContactByEmail(string email)
        {
            if (principalForm != null)
                return principalForm.db.Contacts.Where(c => c.Email == email).SingleOrDefault();
            return null;
        }

        private Contact GetContactByFullTextFromSession(string fulltext)
        {
            return GetContactByEmailFromSession(getShortedString(fulltext));
        }
        private Contact GetContactByEmailFromSession(string email)
        {
            if (principalForm != null)
                return principalForm.Session.Contacts.Where(c => c.Email == email).SingleOrDefault();
            return null;
        }

        private string getShortedString(string theGiven)
        {
            int first = theGiven.IndexOf('<');
            int second = theGiven.LastIndexOf('>');

            if (first != -1 && second != -1)
            {
                return theGiven.Substring(first + 1, second - first - 1);
            }
            return "";
        }

        private void RemoveFromMail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < theSelectedContacts.Count; i++)
            {
                //if (theSelectedContacts[i].BackColor == Color.LightGreen ||
                //    theSelectedContacts[i].BackColor == Color.YellowGreen)
                //{
                Contact contact = GetContactByFullTextFromSession(theSelectedContacts[i].Text);
                principalForm.Session.Contacts.Remove(contact);
                //}
                theSelectedContacts[i].BackColor = Color.LightSteelBlue;
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            theSelectedContacts = theDisplayedContactList;

            Color eachDark, eachLight, changeTo;

            for (int i = 0; i < theSelectedContacts.Count; i++)
            {
                getColors(theSelectedContacts[i].BackColor, out eachDark, out eachLight, out changeTo);
                theSelectedContacts[i].BackColor = eachLight;
            }
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            ///delete the contacts from the main form
            for (int i = 0; i < theSelectedContacts.Count; i++)
            {
                Contact contact = GetContactByFullText(theSelectedContacts[i].Text);
                principalForm.Session.Contacts.Remove(contact);

                principalForm.db.Contacts.Remove(contact);
                principalForm.db.SaveChanges();
            }

            for (int i = 0; i < theSelectedContacts.Count; i++)
            {
                theSelectedContacts[i].Text = "";
            }

            for (int i = 0; i < theDisplayedContactList.Count; i++)
            {
                if (theDisplayedContactList[i].Text == "")
                {
                    for (int j = theDisplayedContactList.Count - 1; j > i; j--)
                    {
                        theDisplayedContactList[j].Location = theDisplayedContactList[j - 1].Location;
                    }
                }
            }

            ///Delete the buttons from memory
            Button theBut;
            while (theSelectedContacts.Count != 0)
            {
                theBut = theSelectedContacts[0];
                theSelectedContacts.Remove(theBut);
                theDisplayedContactList.Remove(theBut);
                PanelContacts.Controls.Remove(theBut);
            }

        }


        public void MyKeyDownEventHandler(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveFromMail.PerformClick();
            }

            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                SelectAllButton.PerformClick();
            }
        }

    }
}
