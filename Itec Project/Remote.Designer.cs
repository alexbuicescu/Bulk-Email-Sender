namespace Itec_Project
{
    partial class Remote
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
            this.button1 = new System.Windows.Forms.Button();
            this.SchedulesList = new System.Windows.Forms.ListView();
            this.Col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerSchedule = new System.Windows.Forms.DateTimePicker();
            this.CheckActivateSchedule = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SessionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SchedulesList
            // 
            this.SchedulesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col1,
            this.Col2});
            this.SchedulesList.FullRowSelect = true;
            this.SchedulesList.GridLines = true;
            this.SchedulesList.Location = new System.Drawing.Point(12, 110);
            this.SchedulesList.Name = "SchedulesList";
            this.SchedulesList.Size = new System.Drawing.Size(342, 241);
            this.SchedulesList.TabIndex = 29;
            this.SchedulesList.UseCompatibleStateImageBehavior = false;
            this.SchedulesList.View = System.Windows.Forms.View.Details;
            this.SchedulesList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SchedulesList_ColumnClick);
            this.SchedulesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SchedulesList_KeyDown);
            // 
            // Col1
            // 
            this.Col1.Text = "Session name";
            this.Col1.Width = 195;
            // 
            // Col2
            // 
            this.Col2.Text = "Start on";
            this.Col2.Width = 142;
            // 
            // dateTimePickerSchedule
            // 
            this.dateTimePickerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSchedule.Location = new System.Drawing.Point(69, 40);
            this.dateTimePickerSchedule.Name = "dateTimePickerSchedule";
            this.dateTimePickerSchedule.Size = new System.Drawing.Size(149, 22);
            this.dateTimePickerSchedule.TabIndex = 28;
            // 
            // CheckActivateSchedule
            // 
            this.CheckActivateSchedule.AutoSize = true;
            this.CheckActivateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckActivateSchedule.Location = new System.Drawing.Point(20, 68);
            this.CheckActivateSchedule.Name = "CheckActivateSchedule";
            this.CheckActivateSchedule.Size = new System.Drawing.Size(135, 20);
            this.CheckActivateSchedule.TabIndex = 27;
            this.CheckActivateSchedule.Text = "Activate Schedule";
            this.CheckActivateSchedule.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Start On";
            // 
            // SessionsComboBox
            // 
            this.SessionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionsComboBox.FormattingEnabled = true;
            this.SessionsComboBox.Location = new System.Drawing.Point(69, 13);
            this.SessionsComboBox.Name = "SessionsComboBox";
            this.SessionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SessionsComboBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Session";
            // 
            // Remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SessionsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SchedulesList);
            this.Controls.Add(this.dateTimePickerSchedule);
            this.Controls.Add(this.CheckActivateSchedule);
            this.Name = "Remote";
            this.Text = "Remote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView SchedulesList;
        private System.Windows.Forms.ColumnHeader Col1;
        private System.Windows.Forms.ColumnHeader Col2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSchedule;
        private System.Windows.Forms.CheckBox CheckActivateSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SessionsComboBox;
        private System.Windows.Forms.Label label2;
    }
}