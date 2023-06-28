
namespace Final_DB_Project
{
    partial class Stock_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerOrdersLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orderDetails = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.branchLocation = new System.Windows.Forms.Label();
            this.empmoyeeName = new System.Windows.Forms.Label();
            this.actualOrderDate = new System.Windows.Forms.Label();
            this.pharmacyID = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.add_To_Cart = new Guna.UI2.WinForms.Guna2Button();
            this.manu_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pro_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ship_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.product_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.unit_Price = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.displayCartItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Manufacturer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipperId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_Bill = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCartItems)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.customerOrdersLable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerOrdersLable
            // 
            this.customerOrdersLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerOrdersLable.AutoSize = true;
            this.customerOrdersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrdersLable.Location = new System.Drawing.Point(337, 8);
            this.customerOrdersLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerOrdersLable.Name = "customerOrdersLable";
            this.customerOrdersLable.Size = new System.Drawing.Size(185, 31);
            this.customerOrdersLable.TabIndex = 1;
            this.customerOrdersLable.Text = "Stock Orders";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 408);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 402);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.63779F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.36221F));
            this.tableLayoutPanel3.Controls.Add(this.orderDetails, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.orderDate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.branchLocation, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.empmoyeeName, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.actualOrderDate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pharmacyID, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.productName, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.quantity, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.unitPrice, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.add_To_Cart, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.manu_comboBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.pro_comboBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.ship_comboBox, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.product_Quantity, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.unit_Price, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.47525F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(423, 402);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // orderDetails
            // 
            this.orderDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDetails.AutoSize = true;
            this.orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetails.Location = new System.Drawing.Point(24, 5);
            this.orderDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(153, 26);
            this.orderDetails.TabIndex = 1;
            this.orderDetails.Text = "Order Details";
            // 
            // orderDate
            // 
            this.orderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderDate.AutoSize = true;
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(2, 47);
            this.orderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(98, 20);
            this.orderDate.TabIndex = 7;
            this.orderDate.Text = "Order Date";
            // 
            // branchLocation
            // 
            this.branchLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.branchLocation.AutoSize = true;
            this.branchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLocation.Location = new System.Drawing.Point(2, 88);
            this.branchLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branchLocation.Name = "branchLocation";
            this.branchLocation.Size = new System.Drawing.Size(140, 20);
            this.branchLocation.TabIndex = 8;
            this.branchLocation.Text = "Branch Location";
            // 
            // empmoyeeName
            // 
            this.empmoyeeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empmoyeeName.AutoSize = true;
            this.empmoyeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empmoyeeName.Location = new System.Drawing.Point(2, 134);
            this.empmoyeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empmoyeeName.Name = "empmoyeeName";
            this.empmoyeeName.Size = new System.Drawing.Size(167, 20);
            this.empmoyeeName.TabIndex = 9;
            this.empmoyeeName.Text = "Manufacturer Name";
            // 
            // actualOrderDate
            // 
            this.actualOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualOrderDate.AutoSize = true;
            this.actualOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualOrderDate.Location = new System.Drawing.Point(288, 47);
            this.actualOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualOrderDate.Name = "actualOrderDate";
            this.actualOrderDate.Size = new System.Drawing.Size(47, 20);
            this.actualOrderDate.TabIndex = 11;
            this.actualOrderDate.Text = "lable";
            // 
            // pharmacyID
            // 
            this.pharmacyID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pharmacyID.AutoSize = true;
            this.pharmacyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacyID.Location = new System.Drawing.Point(288, 88);
            this.pharmacyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pharmacyID.Name = "pharmacyID";
            this.pharmacyID.Size = new System.Drawing.Size(47, 20);
            this.pharmacyID.TabIndex = 12;
            this.pharmacyID.Text = "lable";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(2, 181);
            this.productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(122, 20);
            this.productName.TabIndex = 16;
            this.productName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Shipper Name";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(2, 272);
            this.quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(76, 20);
            this.quantity.TabIndex = 19;
            this.quantity.Text = "Quantity";
            // 
            // unitPrice
            // 
            this.unitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unitPrice.AutoSize = true;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(2, 318);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(87, 20);
            this.unitPrice.TabIndex = 20;
            this.unitPrice.Text = "Unit Price";
            // 
            // add_To_Cart
            // 
            this.add_To_Cart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_To_Cart.BorderRadius = 25;
            this.add_To_Cart.CheckedState.Parent = this.add_To_Cart;
            this.add_To_Cart.CustomImages.Parent = this.add_To_Cart;
            this.add_To_Cart.FillColor = System.Drawing.Color.LightSteelBlue;
            this.add_To_Cart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_To_Cart.ForeColor = System.Drawing.Color.White;
            this.add_To_Cart.HoverState.Parent = this.add_To_Cart;
            this.add_To_Cart.Location = new System.Drawing.Point(203, 357);
            this.add_To_Cart.Margin = new System.Windows.Forms.Padding(2);
            this.add_To_Cart.Name = "add_To_Cart";
            this.add_To_Cart.ShadowDecoration.Parent = this.add_To_Cart;
            this.add_To_Cart.Size = new System.Drawing.Size(218, 39);
            this.add_To_Cart.TabIndex = 21;
            this.add_To_Cart.Text = "Add To Cart";
            this.add_To_Cart.Click += new System.EventHandler(this.add_To_Cart_Click);
            // 
            // manu_comboBox
            // 
            this.manu_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manu_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.manu_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.manu_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manu_comboBox.FocusedColor = System.Drawing.Color.Empty;
            this.manu_comboBox.FocusedState.Parent = this.manu_comboBox;
            this.manu_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.manu_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.manu_comboBox.FormattingEnabled = true;
            this.manu_comboBox.HoverState.Parent = this.manu_comboBox;
            this.manu_comboBox.ItemHeight = 30;
            this.manu_comboBox.ItemsAppearance.Parent = this.manu_comboBox;
            this.manu_comboBox.Location = new System.Drawing.Point(204, 126);
            this.manu_comboBox.Name = "manu_comboBox";
            this.manu_comboBox.ShadowDecoration.Parent = this.manu_comboBox;
            this.manu_comboBox.Size = new System.Drawing.Size(200, 36);
            this.manu_comboBox.TabIndex = 22;
            this.manu_comboBox.SelectedIndexChanged += new System.EventHandler(this.manu_comboBox_SelectedIndexChanged_1);
            // 
            // pro_comboBox
            // 
            this.pro_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pro_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.pro_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pro_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pro_comboBox.FocusedColor = System.Drawing.Color.Empty;
            this.pro_comboBox.FocusedState.Parent = this.pro_comboBox;
            this.pro_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pro_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pro_comboBox.FormattingEnabled = true;
            this.pro_comboBox.HoverState.Parent = this.pro_comboBox;
            this.pro_comboBox.ItemHeight = 30;
            this.pro_comboBox.ItemsAppearance.Parent = this.pro_comboBox;
            this.pro_comboBox.Location = new System.Drawing.Point(204, 173);
            this.pro_comboBox.Name = "pro_comboBox";
            this.pro_comboBox.ShadowDecoration.Parent = this.pro_comboBox;
            this.pro_comboBox.Size = new System.Drawing.Size(200, 36);
            this.pro_comboBox.TabIndex = 23;
            this.pro_comboBox.SelectedIndexChanged += new System.EventHandler(this.pro_comboBox_SelectedIndexChanged);
            // 
            // ship_comboBox
            // 
            this.ship_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ship_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.ship_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ship_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ship_comboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ship_comboBox.FocusedState.Parent = this.ship_comboBox;
            this.ship_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ship_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ship_comboBox.FormattingEnabled = true;
            this.ship_comboBox.HoverState.Parent = this.ship_comboBox;
            this.ship_comboBox.ItemHeight = 30;
            this.ship_comboBox.ItemsAppearance.Parent = this.ship_comboBox;
            this.ship_comboBox.Location = new System.Drawing.Point(204, 218);
            this.ship_comboBox.Name = "ship_comboBox";
            this.ship_comboBox.ShadowDecoration.Parent = this.ship_comboBox;
            this.ship_comboBox.Size = new System.Drawing.Size(200, 36);
            this.ship_comboBox.TabIndex = 24;
            // 
            // product_Quantity
            // 
            this.product_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.product_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product_Quantity.DefaultText = "";
            this.product_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.product_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.product_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.product_Quantity.DisabledState.Parent = this.product_Quantity;
            this.product_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.product_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.product_Quantity.FocusedState.Parent = this.product_Quantity;
            this.product_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.product_Quantity.HoverState.Parent = this.product_Quantity;
            this.product_Quantity.Location = new System.Drawing.Point(204, 264);
            this.product_Quantity.Name = "product_Quantity";
            this.product_Quantity.PasswordChar = '\0';
            this.product_Quantity.PlaceholderText = "";
            this.product_Quantity.SelectedText = "";
            this.product_Quantity.ShadowDecoration.Parent = this.product_Quantity;
            this.product_Quantity.Size = new System.Drawing.Size(200, 36);
            this.product_Quantity.TabIndex = 25;
            // 
            // unit_Price
            // 
            this.unit_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_Price.AutoSize = true;
            this.unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_Price.Location = new System.Drawing.Point(288, 318);
            this.unit_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unit_Price.Name = "unit_Price";
            this.unit_Price.Size = new System.Drawing.Size(47, 20);
            this.unit_Price.TabIndex = 26;
            this.unit_Price.Text = "lable";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.displayCartItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(432, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 402);
            this.panel2.TabIndex = 1;
            // 
            // displayCartItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.displayCartItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.displayCartItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayCartItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.displayCartItems.BackgroundColor = System.Drawing.Color.DimGray;
            this.displayCartItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayCartItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayCartItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayCartItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.displayCartItems.ColumnHeadersHeight = 4;
            this.displayCartItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manufacturer_Id,
            this.productId,
            this.manufacturerName,
            this.Product_Name,
            this.product_quan,
            this.product_price,
            this.shipperId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayCartItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.displayCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayCartItems.EnableHeadersVisualStyles = false;
            this.displayCartItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayCartItems.Location = new System.Drawing.Point(0, 0);
            this.displayCartItems.Margin = new System.Windows.Forms.Padding(2);
            this.displayCartItems.Name = "displayCartItems";
            this.displayCartItems.RowHeadersVisible = false;
            this.displayCartItems.RowHeadersWidth = 51;
            this.displayCartItems.RowTemplate.Height = 24;
            this.displayCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayCartItems.Size = new System.Drawing.Size(424, 402);
            this.displayCartItems.TabIndex = 1;
            this.displayCartItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.displayCartItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.displayCartItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.displayCartItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.displayCartItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.displayCartItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.displayCartItems.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.displayCartItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayCartItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.displayCartItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.displayCartItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayCartItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.displayCartItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.displayCartItems.ThemeStyle.HeaderStyle.Height = 4;
            this.displayCartItems.ThemeStyle.ReadOnly = false;
            this.displayCartItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.displayCartItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayCartItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayCartItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.displayCartItems.ThemeStyle.RowsStyle.Height = 24;
            this.displayCartItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayCartItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.displayCartItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayCartItems_CellClick);
            // 
            // Manufacturer_Id
            // 
            this.Manufacturer_Id.HeaderText = "Manufacturer Id";
            this.Manufacturer_Id.MinimumWidth = 6;
            this.Manufacturer_Id.Name = "Manufacturer_Id";
            // 
            // productId
            // 
            this.productId.HeaderText = "Product Id";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            // 
            // manufacturerName
            // 
            this.manufacturerName.HeaderText = "Manufacturer Name";
            this.manufacturerName.MinimumWidth = 6;
            this.manufacturerName.Name = "manufacturerName";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            // 
            // product_quan
            // 
            this.product_quan.HeaderText = "Quantity";
            this.product_quan.MinimumWidth = 6;
            this.product_quan.Name = "product_quan";
            // 
            // product_price
            // 
            this.product_price.HeaderText = "Unit Price";
            this.product_price.Name = "product_price";
            // 
            // shipperId
            // 
            this.shipperId.HeaderText = "Shipper Id";
            this.shipperId.Name = "shipperId";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21637F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78363F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel4.Controls.Add(this.guna2Button1, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.stock_Bill, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 455);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.58333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.41667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(859, 96);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(644, 47);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(210, 39);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Confirm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(415, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Bill :";
            // 
            // stock_Bill
            // 
            this.stock_Bill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stock_Bill.AutoSize = true;
            this.stock_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.stock_Bill.Location = new System.Drawing.Point(645, 8);
            this.stock_Bill.Name = "stock_Bill";
            this.stock_Bill.Size = new System.Drawing.Size(169, 20);
            this.stock_Bill.TabIndex = 24;
            this.stock_Bill.Text = "________________";
            // 
            // Stock_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 551);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(2, 2);
            this.Name = "Stock_Order";
            this.Text = "Stock_Order";
            this.Load += new System.EventHandler(this.Stock_Order_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayCartItems)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerOrdersLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label orderDetails;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label branchLocation;
        private System.Windows.Forms.Label empmoyeeName;
        private System.Windows.Forms.Label actualOrderDate;
        private System.Windows.Forms.Label pharmacyID;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label unitPrice;
        private Guna.UI2.WinForms.Guna2Button add_To_Cart;
        private Guna.UI2.WinForms.Guna2ComboBox manu_comboBox;
        private Guna.UI2.WinForms.Guna2ComboBox pro_comboBox;
        private Guna.UI2.WinForms.Guna2ComboBox ship_comboBox;
        private Guna.UI2.WinForms.Guna2TextBox product_Quantity;
        private System.Windows.Forms.Label unit_Price;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView displayCartItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stock_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipperId;
    }
}