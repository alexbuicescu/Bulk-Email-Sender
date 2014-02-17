namespace Itec_Project
{
    partial class AttachmentsListForm
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
            this.AddNewAttachmentButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.AttachmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.PanelAttachments = new System.Windows.Forms.Panel();
            this.PrototypeAttachmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.AttachmentsGroupBox.SuspendLayout();
            this.PanelAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewAttachmentButton
            // 
            this.AddNewAttachmentButton.AutoSize = true;
            this.AddNewAttachmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewAttachmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAttachmentButton.Location = new System.Drawing.Point(244, 12);
            this.AddNewAttachmentButton.Name = "AddNewAttachmentButton";
            this.AddNewAttachmentButton.Size = new System.Drawing.Size(146, 26);
            this.AddNewAttachmentButton.TabIndex = 2;
            this.AddNewAttachmentButton.Text = "Add new attachement";
            this.AddNewAttachmentButton.UseVisualStyleBackColor = true;
            this.AddNewAttachmentButton.Click += new System.EventHandler(this.AddNewAttachmentButton_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete selected attachments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.AutoSize = true;
            this.SelectAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllButton.Location = new System.Drawing.Point(247, 44);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(73, 26);
            this.SelectAllButton.TabIndex = 5;
            this.SelectAllButton.Text = "Select all";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // AttachmentsGroupBox
            // 
            this.AttachmentsGroupBox.Controls.Add(this.PanelAttachments);
            this.AttachmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachmentsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AttachmentsGroupBox.Name = "AttachmentsGroupBox";
            this.AttachmentsGroupBox.Size = new System.Drawing.Size(229, 288);
            this.AttachmentsGroupBox.TabIndex = 6;
            this.AttachmentsGroupBox.TabStop = false;
            this.AttachmentsGroupBox.Text = "Attachments";
            // 
            // PanelAttachments
            // 
            this.PanelAttachments.AutoScroll = true;
            this.PanelAttachments.Controls.Add(this.PrototypeAttachmentButton);
            this.PanelAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAttachments.Location = new System.Drawing.Point(3, 18);
            this.PanelAttachments.Name = "PanelAttachments";
            this.PanelAttachments.Size = new System.Drawing.Size(223, 267);
            this.PanelAttachments.TabIndex = 0;
            // 
            // PrototypeAttachmentButton
            // 
            this.PrototypeAttachmentButton.BackColor = System.Drawing.Color.YellowGreen;
            this.PrototypeAttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrototypeAttachmentButton.Location = new System.Drawing.Point(6, 3);
            this.PrototypeAttachmentButton.Name = "PrototypeAttachmentButton";
            this.PrototypeAttachmentButton.Size = new System.Drawing.Size(188, 27);
            this.PrototypeAttachmentButton.TabIndex = 1;
            this.PrototypeAttachmentButton.Text = "Prototype@attachments.com";
            this.PrototypeAttachmentButton.UseVisualStyleBackColor = false;
            this.PrototypeAttachmentButton.Visible = false;
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
            // AttachmentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddNewAttachmentButton);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.AttachmentsGroupBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Name = "AttachmentsListForm";
            this.Text = "AttachmentsListForm";
            this.AttachmentsGroupBox.ResumeLayout(false);
            this.PanelAttachments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewAttachmentButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.GroupBox AttachmentsGroupBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button PrototypeAttachmentButton;
        private System.Windows.Forms.Panel PanelAttachments;
    }
}