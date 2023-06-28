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
    public partial class ReceiveOrder : Form
    {
        int pharId = Form2.return_PharId();
        int checkLoop = 0;
        public ReceiveOrder()
        {
            InitializeComponent();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            
            SqlCommand cmd = new SqlCommand("SELECT Id FROM StockOrder WHERE [Id] = @Id AND [Shipped Date] IS NULL", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(orderId.Text));
            cmd.ExecuteNonQuery();
            object oldquan = cmd.ExecuteScalar();
            if (oldquan == null)
            {
                MessageBox.Show("Invalid order Id");
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("SELECT StockOrderDetails.[Order Id],ManufacturerDetails.Id AS ManuId,ProductDetails.Id AS ProId,Shippers.Id AS ShipId,ManufacturerDetails.Name AS [Manufacturer Name],ProductDetails.Name AS [Product Name],Shippers.name AS [Shipper Name],StockOrderDetails.[Unit Price],StockOrderDetails.Quantity FROM StockOrder,ManufacturerDetails,ProductDetails,Shippers,StockOrderDetails WHERE StockOrderDetails.[Manufacture Id] = ManufacturerDetails.Id AND StockOrderDetails.[Product Id] = ProductDetails.Id AND StockOrder.[Shipper Id] = Shippers.Id AND StockOrderDetails.[Order Id] = @Id AND StockOrder.Id = @Id ", con);
                cmd1.Parameters.AddWithValue("@Id", int.Parse(cmd.ExecuteScalar().ToString()));
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderDetails_view.DataSource = dt;
                cmd1.ExecuteNonQuery();
                orderDetails_view.Columns["ManuId"].Visible = false;
                orderDetails_view.Columns["ProId"].Visible = false;
                orderDetails_view.Columns["ShipId"].Visible = false;
                orderDetails_view.Columns["Manufacturer Name"].ReadOnly = true;
                orderDetails_view.Columns["Product Name"].ReadOnly = true;
                orderDetails_view.Columns["Shipper Name"].ReadOnly = true;
                orderDetails_view.Columns["Unit Price"].ReadOnly = true;
                orderDetails_view.Columns["Quantity"].ReadOnly = true;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            checkLoop = 0;
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Insert_Date", con);
            t7_cmd.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("UPDATE StockOrder SET [Shipped Date] = @ShipDate WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@ShipDate", DateTime.Parse(DateTime.Now.ToString()));
            cmd.Parameters.AddWithValue("Id", int.Parse(orderId.Text));
            cmd.ExecuteNonQuery();
            for (int i = 0; i < orderDetails_view.RowCount - 1; i++)
            {
                SqlCommand cmd4 = new SqlCommand(" Update Stock set [Quantity] += @originalQuantity where [Pharmacy Id]=@pharmacyId and    [Product Id]=@productId and[Manufacturer ID]=@manufacturerId  ", con);
                cmd4.Parameters.AddWithValue("@pharmacyId", pharId);
                cmd4.Parameters.AddWithValue("@manufacturerId", int.Parse(orderDetails_view.Rows[i].Cells[1].FormattedValue.ToString()));
                cmd4.Parameters.AddWithValue("@productId", int.Parse(orderDetails_view.Rows[i].Cells[2].FormattedValue.ToString()));
                cmd4.Parameters.AddWithValue("@originalQuantity", int.Parse(orderDetails_view.Rows[i].Cells[8].FormattedValue.ToString()));
                cmd4.ExecuteNonQuery();
                checkLoop = 1;
            }
            
            if (checkLoop == 1)
            {
                MessageBox.Show("Order received successfully");
                SqlCommand t8_cmd = new SqlCommand("COMMIT TRAN Insert_Date", con);
                t8_cmd.ExecuteNonQuery();
            }
            else if (checkLoop == 0)
            {
                SqlCommand t8_cmd = new SqlCommand("ROLLBACK TRAN Insert_Date", con);
                t8_cmd.ExecuteNonQuery();
            }
            orderDetails_view.DataSource = null;
        }

        private void ReceiveOrder_Load(object sender, EventArgs e)
        {

        }
    }  
}
