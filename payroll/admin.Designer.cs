namespace payroll
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.logoutlbl1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.homeText = new System.Windows.Forms.Label();
            this.homeLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutlbl1
            // 
            this.logoutlbl1.AutoSize = true;
            this.logoutlbl1.BackColor = System.Drawing.Color.Gray;
            this.logoutlbl1.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutlbl1.Location = new System.Drawing.Point(830, 4);
            this.logoutlbl1.Margin = new System.Windows.Forms.Padding(0);
            this.logoutlbl1.Name = "logoutlbl1";
            this.logoutlbl1.Padding = new System.Windows.Forms.Padding(3);
            this.logoutlbl1.Size = new System.Drawing.Size(90, 30);
            this.logoutlbl1.TabIndex = 51;
            this.logoutlbl1.Text = "Log Out";
            this.logoutlbl1.Visible = false;
            this.logoutlbl1.Click += new System.EventHandler(this.logoutlbl1_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(922, 4);
            this.logout.MinimumSize = new System.Drawing.Size(30, 30);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 30);
            this.logout.TabIndex = 50;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Raleway Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(796, 63);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(0, 24);
            this.usernamelbl.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(708, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "welcome";
            // 
            // horizontalLine
            // 
            this.horizontalLine.AutoSize = true;
            this.horizontalLine.BackColor = System.Drawing.SystemColors.Control;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalLine.Location = new System.Drawing.Point(202, 74);
            this.horizontalLine.MinimumSize = new System.Drawing.Size(500, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(500, 4);
            this.horizontalLine.TabIndex = 47;
            // 
            // homeText
            // 
            this.homeText.AutoSize = true;
            this.homeText.BackColor = System.Drawing.Color.Transparent;
            this.homeText.Font = new System.Drawing.Font("Raleway Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText.Location = new System.Drawing.Point(257, 39);
            this.homeText.Name = "homeText";
            this.homeText.Size = new System.Drawing.Size(90, 33);
            this.homeText.TabIndex = 46;
            this.homeText.Text = "home";
            // 
            // homeLogo
            // 
            this.homeLogo.AutoSize = true;
            this.homeLogo.BackColor = System.Drawing.Color.Transparent;
            this.homeLogo.Image = ((System.Drawing.Image)(resources.GetObject("homeLogo.Image")));
            this.homeLogo.Location = new System.Drawing.Point(192, 29);
            this.homeLogo.MinimumSize = new System.Drawing.Size(50, 47);
            this.homeLogo.Name = "homeLogo";
            this.homeLogo.Size = new System.Drawing.Size(50, 47);
            this.homeLogo.TabIndex = 45;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 519);
            this.Controls.Add(this.logoutlbl1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.homeText);
            this.Controls.Add(this.homeLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoutlbl1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label homeText;
        private System.Windows.Forms.Label homeLogo;
    }
}