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
    public partial class Add_Products : Form
    {
        static string query;
        int stockTupleCounter = 0;
        public Add_Products()
        {
            InitializeComponent();
        }
        public void displayData(System.Windows.Forms.DataGridView dataGridView1, string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Add_Products_Load(object sender, EventArgs e)
        {
            medicineTypeComboBox.Items.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("   select Name from Lookup where Category = 'Medicine Type'   ", con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                medicineTypeComboBox.Items.Add(DR1[0]);
            }
            DR1.Close();

            companyNameCombobox.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("   select Name  from ManufacturerDetails      ", con);
            SqlDataReader DR2 = cmd1.ExecuteReader();
            while (DR2.Read())
            {
                companyNameCombobox.Items.Add(DR2[0]);
            }
            DR2.Close();
            query = "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId  order by  R.Id desc ";
            displayData(show_products_table, query);
        }

        private void bunifuButton1000_Click(object sender, EventArgs e)
        {
            
        }

        private void add_medicine_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addMedicine  ", con);
                cmd2.ExecuteNonQuery();

                Type purchaseType = medicinePurchasePrice.GetType();
                Type saleType = medicineSalePrice.GetType();

                if (medicineName.Text != "")
                {
                    if (medicineTypeComboBox.Text != "")
                    {
                        if (medicinePurchasePrice.Text != "")
                        {
                            if (medicineSalePrice.Text != "" && (float.Parse(medicineSalePrice.Text) > float.Parse(medicinePurchasePrice.Text)))
                            {
                                if (companyNameCombobox.Text != "")
                                {
                                    if (manufacturingDate.Text != "")
                                    {
                                        if (expiryDate.Text != "" && (DateTime.Parse(expiryDate.Text) > DateTime.Parse(manufacturingDate.Text)))
                                        {
                                            if (description.Text != "")
                                            {
                                                SqlCommand cmd0 = new SqlCommand(" select Id  from Lookup   where Name = @medicineType ", con);
                                                cmd0.Parameters.AddWithValue("@medicineType", medicineTypeComboBox.Text);
                                                cmd0.ExecuteNonQuery();
                                                SqlCommand cmd1 = new SqlCommand(" select Id  from ManufacturerDetails   where Name = @medicineCompany ", con);
                                                cmd1.Parameters.AddWithValue("@medicineCompany", companyNameCombobox.Text);
                                                cmd1.ExecuteNonQuery();
                                                SqlCommand cmd = new SqlCommand(" insert into ProductDetails values(@firstName , @lastName , @contact , @email , @description , @registrationNumber , @expirydate , @status   ) ", con);
                                                cmd.Parameters.AddWithValue("@firstName", medicineName.Text);
                                                cmd.Parameters.AddWithValue("@lastName", cmd0.ExecuteScalar().ToString());
                                                cmd.Parameters.AddWithValue("@contact", int.Parse(medicinePurchasePrice.Text));
                                                cmd.Parameters.AddWithValue("@email", int.Parse(medicineSalePrice.Text));
                                                cmd.Parameters.AddWithValue("@description", description.Text);
                                                cmd.Parameters.AddWithValue("@registrationNumber", (cmd1.ExecuteScalar().ToString()));
                                                cmd.Parameters.AddWithValue("@expirydate", DateTime.Parse(expiryDate.Text));
                                                cmd.Parameters.AddWithValue("@status", DateTime.Parse(manufacturingDate.Text));
                                                cmd.ExecuteNonQuery();


                                                MessageBox.Show("Medicine Added Successfully ");
                                                displayData(show_products_table, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId order by  R.Id desc  ");
                                                SqlCommand cmd3 = new SqlCommand(" commit tran addMedicine  ", con);
                                                cmd3.ExecuteNonQuery();

                                                SqlCommand cmd7 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addStock  ", con);
                                                cmd7.ExecuteNonQuery();

                                                SqlCommand cmd4 = new SqlCommand(" select [Pharmacy Id]  from EmployeeDetails   where Name = @userName and Pin = @password ", con);
                                                cmd4.Parameters.AddWithValue("@userName", Form2.return_UserName());
                                                cmd4.Parameters.AddWithValue("@password", Form2.return_Password());
                                                cmd4.ExecuteNonQuery();

                                                SqlCommand cmd5 = new SqlCommand(" SELECT TOP 1 Id FROM ProductDetails ORDER BY Id DESC ", con);
                                                cmd5.ExecuteNonQuery();
                                                stockTupleCounter = int.Parse(cmd5.ExecuteScalar().ToString()) ;

                                                SqlCommand cmd6 = new SqlCommand(" insert into Stock values(  @pharmacyID  , @productID    , @manufacturerID , @quantity  ) ", con);
                                                cmd6.Parameters.AddWithValue("@pharmacyID", int.Parse(cmd4.ExecuteScalar().ToString()));
                                                cmd6.Parameters.AddWithValue("@productID", stockTupleCounter);
                                                cmd6.Parameters.AddWithValue("@manufacturerID", cmd1.ExecuteScalar().ToString());
                                                cmd6.Parameters.AddWithValue("@quantity", 0);
                                                cmd6.ExecuteNonQuery();


                                                SqlCommand cmd8 = new SqlCommand(" commit tran addStock  ", con);
                                                cmd8.ExecuteNonQuery();


                                        }
                                            else
                                            {
                                                MessageBox.Show("Please fill description in correct format.......");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please fill expiry date in correct format.......");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill manufacturing date in correct format.......");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please fill company name in correct format.......");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill sale price in correct format.......");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill purchase price in correct format.......");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill medicine type in correct format.......");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill medicine name in correct format.......");

                }

            //}
            //catch
            //{
            //    MessageBox.Show("Please fill all the above fields in correct format");
            //    displayData(show_products_table, "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId  order by  R.Id desc");
            //}
        }
    }
}
