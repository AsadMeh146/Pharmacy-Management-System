using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_DB_Project
{
    public partial class reportS_Displayer : Form
    {
        public reportS_Displayer()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            sale_repport_of_day_form report = new sale_repport_of_day_form();
            report.Show();
        }
        
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            salesReportodMonthForm report1 = new salesReportodMonthForm();
            report1.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Stock_Form report3 = new Stock_Form();
            report3.Show();    
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            expiry_report re2 = new expiry_report();
            re2.Show();
        }
    }
}
