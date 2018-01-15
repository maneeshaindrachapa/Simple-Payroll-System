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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //data parallism to load data from database
        public void loadEmployees()
        {  
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True");
            string query = "SELECT * FROM employee";
            SqlDataAdapter data = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                int[] nums = Enumerable.Range(0, 10).ToArray();


                CancellationTokenSource cts = new CancellationTokenSource();

                ParallelOptions po = new ParallelOptions();
                po.CancellationToken = cts.Token;

                try
                {
                    Parallel.ForEach(nums, po, (i, loopState) =>
                    {
                        if (i == 0)
                        {
                            foreach (DataRow row in dtbl.Rows)
                            {
                                employeeDG.Rows.Add(null,row["indexNo"].ToString(), row["firstName"].ToString(), row["lastName"].ToString(), row["email"].ToString(), row["telephone"].ToString(), row["salary"].ToString());
                            }
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

        }

        private void removeUserlbl_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in employeeDG.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true
                                                  select row).ToList();
            if (MessageBox.Show(string.Format("Do you want to delete {0} Employees?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maneesha\Desktop\payroll\payroll\payroll\payroll.mdf;Integrated Security=True")
)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM employee WHERE indexNo = @indexNo", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@indexNo", row.Cells["indexNo"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                loadEmployees();
            }
        }
    }
}

