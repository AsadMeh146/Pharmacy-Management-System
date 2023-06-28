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
    public partial class Stock_Order : Form
    {
        int rows = 0;
        int pharId = Form2.return_PharId();
        int getId = 0;
        int manuId = 0;
        int checkLoop = 0;
        int checkLoop1 = 0;
        int proId = 0;
        int pro_quantity = 0;
        int shipId = 0;
        int flag1 = 0;
        string tempQuantity1 = "";
        int totalBill = 0;
        int tempQuantity2 = 0;
        int tempSalePrice2 = 0;
        

        DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
        public Stock_Order()
        {
            InitializeComponent();
        }

        private void manu_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Stock_Order_Load(object sender, EventArgs e)
        {
            manu_comboBox.Items.Clear(); 
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand("SELECT [ManufacturerDetails].Name FROM [ManufacturerDetails] WHERE ManufacturerDetails.Id = ANY (SELECT Stock.[Manufacturer ID]  FROM Stock)", con);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                manu_comboBox.Items.Add(DR3[0]);
            }
            DR3.Close();
            btn1.Name = "Update";
            btn1.Text = "Update";
           
            btn1.UseColumnTextForButtonValue = true;
            displayCartItems.Columns.Add(btn1);
            btn2.Name = "Discard";
            btn2.Text = "Discard";
            btn2.UseColumnTextForButtonValue = true;
            displayCartItems.Columns.Add(btn2);
            actualOrderDate.Text = DateTime.Now.ToString();
            SqlCommand cmd4 = new SqlCommand("(SELECT Location FROM Pharmacy WHERE Id = @Id)", con);
            cmd4.Parameters.AddWithValue("@Id", pharId);
            pharmacyID.Text = cmd4.ExecuteScalar().ToString();
        }

        private void manu_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            pro_comboBox.Items.Clear();
            ship_comboBox.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("SELECT Id,Name FROM ManufacturerDetails ", con);
            SqlDataReader DR2 = cmd2.ExecuteReader();

            while (DR2.Read())
            {
                if ((DR2["Name"].ToString()) == manu_comboBox.SelectedItem.ToString())
                {
                    getId = int.Parse(DR2["Id"].ToString());
                }
            }
            DR2.Close();
            SqlCommand cmd3 = new SqlCommand("SELECT ProductDetails.Name FROM ProductDetails,Stock WHERE ProductDetails.Id = Stock.[Product Id] AND Stock.[Pharmacy Id] = @pharId AND Stock.[Manufacturer ID] = @searchId", con);
            cmd3.Parameters.AddWithValue("@pharId", pharId);
            cmd3.Parameters.AddWithValue("@searchId", getId);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                pro_comboBox.Items.Add(DR3[0]);
            }
            DR3.Close();
            SqlCommand cmd4 = new SqlCommand("SELECT name FROM Shippers WHERE Shippers.[Manufacturer Id] =  @searchId", con);
            cmd4.Parameters.AddWithValue("@searchId", getId);
            SqlDataReader DR4 = cmd4.ExecuteReader();
            while (DR4.Read())
            {
                ship_comboBox.Items.Add(DR4[0]);
            }
            DR4.Close();
        }

        private void pro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand("SELECT [Sale Price] FROM ProductDetails WHERE ProductDetails.Name = @Name ", con);
            cmd3.Parameters.AddWithValue("@Name", pro_comboBox.SelectedItem.ToString());
           
            unit_Price.Text = (cmd3.ExecuteScalar().ToString());
        }

        private void add_To_Cart_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (int.Parse(product_Quantity.Text) <= 0)
            {
                MessageBox.Show("Please enter valid quantity");
            }
            else
            {
                ship_comboBox.Enabled = false;
                manu_comboBox.Enabled = false;
                SqlCommand cmd13 = new SqlCommand(" select Id from ManufacturerDetails where Name = @selectedManufacturer ", con);
                cmd13.Parameters.AddWithValue("@selectedManufacturer", manu_comboBox.SelectedItem.ToString());
                cmd13.ExecuteNonQuery();
                manuId = int.Parse(cmd13.ExecuteScalar().ToString());
                SqlCommand cmd14 = new SqlCommand(" select Id from ProductDetails where Name = @selectedProduct ", con);
                cmd14.Parameters.AddWithValue("@selectedProduct", pro_comboBox.SelectedItem.ToString());
                cmd14.ExecuteNonQuery();
                proId = int.Parse(cmd14.ExecuteScalar().ToString());
                SqlCommand cmd15 = new SqlCommand(" select Id from Shippers where name = @selectedShipper ", con);
                cmd15.Parameters.AddWithValue("@selectedShipper", ship_comboBox.SelectedItem.ToString());
                cmd15.ExecuteNonQuery();
                shipId = int.Parse(cmd15.ExecuteScalar().ToString());
                pro_quantity = int.Parse(product_Quantity.Text);
                displayCartItems.Columns["Manufacturer_Id"].ReadOnly = true;
                displayCartItems.Columns["productId"].ReadOnly = true;
                displayCartItems.Columns["manufacturerName"].ReadOnly = true;
                displayCartItems.Columns["Product_Name"].ReadOnly = true;
                displayCartItems.Columns["product_price"].ReadOnly = true;
                displayCartItems.Columns["Manufacturer_Id"].Visible = false;
                displayCartItems.Columns["productId"].Visible = false;
                displayCartItems.Columns["shipperId"].Visible = false;

                for (int i = 0; i < displayCartItems.RowCount - 1; i++)
                {
                    if (int.Parse(displayCartItems.Rows[i].Cells[1].Value.ToString()) == proId && int.Parse(displayCartItems.Rows[i].Cells[0].Value.ToString()) == manuId)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag1 == 0)
                {
                    displayCartItems.Rows.Add();
                    displayCartItems.Rows[rows].Cells[0].Value = manuId;
                    displayCartItems.Rows[rows].Cells[1].Value = proId;
                    displayCartItems.Rows[rows].Cells[2].Value = manu_comboBox.SelectedItem.ToString();
                    displayCartItems.Rows[rows].Cells[3].Value = pro_comboBox.SelectedItem.ToString();
                    displayCartItems.Rows[rows].Cells[4].Value = product_Quantity.Text;
                    displayCartItems.Rows[rows].Cells[5].Value = unit_Price.Text;
                    displayCartItems.Rows[rows].Cells[6].Value = shipId;
                    rows = rows + 1;
                    totalBill = totalBill + (int.Parse(product_Quantity.Text) * int.Parse(unit_Price.Text));
                    stock_Bill.Text = totalBill.ToString();
                }
                if (flag1 == 1)
                {
                    MessageBox.Show("This medicine is already added into the cart.........");
                    flag1 = 0;
                }
            }

        }
        private void displayCartItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == displayCartItems.Columns["Update"].Index && e.RowIndex >= 0)
            {
                if (this.displayCartItems.SelectedRows.Count > 0)
                {
                   totalBill = totalBill - (tempSalePrice2 * int.Parse(tempQuantity1));
                   tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[4].FormattedValue.ToString());
                   tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[5].FormattedValue.ToString());
                    totalBill = totalBill + (tempSalePrice2 * tempQuantity2);
                   stock_Bill.Text = totalBill.ToString();
                   displayCartItems.Rows[rows].Cells[2].Value = displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2];
                   MessageBox.Show("Updated successfully");
                }
            }

            if (e.ColumnIndex == displayCartItems.Columns["Discard"].Index && e.RowIndex >= 0)
            {
                if (this.displayCartItems.SelectedRows.Count > 0)
                {
                    tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[4].FormattedValue.ToString());
                    tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[5].FormattedValue.ToString());
                    totalBill = (totalBill - (tempQuantity2 * tempSalePrice2));
                    stock_Bill.Text = totalBill.ToString();
                    displayCartItems.Rows.RemoveAt(this.displayCartItems.SelectedRows[0].Index);
                    rows = rows - 1;
                }
                if (this.displayCartItems.RowCount == 1)
                {
                    ship_comboBox.Enabled = true;
                    manu_comboBox.Enabled = true;
                }
            }

            if (e.ColumnIndex == displayCartItems.Columns["product_quan"].Index && e.RowIndex >= 0)
            {
                tempQuantity1 = displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[4].FormattedValue.ToString();
                tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[5].FormattedValue.ToString());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            checkLoop = 0;
            checkLoop1 = 0;
            int colIndex = displayCartItems.CurrentCell.ColumnIndex;
            string shipId = displayCartItems.Rows[0].Cells[6].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Stock_Order", con);
            t7_cmd.ExecuteNonQuery();
            SqlCommand cmd4 = new SqlCommand("(SELECT Id FROM Pharmacy WHERE Location = @Location)", con);
            cmd4.Parameters.AddWithValue("@Location", pharmacyID.Text);
            
            SqlCommand cmd = new SqlCommand("Insert into StockOrder([Pharmacy Id],[Order Date],[Shipper Id]) values(@PharId,@OrderDate,@ShipperId)", con);
            cmd.Parameters.AddWithValue("@PharId", int.Parse(cmd4.ExecuteScalar().ToString()));
            cmd.Parameters.AddWithValue("@OrderDate", DateTime.Parse(actualOrderDate.Text));
            cmd.Parameters.AddWithValue("@ShipperId", int.Parse(shipId));
            //cmd.Parameters.AddWithValue("@ShipDate", );
            cmd.ExecuteNonQuery();
            checkLoop = 1;
            if (checkLoop == 1)
            {
                SqlCommand t8_cmd = new SqlCommand("COMMIT TRAN Stock_Order", con);
                t8_cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Order Placed Successfully");
                checkLoop1 = 0;
                SqlCommand t10_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Stock_Details", con);
                t10_cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 Id FROM StockOrder ORDER BY Id DESC ", con);
                cmd2.ExecuteNonQuery();
                for (int i = 0; i < displayCartItems.RowCount - 1; i++)
                {
                    string manufacturer_id = displayCartItems.Rows[i].Cells[0].Value.ToString();
                    string product_id = displayCartItems.Rows[i].Cells[1].Value.ToString();
                    string quantity = displayCartItems.Rows[i].Cells[4].Value.ToString();
                    string unitPrice = displayCartItems.Rows[i].Cells[5].Value.ToString();


                    SqlCommand cmd1 = new SqlCommand("Insert into StockOrderDetails values(@OrderId,@ManuId,@ProId,@Price,@Quantity)", con);
                    cmd1.Parameters.AddWithValue("@OrderId", int.Parse(cmd2.ExecuteScalar().ToString()));
                    cmd1.Parameters.AddWithValue("@ManuId", int.Parse(manufacturer_id));
                    cmd1.Parameters.AddWithValue("@ProId", int.Parse(product_id));

                    cmd1.Parameters.AddWithValue("@Price", int.Parse(unitPrice));
                    cmd1.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                    cmd1.ExecuteNonQuery();
                    checkLoop1 = 1;
                }
                if (checkLoop1 == 1)
                {
                    SqlCommand t11_cmd = new SqlCommand("COMMIT TRAN Stock_Update", con);
                    t11_cmd.ExecuteNonQuery();
                }
                else if (checkLoop1 == 0)
                {
                    SqlCommand t11_cmd = new SqlCommand("ROLLBACK TRAN Stock_Update", con);
                    t11_cmd.ExecuteNonQuery();
                }
            }
            
            this.displayCartItems.Columns.Clear();
            ship_comboBox.Enabled = true;
            manu_comboBox.Enabled = true;


        }

    }
}
