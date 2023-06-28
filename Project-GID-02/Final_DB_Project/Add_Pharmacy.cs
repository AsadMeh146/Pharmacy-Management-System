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
    public partial class Add_Pharmacy : Form
    {
        public Add_Pharmacy()
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
        private void phar_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addPharmacy  ", con);
                cmd2.ExecuteNonQuery();




                if (pharmacyLocation.Text != "")
                {
                    if (pharmacyContactNumber.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand(" insert into Pharmacy values(@firstName , @lastName   ) ", con);
                        cmd.Parameters.AddWithValue("@firstName", pharmacyLocation.Text);
                        cmd.Parameters.AddWithValue("@lastName", pharmacyContactNumber.Text);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand(" commit tran addPharmacy  ", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Pharmacy Added Successfully ");
                        displayData(dataGridView1, "select * from Pharmacy order by Id desc ");

                    }
                    else
                    {
                        MessageBox.Show("Please fill pharmacy's contact number in correct format.......");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill pharmacy's location in correct format.......");
                }



            }
            catch
            {
                MessageBox.Show("Please fill all the above fields in correct format");
                displayData(dataGridView1, "select * from Pharmacy  order by Id desc");
            }
        }

        private void Add_Pharmacy_Load(object sender, EventArgs e)
        {
            displayData(dataGridView1, "select * from Pharmacy order by Id desc ");
        }
    }
}
