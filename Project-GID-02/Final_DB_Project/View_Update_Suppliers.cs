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
    public partial class View_Update_Suppliers : Form
    {
        public View_Update_Suppliers()
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
        private void search_ship_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand(" select Shippers.Id, Shippers.[name], Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id    where Shippers.name = @search order by Id desc  ", con);
            cmd0.Parameters.AddWithValue("@search", searchBar2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            cmd0.ExecuteNonQuery();
        }

        private void update_ship_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran updateShippers  ", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(" select Id  from [ManufacturerDetails]   where Name = @companyName ", con);
                cmd1.Parameters.AddWithValue("@companyName", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                cmd1.ExecuteNonQuery();


                if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[0].FormattedValue.ToString() != "")
                {
                    if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[1].FormattedValue.ToString() != "")
                    {
                        if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[2].FormattedValue.ToString() != "")
                        {
                            if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[3].FormattedValue.ToString() != "")
                            {
                                if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[4].FormattedValue.ToString() != "")
                                {
                                    if (cmd1.ExecuteScalar() == null)
                                    {
                                        MessageBox.Show("The company that your have entered does not exist..........");
                                    }
                                    else
                                    {
                                        SqlCommand cmd = new SqlCommand(" UPDATE [Shippers] SET [name] = @studentName , [Contact Number] = @courseName   , [Manufacturer Id] = @marks , [Address] = @date   where Id =  @studentID  ", con);
                                        cmd.Parameters.AddWithValue("@studentID", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@studentName", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[1].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@courseName", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                                        cmd.Parameters.AddWithValue("@marks", cmd1.ExecuteScalar().ToString());
                                        cmd.Parameters.AddWithValue("@date", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[4].FormattedValue.ToString());
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Successfully updated");

                                        SqlCommand cmd4 = new SqlCommand(" commit tran  updateShippers  ", con);
                                        cmd4.ExecuteNonQuery();
                                    }
                                    displayData(dataGridView6, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc   ");





                                }
                                else
                                {
                                    MessageBox.Show("Please fill the shipper's address in correct format..........");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill the shipper's company name in correct format.  ..........");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill the shipper's contact number in correct format..........");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill the shipper's name in correct format..........");

                    }
                }
            }
            catch
            {
                MessageBox.Show(" Unfortunately shipper is not updated. Please try again.............. ");
                displayData(dataGridView6, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
            }
        }

        private void delete_ship_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            try
            {
                SqlCommand cmd5 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran deleteShipper  ", con);
                cmd5.ExecuteNonQuery();

                if (searchBar2.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from Shippers where  name = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", searchBar2.Text);
                    if (cmd3 == null)
                    {
                        MessageBox.Show("Search is not found..........");

                    }

                    else
                    {
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");
                        SqlCommand cmd6 = new SqlCommand(" commit tran  deleteShipper  ", con);
                        cmd6.ExecuteNonQuery();
                    }

                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand("  exec deleteShipper @searchID    ", con);
                    cmd3.Parameters.AddWithValue("@searchID", dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd7 = new SqlCommand(" commit tran  deleteShipper  ", con);
                    cmd7.ExecuteNonQuery();

                    MessageBox.Show("Successfully deletedcdddddddd");

                }
                displayData(dataGridView6, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");

        }
            catch
            {
                MessageBox.Show("Unfortunately Shipper is not deleted. Please try again..............  ");
                displayData(dataGridView6, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
                SqlCommand cmd17 = new SqlCommand(" rollback tran  deleteShipper  ", con);
                cmd17.ExecuteNonQuery();
            }
}

        private void View_Update_Suppliers_Load(object sender, EventArgs e)
        {
            displayData(dataGridView6, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
            dataGridView6.Columns["Id"].ReadOnly = true;
        }
    }
}
