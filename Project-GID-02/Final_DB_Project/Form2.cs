using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_DB_Project
{
    public  partial class Form2 : Form
    {
        int flag1 = 0;
        int flag2 = 0;
        bool adminLogin = false;
        public static Form2 form2 = new Form2();
        public static string currentlyActiveUser;
        public static string userName;
        public static string password;
        public static string userId;
        public static int pharId;
        SqlCommand cmd;




        public static string return_UserName()
        {
            return userName;
        }
        public static int return_PharId()
        {
            return pharId;
        }
        public static string return_UserId()
        {
            return userId;
        }

        public static string return_Password()
        {
            return password;
        }
        public Form2()
        {
            InitializeComponent();
            warning.Hide();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ToggleSwitch1_Click(object sender, EventArgs e)
        {

            
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd3 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran createPassword  ", con);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("   select RegistrationNumber , PIN from EmployeeDetails  where [RegistrationNumber] =  @registrationNumber ", con);
                cmd2.Parameters.AddWithValue("@registrationNumber", registrationNumber.Text);
                cmd2.ExecuteNonQuery();

                 SqlDataReader reader1 = cmd2.ExecuteReader();
                flag2 = 0;
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {

                    flag2 = 0;

                        if (registrationNumber.Text == reader1.GetValue(0).ToString() && oldPassword.Text == reader1.GetString(1).ToString() && newPassword.Text == confirmPassword.Text)
                        {
                            flag2 = 1;
                            break;
                        }
                    }

            }
            reader1.Close();
            if(flag2 == 1)
            {
                cmd = new SqlCommand(" UPDATE [EmployeeDetails] SET  PIN = @confirmPassword  where [RegistrationNumber] =  @registrationNumber  ", con);
                cmd.Parameters.AddWithValue("@confirmPassword", confirmPassword.Text);
                cmd.Parameters.AddWithValue("@registrationNumber", int.Parse(registrationNumber.Text));
                cmd.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand(" commit tran createPassword  ",con);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Password created successfully..............");
                bunifuPages1.SetPage(0);
            }
            else
            {
                warning1.Show();
            }

            


            //}
            //catch
            //{
            //    MessageBox.Show("Sorry for inconvinience........");
            //}








        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void username_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void password_Textbox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toggle_Switch_Click(object sender, EventArgs e)
        {
           
        }

        private void toggle_Switch_Click_1(object sender, EventArgs e)
        {
            if (toggle_Switch.Checked == true)
            {
                password_Textbox.UseSystemPasswordChar = false;
            }
            else
            {
                password_Textbox.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                userName = username_TextBox.Text;
                password = password_Textbox.Text;

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("select Id from Lookup where Name = 'Admin' ", con);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd0 = new SqlCommand("select [RegistrationNumber] from EmployeeDetails where Name = @userName  and Pin = @password and [Designation] = @designation  ", con);
                cmd0.Parameters.AddWithValue("@userName", username_TextBox.Text);
                cmd0.Parameters.AddWithValue("@password", password_Textbox.Text);
                cmd0.Parameters.AddWithValue("@designation", int.Parse(cmd2.ExecuteScalar().ToString()));
                cmd0.ExecuteNonQuery();
                

                SqlCommand cmd1 = new SqlCommand(" select Name,Pin,[Pharmacy Id]  from EmployeeDetails where [Designation] = @designation  ", con);
                cmd1.Parameters.AddWithValue("@userName", username_TextBox.Text);
                cmd1.Parameters.AddWithValue("@password", password_Textbox.Text);
                cmd1.Parameters.AddWithValue("@designation", int.Parse(cmd2.ExecuteScalar().ToString()));
                cmd1.ExecuteNonQuery();
                object ab = cmd0.ExecuteScalar();

                 
            
            if (ab != null)
            {
                    userId = cmd0.ExecuteScalar().ToString();

             }
            if (username_TextBox.Text == "Head" && password_Textbox.Text == "000")
            {
                flag1 = 1;
                warning.Hide();
                this.Hide();
                headPage.hp.Closed += (s, args) => this.Close();
                headPage.hp.Show();
            }

            else
            {
                SqlDataReader reader = cmd1.ExecuteReader();
                flag1 = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        flag1 = 0;


                        if (username_TextBox.Text == reader.GetString(0).ToString() && password_Textbox.Text == reader.GetString(1).ToString())
                        {
                            flag1 = 1;
                            currentlyActiveUser = username_TextBox.Text;
                            //pharId = int.Parse(reader.GetString(2).ToString());
                            pharId = int.Parse(reader.GetInt32(2).ToString());
                            warning.Hide();
                            this.Hide();
                            mainPage.mp.Closed += (s, args) => this.Close();
                            mainPage.mp.Show();
                            adminLogin = true;
                            break;
                        }
                    }

                }
                reader.Close();

                if (flag1 == 0)
                {
                    warning.Show();
                }
                if (adminLogin == false)
                {
                    SqlCommand cmd5 = new SqlCommand("select Id from Lookup where Name <> 'Admin' AND Category = 'EMPLOYEE_DESIGNATION'", con);
                    cmd5.ExecuteNonQuery();
                    object ab1 = cmd5.ExecuteScalar();

                    SqlCommand cmd11 = new SqlCommand(" select Name,Pin,[Pharmacy Id]  from EmployeeDetails where [Designation] = @designation  ", con);
                    cmd11.Parameters.AddWithValue("@userName", username_TextBox.Text);
                    cmd11.Parameters.AddWithValue("@password", password_Textbox.Text);
                    cmd11.Parameters.AddWithValue("@designation", int.Parse(cmd5.ExecuteScalar().ToString()));
                    cmd11.ExecuteNonQuery();
                    SqlDataReader reader1 = cmd11.ExecuteReader();
                    flag1 = 0;

                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            flag1 = 0;
                            if (username_TextBox.Text == reader1.GetString(0).ToString() && password_Textbox.Text == reader1.GetString(1).ToString())
                            {
                                flag1 = 1;
                                currentlyActiveUser = username_TextBox.Text;
                                //pharId = int.Parse(reader.GetString(2).ToString());
                                pharId = int.Parse(reader1.GetInt32(2).ToString());
                                warning.Hide();
                                this.Hide();
                                employeePage.ep.Closed += (s, args) => this.Close();
                                employeePage.ep.Show();
                                break;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not exists");
                    }
                    reader1.Close();
                    if (flag1 == 0)
                    {
                        warning.Show();
                    }
                }
            }
             
            
            //}
            //catch
            //{

            //    warning.Show();
            //}

}

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            newPassword.UseSystemPasswordChar = true;
            confirmPassword.UseSystemPasswordChar = true;
            oldPassword.UseSystemPasswordChar = true;
            warning1.Hide();
        }

        private void guna2TextBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox7_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2TextBox6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void guna2TextBox7_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void guna2TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void username_TextBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            warning.Hide();

        }

        private void password_Textbox_MouseClick_1(object sender, MouseEventArgs e)
        {
            warning.Hide();
            

        }

        public static string getCurrntlyActiveUserName()
        {
            return currentlyActiveUser;
        }

        private void ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toggle_Switch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_Click(object sender, EventArgs e)
        {
            if (toggle_of_forget_password.Checked == true)
            {
                newPassword.UseSystemPasswordChar = false;
                confirmPassword.UseSystemPasswordChar = false;
                oldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                newPassword.UseSystemPasswordChar = true;
                confirmPassword.UseSystemPasswordChar = true;
                oldPassword.UseSystemPasswordChar = true;

            }
        }

        private void toggle_of_forget_password_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void registrationNumber_MouseClick(object sender, MouseEventArgs e)
        {
            warning1.Hide();
        }

        private void oldPassword_MouseClick(object sender, MouseEventArgs e)
        {
            warning1.Hide();

        }

        private void newPassword_MouseClick(object sender, MouseEventArgs e)
        {
            warning1.Hide();

        }

        private void confirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            warning1.Hide();

        }
    }
}
