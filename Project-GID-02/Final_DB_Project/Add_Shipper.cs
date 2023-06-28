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
    public partial class Add_Shipper : Form
    {
        public Add_Shipper()
        {
            InitializeComponent();
        }
        public void loadDataIntoShipperCombobox(ComboBox shipperCompanyNameComboBox, string query)
        {

            var con = Configuration.getInstance().getConnection();
            shipperCompanyNameComboBox.Items.Clear();
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader DR2 = cmd1.ExecuteReader();
            while (DR2.Read())
            {
                shipperCompanyNameComboBox.Items.Add(DR2[0]);
            }
            DR2.Close();
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

        private void Add_Shipper_Load(object sender, EventArgs e)
        {
            displayData(displayShippers, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
            loadDataIntoShipperCombobox(shipperCompanyNameComboBox, "select Name  from ManufacturerDetails");
        }

        private void add_shipp_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void add_shipp_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addSupplier  ", con);
                cmd2.ExecuteNonQuery();

                if (shipperName.Text != "")
                {
                    if (shipperContactNumber.Text != "")
                    {
                        if (shipperCompanyNameComboBox.Text != "")
                        {
                            if (shipperAddress.Text != "")
                            {

                                SqlCommand cmd1 = new SqlCommand(" select Id  from ManufacturerDetails   where Name = @companyName ", con);
                                cmd1.Parameters.AddWithValue("@companyName", shipperCompanyNameComboBox.Text);
                                cmd1.ExecuteNonQuery();
                                SqlCommand cmd = new SqlCommand(" insert into Shippers values(@firstName , @lastName , @contact , @email    ) ", con);
                                cmd.Parameters.AddWithValue("@firstName", shipperName.Text);
                                cmd.Parameters.AddWithValue("@lastName", shipperContactNumber.Text);
                                cmd.Parameters.AddWithValue("@contact", cmd1.ExecuteScalar().ToString());
                                cmd.Parameters.AddWithValue("@email", (shipperAddress.Text));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Shippers Added Successfully ");
                                displayData(displayShippers, " select Shippers.Id , Shippers.name , Shippers.[Contact Number] , ManufacturerDetails.Name AS CompanyName , Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
                                SqlCommand cmd3 = new SqlCommand(" commit tran addSupplier  ", con);
                                cmd3.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Please fill shipper's address in correct format.......");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill shipper's company name in correct format.......");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please fill contact number in correct format.......");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill shipper's name in correct format.......");
                }


            }
            catch
            {
                MessageBox.Show("Shipper is not added .Please fill all the above fields in correct format.........");
                displayData(displayShippers, " select Shippers.Id, Shippers.name, Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id   order by Id desc  ");
            }
        }
    }
}
