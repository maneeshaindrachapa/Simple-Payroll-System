﻿namespace payroll
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.checkCredentials = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.viewPassword = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Label();
            this.shutdown = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centerLogo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkCredentials
            // 
            this.checkCredentials.AutoSize = true;
            this.checkCredentials.BackColor = System.Drawing.Color.Transparent;
            this.checkCredentials.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCredentials.ForeColor = System.Drawing.Color.Red;
            this.checkCredentials.Location = new System.Drawing.Point(423, 354);
            this.checkCredentials.Name = "checkCredentials";
            this.checkCredentials.Size = new System.Drawing.Size(201, 24);
            this.checkCredentials.TabIndex = 23;
            this.checkCredentials.Text = "Incorrect Credentials";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Location = new System.Drawing.Point(913, 1);
            this.minimizeLabel.MinimumSize = new System.Drawing.Size(20, 20);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(27, 33);
            this.minimizeLabel.TabIndex = 22;
            this.minimizeLabel.Text = "-";
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // viewPassword
            // 
            this.viewPassword.AutoSize = true;
            this.viewPassword.BackColor = System.Drawing.Color.Transparent;
            this.viewPassword.Image = ((System.Drawing.Image)(resources.GetObject("viewPassword.Image")));
            this.viewPassword.Location = new System.Drawing.Point(685, 443);
            this.viewPassword.MinimumSize = new System.Drawing.Size(46, 46);
            this.viewPassword.Name = "viewPassword";
            this.viewPassword.Size = new System.Drawing.Size(46, 46);
            this.viewPassword.TabIndex = 20;
            this.viewPassword.Click += new System.EventHandler(this.viewPassword_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Raleway Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(447, 508);
            this.loginButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 30);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // shutdown
            // 
            this.shutdown.AutoSize = true;
            this.shutdown.BackColor = System.Drawing.Color.Transparent;
            this.shutdown.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdown.ForeColor = System.Drawing.Color.Transparent;
            this.shutdown.Location = new System.Drawing.Point(946, 8);
            this.shutdown.MinimumSize = new System.Drawing.Size(20, 20);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(23, 24);
            this.shutdown.TabIndex = 18;
            this.shutdown.Text = "X";
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(445, 448);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 31);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(446, 406);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 31);
            this.txtUsername.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // centerLogo
            // 
            this.centerLogo.AutoSize = true;
            this.centerLogo.BackColor = System.Drawing.Color.Transparent;
            this.centerLogo.ForeColor = System.Drawing.Color.Transparent;
            this.centerLogo.Image = ((System.Drawing.Image)(resources.GetObject("centerLogo.Image")));
            this.centerLogo.Location = new System.Drawing.Point(444, 181);
            this.centerLogo.MinimumSize = new System.Drawing.Size(167, 222);
            this.centerLogo.Name = "centerLogo";
            this.centerLogo.Size = new System.Drawing.Size(167, 222);
            this.centerLogo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.MinimumSize = new System.Drawing.Size(167, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 222);
            this.label3.TabIndex = 24;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkCredentials);
            this.Controls.Add(this.minimizeLabel);
            this.Controls.Add(this.viewPassword);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centerLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkCredentials;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label viewPassword;
        private System.Windows.Forms.Label loginButton;
        private System.Windows.Forms.Label shutdown;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label centerLogo;
        private System.Windows.Forms.Label label3;
    }
}

