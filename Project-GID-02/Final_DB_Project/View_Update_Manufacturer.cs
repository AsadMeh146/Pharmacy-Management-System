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
    public partial class View_Update_Manufacturer : Form
    {
        public View_Update_Manufacturer()
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
        private void View_Update_Manufacturer_Load(object sender, EventArgs e)
        {
            displayData(dataGridView5, "select * from ManufacturerDetails order by Id desc");
            dataGridView5.Columns["Id"].ReadOnly = true;
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand(" select * from ManufacturerDetails where Name = @search", con);
            cmd0.Parameters.AddWithValue("@search", searchBar1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            cmd0.ExecuteNonQuery();
        }

        private void updateCompany_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd4 = new SqlCommand(" begin tran deleteCompany  ", con);
                cmd4.ExecuteNonQuery();

                if (searchBar1.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from [ManufacturerDetails] where  Name = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", searchBar1.Text);


                    if (cmd3 == null)
                    {
                        MessageBox.Show("Search is not found..........");

                    }

                    else
                    {
                        cmd3.ExecuteNonQuery();
                        SqlCommand cmd5 = new SqlCommand(" commit tran  deleteCompany  ", con);
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");

                    }

                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from ManufacturerDetails where  Id = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    SqlCommand cmd6 = new SqlCommand(" commit tran  deleteCompany  ", con);
                    cmd6.ExecuteNonQuery();

                }
                //displayData(dataGridView5, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Category as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId   ");
                displayData(dataGridView5, "select * from ManufacturerDetails order by Id desc");

            }
            catch
            {
                MessageBox.Show(" Company is not deleted. Please try again............ ");
                displayData(dataGridView5, "   select * from [ManufacturerDetails] order by Id desc  ");
            }
        }

        private void search_ship_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran updateCompany  ", con);
                cmd3.ExecuteNonQuery();

                if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[1].FormattedValue.ToString() != "")
                {
                    if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[2].FormattedValue.ToString() != "")
                    {
                        if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[3].FormattedValue.ToString() != "")
                        {
                            if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[4].FormattedValue.ToString() != "")
                            {
                                if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[5].FormattedValue.ToString() != "")
                                {
                                    if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[6].FormattedValue.ToString() != "")
                                    {
                                        SqlCommand cmd = new SqlCommand(" UPDATE ManufacturerDetails SET   [Name] = @studentName , [City] = @courseName   , [Country] = @marks , [Address] = @updatedDate, [ContactNumber] = @date, [Email] = @grade  where Id =  @studentID  ", con);
                                        cmd.Parameters.AddWithValue("@studentID", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@studentName", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[1].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@courseName", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@marks", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@updatedDate", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[4].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@date", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[5].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@grade", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[6].FormattedValue.ToString());
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Successfully updated");

                                        displayData(dataGridView5, " select * from ManufacturerDetails order by Id desc   ");
                                        SqlCommand cmd4 = new SqlCommand(" commit tran  updateCompany  ", con);
                                        cmd4.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        MessageBox.Show("please update company's email in correct formay.......      ");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("please update company's contact number in correct formay.......      ");

                                }
                            }
                            else
                            {
                                MessageBox.Show("please update company's address  in correct formay.......      ");

                            }
                        }
                        else
                        {
                            MessageBox.Show("please update company's country in correct formay.......      ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("please update company's city in correct formay.......      ");

                    }
                }
                else
                {
                    MessageBox.Show("please update company's name in correct formay.......      ");

                }
            }
            catch
            {
                MessageBox.Show(" Company's information is not updated Please try again........ ");
                displayData(dataGridView5, "   select * from [ManufacturerDetails] order by Id desc  ");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd4 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran deleteCompany  ", con);
                cmd4.ExecuteNonQuery();

                if (searchBar1.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from [ManufacturerDetails] where  Name = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", searchBar1.Text);


                    if (cmd3 == null)
                    {
                        MessageBox.Show("Search is not found..........");

                    }

                    else
                    {
                        cmd3.ExecuteNonQuery();
                        SqlCommand cmd5 = new SqlCommand(" commit tran  deleteCompany  ", con);
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");

                    }

                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from ManufacturerDetails where  Id = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    SqlCommand cmd6 = new SqlCommand(" commit tran  deleteCompany  ", con);
                    cmd6.ExecuteNonQuery();

                }
                //displayData(dataGridView5, " select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Category as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId   ");
                displayData(dataGridView5, "select * from ManufacturerDetails order by Id desc");

            }
            catch
            {
                MessageBox.Show(" Company is not deleted. Please try again............ ");
                displayData(dataGridView5, "   select * from [ManufacturerDetails] order by Id desc  ");
            }
        }
    }
}
