namespace Itec_Project
{
    partial class ContactListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewContactButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AddToMail = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.ContactsGroupBox = new System.Windows.Forms.GroupBox();
            this.PanelContacts = new System.Windows.Forms.Panel();
            this.PrototypeContactButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.RemoveFromMail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewContactName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewContactEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ContactsGroupBox.SuspendLayout();
            this.PanelContacts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewContactButton
            // 
            this.AddNewContactButton.AutoSize = true;
            this.AddNewContactButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewContactButton.Location = new System.Drawing.Point(39, 129);
            this.AddNewContactButton.Name = "AddNewContactButton";
            this.AddNewContactButton.Size = new System.Drawing.Size(116, 26);
            this.AddNewContactButton.TabIndex = 2;
            this.AddNewContactButton.Text = "Add new contact";
            this.AddNewContactButton.UseVisualStyleBackColor = true;
            this.AddNewContactButton.Click += new System.EventHandler(this.AddNewContactButton_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete selected contacts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // AddToMail
            // 
            this.AddToMail.AutoSize = true;
            this.AddToMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddToMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToMail.Location = new System.Drawing.Point(247, 73);
            this.AddToMail.Name = "AddToMail";
            this.AddToMail.Size = new System.Drawing.Size(193, 26);
            this.AddToMail.TabIndex = 4;
            this.AddToMail.Text = "Add selected contacts to mail";
            this.AddToMail.UseVisualStyleBackColor = true;
            this.AddToMail.Click += new System.EventHandler(this.AddToMail_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.AutoSize = true;
            this.SelectAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllButton.Location = new System.Drawing.Point(247, 9);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(73, 26);
            this.SelectAllButton.TabIndex = 5;
            this.SelectAllButton.Text = "Select all";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // ContactsGroupBox
            // 
            this.ContactsGroupBox.Controls.Add(this.PanelContacts);
            this.ContactsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ContactsGroupBox.Name = "ContactsGroupBox";
            this.ContactsGroupBox.Size = new System.Drawing.Size(229, 288);
            this.ContactsGroupBox.TabIndex = 6;
            this.ContactsGroupBox.TabStop = false;
            this.ContactsGroupBox.Text = "Contacts";
            // 
            // PanelContacts
            // 
            this.PanelContacts.AutoScroll = true;
            this.PanelContacts.Controls.Add(this.PrototypeContactButton);
            this.PanelContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContacts.Location = new System.Drawing.Point(3, 18);
            this.PanelContacts.Name = "PanelContacts";
            this.PanelContacts.Size = new System.Drawing.Size(223, 267);
            this.PanelContacts.TabIndex = 0;
            // 
            // PrototypeContactButton
            // 
            this.PrototypeContactButton.BackColor = System.Drawing.Color.YellowGreen;
            this.PrototypeContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrototypeContactButton.Location = new System.Drawing.Point(6, 3);
            this.PrototypeContactButton.Name = "PrototypeContactButton";
            this.PrototypeContactButton.Size = new System.Drawing.Size(188, 27);
            this.PrototypeContactButton.TabIndex = 1;
            this.PrototypeContactButton.Text = "Prototype@contact.com";
            this.PrototypeContactButton.UseVisualStyleBackColor = false;
            this.PrototypeContactButton.Visible = false;
            this.PrototypeContactButton.Click += new System.EventHandler(this.PrototypeContactButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(383, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(464, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(383, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(464, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // RemoveFromMail
            // 
            this.RemoveFromMail.AutoSize = true;
            this.RemoveFromMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveFromMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromMail.Location = new System.Drawing.Point(247, 105);
            this.RemoveFromMail.Name = "RemoveFromMail";
            this.RemoveFromMail.Size = new System.Drawing.Size(235, 26);
            this.RemoveFromMail.TabIndex = 7;
            this.RemoveFromMail.Text = "Remove selected contacts from mail";
            this.RemoveFromMail.UseVisualStyleBackColor = true;
            this.RemoveFromMail.Click += new System.EventHandler(this.RemoveFromMail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.NewContactName);
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // NewContactName
            // 
            this.NewContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactName.Location = new System.Drawing.Point(6, 21);
            this.NewContactName.Name = "NewContactName";
            this.NewContactName.Size = new System.Drawing.Size(168, 22);
            this.NewContactName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.NewContactEmail);
            this.groupBox2.Location = new System.Drawing.Point(14, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email address";
            // 
            // NewContactEmail
            // 
            this.NewContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactEmail.Location = new System.Drawing.Point(6, 21);
            this.NewContactEmail.Name = "NewContactEmail";
            this.NewContactEmail.Size = new System.Drawing.Size(168, 22);
            this.NewContactEmail.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.AddNewContactButton);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(260, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 163);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New contact details";
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RemoveFromMail);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ContactsGroupBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.AddToMail);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "ContactListForm";
            this.Text = "ContactListForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDownEventHandler);
            this.ContactsGroupBox.ResumeLayout(false);
            this.PanelContacts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewContactButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddToMail;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.GroupBox ContactsGroupBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button PrototypeContactButton;
        private System.Windows.Forms.Button RemoveFromMail;
        private System.Windows.Forms.Panel PanelContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewContactName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NewContactEmail;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}