using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace payroll
{
    public partial class loginForm : Form
    {
        Boolean passwordTextChange = false;
        public loginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            passwordTextChange = true;
            this.checkCredentials.Visible = false;
        }
        //close
        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //minimize
        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //view password
        private void viewPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextChange)
            {
                txtPassword.PasswordChar = '\0';
                passwordTextChange = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                passwordTextChange = true;
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //setting ms sql connection
            try
            {
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
                string query = "SELECT * FROM admin where username='" + username + "'and password='" + password + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    //admin login
                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.setUsername(username);
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.checkCredentials.Visible = true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There is an Error");
            }
        }
    }
}
