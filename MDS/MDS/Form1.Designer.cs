﻿namespace MDS
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
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(188, 42);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(129, 85);
            this.buttonRegisterUser.TabIndex = 0;
            this.buttonRegisterUser.Text = "Register User";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Suspend User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRegisterUser);
            this.Name = "Form1";
            this.Text = "MDS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
