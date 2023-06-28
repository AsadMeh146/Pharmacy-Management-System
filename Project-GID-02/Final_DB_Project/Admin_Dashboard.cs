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
    public partial class Admin_Dashboard : Form
    {
        //public static mainPage mp = new mainPage();
        int pharId = Form2.return_PharId();
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT [Shipper Id]) FROM StockOrder WHERE [Pharmacy Id] = @pharId", con);
            cmd.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(CustomerDetails.Id) FROM CustomerDetails WHERE CustomerDetails.Id = ANY (SELECT CustomerId FROM  CustomerOrder WHERE [Pharmacy Id] = @pharId GROUP BY CustomerId)", con);
            cmd1.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT([Product Id]) FROM Stock WHERE [Pharmacy Id] = @pharId AND Quantity = 0", con);
            cmd2.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(ProductDetails.Id) FROM Stock,ProductDetails WHERE Stock.[Product Id] = ProductDetails.Id and DATEADD(dd, 0, DATEDIFF(dd, 0, ProductDetails.[Expiry Date])) = GETDATE() and Stock.[Pharmacy Id] = @pharId", con);
            cmd3.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(Stock.[Product Id]) FROM Stock WHERE Stock.[Pharmacy Id] = @pharId", con);
            cmd4.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd5 = new SqlCommand("SELECT ISNULL(SUM(CustomerOrderDetails.[Price] * CustomerOrderDetails.Quantity),0) FROM CustomerOrder,CustomerOrderDetails WHERE CustomerOrder.OrderId = CustomerOrderDetails.[Order Id] AND CustomerOrder.[Pharmacy Id] = @pharId", con);
            cmd5.Parameters.AddWithValue("@pharId", pharId);
            SqlCommand cmd6 = new SqlCommand("SELECT ISNULL(SUM(CustomerOrderDetails.[Price] * CustomerOrderDetails.Quantity),0) FROM CustomerOrder,CustomerOrderDetails WHERE CustomerOrder.OrderId = CustomerOrderDetails.[Order Id] AND CustomerOrder.[Pharmacy Id] = @pharId AND DATEADD(dd, 0, DATEDIFF(dd, 0, CustomerOrder.[Order Date])) = GETDATE()", con);
            cmd6.Parameters.AddWithValue("@pharId", pharId);
            label9.Text = cmd1.ExecuteScalar().ToString();
            label12.Text = cmd2.ExecuteScalar().ToString();
            label10.Text = cmd4.ExecuteScalar().ToString();
            label11.Text = cmd.ExecuteScalar().ToString();
            label13.Text = cmd3.ExecuteScalar().ToString();
            label14.Text = cmd5.ExecuteScalar().ToString();
            label26.Text = cmd6.ExecuteScalar().ToString();
        }

        private void bunifuShadowPanel8_ControlAdded(object sender, ControlEventArgs e)
        {
         }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.mp.mainPagePanel.Controls.Clear();
            Stock_Order stockForm = new Stock_Order() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stockForm.FormBorderStyle = FormBorderStyle.None;
            mainPage.mp.mainPagePanel.Controls.Add(stockForm);
            stockForm.Show();
        }

        private void bunifuShadowPanel9_ControlAdded(object sender, ControlEventArgs e)
        {
        
        }

        private void bunifuShadowPanel10_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.mp.mainPagePanel.Controls.Clear();
            Stock_Return returnstockForm = new Stock_Return() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            returnstockForm.FormBorderStyle = FormBorderStyle.None;
            mainPage.mp.mainPagePanel.Controls.Add(returnstockForm);
            returnstockForm.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.mp.mainPagePanel.Controls.Clear();
            ReceiveOrder receivestockForm = new ReceiveOrder() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            receivestockForm.FormBorderStyle = FormBorderStyle.None;
            mainPage.mp.mainPagePanel.Controls.Add(receivestockForm);
            receivestockForm.Show();
        }
    }
}
