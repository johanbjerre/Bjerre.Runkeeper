namespace Bjerre.Runkeeper.TestApp
{
    partial class Form1
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
            this.collectStats = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.startDateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // collectStats
            // 
            this.collectStats.Location = new System.Drawing.Point(12, 64);
            this.collectStats.Name = "collectStats";
            this.collectStats.Size = new System.Drawing.Size(117, 23);
            this.collectStats.TabIndex = 0;
            this.collectStats.Text = "collectStats";
            this.collectStats.UseVisualStyleBackColor = true;
            this.collectStats.Click += new System.EventHandler(this.collectStats_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 329);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(117, 20);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "username";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 38);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(117, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.Text = "password";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(12, 94);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(117, 20);
            this.startDateBox.TabIndex = 5;
            this.startDateBox.Text = "May-01-2013";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 353);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.collectStats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button collectStats;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox startDateBox;
    }
}

