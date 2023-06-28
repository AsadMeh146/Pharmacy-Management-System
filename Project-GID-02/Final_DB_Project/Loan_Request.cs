using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_DB_Project
{
    public partial class Loan_Request : Form
    {
        public Loan_Request()
        {
            InitializeComponent();
        }

        private void search_loan_requestName_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand(" select R.Id , R.Name , R.Purpose , R.AmountRequested , R.ApplyDate , Lookup.Name AS [Loan Status] from (select EmployeeLoan.Id , EmployeeDetails.Name , EmployeeLoan.Purpose , EmployeeLoan.AmountRequested , EmployeeLoan.AmountAccepted, EmployeeLoan.ApplyDate , EmployeeLoan.Status from EmployeeLoan join EmployeeDetails on EmployeeLoan.EmployeeId = EmployeeDetails.RegistrationNumber) as R join Lookup  on R.Status = Lookup.Id where R.Name = @search and Lookup.Name = 'Waiting' ", con);
            cmd0.Parameters.AddWithValue("@search", searchBar20003.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dispalyLoanRequests.DataSource = dt;
            cmd0.ExecuteNonQuery();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loan_Request_Load(object sender, EventArgs e)
        {

            mainPage.mp.displayData(dispalyLoanRequests, "select R.Id , R.Name , R.Purpose , R.AmountRequested , R.ApplyDate , Lookup.Category AS [Loan Status] from (select EmployeeLoan.Id , EmployeeDetails.Name , EmployeeLoan.Purpose , EmployeeLoan.AmountRequested , EmployeeLoan.AmountAccepted, EmployeeLoan.ApplyDate , EmployeeLoan.Status from EmployeeLoan join EmployeeDetails on EmployeeLoan.EmployeeId = EmployeeDetails.RegistrationNumber) as R join Lookup  on R.Status = Lookup.Id where Lookup.Name = 'Waiting'");
            addButtonsInColumns();
            dispalyLoanRequests.Columns["Id"].ReadOnly = true;
            dispalyLoanRequests.Columns["Name"].ReadOnly = true;
            dispalyLoanRequests.Columns["Purpose"].ReadOnly = true;
            dispalyLoanRequests.Columns["ApplyDate"].ReadOnly = true;
            dispalyLoanRequests.Columns["Loan Status"].ReadOnly = true;
        }
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        //DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();

        public void addButtonsInColumns()
        {
            btn.Name = "Decide";
            btn.Text = "Approve";
            btn.UseColumnTextForButtonValue = true;
            dispalyLoanRequests.Columns.Add(btn);

        }
        int temp = 3;
        int tempId = 1;
        int tempLoanAmountIndex = 4;

        private void dispalyLoanRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dispalyLoanRequests.Columns["Decide"].Index && e.RowIndex >= 0)
            {


                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd3 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran loanRequests  ", con);
                    cmd3.ExecuteNonQuery();
                    if (dispalyLoanRequests.Rows[dispalyLoanRequests.CurrentRow.Index].Cells[3].FormattedValue.ToString() != null)
                    {

                        SqlCommand cmd5 = new SqlCommand(" select Id from Lookup where Name = 'Approved'  ", con);
                        cmd5.ExecuteNonQuery();

                        SqlCommand cmd = new SqlCommand(" UPDATE EmployeeLoan SET AmountAccepted = @loanAmount , Status = @status    where Id =  @id  ", con);
                        cmd.Parameters.AddWithValue("@id", dispalyLoanRequests.Rows[dispalyLoanRequests.CurrentRow.Index].Cells[tempId].FormattedValue.ToString());

                        MessageBox.Show(dispalyLoanRequests.Rows[dispalyLoanRequests.CurrentRow.Index].Cells[tempId].FormattedValue.ToString());
                        MessageBox.Show(dispalyLoanRequests.Rows[dispalyLoanRequests.CurrentRow.Index].Cells[tempLoanAmountIndex].FormattedValue.ToString());



                        cmd.Parameters.AddWithValue("@loanAmount", dispalyLoanRequests.Rows[dispalyLoanRequests.CurrentRow.Index].Cells[tempLoanAmountIndex].FormattedValue.ToString());
                        cmd.Parameters.AddWithValue("@status", cmd5.ExecuteScalar().ToString());





                        cmd.ExecuteNonQuery();
                        SqlCommand cmd4 = new SqlCommand(" commit tran  loanRequests  ", con);
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Successfully Loan updated");
                        mainPage.mp.displayData(dispalyLoanRequests, "select R.Id , R.Name , R.Purpose , R.AmountRequested , R.ApplyDate , Lookup.Category AS [Loan Status] from (select EmployeeLoan.Id , EmployeeDetails.Name , EmployeeLoan.Purpose , EmployeeLoan.AmountRequested , EmployeeLoan.AmountAccepted, EmployeeLoan.ApplyDate , EmployeeLoan.Status from EmployeeLoan join EmployeeDetails on EmployeeLoan.EmployeeId = EmployeeDetails.RegistrationNumber) as R join Lookup  on R.Status = Lookup.Id where Lookup.Category = 'Waiting'   ");

                        if (tempId == 0)
                        {
                            tempId = 1;
                        }

                        if (tempLoanAmountIndex == 3)
                        {
                            tempLoanAmountIndex = 4;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please fill loan amount in correct format......... ");
                    }

            }
                catch
            {
                MessageBox.Show(" Sorry for inconvinience............ ");
                mainPage.mp.displayData(dispalyLoanRequests, "select R.Id , R.Name , R.Purpose , R.AmountRequested , R.ApplyDate , Lookup.Category AS [Loan Status] from (select EmployeeLoan.Id , EmployeeDetails.Name , EmployeeLoan.Purpose , EmployeeLoan.AmountRequested , EmployeeLoan.AmountAccepted, EmployeeLoan.ApplyDate , EmployeeLoan.Status from EmployeeLoan join EmployeeDetails on EmployeeLoan.EmployeeId = EmployeeDetails.RegistrationNumber) as R join Lookup  on R.Status = Lookup.Id where Lookup.Category = 'Waiting'");
            }
        }
        }

        private void loan_request_title_table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
