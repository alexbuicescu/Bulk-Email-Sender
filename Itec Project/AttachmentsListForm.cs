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
    public partial class AttachmentsListForm : Form
    {
        List<Button> theDisplayedAttachmentList = new List<Button>();
        List<Button> theSelectedAttachments = new List<Button>();

        public MainForm principalForm = null;

        public AttachmentsListForm(Form inlocuie)
        {
            InitializeComponent();
            principalForm = inlocuie as MainForm;
            loadButtons();
        }

        public void loadButtons()
        {
            int xFirst = PrototypeAttachmentButton.Location.X;
            int yFirst = PrototypeAttachmentButton.Location.Y;

            Button but;

            foreach (Attachment contact in principalForm.Session.Attachments)
            {
                addOneButton(out but, xFirst, yFirst);
                but.Text = contact.OriginalFileName;
                theDisplayedAttachmentList.Add(but);

                yFirst = theDisplayedAttachmentList[theDisplayedAttachmentList.Count - 1].Location.Y + PrototypeAttachmentButton.Size.Height + 5;

                but = null;
            }
        }

        void addOneButton(out Button butonul, int xCord, int yCord)
        {
            butonul = new Button();
            butonul.Location = new System.Drawing.Point(xCord, yCord);
            butonul.Size = new System.Drawing.Size(PrototypeAttachmentButton.Size.Width, PrototypeAttachmentButton.Size.Height);
            butonul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            butonul.AutoSize = true;
            butonul.BackColor = System.Drawing.Color.CornflowerBlue;
            butonul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butonul.UseVisualStyleBackColor = true;
            butonul.Click += new System.EventHandler(this.clickedAttachment);
            PanelAttachments.Controls.Add(butonul);
        }

        Color theColorOfPressedButton, theColorToChangeTo, darkColor, lightColor;
        bool isLight = false;

        private void clickedAttachment(object sender, EventArgs e)
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
                    theSelectedAttachments.Add(theClickedButton);
                }
                else
                    ///if the button is pressed
                    if (isLight)
                    {
                        theClickedButton.BackColor = theColorToChangeTo;
                        theSelectedAttachments.Remove(theClickedButton);
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
                        for (int i = 0; i < theSelectedAttachments.Count; i++)
                        {
                            getColors(theSelectedAttachments[i].BackColor, out eachDark, out eachLight, out changeTo);
                            theSelectedAttachments[i].BackColor = eachDark;
                        }
                        theSelectedAttachments.Clear();

                        ///select the button
                        theClickedButton.BackColor = theColorToChangeTo;
                        theSelectedAttachments.Add(theClickedButton);
                    }
                    else
                        ///if the button is pressed
                        if (isLight)
                        {
                            bool isMore = false;
                            ///daca sunt mai multe butoane selectate atunci deselecteaza pe toate si selecteaza pe cel apasat
                            if (theSelectedAttachments.Count > 1)
                            {
                                isMore = true;
                            }

                            Color eachDark, eachLight, changeTo;
                            ///empty the list
                            for (int i = 0; i < theSelectedAttachments.Count; i++)
                            {
                                getColors(theSelectedAttachments[i].BackColor, out eachDark, out eachLight, out changeTo);
                                theSelectedAttachments[i].BackColor = eachDark;
                            }
                            theSelectedAttachments.Clear();

                            ///are there any more buttons pressed???
                            if (!isMore)
                            {
                                theClickedButton.BackColor = darkColor;
                                theSelectedAttachments.Remove(theClickedButton);
                            }
                            else
                                if (isMore)
                                {
                                    theClickedButton.BackColor = lightColor;
                                    theSelectedAttachments.Add(theClickedButton);
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

        private void AddNewAttachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = true;

            if (of.ShowDialog() != System.Windows.Forms.DialogResult.Cancel &&
               of.FileName.Length > 0)
            {
                Button but;
                Point lastPoint = new Point();
                foreach (String file in of.FileNames)
                {
                    try
                    {
                        lastPoint = theDisplayedAttachmentList[theDisplayedAttachmentList.Count - 1].Location;
                        lastPoint.Y += PrototypeAttachmentButton.Size.Height + 5;
                    }
                    ///it enters catch if there is no name in the Attachment list
                    catch
                    {
                        lastPoint = PrototypeAttachmentButton.Location;
                    }
                    Attachment at = new Attachment();
                    at.OriginalFileName = file;
                    //at.FullFileName = file;
                    //at.OriginalFileName = at.ToString();
                    
                    principalForm.Session.Attachments.Add(at);

                    addOneButton(out but, lastPoint.X, lastPoint.Y);
                    but.Text = at.OriginalFileName;
                    theDisplayedAttachmentList.Add(but);

                    but = null;
                }
            }
        }

        private Attachment GetAttachmentOriginalFileName(string fullfilename)
        {
            if(principalForm != null && principalForm.Session != null && principalForm.Session.Attachments != null)
            return principalForm.Session.Attachments.Where(a => a.OriginalFileName == fullfilename).FirstOrDefault();
            return new Attachment();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            theSelectedAttachments = theDisplayedAttachmentList;

            Color eachDark, eachLight, changeTo;

            for (int i = 0; i < theSelectedAttachments.Count; i++)
            {
                getColors(theSelectedAttachments[i].BackColor, out eachDark, out eachLight, out changeTo);
                theSelectedAttachments[i].BackColor = eachLight;
            }
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            ///delete the Attachments from the main form
            for (int i = 0; i < theSelectedAttachments.Count; i++)
            {
                Attachment at = GetAttachmentOriginalFileName(theSelectedAttachments[i].Text);
                principalForm.Session.Attachments.Remove(at);                
            }

            for (int i = 0; i < theSelectedAttachments.Count; i++)
            {
                theSelectedAttachments[i].Text = "";
            }

            for (int i = 0; i < theDisplayedAttachmentList.Count; i++)
            {
                if (theDisplayedAttachmentList[i].Text == "")
                {
                    for (int j = theDisplayedAttachmentList.Count - 1; j > i; j--)
                    {
                        theDisplayedAttachmentList[j].Location = theDisplayedAttachmentList[j - 1].Location;
                    }
                }
            }

            ///Delete the buttons from memory
            Button theBut;
            while (theSelectedAttachments.Count != 0)
            {
                theBut = theSelectedAttachments[0];
                theSelectedAttachments.Remove(theBut);
                theDisplayedAttachmentList.Remove(theBut);
                PanelAttachments.Controls.Remove(theBut);
            }

        }

    }
}
