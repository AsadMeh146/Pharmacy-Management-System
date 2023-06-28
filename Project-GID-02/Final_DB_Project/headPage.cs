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
    public partial class headPage : Form
    {
        public static headPage hp = new headPage();
        public headPage()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            manage_phar_subPanel.Visible = false;
            manage_pro_subPanel.Visible = false;


        }
        private void hideSubMenu()
        {
            if (manage_phar_subPanel.Visible == true)
            {
                manage_phar_subPanel.Visible = false;
            }
            if (manage_pro_subPanel.Visible == true)
            {
                manage_pro_subPanel.Visible = false;
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
        private void headPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Home homeForm = new Home() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            homeForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Head_Dashboard stockForm = new Head_Dashboard() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(stockForm);
            stockForm.Show();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Add_Pharmacy pharmacyForm = new Add_Pharmacy() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            pharmacyForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(pharmacyForm);
            pharmacyForm.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Update_Pharmacy update_pharmacyForm = new Update_Pharmacy() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            update_pharmacyForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(update_pharmacyForm);
            update_pharmacyForm.Show();
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
        
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

        private void searchPharmacy1_Click(object sender, EventArgs e)
        {
       
        }

        private void updatePharmacy1_Click(object sender, EventArgs e)
        {
                    }

        private void deletePharmacy1_Click(object sender, EventArgs e)
        {
            
}

        private void button1_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Loan_Request loan_requestForm = new Loan_Request() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            loan_requestForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(loan_requestForm);
            loan_requestForm.Show();
        }
       
        
        private void c(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void displayEmployeeLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void employeeLoanView_CellClick(object sender, DataGridViewCellEventArgs e)
        {        }

        private void search20003_Click(object sender, EventArgs e)
        {
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_phar_subPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_pro_subPanel);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            Add_Admin loan_requestForm = new Add_Admin() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            loan_requestForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(loan_requestForm);
            loan_requestForm.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            View_Employees loan_requestForm = new View_Employees() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            loan_requestForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(loan_requestForm);
            loan_requestForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.head_mainPanel.Controls.Clear();
            reportS_Displayer loan_requestForm = new reportS_Displayer() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            loan_requestForm.FormBorderStyle = FormBorderStyle.None;
            this.head_mainPanel.Controls.Add(loan_requestForm);
            loan_requestForm.Show();
        }
    }
    
}

