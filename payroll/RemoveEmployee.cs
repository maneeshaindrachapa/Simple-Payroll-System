﻿using System;
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

        public void loadEmployees()
        {   //data parallism to load data from database
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
                        foreach (DataRow row in dtbl.Rows)
                        {
                            employeeDG.Rows.Add(row["indexNo"].ToString(), row["firstName"].ToString(), row["lastName"].ToString(), row["email"].ToString(), row["telephone"].ToString(), row["salary"].ToString());
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
    }
}

