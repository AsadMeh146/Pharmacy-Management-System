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
    public partial class Employee_Loan : Form
    {
        public Employee_Loan()
        {
            InitializeComponent();
        }

        private void Employee_Loan_Load(object sender, EventArgs e)
        {
            employeeName.Text = Form2.getCurrntlyActiveUserName();
            currentDate.Text = DateTime.Now.ToString();
        }

        private void apply_loan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addLoan  ", con);
                cmd2.ExecuteNonQuery();


                if (employeeName.Text != "")
                {
                    if (purposeLoan.Text != "")
                    {
                        if (loanAmount.Text != "" && int.Parse(loanAmount.Text) >= 0)
                        {
                            if (currentDate.Text != "")
                            {
                                SqlCommand cmd0 = new SqlCommand(" select Id  from Lookup   where Name = 'Waiting' ", con);
                                //cmd0.Parameters.AddWithValue("@medicineType", medicineTypeComboBox.Text);
                                cmd0.ExecuteNonQuery();

                                SqlCommand cmd1 = new SqlCommand(" select [RegistrationNumber]  from EmployeeDetails   where Name = @employeeName ", con);
                                cmd1.Parameters.AddWithValue("@employeeName", employeeName.Text);
                                cmd1.ExecuteNonQuery();

                                SqlCommand cmd = new SqlCommand(" insert into EmployeeLoan ([EmployeeId],[Purpose],[AmountRequested]  ,[ApplyDate],[Status] )  values(@firstName , @lastName , @contact , @email , @description   ) ", con);
                                cmd.Parameters.AddWithValue("@firstName", cmd1.ExecuteScalar().ToString());
                                cmd.Parameters.AddWithValue("@lastName", purposeLoan.Text);
                                cmd.Parameters.AddWithValue("@contact", loanAmount.Text);
                                cmd.Parameters.AddWithValue("@email", currentDate.Text);
                                cmd.Parameters.AddWithValue("@description", cmd0.ExecuteScalar().ToString());
                                cmd.ExecuteNonQuery();
                                SqlCommand cmd3 = new SqlCommand(" commit tran addLoan  ", con);
                                cmd3.ExecuteNonQuery();
                                MessageBox.Show("Your Application for loan is submitted. Admin will contact you soon........ ");
                                //displayData(dataGridView1, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Category as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId order by  R.Id desc  ");

                            }
                            else
                            {
                                MessageBox.Show("Inappropiate Date.......");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill loan amount in correct format.......");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please fill loan purpose in correct format.......");
                    }
                }
                else
                {
                    MessageBox.Show("Inappropiate employee name.......");
                }


            }
            catch
            {
                MessageBox.Show("Sorry for inconvinience");
                //displayData(dataGridView1, "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Category as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId  order by  R.Id desc");
            }
        }
    }
}
