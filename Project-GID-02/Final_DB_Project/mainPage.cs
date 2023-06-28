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
using System.Text.RegularExpressions;


namespace Final_DB_Project
{
    public partial class mainPage : Form
    {
       

        public static mainPage mp = new mainPage();
        static  string query;
        public mainPage()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            manage_emp_subPanel.Visible = false;
            manage_manu_subPanel.Visible = false;
            manage_pro_subPanel.Visible = false;
            manage_stock_subPanel.Visible = false;
            manage_atten_subPanel.Visible = false;
            manage_st_subPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (manage_emp_subPanel.Visible == true)
            {
                manage_emp_subPanel.Visible = false;
            }
            if (manage_manu_subPanel.Visible == true)
            {
                manage_manu_subPanel.Visible = false;
            }
            if (manage_pro_subPanel.Visible == true)
            {
                manage_pro_subPanel.Visible = false;
            }
            if (manage_stock_subPanel.Visible == true)
            {
                manage_stock_subPanel.Visible = false;
            }
            if (manage_atten_subPanel.Visible == true)
            {
                manage_atten_subPanel.Visible = false;
            }
            if (manage_st_subPanel.Visible == true)
            {
                manage_atten_subPanel.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click_2(object sender, EventArgs e)
        {
        }

        private void bunifuButton3_Click_2(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click_3(object sender, EventArgs e)
        {
            
        }

        private void bunifuShadowPanel13_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_emp_subPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Home homeForm = new Home() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            homeForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(homeForm);
            homeForm.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.mainPagePanel.Controls.Clear();
            Admin_Dashboard stockForm = new Admin_Dashboard() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(stockForm);
            stockForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_emp_subPanel);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(manage_manu_subPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_pro_subPanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_stock_subPanel);
        }

        private void bunifuButton2_Click_4(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Add_Employee add_employeeForm = new Add_Employee() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_employeeForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_employeeForm);
            add_employeeForm.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Add_Products add_ProductForm = new Add_Products() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_ProductForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_ProductForm);
            add_ProductForm.Show();




        }
        int flag=0;
        private void addMedicine_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        public void loadingDataIntoCombobox()
        {
            //medicineTypeComboBox.Items.Clear();
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("   select Category from Lookup where Name = 'MedicineType'   ", con);
            //SqlDataReader DR1 = cmd.ExecuteReader();
            //while (DR1.Read())
            //{
            //    medicineTypeComboBox.Items.Add(DR1[0]);
            //}
            //DR1.Close();

            //companyNameCombobox.Items.Clear();
            //SqlCommand cmd1 = new SqlCommand("   select Name  from ManufacturerDetails      ", con);
            //SqlDataReader DR2 = cmd1.ExecuteReader();
            //while (DR2.Read())
            //{
            //    companyNameCombobox.Items.Add(DR2[0]);
            //}
            //DR2.Close();
        }

        public void displayData(System.Windows.Forms.DataGridView dataGridView1  , string query )
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuButton5_Click_2(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            View_Update_Products view_update_ProductForm = new View_Update_Products() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            view_update_ProductForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(view_update_ProductForm);
            view_update_ProductForm.Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd0 = new SqlCommand(" select R.Id , R.[Name] , R.Type , R.[Purchase Price] , R.[Sale Price] , R.[Description] , ManufacturerDetails.Name AS [Company Name], R.[Expiry Date] , R.[Manufacturing Date]  from  (select ProductDetails.Id, ProductDetails.[Name], LookUp.Category as Type , ProductDetails.[Purchase Price] ,ProductDetails.[Sale Price] , ProductDetails.[Description] , ProductDetails.ManufacturerId , ProductDetails.[Expiry Date] , ProductDetails.[Manufacturing Date]       from ProductDetails join Lookup on ProductDetails.Type = Lookup.Id) as R join ManufacturerDetails on ManufacturerDetails.Id = R.ManufacturerId where R.Name = @search", con);
            //cmd0.Parameters.AddWithValue("@search", searchBar.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd0);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;
            //cmd0.ExecuteNonQuery();
        }

        private void bunifuButton4_Click_2(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Add_Manufacturer add_manufacturerForm = new Add_Manufacturer() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_manufacturerForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_manufacturerForm);
            add_manufacturerForm.Show();
        }
        
        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
                  
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuButton8_Click_2(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Add_Shipper add_shipperForm = new Add_Shipper() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_shipperForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_shipperForm);
            add_shipperForm.Show();
        }
        public void loadDataIntoShipperCombobox(ComboBox shipperCompanyNameComboBox , string query)
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

     

        private void bunifuButton3_Click_3(object sender, EventArgs e)
        {
        }

        private void bunifuButton3_Click_4(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            View_Update_Manufacturer view_update_manuForm = new View_Update_Manufacturer() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            view_update_manuForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(view_update_manuForm);
            view_update_manuForm.Show();
           

        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
        
        }

        private void updateCompany_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteCompany_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            
        }


        private void searchShipper_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton7_Click_1(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            View_Update_Suppliers view_update_shipperForm = new View_Update_Suppliers() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            view_update_shipperForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(view_update_shipperForm);
            view_update_shipperForm.Show();
          
        }

        private void guna2GradientTileButton9_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd0 = new SqlCommand(" select Shippers.Id, Shippers.[name], Shippers.[Contact Number], ManufacturerDetails.Name AS CompanyName, Shippers.Address from Shippers join ManufacturerDetails on Shippers.[Manufacturer Id] = ManufacturerDetails.Id    where Shippers.name = @search order by Id desc  ", con);
            //cmd0.Parameters.AddWithValue("@search", searchBar2.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd0);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView6.DataSource = dt;
            //cmd0.ExecuteNonQuery();
        }

        private void guna2GradientTileButton8_Click_1(object sender, EventArgs e)
        {
            
            
         
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Employee_Loan employee_loanForm = new Employee_Loan() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            employee_loanForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(employee_loanForm);
            employee_loanForm.Show();

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            View_Update_Employee view_update_employeeForm = new View_Update_Employee() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            view_update_employeeForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(view_update_employeeForm);
            view_update_employeeForm.Show();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Add_Date add_dateForm = new Add_Date() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_dateForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_dateForm);
            add_dateForm.Show();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            New_Attendance add_attendanceForm = new New_Attendance() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            add_attendanceForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(add_attendanceForm);
            add_attendanceForm.Show();
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Update_Attendance update_attendanceForm = new Update_Attendance() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_attendanceForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(update_attendanceForm);
            update_attendanceForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_atten_subPanel);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            showSubMenu(manage_st_subPanel);
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Stock_Order update_attendanceForm = new Stock_Order() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_attendanceForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(update_attendanceForm);
            update_attendanceForm.Show();
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            Stock_Return update_attendanceForm = new Stock_Return() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_attendanceForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(update_attendanceForm);
            update_attendanceForm.Show();

        }

        private void bunifuButton11_Click_1(object sender, EventArgs e)
        {
            this.mainPagePanel.Controls.Clear();
            ReceiveOrder update_attendanceForm = new ReceiveOrder() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_attendanceForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPagePanel.Controls.Add(update_attendanceForm);
            update_attendanceForm.Show();
        }
    }
}
