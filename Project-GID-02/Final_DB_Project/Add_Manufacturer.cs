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
    public partial class Add_Manufacturer : Form
    {
        public Add_Manufacturer()
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

        private void Add_Manufacturer_Load(object sender, EventArgs e)
        {
            displayData(dataGridView3, "   select * from [ManufacturerDetails] order by Id desc  ");
        }

        private void bunifuButton1000_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE  begin tran addCompany  ", con);
                cmd2.ExecuteNonQuery();

                if (companyName.Text != "")
                {
                    if (companyCity.Text != "")
                    {
                        if (companyCountry.Text != "")
                        {
                            if (companyAddress.Text != "")
                            {
                                if (companyContactNumber.Text != "")
                                {
                                    if (companyEmail.Text != "")
                                    {

                                        SqlCommand cmd = new SqlCommand(" exec insertingCompany   @firstName  , @lastName  ,  @contact  , @email  , @description  ,  @registrationNumber    " , con);
                                        cmd.Parameters.AddWithValue("@firstName", companyName.Text);
                                        cmd.Parameters.AddWithValue("@lastName", companyCity.Text);
                                        cmd.Parameters.AddWithValue("@contact", companyCountry.Text);
                                        cmd.Parameters.AddWithValue("@email",  companyAddress.Text  );
                                        cmd.Parameters.AddWithValue("@description", companyContactNumber.Text);
                                        cmd.Parameters.AddWithValue("@registrationNumber", companyEmail.Text);
                                        cmd.ExecuteNonQuery();
                                        SqlCommand cmd3 = new SqlCommand(" commit tran addCompany  ", con);
                                        cmd3.ExecuteNonQuery();
                                        MessageBox.Show("Company Added Successfully ");
                                        displayData(dataGridView3, "   select * from [ManufacturerDetails] order by Id desc  ");

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please fill email in correct format.......");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please fill contact number in correct format.......");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please fill address in correct format.......");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill country in correct format.......");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill city in correct format.......");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill name in correct format.......");
                }


            }
            catch
            {
                MessageBox.Show("Medicine is not added .Please fill all the above fields in correct format.........");
                displayData(dataGridView3, "   select * from [ManufacturerDetails] order by Id desc  ");
            }
        }
    }
}
