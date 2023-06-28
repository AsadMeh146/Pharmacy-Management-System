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
    public partial class CustomerOrder : Form
    {
        public List<Label> labels;
        public static Form2 f2 = new Form2();
        List<string> productIds = new List<string>();
        int idx = 0;
        string selectedProduct;
        string manufacturer;
        string SalePrice;
        string tempID;
        string tempSalePrice;
        string tempIdx;
        string tempQuantity;
        string tempQuantity1;
        int flag1 = 0;
        int totalBill=0;
        int tempQuantity2=0;
        int tempSalePrice2=0;
        SqlCommand cmd22;
        SqlCommand cmd23;
        SqlCommand cmd27;
        SqlCommand cmd28;
        SqlCommand cmd30;
        int stockQuantity = 0;
        float tempDiscount = 0;




        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            btn1.Name = "update";
            btn1.Text = "Update";
            btn1.UseColumnTextForButtonValue = true;
            displayCartItems.Columns.Add(btn1);


            btn2.Name = "discart";
            btn2.Text = "Discart";
            btn2.UseColumnTextForButtonValue = true;
            displayCartItems.Columns.Add(btn2);
        }

        public void addingLableinDataGrigView()
        {
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlCommand cmd1;
        private void addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE begin tran addCustomerOrder  ", con);
                cmd2.ExecuteNonQuery();


        

              
                                        if (customerName3001.Text != "")
                                        {
                                            if (contactNumber3001.Text != "")
                                            {
                                                SqlCommand cmd6 = new SqlCommand(" select Name  from lookup   where Category = 'ORDER TYPE' ", con);
                                                cmd6.ExecuteNonQuery();

                                                cmd30 = new SqlCommand("select Name from Lookup  where Category = 'Discount' ", con);
                                                //cmd30.Parameters.AddWithValue("@Id", cmd1.ExecuteScalar().ToString());
                                                cmd30.ExecuteNonQuery();

                                                cmd1 = new SqlCommand(" select [Pharmacy Id]  from EmployeeDetails   where Name = @userName and Pin = @password ", con);
                                                cmd1.Parameters.AddWithValue("@userName", Form2.return_UserName());
                                                 cmd1.Parameters.AddWithValue("@password",  Form2.return_Password() );
                                                cmd1.ExecuteNonQuery();

                                                SqlCommand cmd7 = new SqlCommand(" select Location from Pharmacy where Id = @Id ", con);
                                                cmd7.Parameters.AddWithValue("@Id", cmd1.ExecuteScalar().ToString());
                                                cmd7.ExecuteNonQuery();


                                                 SqlCommand cmd = new SqlCommand(" insert into CustomerDetails (Name , ContactNumber) values(@firstName , @lastName    ) ", con);
                                                cmd.Parameters.AddWithValue("@firstName", customerName3001.Text);
                                                cmd.Parameters.AddWithValue("@lastName", contactNumber3001.Text);
                                                cmd.ExecuteNonQuery();


                                                SqlCommand cmd8 = new SqlCommand(" select [RegistrationNumber] from EmployeeDetails where [Pharmacy Id] = @Id ", con);
                                                cmd8.Parameters.AddWithValue("@Id", cmd1.ExecuteScalar().ToString());
                                                cmd8.ExecuteNonQuery();

                                                SqlCommand cmd9 = new SqlCommand(" select [Product Id] from Stock  ", con);
                                                SqlDataReader SDR = cmd9.ExecuteReader();
                                                //productComboBox.Items.Clear();
                                                while (SDR.Read())
                                                {
                                                    tempID = SDR["Product Id"].ToString();
                                                    productIds.Add(tempID);

                            
                                                }
                                                SDR.Close();

                                                for (int i = 0; i < productIds.Count; i++)
                                                {
                                                    SqlCommand cmd11 = new SqlCommand("select Name from ProductDetails where Id =  @Id ", con);
                                                    cmd11.Parameters.AddWithValue("@Id", productIds[i]);

                                                    SqlDataReader DR2 = cmd11.ExecuteReader();
                                                    while (DR2.Read())
                                                    {
                                                        productComboBox.Items.Add(DR2[0]);
                                                    }
                                                    DR2.Close();
                                                    cmd9.ExecuteNonQuery();
                                                }
              

                                                



                                                actualCustomerName.Text = customerName3001.Text;
                                                actualOrderDate.Text = DateTime.Now.ToString();
                                                pharmacyID.Text = cmd7.ExecuteScalar().ToString();
                                                orderType30000012.Text = "OnPharmacy";
                                                 discount30000012.Text = cmd30.ExecuteScalar().ToString() + "    " + " % ";
                                                //loading_Data_Into_Combobox_Through_SQL_Command_Object(orderType3001 , cmd6 );
                                                //loading_Data_Into_Combobox_Through_SQL_Command_Object(employeeNameCombobox , cmd8);
                                                //loading_Data_Into_Combobox_Through_SQL_Command_Object(productComboBox, cmd9);



                        MessageBox.Show("Customer Added Successfully ");

                                            }
                                            else
                                            {
                                                MessageBox.Show("Please fill contact number in correct format.......");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please fill customer name in correct format.......");
                                        }



            }
            catch
            {
                MessageBox.Show("Please fill all the above fields in correct format");
            }
        }

        public void loadingDataIntoCombobox(ComboBox companyNameCombobox , string query)
        {
            var con = Configuration.getInstance().getConnection();
            companyNameCombobox.Items.Clear();
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader DR2 = cmd1.ExecuteReader();
            while (DR2.Read())
            {
                companyNameCombobox.Items.Add(DR2[0]);
            }
            DR2.Close();

        }

        public void loading_Data_Into_Combobox_Through_SQL_Command_Object(ComboBox companyNameCombobox, SqlCommand cmd)
        {
            companyNameCombobox.Items.Clear();
            SqlDataReader DR2 = cmd.ExecuteReader();
            while (DR2.Read())
            {
                companyNameCombobox.Items.Add(DR2[0]);
            }
            DR2.Close();
        }

        private void productComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd31 = new SqlCommand(" select Name from ProductDetails where Name = @search ", con);
            //cmd31.Parameters.AddWithValue("@search", productComboBox.Text);
            //cmd31.ExecuteNonQuery();
            //loading_Data_Into_Combobox_Through_SQL_Command_Object(productComboBox, cmd31);
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {

        }
        SqlCommand cmd11;
        private void productComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            selectedProduct = productComboBox.GetItemText(productComboBox.SelectedItem);
            SqlCommand cmd10 = new SqlCommand(" select Id from ProductDetails where Name = @product ", con);
            cmd10.Parameters.AddWithValue("@product", selectedProduct);
            cmd10.ExecuteNonQuery();



            cmd11 = new SqlCommand(" select [ManufacturerId] from ProductDetails where Id = @productId ", con);
            cmd11.Parameters.AddWithValue("@productId", cmd10.ExecuteScalar().ToString());
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = new SqlCommand(" select Name from ManufacturerDetails where Id = @manufacturerID ", con);
            cmd12.Parameters.AddWithValue("@manufacturerID", cmd11.ExecuteScalar().ToString());
            cmd12.ExecuteNonQuery();

            manufacturer = cmd12.ExecuteScalar().ToString();
            manufacturerLable.Text = cmd12.ExecuteScalar().ToString();

            SqlCommand cmd13 = new SqlCommand(" select [Sale Price] from ProductDetails where Name = @product ", con);
            cmd13.Parameters.AddWithValue("@product", selectedProduct);
            cmd13.ExecuteNonQuery();
            SalePrice = cmd13.ExecuteScalar().ToString();

            //loading_Data_Into_Combobox_Through_SQL_Command_Object(companyNameCombobox3001 , cmd12);
            salePrice.Text = cmd13.ExecuteScalar().ToString();



        }
        int rows = 0;
        int columns = 0;
        DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();

        private void add_To_Cart_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

           

            SqlCommand cmd13 = new SqlCommand(" select Id from ProductDetails where Name = @selectedProduct ", con);
            cmd13.Parameters.AddWithValue("@selectedProduct", selectedProduct);
            cmd13.ExecuteNonQuery();

            tempIdx = cmd13.ExecuteScalar().ToString();

            SqlCommand cmd14 = new SqlCommand(" select [Quantity] from Stock where [Product Id] = @tempIdx ", con);
            cmd14.Parameters.AddWithValue("@tempIdx", tempIdx);
            cmd14.ExecuteNonQuery();

            tempQuantity = cmd14.ExecuteScalar().ToString();

            if(int.Parse(quantity_Of_Product.Text) <= int.Parse(tempQuantity))
            {
                //SqlCommand cmd15 = new SqlCommand(" UPDATE Stock SET Quantity = @quantity_Of_Product     where [Product Id] =  @tempIdx  ", con);
                //cmd15.Parameters.AddWithValue("@quantity_Of_Product", (    (int.Parse(tempQuantity) - int.Parse(quantity_Of_Product.Text)     ).ToString()) );
                //cmd15.Parameters.AddWithValue("@tempIdx", tempIdx);
                //cmd15.ExecuteNonQuery();
                //MessageBox.Show("Successfully updated");


                displayCartItems.Columns["Product_Name"].ReadOnly = true;
                displayCartItems.Columns["Company_Name"].ReadOnly = true;
                displayCartItems.Columns["unitPrices"].ReadOnly = true;
                //displayCartItems.Columns["Discounts"].ReadOnly = true;


                for (int i = 0; i < displayCartItems.RowCount-1; i++)
                {


                    if (displayCartItems.Rows[i].Cells[0].Value.ToString()  == selectedProduct && displayCartItems.Rows[i].Cells[1].Value.ToString() == manufacturerLable.Text)
                    {
                        
                        displayCartItems.Rows[i].Cells[2].Value = (int.Parse(displayCartItems.Rows[i].Cells[2].Value.ToString()) + int.Parse(quantity_Of_Product.Text)).ToString();

                        flag1 = 1;
                        break;
                    }

                }

                if ( flag1 == 0)
                {


                    displayCartItems.Rows.Add();
                    displayCartItems.Rows[rows].Cells[0].Value = selectedProduct;
                    displayCartItems.Rows[rows].Cells[1].Value = manufacturer;
                    displayCartItems.Rows[rows].Cells[2].Value = quantity_Of_Product.Text;
                    displayCartItems.Rows[rows].Cells[3].Value = SalePrice;
                    //displayCartItems.Rows[rows].Cells[4].Value = discount30001.Text;
                    rows = rows + 1;
                    totalBill = totalBill + int.Parse(quantity_Of_Product.Text) * int.Parse(salePrice.Text);
                    //totalAmount.Text = totalBill.ToString();


                    tempDiscount = float.Parse(cmd30.ExecuteScalar().ToString());
                    discountAmount.Text = ((tempDiscount / 100) * totalBill).ToString();
                    totalAmount.Text = (float.Parse(totalBill.ToString()) - float.Parse(discountAmount.Text)).ToString();
                    flag1 = 0;


                }
                if (flag1 == 1)
                {
                    MessageBox.Show("quantity is updated.........");
                    totalBill = totalBill + int.Parse(quantity_Of_Product.Text) * int.Parse(salePrice.Text);
                    //totalAmount.Text = totalBill.ToString();
                    tempDiscount = float.Parse(cmd30.ExecuteScalar().ToString());
                    discountAmount.Text = ((tempDiscount / 100) * totalBill).ToString();
                    totalAmount.Text = (float.Parse(totalBill.ToString()) - float.Parse(discountAmount.Text)).ToString();

                    flag1 = 0;
                }

                
            }
            else
            {
                MessageBox.Show("You can sell maximun  " + tempQuantity + "  products"   );
            }






            


            


        }

        private void displayCartItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.ColumnIndex == displayCartItems.Columns["update"].Index && e.RowIndex >= 0)
            {
                if (this.displayCartItems.SelectedRows.Count > 0)
                {
                 

                    if (int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString()) <= int.Parse(tempQuantity)) 
                    {
                        totalBill = totalBill - (tempSalePrice2 * tempQuantity2);
                        tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                        tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                        totalBill = (totalBill + (tempQuantity2 * tempSalePrice2));

                        tempDiscount = float.Parse(cmd30.ExecuteScalar().ToString());
                        discountAmount.Text = ((tempDiscount / 100) * totalBill).ToString();
                        totalAmount.Text = (float.Parse(totalBill.ToString()) - float.Parse(discountAmount.Text)).ToString();


                        displayCartItems.Rows[rows].Cells[2].Value = displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2];
                        MessageBox.Show("Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("You can sell maximun  " + tempQuantity + "  products");
                        displayCartItems.Rows[rows-1].Cells[2].Value = tempQuantity1;

                    }

                }
            }

            if (e.ColumnIndex == displayCartItems.Columns["discart"].Index && e.RowIndex >= 0)
            {
                if (this.displayCartItems.SelectedRows.Count > 0)
                {
                    tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                    tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[3].FormattedValue.ToString());
                    totalBill = (totalBill - (tempQuantity2 * tempSalePrice2));

                    tempDiscount = float.Parse(cmd30.ExecuteScalar().ToString());
                    discountAmount.Text = ((tempDiscount / 100) * totalBill).ToString();
                    totalAmount.Text = (float.Parse(totalBill.ToString()) - float.Parse(discountAmount.Text)).ToString();


                    displayCartItems.Rows.RemoveAt(this.displayCartItems.SelectedRows[0].Index);
                    rows = rows - 1;
                }
            }

            if (e.ColumnIndex == displayCartItems.Columns["Quantity_of_Products"].Index && e.RowIndex >= 0)
            {
                tempQuantity1 = displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString();
                tempQuantity2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[2].FormattedValue.ToString());
                tempSalePrice2 = int.Parse(displayCartItems.Rows[displayCartItems.CurrentRow.Index].Cells[3].FormattedValue.ToString());
            }
        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            //try
            //{
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand(" set transaction isolation level SERIALIZABLE  begin tran addOrder  ", con);
                cmd2.ExecuteNonQuery();

            SqlCommand cmd20 = new SqlCommand(" select Id from ProductDetails where Name = @productComboBox ", con);
            cmd20.Parameters.AddWithValue("@productComboBox", productComboBox.Text);
            cmd20.ExecuteNonQuery();

            SqlCommand cmd19 = new SqlCommand(" select Id from Lookup where Name = @orderType3001 ", con);
            cmd19.Parameters.AddWithValue("@orderType3001", orderType30000012.Text);
            cmd19.ExecuteNonQuery();

            SqlCommand cmd18 = new SqlCommand(" select Id from CustomerDetails where Name = @actualCustomerName ", con);
            cmd18.Parameters.AddWithValue("@actualCustomerName", actualCustomerName.Text);
            cmd18.ExecuteNonQuery();

            if (actualCustomerName.Text != "")
                {
                    if (actualOrderDate.Text != "")
                    {
                        if (pharmacyID.Text != "")
                        {
                            if (orderType30000012.Text != "")
                            {
                                //if (employeeNameCombobox.Text != "")
                                //{
                                    if (productComboBox.Text != "")
                                    {
                                        if (manufacturerLable.Text != "")
                                        {
                                            if (quantity_Of_Product.Text != "")
                                            {
                                                if (salePrice.Text != "")
                                                {
                                                    if ( discount30000012.Text != "" )
                                                    {
                                                        SqlCommand cmd = new SqlCommand(" insert into CustomerOrder values(@firstName , @lastName , @contact , @email  , @discount ) ", con);
                                                        cmd.Parameters.AddWithValue("@firstName", cmd18.ExecuteScalar().ToString());
                                                        cmd.Parameters.AddWithValue("@lastName", actualOrderDate.Text);
                                                        cmd.Parameters.AddWithValue("@contact", cmd1.ExecuteScalar().ToString() );
                                                        cmd.Parameters.AddWithValue("@email", cmd19.ExecuteScalar().ToString());
                                                        cmd.Parameters.AddWithValue("@discount", float.Parse( cmd30.ExecuteScalar().ToString()  ));

                                                //cmd.Parameters.AddWithValue("@description", employeeNameCombobox.Text);
                                                cmd.ExecuteNonQuery();
                                                        //SqlCommand cmd3 = new SqlCommand(" commit tran addOrder  ", con);
                                                        //cmd3.ExecuteNonQuery();
                                                        MessageBox.Show("Company Added Successfully ");

                                                    SqlCommand cmd21 = new SqlCommand(" SELECT TOP 1 OrderId FROM CustomerOrder ORDER BY OrderId DESC ", con);
                                                    cmd21.ExecuteNonQuery();

                                                        
                                                    for (int i = 0; i < displayCartItems.RowCount-1 ; i++)
                                                    {

                                                        cmd22 = new SqlCommand(" select [Id] from ManufacturerDetails where Name = @name ", con);
                                                        cmd22.Parameters.AddWithValue("@name", displayCartItems.Rows[i].Cells[1].Value.ToString());
                                                        cmd22.ExecuteNonQuery( );

                                                        cmd23 = new SqlCommand(" select [Id] from ProductDetails where Name = @name ", con);
                                                        cmd23.Parameters.AddWithValue("@name", displayCartItems.Rows[i].Cells[0].Value.ToString());
                                                        cmd23.ExecuteNonQuery();

                                                        SqlCommand cmd16 = new SqlCommand(" insert into [CustomerOrderDetails] values(@orderID,@firstName , @lastName , @contact , @email  ) ", con);
                                                        cmd16.Parameters.AddWithValue("@orderID", cmd21.ExecuteScalar().ToString());
                                                        cmd16.Parameters.AddWithValue("@firstName",cmd22.ExecuteScalar().ToString() );
                                                        cmd16.Parameters.AddWithValue("@lastName", cmd23.ExecuteScalar().ToString() );
                                                        cmd16.Parameters.AddWithValue("@contact", int.Parse(displayCartItems.Rows[i].Cells[2].Value.ToString()));
                                                        cmd16.Parameters.AddWithValue("@email", int.Parse(displayCartItems.Rows[i].Cells[3].Value.ToString()));
                                                        //cmd16.Parameters.AddWithValue("@description", int.Parse(displayCartItems.Rows[i].Cells[4].Value.ToString()));
                                                        cmd16.ExecuteNonQuery();

                                                            

                                                            //SqlCommand cmd27 = new SqlCommand(" UPDATE Stock SET [Quantity] = @studentID     where [Pharmacy Id] =  @ and [Product Id] = @ and [Manufacturer ID] = @ ", con);
                                                            cmd27 = new SqlCommand(" select [Quantity]  from Stock    where [Pharmacy Id] =  @pharmacyID and [Product Id] = @productID and [Manufacturer ID] = @manufacturingID ", con);
                                                            cmd27.Parameters.AddWithValue("@pharmacyID", cmd1.ExecuteScalar().ToString()     );
                                                            cmd27.Parameters.AddWithValue("@productID", cmd23.ExecuteScalar().ToString()    );
                                                            cmd27.Parameters.AddWithValue("@manufacturingID", cmd22.ExecuteScalar().ToString()   );
                                                            cmd27.ExecuteNonQuery();

                                                        //MessageBox.Show(cmd1.ExecuteScalar().ToString()+"   , "+ cmd23.ExecuteScalar().ToString()+"     ,      "+ cmd22.ExecuteScalar().ToString());

                                                            stockQuantity = int.Parse( cmd27.ExecuteScalar().ToString() ) - int.Parse(displayCartItems.Rows[i].Cells[2].Value.ToString());


                                                            //SqlCommand cmd27 = new SqlCommand(" UPDATE Stock SET [Quantity] = @studentID     where [Pharmacy Id] =  @ and [Product Id] = @ and [Manufacturer ID] = @ ", con);
                                                            cmd28 = new SqlCommand(" UPDATE Stock SET [Quantity] = @stockQuantity    where [Pharmacy Id] =  @pharmacyID and [Product Id] = @productID and [Manufacturer ID] = @manufacturingID   ", con);
                                                            cmd28.Parameters.AddWithValue("@pharmacyID", cmd1.ExecuteScalar().ToString());
                                                            cmd28.Parameters.AddWithValue("@productID", cmd23.ExecuteScalar().ToString());
                                                            cmd28.Parameters.AddWithValue("@manufacturingID", cmd22.ExecuteScalar().ToString());
                                                            cmd28.Parameters.AddWithValue("@stockQuantity", stockQuantity.ToString());

                                                        cmd28.ExecuteNonQuery();








                                                        }
                                                        MessageBox.Show("Order Added  Successfully ");

                                                    SqlCommand cmd3 = new SqlCommand(" commit tran addCustomerOrder  ", con);
                                                    cmd3.ExecuteNonQuery();
                                                    SqlCommand cmd17 = new SqlCommand(" commit tran addOrder  ", con);
                                                    cmd17.ExecuteNonQuery();

                                                    

                                                }
                                                    else
                                                    {
                                                        MessageBox.Show("Please enter discount  in correct format.........");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please enter sale price  in correct format.........");

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter quantity of products  in correct format.........");

                                            }



                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter company name  in correct format.........");

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter product name  in correct format.........");

                                    }
                                //}
                                //else
                                //{
                                //                MessageBox.Show("Please enter employee name  in correct format.........");

                                //}

                            }
                            else
                            {
                                MessageBox.Show("Please enter order type  in correct format.........");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter pharmacy name  in correct format.........");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter order date  in correct format.........");

                    }
                }
                else
                {
                    MessageBox.Show("Please customer name in correct format.......");
                }


        //}
        //    catch
        //    {
        //        MessageBox.Show("Sorry for inconvinience.........");
        //    }

}
    }
}
