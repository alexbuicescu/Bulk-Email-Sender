namespace Itec_Project
{
    partial class GetStringForm
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
            this.MainButton = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(438, 32);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(75, 23);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Save";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MainTextBox.Location = new System.Drawing.Point(11, 32);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(421, 22);
            this.MainTextBox.TabIndex = 1;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MainLabel.Location = new System.Drawing.Point(12, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(206, 16);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Enter a name for the new session.";
            // 
            // GetStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 67);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.MainButton);
            this.Name = "GetStringForm";
            this.Text = "Save as";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Label MainLabel;
    }
}