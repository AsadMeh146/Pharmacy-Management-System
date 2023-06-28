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
    public partial class Stock_Return : Form
    {
        static int new_quantity = 0;
        static int old_quantity = 0;
        int pharId = Form2.return_PharId();
        int manufacturerId = 0;
        int productId = 0;
        int get_Quan = 0;
        int checkLoop = 0;
        public Stock_Return()
        {
            InitializeComponent();
        }
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        public void addButtonsInColumns(DataGridViewButtonColumn btn)
        {
            btn.Name = "Return";
            btn.Text = "Return Item";
            btn.UseColumnTextForButtonValue = true;
            displayReturnOrders.Columns.Add(btn);
        }
        private void search_order_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand("SELECT [StockOrderDetails].[Order Id] AS OrderId,[StockOrderDetails].[Manufacture Id],[StockOrderDetails].[Product Id],Shippers.Id AS [Shipper Id],ManufacturerDetails.Name AS [Manufacturer Name],ProductDetails.Name AS [Product Name],Shippers.name AS [Shipper Name],(StockOrderDetails.Quantity - ISNULL(R1.Total_Quantity,0)) AS Quantity,StockOrderDetails.[Unit Price] FROM StockOrderDetails LEFT JOIN (SELECT StockOrderId,ProductId,SUM(Quantity) AS Total_Quantity FROM ReturnStockOrder GROUP BY StockOrderId,ProductId) AS R1 ON StockOrderDetails.[Order Id] = R1.StockOrderId AND StockOrderDetails.[Product Id] = R1.ProductId INNER JOIN ProductDetails ON StockOrderDetails.[Product Id] = ProductDetails.Id  INNER JOIN ManufacturerDetails ON ManufacturerDetails.Id = StockOrderDetails.[Manufacture Id] INNER JOIN StockOrder ON StockOrder.Id = StockOrderDetails.[Order Id] INNER JOIN Shippers ON Shippers.Id = StockOrder.[Shipper Id] WHERE StockOrder.[Shipped Date] IS NOT NULL AND [StockOrderDetails].[Order Id] = @searchId", con);
            cmd0.Parameters.AddWithValue("@searchId", (int.Parse(search_Stock.Text)).ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayReturnOrders.DataSource = dt;
            cmd0.ExecuteNonQuery();
            displayReturnOrders.Columns["Manufacture Id"].Visible = false;
            displayReturnOrders.Columns["Product Id"].Visible = false;
            displayReturnOrders.Columns["Shipper Id"].Visible = false;
            displayReturnOrders.Columns["OrderId"].ReadOnly = true;
            displayReturnOrders.Columns["Manufacturer Name"].ReadOnly = true;
            displayReturnOrders.Columns["Product Name"].ReadOnly = true;
            displayReturnOrders.Columns["Shipper Name"].ReadOnly = true;
            displayReturnOrders.Columns["Unit Price"].ReadOnly = true;
            displayReturnOrders.Visible = true;
            addButtonsInColumns(btn);

        }

        private void displayReturnOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkLoop = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand t10_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Return_Stock", con);
            t10_cmd.ExecuteNonQuery();
            if (e.ColumnIndex == displayReturnOrders.Columns["Return"].Index && e.RowIndex >= 0)
            {
                if (this.displayReturnOrders.SelectedRows.Count > 0)
                {
                    int proId = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Product Id"]);
                    int manu_Id = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Manufacture Id"]);
                    int quantity = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Quantity"]);
                    manufacturerId = int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[manu_Id].FormattedValue.ToString());
                    productId = int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[proId].FormattedValue.ToString());

                    SqlCommand tcmd = new SqlCommand("select Quantity from StockOrderDetails  where [Order Id] = @orderId AND [Product Id] = @productId and [Manufacture Id] = @manufacturerId  ", con);
                    tcmd.Parameters.AddWithValue("@orderId", int.Parse(search_Stock.Text));
                    tcmd.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                    tcmd.Parameters.AddWithValue("@productId", productId);
                    tcmd.ExecuteNonQuery();
                    SqlCommand tcmd1 = new SqlCommand("  select SUM(Quantity) AS Quantity from ReturnStockOrder  where [StockOrderId] = @orderId  AND [ProductId] = @productId GROUP BY [StockOrderId],[ProductId]", con);
                    tcmd1.Parameters.AddWithValue("@orderId", int.Parse(search_Stock.Text));
                    tcmd1.Parameters.AddWithValue("@productId", productId);
                    tcmd1.ExecuteNonQuery();
                    new_quantity = int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[quantity].FormattedValue.ToString());
                    object oldquan = tcmd1.ExecuteScalar();
                    if (oldquan == null)
                    {
                        get_Quan = 0;
                        old_quantity = int.Parse(tcmd.ExecuteScalar().ToString()) - get_Quan;
                    }
                    else
                    {
                        get_Quan = int.Parse(tcmd1.ExecuteScalar().ToString());
                        old_quantity = int.Parse(tcmd.ExecuteScalar().ToString()) - get_Quan;
                    }

                    new_quantity = int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[quantity].FormattedValue.ToString());
                   
                    if (new_quantity > old_quantity)
                    {
                       MessageBox.Show("You cannot return that much items");
                    }
                    else
                    {
                        SqlCommand cmd4 = new SqlCommand(" Update Stock set [Quantity] -= @originalQuantity where [Pharmacy Id]=@pharmacyId and    [Product Id]=@productId and[Manufacturer ID]=@manufacturerId  ", con);
                        cmd4.Parameters.AddWithValue("@pharmacyId", pharId);
                        cmd4.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                        cmd4.Parameters.AddWithValue("@productId", productId);
                        cmd4.Parameters.AddWithValue("@originalQuantity", new_quantity);
                        cmd4.ExecuteNonQuery();

                        SqlCommand cmd5 = new SqlCommand("INSERT INTO ReturnStockOrder values(@stockId,@productId2,@quantity,@returnDate)", con);
                        cmd5.Parameters.AddWithValue("@stockId", int.Parse(search_Stock.Text));
                        cmd5.Parameters.AddWithValue("@quantity", new_quantity);
                        cmd5.Parameters.AddWithValue("@productId2", productId);
                        cmd5.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString());
                        cmd5.ExecuteNonQuery();
                        checkLoop = 1;
                        MessageBox.Show("Your quantity is returned");
                        displayReturnOrders.Rows.RemoveAt(this.displayReturnOrders.SelectedRows[0].Index);
                          
                    }
                
                }
            }
            if (checkLoop == 1)
            {
                SqlCommand t11_cmd = new SqlCommand("COMMIT TRAN Return_Stock", con);
                t11_cmd.ExecuteNonQuery();
            }
            else if (checkLoop == 0)
            {
                SqlCommand t11_cmd = new SqlCommand("ROLLBACK TRAN Return_Stock", con);
                t11_cmd.ExecuteNonQuery();
            }
        }

        private void displayReturnOrders_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void displayReturnOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void return_all_stock_order_Click(object sender, EventArgs e)
        {
            checkLoop = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand t10_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Return_Stock", con);
            t10_cmd.ExecuteNonQuery();
            for (int i = 0; i < displayReturnOrders.RowCount -1; i++)
            {
                int quantity = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Quantity"]);
                int proId = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Product Id"]);
                int manu_Id = displayReturnOrders.Columns.IndexOf(displayReturnOrders.Columns["Manufacture Id"]);
                manufacturerId = int.Parse(displayReturnOrders.Rows[i].Cells[manu_Id].FormattedValue.ToString());
                productId = int.Parse(displayReturnOrders.Rows[i].Cells[proId].FormattedValue.ToString());

                SqlCommand tcmd = new SqlCommand("select Quantity from StockOrderDetails  where [Order Id] = @orderId AND [Product Id] = @productId and [Manufacture Id] = @manufacturerId  ", con);
                tcmd.Parameters.AddWithValue("@orderId", int.Parse(search_Stock.Text));
                tcmd.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                tcmd.Parameters.AddWithValue("@productId", productId);
                tcmd.ExecuteNonQuery();
                SqlCommand tcmd1 = new SqlCommand("  select SUM(Quantity) AS Quantity from ReturnStockOrder  where [StockOrderId] = @orderId  AND [ProductId] = @productId GROUP BY [StockOrderId],[ProductId]", con);
                tcmd1.Parameters.AddWithValue("@orderId", int.Parse(search_Stock.Text));
                tcmd1.Parameters.AddWithValue("@productId", productId);
                tcmd1.ExecuteNonQuery();
                new_quantity = int.Parse(displayReturnOrders.Rows[i].Cells[quantity].FormattedValue.ToString());
                object oldquan = tcmd1.ExecuteScalar();
                if (oldquan == null)
                {
                    get_Quan = 0;
                    old_quantity = int.Parse(tcmd.ExecuteScalar().ToString()) - get_Quan;
                }
                else
                {
                    get_Quan = int.Parse(tcmd1.ExecuteScalar().ToString());
                    old_quantity = int.Parse(tcmd.ExecuteScalar().ToString()) - get_Quan;
                }
                
                new_quantity = int.Parse(displayReturnOrders.Rows[i].Cells[quantity].FormattedValue.ToString());
                
                


                if (new_quantity == 0)
                {
                    MessageBox.Show("You cannot return that much items");
                }
                else
                {
                    SqlCommand cmd4 = new SqlCommand(" Update Stock set [Quantity] -= @originalQuantity where [Pharmacy Id]=@pharmacyId and    [Product Id]=@productId and[Manufacturer ID]=@manufacturerId  ", con);
                    cmd4.Parameters.AddWithValue("@pharmacyId", pharId);
                    cmd4.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                    cmd4.Parameters.AddWithValue("@productId", productId);
                    cmd4.Parameters.AddWithValue("@originalQuantity", new_quantity);
                    cmd4.ExecuteNonQuery();
                    SqlCommand cmd5 = new SqlCommand("INSERT INTO ReturnStockOrder values(@stockId,@productId2,@quantity,@returnDate)", con);
                    cmd5.Parameters.AddWithValue("@stockId", int.Parse(search_Stock.Text));
                    cmd5.Parameters.AddWithValue("@quantity", new_quantity);
                    cmd5.Parameters.AddWithValue("@productId2", productId);
                    cmd5.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString());
                    cmd5.ExecuteNonQuery();
                    checkLoop = 1;
                    MessageBox.Show("Your quantity is returned");
                }
            }
            if (checkLoop == 1)
            {
                SqlCommand t11_cmd = new SqlCommand("COMMIT TRAN Return_Stock", con);
                t11_cmd.ExecuteNonQuery();
            }
            else if (checkLoop == 0)
            {
                SqlCommand t11_cmd = new SqlCommand("ROLLBACK TRAN Return_Stock", con);
                t11_cmd.ExecuteNonQuery();
            }
            //displayReturnOrders.DataSource = null;
            this.displayReturnOrders.Columns.Clear();


        }

        private void Stock_Return_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand("SELECT [StockOrderDetails].[Order Id] AS OrderId,[StockOrderDetails].[Manufacture Id],[StockOrderDetails].[Product Id],Shippers.Id AS [Shipper Id],ManufacturerDetails.Name AS [Manufacturer Name],ProductDetails.Name AS [Product Name],Shippers.name AS [Shipper Name],[StockOrderDetails].Quantity,[StockOrderDetails].[Unit Price] FROM [StockOrderDetails],ManufacturerDetails,ProductDetails,Shippers,StockOrder WHERE ManufacturerDetails.Id = [StockOrderDetails].[Manufacture Id] AND ProductDetails.Id = [StockOrderDetails].[Product Id] AND Shippers.Id = [StockOrder].[Shipper Id] AND StockOrder.[Shipped Date] != NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayReturnOrders.DataSource = dt;
            cmd0.ExecuteNonQuery();
            displayReturnOrders.Columns["Manufacture Id"].Visible = false;
            displayReturnOrders.Columns["Product Id"].Visible = false;
            displayReturnOrders.Columns["Shipper Id"].Visible = false;
            displayReturnOrders.Columns["OrderId"].ReadOnly = true;
            displayReturnOrders.Columns["Manufacturer Name"].ReadOnly = true;
            displayReturnOrders.Columns["Product Name"].ReadOnly = true;
            displayReturnOrders.Columns["Shipper Name"].ReadOnly = true;
            displayReturnOrders.Columns["Unit Price"].ReadOnly = true;
            displayReturnOrders.Visible = false;

        }
    }
}
