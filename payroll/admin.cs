using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        //log out
        private void logout_Click(object sender, EventArgs e)
        {
            logoutlbl1.Visible = !(logoutlbl1.Visible);
        }

        private void logoutlbl1_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.ShowDialog();
            this.Dispose();
        }
        //set username
        public void setUsername(string username)
        {
            usernamelbl.Text = username;
        }
    }
}
