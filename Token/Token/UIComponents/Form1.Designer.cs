﻿namespace Token
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTab1 = new Token.LoginTab();
            this.SuspendLayout();
            // 
            // loginTab1
            // 
            this.loginTab1.Location = new System.Drawing.Point(2, 2);
            this.loginTab1.Name = "loginTab1";
            this.loginTab1.Size = new System.Drawing.Size(411, 603);
            this.loginTab1.TabIndex = 0;
            this.loginTab1.Load += new System.EventHandler(this.loginTab1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 669);
            this.ControlBox = false;
            this.Controls.Add(this.loginTab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginTab loginTab1;
    }
}