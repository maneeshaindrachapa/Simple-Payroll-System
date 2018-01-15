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
using System.Text.RegularExpressions;
using System.Threading;

namespace payroll
{
    public partial class addUserForm : Form
    {
        //validations
        bool telValidate = false;
        bool emailValidate = false;
        bool indexValidate = false;
        bool firstnameValidate = false;
        bool lastnameValidate = false;

        
        public addUserForm()
        {
            InitializeComponent();
            TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            //task parallism to check validations
            Task t=Task.Factory.StartNew(() => checkValid(uiScheduler));
        }

        //exit 
        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void adduserlbl_Click(object sender, EventArgs e)
        {
            try
            {
                //setting ms sql connection
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
                sqlConn.Open();

                if (indexValidate && firstnameValidate && lastnameValidate && emailValidate && telValidate)
                {
                    string query1 = "INSERT INTO employee(indexNo,firstName,lastName,email,telephone) VALUES('"+indexnoTB.Text.ToString()+"','"+firstnameTB.Text.ToString()+"','"+lastnameTB.Text.ToString()+"','"+emailTB.Text.ToString()+"','"+telephoneTB.Text.ToString()+"')";
                    SqlCommand cmd3 = new SqlCommand(query1, sqlConn);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("User Added Succesfully");
                    indexnoTB.ResetText();
                    firstnameTB.ResetText();
                    lastnameTB.ResetText();
                    emailTB.ResetText();
                    telephoneTB.ResetText();

                    //setiing invalid in index no
                    indexValidate = false;
                    indexVallbl.Text = "Invaild";
                    indexVallbl.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    MessageBox.Show("There is an Invaild Details in Form");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //telephone no validation
        private void telephoneTB_TextChanged(object sender, EventArgs e)
        {   
            Regex validator = new Regex("(0|1|2|3|4|5|6|7|8|9){1}[0-9]{9}");
            string match = validator.Match(telephoneTB.Text).Value.ToString();
            if (match.Length == 10)
            {
                telValidate = true;
                telvallbl.Text = "Valid";
                telvallbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                telValidate = false;
                telvallbl.Text = "Invalid";
                telvallbl.ForeColor = System.Drawing.Color.Red;
            }
        }
        //email validate
        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(emailTB.Text.ToString(), expresion))
            {
                if (Regex.Replace(emailTB.Text.ToString(), expresion, string.Empty).Length == 0)
                {
                    emailValidate = true;
                    emailvalbl.Text = "Valid";
                    emailvalbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    emailValidate = false;
                    emailvalbl.Text = "Invalid";
                    emailvalbl.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                emailValidate = false;
                emailvalbl.Text = "Invalid";
                emailvalbl.ForeColor = System.Drawing.Color.Red;
            }

        }
        //firstname validate
        private void firstnameTB_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(firstnameTB.Text, @"^[\p{L}\p{M}']+$").Success)
            {
                firstnamevallbl.Text = "Invaild";
                firstnamevallbl.ForeColor = System.Drawing.Color.Red;
                firstnameValidate = false;
            }
            else
            {
                firstnamevallbl.Text = "Valid";
                firstnamevallbl.ForeColor = System.Drawing.Color.Green;
                firstnameValidate = true;
            }
        }
        //lastname validate
        private void lastnameTB_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(lastnameTB.Text, @"^[\p{L}\p{M}']+$").Success)
            {
                lastnamevalbl.Text = "Invaild";
                lastnamevalbl.ForeColor = System.Drawing.Color.Red;
                lastnameValidate = false;
            }
            else
            {
                lastnamevalbl.Text = "Valid";
                lastnamevalbl.ForeColor = System.Drawing.Color.Green;
                lastnameValidate = true;
            }
        }

        private void indexnoTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //setting ms sql connection
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
                sqlConn.Open();

                //check that index no is alreadyin db
                string query = "SELECT * FROM employee where indexNo='" + indexnoTB.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);
                if (dtbl.Rows.Count != 0)
                {
                    indexVallbl.Text = "Invaild";
                    indexVallbl.ForeColor = System.Drawing.Color.Red;
                    indexValidate = false;
                }
                else
                {
                    indexValidate = true;
                    indexVallbl.Text = "Valid";
                    indexVallbl.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There is an Error,Conecting to the Database");
            }
        }

        //task parallism to check valididty
        private void checkValid(TaskScheduler uiScheduler)
        {
            Task.Factory.StartNew(() =>
            {
                if (indexValidate && firstnameValidate && lastnameValidate && emailValidate && telValidate)
                {
                    compltelbl.Text += "*All Details are Correct";
                    compltelbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {   
                    compltelbl.Text = "*Fill The Details";
                    compltelbl.ForeColor = System.Drawing.Color.Red;
                }
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);

        }

        
    }
}
