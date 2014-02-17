namespace Itec_Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SessionNameTextBox = new System.Windows.Forms.TextBox();
            this.SeeAllAttachmentsButton = new System.Windows.Forms.Button();
            this.ListOfTheAttachments = new System.Windows.Forms.ListBox();
            this.ListOfTheContacts = new System.Windows.Forms.ListBox();
            this.SeeContactListButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmailsNumberTextBox = new System.Windows.Forms.NumericUpDown();
            this.IsHtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxTimeTextBox = new System.Windows.Forms.NumericUpDown();
            this.MinTimeTextBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CounterCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomSubjectCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PortTextBox = new System.Windows.Forms.NumericUpDown();
            this.ExchangeRadioButton = new System.Windows.Forms.RadioButton();
            this.SmtpRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelPercentage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailsNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTimeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinTimeTextBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTextBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromTextBox
            // 
            this.FromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTextBox.Location = new System.Drawing.Point(6, 80);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(305, 22);
            this.FromTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTextBox.Location = new System.Drawing.Point(6, 313);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(305, 22);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageRichTextBox.Location = new System.Drawing.Point(6, 357);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.Size = new System.Drawing.Size(305, 93);
            this.MessageRichTextBox.TabIndex = 6;
            this.MessageRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SessionNameTextBox);
            this.groupBox1.Controls.Add(this.SeeAllAttachmentsButton);
            this.groupBox1.Controls.Add(this.ListOfTheAttachments);
            this.groupBox1.Controls.Add(this.ListOfTheContacts);
            this.groupBox1.Controls.Add(this.SubjectTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SeeContactListButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MessageRichTextBox);
            this.groupBox1.Controls.Add(this.FromTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 465);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // SessionNameTextBox
            // 
            this.SessionNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionNameTextBox.Location = new System.Drawing.Point(6, 39);
            this.SessionNameTextBox.Name = "SessionNameTextBox";
            this.SessionNameTextBox.Size = new System.Drawing.Size(305, 22);
            this.SessionNameTextBox.TabIndex = 16;
            // 
            // SeeAllAttachmentsButton
            // 
            this.SeeAllAttachmentsButton.AutoSize = true;
            this.SeeAllAttachmentsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeAllAttachmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeAllAttachmentsButton.Location = new System.Drawing.Point(161, 263);
            this.SeeAllAttachmentsButton.Name = "SeeAllAttachmentsButton";
            this.SeeAllAttachmentsButton.Size = new System.Drawing.Size(144, 26);
            this.SeeAllAttachmentsButton.TabIndex = 15;
            this.SeeAllAttachmentsButton.Text = "Manage Attachments";
            this.SeeAllAttachmentsButton.UseVisualStyleBackColor = true;
            this.SeeAllAttachmentsButton.Click += new System.EventHandler(this.SeeAllAttachmentsButton_Click);
            // 
            // ListOfTheAttachments
            // 
            this.ListOfTheAttachments.FormattingEnabled = true;
            this.ListOfTheAttachments.ItemHeight = 16;
            this.ListOfTheAttachments.Location = new System.Drawing.Point(156, 124);
            this.ListOfTheAttachments.Name = "ListOfTheAttachments";
            this.ListOfTheAttachments.Size = new System.Drawing.Size(155, 132);
            this.ListOfTheAttachments.TabIndex = 14;
            // 
            // ListOfTheContacts
            // 
            this.ListOfTheContacts.FormattingEnabled = true;
            this.ListOfTheContacts.ItemHeight = 16;
            this.ListOfTheContacts.Location = new System.Drawing.Point(6, 124);
            this.ListOfTheContacts.Name = "ListOfTheContacts";
            this.ListOfTheContacts.Size = new System.Drawing.Size(144, 132);
            this.ListOfTheContacts.TabIndex = 13;
            // 
            // SeeContactListButton
            // 
            this.SeeContactListButton.AutoSize = true;
            this.SeeContactListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeContactListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeContactListButton.Location = new System.Drawing.Point(12, 263);
            this.SeeContactListButton.Name = "SeeContactListButton";
            this.SeeContactListButton.Size = new System.Drawing.Size(123, 26);
            this.SeeContactListButton.TabIndex = 12;
            this.SeeContactListButton.Text = "Manage Contacts";
            this.SeeContactListButton.UseVisualStyleBackColor = true;
            this.SeeContactListButton.Click += new System.EventHandler(this.SeeContactListButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Attachments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmailsNumberTextBox);
            this.groupBox2.Controls.Add(this.IsHtmlCheckBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.MaxTimeTextBox);
            this.groupBox2.Controls.Add(this.MinTimeTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CounterCheckBox);
            this.groupBox2.Controls.Add(this.RandomMessageCheckBox);
            this.groupBox2.Controls.Add(this.RandomSubjectCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(490, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiplication Options";
            // 
            // EmailsNumberTextBox
            // 
            this.EmailsNumberTextBox.Location = new System.Drawing.Point(6, 39);
            this.EmailsNumberTextBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EmailsNumberTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EmailsNumberTextBox.Name = "EmailsNumberTextBox";
            this.EmailsNumberTextBox.Size = new System.Drawing.Size(82, 22);
            this.EmailsNumberTextBox.TabIndex = 20;
            this.EmailsNumberTextBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // IsHtmlCheckBox
            // 
            this.IsHtmlCheckBox.AutoSize = true;
            this.IsHtmlCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsHtmlCheckBox.Location = new System.Drawing.Point(6, 224);
            this.IsHtmlCheckBox.Name = "IsHtmlCheckBox";
            this.IsHtmlCheckBox.Size = new System.Drawing.Size(124, 20);
            this.IsHtmlCheckBox.TabIndex = 19;
            this.IsHtmlCheckBox.Text = "Message is html";
            this.IsHtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Max";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Min";
            // 
            // MaxTimeTextBox
            // 
            this.MaxTimeTextBox.Location = new System.Drawing.Point(42, 115);
            this.MaxTimeTextBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MaxTimeTextBox.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaxTimeTextBox.Name = "MaxTimeTextBox";
            this.MaxTimeTextBox.Size = new System.Drawing.Size(82, 22);
            this.MaxTimeTextBox.TabIndex = 16;
            this.MaxTimeTextBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MinTimeTextBox
            // 
            this.MinTimeTextBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinTimeTextBox.Location = new System.Drawing.Point(42, 87);
            this.MinTimeTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinTimeTextBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinTimeTextBox.Name = "MinTimeTextBox";
            this.MinTimeTextBox.Size = new System.Drawing.Size(82, 22);
            this.MinTimeTextBox.TabIndex = 15;
            this.MinTimeTextBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Emails Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Time between emails";
            // 
            // CounterCheckBox
            // 
            this.CounterCheckBox.AutoSize = true;
            this.CounterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterCheckBox.Location = new System.Drawing.Point(6, 146);
            this.CounterCheckBox.Name = "CounterCheckBox";
            this.CounterCheckBox.Size = new System.Drawing.Size(159, 20);
            this.CounterCheckBox.TabIndex = 6;
            this.CounterCheckBox.Text = "Add counter to subject";
            this.CounterCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomMessageCheckBox
            // 
            this.RandomMessageCheckBox.AutoSize = true;
            this.RandomMessageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomMessageCheckBox.Location = new System.Drawing.Point(6, 198);
            this.RandomMessageCheckBox.Name = "RandomMessageCheckBox";
            this.RandomMessageCheckBox.Size = new System.Drawing.Size(161, 20);
            this.RandomMessageCheckBox.TabIndex = 8;
            this.RandomMessageCheckBox.Text = "Add random message";
            this.RandomMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomSubjectCheckBox
            // 
            this.RandomSubjectCheckBox.AutoSize = true;
            this.RandomSubjectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomSubjectCheckBox.Location = new System.Drawing.Point(6, 172);
            this.RandomSubjectCheckBox.Name = "RandomSubjectCheckBox";
            this.RandomSubjectCheckBox.Size = new System.Drawing.Size(147, 20);
            this.RandomSubjectCheckBox.TabIndex = 7;
            this.RandomSubjectCheckBox.Text = "Add random subject";
            this.RandomSubjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PortTextBox);
            this.groupBox6.Controls.Add(this.ExchangeRadioButton);
            this.groupBox6.Controls.Add(this.SmtpRadioButton);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.PasswordTextBox);
            this.groupBox6.Controls.Add(this.UsernameTextBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.AddressTextBox);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(490, 286);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 211);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Send via";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(166, 91);
            this.PortTextBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(65, 22);
            this.PortTextBox.TabIndex = 19;
            this.PortTextBox.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // ExchangeRadioButton
            // 
            this.ExchangeRadioButton.AutoSize = true;
            this.ExchangeRadioButton.Location = new System.Drawing.Point(6, 45);
            this.ExchangeRadioButton.Name = "ExchangeRadioButton";
            this.ExchangeRadioButton.Size = new System.Drawing.Size(218, 20);
            this.ExchangeRadioButton.TabIndex = 18;
            this.ExchangeRadioButton.TabStop = true;
            this.ExchangeRadioButton.Text = "Exchange Server Mail Transport";
            this.ExchangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SmtpRadioButton
            // 
            this.SmtpRadioButton.AutoSize = true;
            this.SmtpRadioButton.Location = new System.Drawing.Point(6, 19);
            this.SmtpRadioButton.Name = "SmtpRadioButton";
            this.SmtpRadioButton.Size = new System.Drawing.Size(64, 20);
            this.SmtpRadioButton.TabIndex = 17;
            this.SmtpRadioButton.TabStop = true;
            this.SmtpRadioButton.Text = "SMTP";
            this.SmtpRadioButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Port";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 180);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(225, 22);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(6, 136);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(225, 22);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(6, 91);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(158, 22);
            this.AddressTextBox.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 503);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(93, 503);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 16;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 503);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(472, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.schedulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveAsToolStripMenuItem.Text = "Save as ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelPercentage
            // 
            this.LabelPercentage.AutoSize = true;
            this.LabelPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercentage.Location = new System.Drawing.Point(202, 508);
            this.LabelPercentage.Name = "LabelPercentage";
            this.LabelPercentage.Size = new System.Drawing.Size(14, 16);
            this.LabelPercentage.TabIndex = 21;
            this.LabelPercentage.Text = "\'\'";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(5, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 95);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // schedulesToolStripMenuItem
            // 
            this.schedulesToolStripMenuItem.Name = "schedulesToolStripMenuItem";
            this.schedulesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.schedulesToolStripMenuItem.Text = "Schedules";
            this.schedulesToolStripMenuItem.Click += new System.EventHandler(this.schedulesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(737, 533);
            this.Controls.Add(this.LabelPercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bulk Email Sender (by TM Studios)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailsNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTimeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinTimeTextBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTextBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox RandomMessageCheckBox;
        private System.Windows.Forms.CheckBox RandomSubjectCheckBox;
        private System.Windows.Forms.CheckBox CounterCheckBox;
        private System.Windows.Forms.Button SeeContactListButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SeeAllAttachmentsButton;
        public System.Windows.Forms.ListBox ListOfTheContacts;
        public System.Windows.Forms.ListBox ListOfTheAttachments;
        private System.Windows.Forms.TextBox SessionNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ExchangeRadioButton;
        private System.Windows.Forms.RadioButton SmtpRadioButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MaxTimeTextBox;
        private System.Windows.Forms.NumericUpDown MinTimeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox IsHtmlCheckBox;
        private System.Windows.Forms.NumericUpDown EmailsNumberTextBox;
        private System.Windows.Forms.NumericUpDown PortTextBox;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelPercentage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem schedulesToolStripMenuItem;
    }
}

