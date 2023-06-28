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
    
    public partial class Add_Date : Form
    {
        int checkLoop = 0;
        public Add_Date()
        {
            InitializeComponent();
        }

        private void add_date_button_Click(object sender, EventArgs e)
        {
            checkLoop = 0;
            bool checkDate = false;
            var con = Configuration.getInstance().getConnection();
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Insert_Date", con);
            t7_cmd.ExecuteNonQuery();
            SqlCommand cmd7 = new SqlCommand("SELECT Date FROM AttendanceDate ", con);
            SqlDataReader myReader5 = cmd7.ExecuteReader();
            while (myReader5.Read())
            {
                if (DateTime.Parse(add_date_picker.Text) == DateTime.Parse(myReader5.GetValue(0).ToString()))
                {
                    checkDate = true;
                    break;
                }
                else
                {
                    checkDate = false;

                }

            }
            myReader5.Close();
            if (checkDate == false)
            {
                
                SqlCommand cmd = new SqlCommand("Insert into AttendanceDate values (@Date)", con);
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(add_date_picker.Text));
                cmd.ExecuteNonQuery();
                checkLoop = 1;
                MessageBox.Show("Successfully Added");
            }
            if (checkLoop == 1)
            {
                SqlCommand t8_cmd = new SqlCommand("COMMIT TRAN Insert_Date", con);
                t8_cmd.ExecuteNonQuery();
            }
            else if (checkLoop == 0)
            {
                SqlCommand t8_cmd = new SqlCommand("ROLLBACK TRAN Insert_Date", con);
                t8_cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Date already exists");
            }
        }

        private void Add_Date_Load(object sender, EventArgs e)
        {
            this.datePanel.Controls.Clear();
            Update_Date update_dateForm = new Update_Date() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_dateForm.FormBorderStyle = FormBorderStyle.None;
            this.datePanel.Controls.Add(update_dateForm);
            update_dateForm.Show();
        }
    }
}
