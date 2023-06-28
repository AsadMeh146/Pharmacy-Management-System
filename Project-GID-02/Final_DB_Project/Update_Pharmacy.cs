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
    public partial class Update_Pharmacy : Form
    {
        public Update_Pharmacy()
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
        private void Update_Pharmacy_Load(object sender, EventArgs e)
        {
            displayData(dataGridView2, "select * from Pharmacy  order by Id desc");
            dataGridView2.Columns["Id"].ReadOnly = true;
        }

        private void searchPharmacy1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand(" select * from Pharmacy where Location = @search", con);
            cmd0.Parameters.AddWithValue("@search", searchBar1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd0.ExecuteNonQuery();
        }

        private void updatePharmacy_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran updatePharmacy  ", con);
                cmd3.ExecuteNonQuery();


                int flag = 0;


                if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].FormattedValue.ToString() != "")
                {
                    if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].FormattedValue.ToString() != "")
                    {
                        SqlCommand cmd = new SqlCommand(" UPDATE Pharmacy SET Location = @studentID  ,ContactNumber = @studentName    where Id =  @search  ", con);
                        cmd.Parameters.AddWithValue("@studentID", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].FormattedValue.ToString());
                        cmd.Parameters.AddWithValue("@studentName", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                        cmd.Parameters.AddWithValue("@search", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd4 = new SqlCommand(" commit tran  updatePharmacy  ", con);
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");
                        displayData(dataGridView2, "select * from Pharmacy  order by Id desc ");

                    }
                    else
                    {
                        MessageBox.Show("Please enter pharmacy's contact number in correct format......... ");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter pharmacy's location in correct format......... ");
                }


            }
            catch
            {
                MessageBox.Show(" Please update the pharmacy information in correct format ");
                displayData(dataGridView2, "select * from Pharmacy  order by Id desc");
            }
        }

        private void deletePharmacy_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran deletePharmacy  ", con);
                cmd2.ExecuteNonQuery();

                if (searchBar1.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from Pharmacy where  Location = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", searchBar1.Text);
                    if (cmd3 == null)
                    {
                        MessageBox.Show("Search is not found..........");

                    }

                    else
                    {
                        cmd3.ExecuteNonQuery();
                        SqlCommand cmd4 = new SqlCommand(" commit tran  deletePharmacy  ", con);
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Successfully deleted");

                    }

                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand(" DELETE from Pharmacy where  Id = @searchID  ", con);
                    cmd3.Parameters.AddWithValue("@searchID", dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].FormattedValue.ToString());
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd4 = new SqlCommand(" commit tran  deletePharmacy  ", con);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");


                }
                displayData(dataGridView2, "select * from Pharmacy order by Id desc ");


        }
            catch
            {
                MessageBox.Show("Pharmacy is not deleted. Please try again...........");
                displayData(dataGridView2, "select * from Pharmacy order by Id desc ");
             }
}
    }
}
