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
    public partial class View_Update_Products : Form
    {
        static string query = "";
        public View_Update_Products()
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
        private void View_Update_Products_Load(object sender, EventArgs e)
        {
            query = "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId ";
            
            displayData(dataGridView2, query);
            dataGridView2.Columns["Id"].ReadOnly = true;
        }

        private void update_product_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran updateMedicine  ", con);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd0 = new SqlCommand(" select Id  from Lookup   where Name = @medicineType ", con);
                cmd0.Parameters.AddWithValue("@medicineType", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                cmd0.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand(" select Id  from [ManufacturerDetails]   where Name = @manufacturerType ", con);
                cmd1.Parameters.AddWithValue("@manufacturerType", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].FormattedValue.ToString());
                cmd1.ExecuteNonQuery();

                int flag = 0;

                //if (float.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].FormattedValue.ToString()) > float.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].FormattedValue.ToString()))
                //{
                if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].FormattedValue.ToString() != "")
                {
                    if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].FormattedValue.ToString() != "")
                    {
                        if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].FormattedValue.ToString() != "")
                        {
                            if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].FormattedValue.ToString() != "")
                            {
                                if (float.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].FormattedValue.ToString()) > float.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].FormattedValue.ToString()))
                                {
                                    if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].FormattedValue.ToString() != "")
                                    {
                                        if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].FormattedValue.ToString() != "")
                                        {
                                            if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].FormattedValue.ToString() != "")
                                            {
                                                if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].FormattedValue.ToString() != "")
                                                {
                                                    if (DateTime.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].FormattedValue.ToString()) > DateTime.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].FormattedValue.ToString()))
                                                    {





                                                        if (cmd0.ExecuteScalar() != null)
                                                        {
                                                            if (cmd1.ExecuteScalar() != null)
                                                            {

                                                                //if (DateTime.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].FormattedValue.ToString()) > DateTime.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].FormattedValue.ToString()))
                                                                //{
                                                                SqlCommand cmd = new SqlCommand(" exec updateProduct   @search  , @studentID  ,  @studentName  , @courseName  , @marks  ,  @updatedDate , @date,   @grade , @description ", con);
                                                                cmd.Parameters.AddWithValue("@studentID", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@studentName", cmd0.ExecuteScalar().ToString());
                                                                cmd.Parameters.AddWithValue("@courseName", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@marks", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@updatedDate", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@date", cmd1.ExecuteScalar().ToString());
                                                                cmd.Parameters.AddWithValue("@grade", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@description", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].FormattedValue.ToString());
                                                                cmd.Parameters.AddWithValue("@search", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                                                                cmd.ExecuteNonQuery();
                                                                SqlCommand cmd4 = new SqlCommand(" commit tran  updateMedicine  ", con);
                                                                cmd4.ExecuteNonQuery();
                                                                MessageBox.Show("Successfully updated");

                                                                displayData(dataGridView2, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId   ");

                                                                //}
                                                                //else
                                                                //{
                                                                //    MessageBox.Show("Expiry Date is always greater than manufacturing date price. Please update in correct format......... ");
                                                                //}

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("This medicine company does not appear in this system......... ");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("This medicine type does not appear in this system.........");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Expiry Date is always greater than manufacturing date price. Please update in correct format  ......... ");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please fill manufacturing date in correct format......... ");

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please fill expiry date in correct format........ ");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please fill the company name in correct format.........");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill medicine description in correct format.......");
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Sale price is always greater than purchasee price. Please update in correct format......");
                                }




                            }
                            else
                            {
                                MessageBox.Show("Please fill the sale price in correct format.........");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill the purchase price in correct format.........");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the medicine type in correct format..........");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the medicine name in correct format........... ");
                }
                //}

                //else
                //{
                //    MessageBox.Show("Sale price is always greater than purchase price. Please update in correct format.........  ");
                //}

            }
            catch
            {
                MessageBox.Show(" Please update the medicines in correct format ");
                displayData(dataGridView2, "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId  order by  R.Id desc");
            }
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran deleteMedicine  ", con);
                cmd2.ExecuteNonQuery();

                if (searchBar.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from ProductDetails where  Name = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", searchBar.Text);
                    if (cmd3 == null)
                    {
                        MessageBox.Show("Search is not found..........");

                    }

                    else
                    {
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");
                        SqlCommand cmd4 = new SqlCommand(" commit tran  deleteMedicine  ", con);
                        cmd4.ExecuteNonQuery();
                    }

                }
                else
                {
                    MessageBox.Show(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    SqlCommand cmd3 = new SqlCommand(" DELETE from ProductDetails where  Id = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    SqlCommand cmd4 = new SqlCommand(" commit tran  deleteMedicine  ", con);
                    cmd4.ExecuteNonQuery();

                }
                displayData(dataGridView2, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId   ");

            }
            catch
            {
                MessageBox.Show("Medicine is not deleted. Please try again...........");
                displayData(dataGridView2, "select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId  order by  R.Id desc");
            }
        }

        private void search_med_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand(" select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Name as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId where R.Name = @search", con);
            cmd0.Parameters.AddWithValue("@search", searchBar.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd0.ExecuteNonQuery();
        }
    }
}
