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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        //set Username
        public void setUsername(string username)
        {
            usernamelbl.Text = username;
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

        private void adduser_Click(object sender, EventArgs e)
        {
            addUserlbl.Visible = !(addUserlbl.Visible);
        }

        private void addUserlbl_Click(object sender, EventArgs e)
        {
            addUserForm addUserform = new addUserForm();
            addUserform.ShowDialog();
        }

        private void searchlbl_Click(object sender, EventArgs e)
        {
            string indexNo = searchTB.Text.ToString();
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
            string query = "SELECT * FROM employee where indexNo='" + indexNo+ "'";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                validsearchlbl.Text = "Valid Employee";
                validsearchlbl.ForeColor = System.Drawing.Color.Green;
                foreach (DataRow row in dtbl.Rows)
                {
                    //filling text fields
                    indexnotxtlbl.Text= row["indexNo"].ToString();
                    firstnametxtlbl.Text = row["firstName"].ToString();
                    lastnametxtlbl.Text = row["lastName"].ToString();
                    salarytxtlbl.Text = row["salary"].ToString();
                    emailtxtlbl.Text = row["email"].ToString();
                    telephonetxtlbl.Text = row["telephone"].ToString();
                }
                
            }
            else
            {
                validsearchlbl.Text = "Invalid Employee";
                validsearchlbl.ForeColor = System.Drawing.Color.Red;

                //reset text fields
                indexnotxtlbl.ResetText();
                firstnametxtlbl.ResetText();
                lastnametxtlbl.ResetText();
                emailtxtlbl.ResetText();
                telephonetxtlbl.ResetText();
                salarytxtlbl.ResetText();
            }
        }
    }
}
