﻿namespace TestBuilderAdmin
{
    partial class Autorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOkAdminLog = new System.Windows.Forms.Button();
            this.buttonCancelAdminLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(124, 62);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(181, 26);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(123, 130);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(181, 26);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonOkAdminLog
            // 
            this.buttonOkAdminLog.Location = new System.Drawing.Point(30, 215);
            this.buttonOkAdminLog.Name = "buttonOkAdminLog";
            this.buttonOkAdminLog.Size = new System.Drawing.Size(89, 31);
            this.buttonOkAdminLog.TabIndex = 4;
            this.buttonOkAdminLog.Text = "OK";
            this.buttonOkAdminLog.UseVisualStyleBackColor = true;
            this.buttonOkAdminLog.Click += new System.EventHandler(this.buttonOkAdminLog_Click);
            // 
            // buttonCancelAdminLog
            // 
            this.buttonCancelAdminLog.Location = new System.Drawing.Point(215, 215);
            this.buttonCancelAdminLog.Name = "buttonCancelAdminLog";
            this.buttonCancelAdminLog.Size = new System.Drawing.Size(89, 31);
            this.buttonCancelAdminLog.TabIndex = 5;
            this.buttonCancelAdminLog.Text = "Cancel";
            this.buttonCancelAdminLog.UseVisualStyleBackColor = true;
            this.buttonCancelAdminLog.Click += new System.EventHandler(this.buttonCancelAdminLog_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 278);
            this.Controls.Add(this.buttonCancelAdminLog);
            this.Controls.Add(this.buttonOkAdminLog);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autorization";
            this.Text = "Autorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonOkAdminLog;
        private System.Windows.Forms.Button buttonCancelAdminLog;
    }
}