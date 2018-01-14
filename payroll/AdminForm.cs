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
using System.Threading;

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

        //data parallism
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
                int[] nums = Enumerable.Range(0, 10).ToArray();
                validsearchlbl.Text = "Valid Employee";
                validsearchlbl.ForeColor = System.Drawing.Color.Green;

                CancellationTokenSource cts = new CancellationTokenSource();

                ParallelOptions po = new ParallelOptions();
                po.CancellationToken = cts.Token;

                try
                {
                    Parallel.ForEach(nums, po, (i, loopState) =>
                    {
                        foreach (DataRow row in dtbl.Rows)
                        {
                            //filling text fields
                            indexnotxtlbl.Text = row["indexNo"].ToString();
                            firstnametxtlbl.Text = row["firstName"].ToString();
                            lastnametxtlbl.Text = row["lastName"].ToString();
                            salarytxtlbl.Text = row["salary"].ToString();
                            emailtxtlbl.Text = row["email"].ToString();
                            telephonetxtlbl.Text = row["telephone"].ToString();
                        }
                        loopState.Stop();
                           
                        po.CancellationToken.ThrowIfCancellationRequested();
                        
                    });
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    cts.Cancel();
                }

            }
            else
            {
                validsearchlbl.Text = "Invalid Employee";
                validsearchlbl.ForeColor = System.Drawing.Color.Red;

                
                indexnotxtlbl.ResetText();
                firstnametxtlbl.ResetText();
                lastnametxtlbl.ResetText();
                emailtxtlbl.ResetText();
                telephonetxtlbl.ResetText();
                salarytxtlbl.ResetText();

            }
        }

        private void calculatenetlbl_Click(object sender, EventArgs e)
        {
            //task parallism to calculate net pay
            decimal subTotal = 0;
            decimal grossPay = 0;
            decimal netPay =0;
            TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Factory.StartNew(() =>
            {
                decimal basic = Convert.ToDecimal(basicNUD.Value);
                decimal interim = Convert.ToDecimal(interimNUD.Value);
                decimal costOfLiving = Convert.ToDecimal(costoflivingNUD.Value);
                decimal other = Convert.ToDecimal(otherNUD.Value);
                decimal overtime = Convert.ToDecimal(overtimeNUD.Value);
                decimal specialAllowance = Convert.ToDecimal(specialNUD.Value);
                decimal deductions = Convert.ToDecimal(deductionsNUD.Value);
                subTotal = basic + interim + costOfLiving + other;
                grossPay = subTotal + overtime + specialAllowance;
                netPay = grossPay - deductions;
               
            },CancellationToken.None, TaskCreationOptions.None, uiScheduler);

            Task.Factory.StartNew(() =>setSubTotal(subTotal),CancellationToken.None, TaskCreationOptions.None, uiScheduler);
            Task.Factory.StartNew(() => setGrossPay(grossPay), CancellationToken.None, TaskCreationOptions.None, uiScheduler);
            Task.Factory.StartNew(() => setNetPay(netPay), CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private string setSubTotal(decimal subTotal)
        {
            subtotaltxtlbl.Text = subTotal.ToString();
            return subtotaltxtlbl.Text;
        }
        private string setGrossPay(decimal grossPay)
        {
            grosspaytxtlbl.Text = grossPay.ToString();
            return grosspaytxtlbl.Text;
        }
        private string setNetPay(decimal netPay)
        {
            netpaytxtlbl.Text = netPay.ToString();
            return netpaytxtlbl.Text;
        }

        private void paytoemployeelbl_Click(object sender, EventArgs e)
        {
            if (netpaytxtlbl.Text != "")
            {
                if (indexnotxtlbl.Text != "")
                {
                    SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
                    sqlConn.Open();
                    string query = "UPDATE employee set salary='" + netpaytxtlbl.Text + "' WHERE indexNo='" + indexnotxtlbl.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please Select a User");
                }
            }
            else
            {
                MessageBox.Show("Please Calculate Net Pay for the Employee");
            }
        }
    }
}
