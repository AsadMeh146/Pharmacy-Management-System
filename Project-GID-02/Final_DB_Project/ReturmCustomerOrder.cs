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
    public partial class ReturmCustomerOrder : Form
    {
        DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();

        SqlCommand cmd0;

        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;
        SqlCommand cmd5;
        SqlCommand cmd7;


        string pharmacyId;
        string manufacturerId;
        string productId;
        int quantity_of_Table;
        int originalQuantity;




        public ReturmCustomerOrder()
        {
            InitializeComponent();
        }
        public void addButtonsInColumns(DataGridViewButtonColumn btn )
        {
            btn.Name = "Return";
            btn.Text = "Return Item";
            btn.UseColumnTextForButtonValue = true;
            displayReturnOrders.Columns.Add(btn);
            
        }

        private void searchBar3001_Click(object sender, EventArgs e)
        {
            this.displayReturnOrders.Columns.Clear();




            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd0 = new SqlCommand("  select R2.Order_Id ,  ManufacturerDetails.Name,ProductDetails.Name  , ISNULL(R2.Quantity , R2.ActualQuantity ) AS Quantity , ProductDetails.[Sale Price] from (select R1.[Order Id] as Order_Id , R1.[Product Id] as Product_Id,  ( max(R1.Quantity) - Sum(ReturnCustomerOrder.Quantity) ) as Quantity , max(R1.Quantity) as ActualQuantity from (select CustomerOrderDetails.[Order Id] , CustomerOrderDetails.[Manufacture Id]  , CustomerOrderDetails.[Product Id]   , CustomerOrderDetails.Quantity , CustomerOrderDetails.[Price] from CustomerOrderDetails where CustomerOrderDetails.[Order Id] =  @search ) as R1 left join ReturnCustomerOrder on ReturnCustomerOrder.OrderID = R1.[Order Id] and ReturnCustomerOrder.ProductID = R1.[Product Id] group by R1.[Order Id] , R1.[Product Id]) as R2 join ProductDetails on ProductDetails.Id = R2.Product_Id join ManufacturerDetails on ManufacturerDetails.Id = ProductDetails.ManufacturerId  ", con);
            cmd0.Parameters.AddWithValue("@search", (int.Parse(searchBar.Text)).ToString()   );
            SqlDataAdapter da = new SqlDataAdapter(cmd0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayReturnOrders.DataSource = dt;
            cmd0.ExecuteNonQuery();
            addButtonsInColumns(btn1);

            //displayReturnOrders.Columns["Order Id"].ReadOnly = true;
            //displayReturnOrders.Columns["Company Name"].ReadOnly = true;
            //displayReturnOrders.Columns["Product Name"].ReadOnly = true;
            //displayReturnOrders.Columns["Price"].ReadOnly = true;

        }

        private void returnAllProducts_Click(object sender, EventArgs e)
        {
            //try
            //{
            
                
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd5 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran returnOrder  ", con);
                cmd5.ExecuteNonQuery();

                pharmacyId = "";
                manufacturerId = "";
                productId = "";
                quantity_of_Table = 0;
                originalQuantity = 0;

                for (int i = 0; i < displayReturnOrders.RowCount - 1; i++)
                {

                    cmd0 = new SqlCommand(" select [Id] from ManufacturerDetails where Name = @companyName ", con);
                    cmd0.Parameters.AddWithValue("@companyName", displayReturnOrders.Rows[i].Cells[1].Value.ToString());
                    cmd0.ExecuteNonQuery();

                    cmd1 = new SqlCommand(" select [Id] from ProductDetails where Name = @productName ", con);
                    cmd1.Parameters.AddWithValue("@productName", displayReturnOrders.Rows[i].Cells[2].Value.ToString());
                    cmd1.ExecuteNonQuery();

                    cmd2 = new SqlCommand(" select [Pharmacy Id] from EmployeeDetails where [RegistrationNumber] = @userID ", con);
                    cmd2.Parameters.AddWithValue("@userID", Form2.return_UserId());
                    cmd2.ExecuteNonQuery();

                    pharmacyId = cmd2.ExecuteScalar().ToString();
                    manufacturerId = cmd0.ExecuteScalar().ToString();
                    productId = cmd1.ExecuteScalar().ToString();
                    quantity_of_Table = int.Parse(displayReturnOrders.Rows[i].Cells[3].Value.ToString());

                    cmd3 = new SqlCommand(" select [Quantity]  from Stock  where [Pharmacy Id] = @pharmacyId and [Product Id] = @productId and [Manufacturer ID] = @manufacturerId  ", con);
                    cmd3.Parameters.AddWithValue("@pharmacyId", pharmacyId);
                    cmd3.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                    cmd3.Parameters.AddWithValue("@productId", productId);
                    cmd3.ExecuteNonQuery();

                    originalQuantity = int.Parse(cmd3.ExecuteScalar().ToString());
                    originalQuantity = originalQuantity + quantity_of_Table;

                    cmd4 = new SqlCommand(" Update Stock set [Quantity] = @originalQuantity where [Pharmacy Id]=@pharmacyId and    [Product Id]=@productId and[Manufacturer ID]=@manufacturerId  ", con);
                    cmd4.Parameters.AddWithValue("@pharmacyId", pharmacyId.ToString());
                    cmd4.Parameters.AddWithValue("@manufacturerId", manufacturerId.ToString());
                    cmd4.Parameters.AddWithValue("@productId", productId.ToString());
                    cmd4.Parameters.AddWithValue("@originalQuantity", originalQuantity.ToString());
                    cmd4.ExecuteNonQuery();




                    cmd5 = new SqlCommand(" insert into [ReturnCustomerOrder] values(  @orderID  , @productID    , @quantity , @returnDate  ) ", con);
                    cmd5.Parameters.AddWithValue("@orderID", displayReturnOrders.Rows[i].Cells[0].Value.ToString());
                    cmd5.Parameters.AddWithValue("@productID", int.Parse(cmd1.ExecuteScalar().ToString()));
                    cmd5.Parameters.AddWithValue("@quantity", int.Parse(displayReturnOrders.Rows[i].Cells[3].Value.ToString()));
                    cmd5.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString());
                    cmd5.ExecuteNonQuery();


            }
                displayReturnOrders.DataSource = null;

            MessageBox.Show("Your order is returned");
                SqlCommand cmd6 = new SqlCommand(" commit tran returnOrder  ", con);
                cmd6.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Sorry for inconvinience...........");
            //}
            
        }

        private void displayReturnOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd5 = new SqlCommand("set transaction isolation level SERIALIZABLE begin tran return_Order_in_Parts  ", con);
                cmd5.ExecuteNonQuery();

                pharmacyId = "";
                manufacturerId = "";
                productId = "";
                quantity_of_Table = 0;
                originalQuantity = 0;

                if (e.ColumnIndex == displayReturnOrders.Columns["Return"].Index && e.RowIndex >= 0)
                {
                    if (this.displayReturnOrders.SelectedRows.Count > 0)
                    {
                        cmd0 = new SqlCommand(" select [Id] from ManufacturerDetails where Name = @companyName ", con);
                        cmd0.Parameters.AddWithValue("@companyName", displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[1].FormattedValue.ToString());
                        cmd0.ExecuteNonQuery();

                        cmd1 = new SqlCommand(" select [Id] from ProductDetails where Name = @productName ", con);
                        cmd1.Parameters.AddWithValue("@productName", displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                        cmd1.ExecuteNonQuery();

                        cmd2 = new SqlCommand(" select [Pharmacy Id] from EmployeeDetails where [RegistrationNumber] = @userID ", con);
                        cmd2.Parameters.AddWithValue("@userID", Form2.return_UserId());
                        cmd2.ExecuteNonQuery();

                        pharmacyId = cmd2.ExecuteScalar().ToString();
                        manufacturerId = cmd0.ExecuteScalar().ToString();
                        productId = cmd1.ExecuteScalar().ToString();
                        quantity_of_Table = int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[3].FormattedValue.ToString());

                        cmd3 = new SqlCommand(" select [Quantity]  from Stock  where [Pharmacy Id] = @pharmacyId and [Product Id] = @productId and [Manufacturer ID] = @manufacturerId  ", con);
                        cmd3.Parameters.AddWithValue("@pharmacyId", pharmacyId);
                        cmd3.Parameters.AddWithValue("@manufacturerId", manufacturerId);
                        cmd3.Parameters.AddWithValue("@productId", productId);
                        cmd3.ExecuteNonQuery();

                        originalQuantity = int.Parse(cmd3.ExecuteScalar().ToString());
                        originalQuantity = originalQuantity + quantity_of_Table;

                        cmd4 = new SqlCommand(" Update Stock set [Quantity] = @originalQuantity where [Pharmacy Id]=@pharmacyId and    [Product Id]=@productId and[Manufacturer ID]=@manufacturerId  ", con);
                        cmd4.Parameters.AddWithValue("@pharmacyId", pharmacyId.ToString());
                        cmd4.Parameters.AddWithValue("@manufacturerId", manufacturerId.ToString());
                        cmd4.Parameters.AddWithValue("@productId", productId.ToString());
                        cmd4.Parameters.AddWithValue("@originalQuantity", originalQuantity.ToString());
                        cmd4.ExecuteNonQuery();


   



                        cmd7 = new SqlCommand(" insert into [ReturnCustomerOrder] values(  @orderID  , @productID    , @quantity , @returnDate  ) ", con);
                        cmd7.Parameters.AddWithValue("@orderID", int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[0].FormattedValue.ToString()));
                        cmd7.Parameters.AddWithValue("@productID", int.Parse(cmd1.ExecuteScalar().ToString()));
                        cmd7.Parameters.AddWithValue("@quantity", int.Parse(displayReturnOrders.Rows[displayReturnOrders.CurrentRow.Index].Cells[3].FormattedValue.ToString()));
                        cmd7.Parameters.AddWithValue("@returnDate", DateTime.Now.ToString());
                        cmd7.ExecuteNonQuery();

                        MessageBox.Show("Your quantity is returned");
                        SqlCommand cmd6 = new SqlCommand(" commit tran return_Order_in_Parts  ", con);
                        cmd6.ExecuteNonQuery();

                        //tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                        //tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                        //totalBill = (totalBill - (tempQuantity2 * tempSalePrice2));
                        //totalAmount.Text = totalBill.ToString();
                        displayReturnOrders.Rows.RemoveAt(this.displayReturnOrders.SelectedRows[0].Index);
                        //rows = rows - 1;

                    }


                }
            }
            catch
            {
                MessageBox.Show("Sorry for inconvinience");
            }
           

        }

        private void ReturmCustomerOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
