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
    public partial class Head_Dashboard : Form
    {
        
        public Head_Dashboard()
        {
            InitializeComponent();
        }

        private void Head_Dashboard_Load(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT [Shipper Id]) FROM StockOrder", con);
        
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(CustomerDetails.Id) FROM CustomerDetails WHERE CustomerDetails.Id = ANY (SELECT CustomerId FROM  CustomerOrder  GROUP BY CustomerId)", con);
        
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT([Product Id]) FROM Stock WHERE Quantity = 0", con);
            
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(ProductDetails.Id) FROM Stock,ProductDetails WHERE Stock.[Product Id] = ProductDetails.Id and DATEADD(dd, 0, DATEDIFF(dd, 0, ProductDetails.[Expiry Date])) = GETDATE() ", con);
          
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(Stock.[Product Id]) FROM Stock", con);
            
            SqlCommand cmd5 = new SqlCommand("SELECT ISNULL(SUM(CustomerOrderDetails.[Price] * CustomerOrderDetails.Quantity),0) FROM CustomerOrder,CustomerOrderDetails WHERE CustomerOrder.OrderId = CustomerOrderDetails.[Order Id] ", con);
            
            SqlCommand cmd6 = new SqlCommand("SELECT ISNULL(SUM(CustomerOrderDetails.[Price] * CustomerOrderDetails.Quantity),0) FROM CustomerOrder,CustomerOrderDetails WHERE CustomerOrder.OrderId = CustomerOrderDetails.[Order Id]  AND DATEADD(dd, 0, DATEDIFF(dd, 0, CustomerOrder.[Order Date])) = GETDATE()", con);
            
            label9.Text = cmd1.ExecuteScalar().ToString();
            label12.Text = cmd2.ExecuteScalar().ToString();
            label10.Text = cmd4.ExecuteScalar().ToString();
            label11.Text = cmd.ExecuteScalar().ToString();
            label13.Text = cmd3.ExecuteScalar().ToString();
            label14.Text = cmd5.ExecuteScalar().ToString();
            label26.Text = cmd6.ExecuteScalar().ToString();
        }
    }
}
