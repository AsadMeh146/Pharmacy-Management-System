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
    public partial class employeePage : Form
    {
        public static employeePage ep = new employeePage();
        public employeePage()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            manage_cus_subPanel.Visible = false;
           

        }
        private void hideSubMenu()
        {
            if (manage_cus_subPanel.Visible == true)
            {
                manage_cus_subPanel.Visible = false;
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
        private void employeePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(manage_cus_subPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.employee_mainPanel.Controls.Clear();
            Admin_Dashboard stockForm = new Admin_Dashboard() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.employee_mainPanel.Controls.Add(stockForm);
            stockForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.employee_mainPanel.Controls.Clear();
            Employee_Loan stockForm = new Employee_Loan() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.employee_mainPanel.Controls.Add(stockForm);
            stockForm.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.employee_mainPanel.Controls.Clear();
            CustomerOrder stockForm = new CustomerOrder() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.employee_mainPanel.Controls.Add(stockForm);
            stockForm.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.employee_mainPanel.Controls.Clear();
            ReturmCustomerOrder stockForm = new ReturmCustomerOrder() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            this.employee_mainPanel.Controls.Add(stockForm);
            stockForm.Show();
        }
    }
}
