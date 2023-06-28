
namespace Final_DB_Project
{
    partial class CustomerOrder
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
            this.newOrder = new System.Windows.Forms.Label();
            this.customerOrdersLable = new System.Windows.Forms.Label();
            this.dispalyCustomerAttribute = new System.Windows.Forms.TableLayoutPanel();
            this.contactNumber3001 = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.customerName3001 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.cartTable = new System.Windows.Forms.TableLayoutPanel();
            this.displayCartItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_of_Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmOrder = new Guna.UI2.WinForms.Guna2Button();
            this.grandTotal = new System.Windows.Forms.Label();
            this.discountLable3001 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.discountAmount = new System.Windows.Forms.Label();
            this.shadowGridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.addOrder = new System.Windows.Forms.TableLayoutPanel();
            this.add_To_Cart = new Guna.UI2.WinForms.Guna2Button();
            this.orderHeader = new System.Windows.Forms.TableLayoutPanel();
            this.orderDetails = new System.Windows.Forms.Label();
            this.ordegrid = new System.Windows.Forms.TableLayoutPanel();
            this.customerName30002 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.branchLocation = new System.Windows.Forms.Label();
            this.orderType = new System.Windows.Forms.Label();
            this.actualCustomerName = new System.Windows.Forms.Label();
            this.actualOrderDate = new System.Windows.Forms.Label();
            this.pharmacyID = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerLable = new System.Windows.Forms.Label();
            this.quantity_Of_Product = new System.Windows.Forms.TextBox();
            this.salePrice = new System.Windows.Forms.Label();
            this.orderType30000012 = new System.Windows.Forms.Label();
            this.discount30000012 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.dispalyCustomerAttribute.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cartTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCartItems)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.shadowGridPanel.SuspendLayout();
            this.orderShadowPanel.SuspendLayout();
            this.addOrder.SuspendLayout();
            this.orderHeader.SuspendLayout();
            this.ordegrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.newOrder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerOrdersLable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newOrder
            // 
            this.newOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newOrder.AutoSize = true;
            this.newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.Location = new System.Drawing.Point(2, 38);
            this.newOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(171, 26);
            this.newOrder.TabIndex = 1;
            this.newOrder.Text = "Add new Order";
            // 
            // customerOrdersLable
            // 
            this.customerOrdersLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerOrdersLable.AutoSize = true;
            this.customerOrdersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrdersLable.Location = new System.Drawing.Point(403, 1);
            this.customerOrdersLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerOrdersLable.Name = "customerOrdersLable";
            this.customerOrdersLable.Size = new System.Drawing.Size(237, 31);
            this.customerOrdersLable.TabIndex = 0;
            this.customerOrdersLable.Text = "Customer Orders";
            // 
            // dispalyCustomerAttribute
            // 
            this.dispalyCustomerAttribute.ColumnCount = 2;
            this.dispalyCustomerAttribute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dispalyCustomerAttribute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dispalyCustomerAttribute.Controls.Add(this.contactNumber3001, 1, 1);
            this.dispalyCustomerAttribute.Controls.Add(this.customerName, 0, 0);
            this.dispalyCustomerAttribute.Controls.Add(this.contactNumber, 0, 1);
            this.dispalyCustomerAttribute.Controls.Add(this.customerName3001, 1, 0);
            this.dispalyCustomerAttribute.Location = new System.Drawing.Point(2, 73);
            this.dispalyCustomerAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.dispalyCustomerAttribute.Name = "dispalyCustomerAttribute";
            this.dispalyCustomerAttribute.RowCount = 2;
            this.dispalyCustomerAttribute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dispalyCustomerAttribute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dispalyCustomerAttribute.Size = new System.Drawing.Size(523, 102);
            this.dispalyCustomerAttribute.TabIndex = 1;
            // 
            // contactNumber3001
            // 
            this.contactNumber3001.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNumber3001.DefaultText = "";
            this.contactNumber3001.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactNumber3001.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactNumber3001.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumber3001.DisabledState.Parent = this.contactNumber3001;
            this.contactNumber3001.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumber3001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumber3001.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumber3001.FocusedState.Parent = this.contactNumber3001;
            this.contactNumber3001.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumber3001.HoverState.Parent = this.contactNumber3001;
            this.contactNumber3001.Location = new System.Drawing.Point(264, 54);
            this.contactNumber3001.Name = "contactNumber3001";
            this.contactNumber3001.PasswordChar = '\0';
            this.contactNumber3001.PlaceholderText = "enter contact number";
            this.contactNumber3001.SelectedText = "";
            this.contactNumber3001.ShadowDecoration.Parent = this.contactNumber3001;
            this.contactNumber3001.Size = new System.Drawing.Size(256, 45);
            this.contactNumber3001.TabIndex = 5;
            this.contactNumber3001.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // customerName
            // 
            this.customerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(2, 15);
            this.customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(147, 20);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "Customer Name :";
            // 
            // contactNumber
            // 
            this.contactNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.Location = new System.Drawing.Point(2, 66);
            this.contactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(139, 20);
            this.contactNumber.TabIndex = 3;
            this.contactNumber.Text = "Contact Number";
            // 
            // customerName3001
            // 
            this.customerName3001.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName3001.DefaultText = "";
            this.customerName3001.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerName3001.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerName3001.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName3001.DisabledState.Parent = this.customerName3001;
            this.customerName3001.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName3001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerName3001.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName3001.FocusedState.Parent = this.customerName3001;
            this.customerName3001.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName3001.HoverState.Parent = this.customerName3001;
            this.customerName3001.Location = new System.Drawing.Point(264, 3);
            this.customerName3001.Name = "customerName3001";
            this.customerName3001.PasswordChar = '\0';
            this.customerName3001.PlaceholderText = "enter customer name";
            this.customerName3001.SelectedText = "";
            this.customerName3001.ShadowDecoration.Parent = this.customerName3001;
            this.customerName3001.Size = new System.Drawing.Size(256, 45);
            this.customerName3001.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.addCustomer, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 178);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 53);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // addCustomer
            // 
            this.addCustomer.BorderRadius = 25;
            this.addCustomer.CheckedState.Parent = this.addCustomer;
            this.addCustomer.CustomImages.Parent = this.addCustomer;
            this.addCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCustomer.FillColor = System.Drawing.Color.CornflowerBlue;
            this.addCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addCustomer.ForeColor = System.Drawing.Color.White;
            this.addCustomer.HoverState.Parent = this.addCustomer;
            this.addCustomer.Location = new System.Drawing.Point(2, 2);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.ShadowDecoration.Parent = this.addCustomer;
            this.addCustomer.Size = new System.Drawing.Size(516, 49);
            this.addCustomer.TabIndex = 0;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // cartTable
            // 
            this.cartTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cartTable.ColumnCount = 1;
            this.cartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartTable.Controls.Add(this.displayCartItems, 0, 0);
            this.cartTable.Location = new System.Drawing.Point(529, 76);
            this.cartTable.Margin = new System.Windows.Forms.Padding(2);
            this.cartTable.Name = "cartTable";
            this.cartTable.RowCount = 1;
            this.cartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartTable.Size = new System.Drawing.Size(517, 443);
            this.cartTable.TabIndex = 4;
            // 
            // displayCartItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.displayCartItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.displayCartItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Product_Name,
            this.Company_Name,
            this.Quantity_of_Products,
            this.unitPrices});
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
            this.displayCartItems.Location = new System.Drawing.Point(2, 2);
            this.displayCartItems.Margin = new System.Windows.Forms.Padding(2);
            this.displayCartItems.Name = "displayCartItems";
            this.displayCartItems.RowHeadersVisible = false;
            this.displayCartItems.RowHeadersWidth = 51;
            this.displayCartItems.RowTemplate.Height = 24;
            this.displayCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayCartItems.Size = new System.Drawing.Size(513, 439);
            this.displayCartItems.TabIndex = 0;
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
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            // 
            // Company_Name
            // 
            this.Company_Name.HeaderText = "Company Name";
            this.Company_Name.MinimumWidth = 6;
            this.Company_Name.Name = "Company_Name";
            // 
            // Quantity_of_Products
            // 
            this.Quantity_of_Products.HeaderText = "Quantity";
            this.Quantity_of_Products.MinimumWidth = 6;
            this.Quantity_of_Products.Name = "Quantity_of_Products";
            // 
            // unitPrices
            // 
            this.unitPrices.HeaderText = "Unit Price";
            this.unitPrices.MinimumWidth = 6;
            this.unitPrices.Name = "unitPrices";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.confirmOrder, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.grandTotal, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.discountLable3001, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.totalAmount, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.discountAmount, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(531, 524);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(514, 103);
            this.tableLayoutPanel3.TabIndex = 5;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // confirmOrder
            // 
            this.confirmOrder.BorderRadius = 20;
            this.confirmOrder.CheckedState.Parent = this.confirmOrder;
            this.confirmOrder.CustomImages.Parent = this.confirmOrder;
            this.confirmOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmOrder.FillColor = System.Drawing.Color.RoyalBlue;
            this.confirmOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmOrder.ForeColor = System.Drawing.Color.White;
            this.confirmOrder.HoverState.Parent = this.confirmOrder;
            this.confirmOrder.Location = new System.Drawing.Point(206, 53);
            this.confirmOrder.Margin = new System.Windows.Forms.Padding(2);
            this.confirmOrder.Name = "confirmOrder";
            this.confirmOrder.ShadowDecoration.Parent = this.confirmOrder;
            this.confirmOrder.Size = new System.Drawing.Size(306, 48);
            this.confirmOrder.TabIndex = 7;
            this.confirmOrder.Text = "Confirm Order";
            this.confirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // grandTotal
            // 
            this.grandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grandTotal.AutoSize = true;
            this.grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotal.Location = new System.Drawing.Point(2, 57);
            this.grandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(64, 40);
            this.grandTotal.TabIndex = 5;
            this.grandTotal.Text = "Grand Total";
            // 
            // discountLable3001
            // 
            this.discountLable3001.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.discountLable3001.AutoSize = true;
            this.discountLable3001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLable3001.Location = new System.Drawing.Point(2, 5);
            this.discountLable3001.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discountLable3001.Name = "discountLable3001";
            this.discountLable3001.Size = new System.Drawing.Size(80, 40);
            this.discountLable3001.TabIndex = 8;
            this.discountLable3001.Text = "Total Discount";
            // 
            // totalAmount
            // 
            this.totalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(104, 67);
            this.totalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(19, 20);
            this.totalAmount.TabIndex = 6;
            this.totalAmount.Text = "0";
            // 
            // discountAmount
            // 
            this.discountAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.discountAmount.AutoSize = true;
            this.discountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAmount.Location = new System.Drawing.Point(104, 15);
            this.discountAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.Size = new System.Drawing.Size(19, 20);
            this.discountAmount.TabIndex = 9;
            this.discountAmount.Text = "0";
            // 
            // shadowGridPanel
            // 
            this.shadowGridPanel.ColumnCount = 1;
            this.shadowGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shadowGridPanel.Controls.Add(this.orderShadowPanel, 0, 0);
            this.shadowGridPanel.Location = new System.Drawing.Point(9, 233);
            this.shadowGridPanel.Margin = new System.Windows.Forms.Padding(2);
            this.shadowGridPanel.Name = "shadowGridPanel";
            this.shadowGridPanel.RowCount = 1;
            this.shadowGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shadowGridPanel.Size = new System.Drawing.Size(513, 455);
            this.shadowGridPanel.TabIndex = 6;
            // 
            // orderShadowPanel
            // 
            this.orderShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.orderShadowPanel.Controls.Add(this.addOrder);
            this.orderShadowPanel.Controls.Add(this.orderHeader);
            this.orderShadowPanel.Controls.Add(this.ordegrid);
            this.orderShadowPanel.FillColor = System.Drawing.Color.White;
            this.orderShadowPanel.Location = new System.Drawing.Point(2, 2);
            this.orderShadowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.orderShadowPanel.Name = "orderShadowPanel";
            this.orderShadowPanel.ShadowColor = System.Drawing.Color.SteelBlue;
            this.orderShadowPanel.ShadowShift = 15;
            this.orderShadowPanel.Size = new System.Drawing.Size(508, 450);
            this.orderShadowPanel.TabIndex = 12;
            // 
            // addOrder
            // 
            this.addOrder.ColumnCount = 1;
            this.addOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addOrder.Controls.Add(this.add_To_Cart, 0, 0);
            this.addOrder.Location = new System.Drawing.Point(34, 390);
            this.addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.addOrder.Name = "addOrder";
            this.addOrder.RowCount = 1;
            this.addOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addOrder.Size = new System.Drawing.Size(443, 43);
            this.addOrder.TabIndex = 2;
            // 
            // add_To_Cart
            // 
            this.add_To_Cart.BorderRadius = 25;
            this.add_To_Cart.CheckedState.Parent = this.add_To_Cart;
            this.add_To_Cart.CustomImages.Parent = this.add_To_Cart;
            this.add_To_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_To_Cart.FillColor = System.Drawing.Color.LightSteelBlue;
            this.add_To_Cart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_To_Cart.ForeColor = System.Drawing.Color.White;
            this.add_To_Cart.HoverState.Parent = this.add_To_Cart;
            this.add_To_Cart.Location = new System.Drawing.Point(2, 2);
            this.add_To_Cart.Margin = new System.Windows.Forms.Padding(2);
            this.add_To_Cart.Name = "add_To_Cart";
            this.add_To_Cart.ShadowDecoration.Parent = this.add_To_Cart;
            this.add_To_Cart.Size = new System.Drawing.Size(439, 39);
            this.add_To_Cart.TabIndex = 1;
            this.add_To_Cart.Text = "Add To Cart";
            this.add_To_Cart.Click += new System.EventHandler(this.add_To_Cart_Click);
            // 
            // orderHeader
            // 
            this.orderHeader.ColumnCount = 1;
            this.orderHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderHeader.Controls.Add(this.orderDetails, 0, 0);
            this.orderHeader.Location = new System.Drawing.Point(34, 15);
            this.orderHeader.Margin = new System.Windows.Forms.Padding(2);
            this.orderHeader.Name = "orderHeader";
            this.orderHeader.RowCount = 1;
            this.orderHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderHeader.Size = new System.Drawing.Size(443, 68);
            this.orderHeader.TabIndex = 1;
            // 
            // orderDetails
            // 
            this.orderDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDetails.AutoSize = true;
            this.orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetails.Location = new System.Drawing.Point(145, 21);
            this.orderDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(153, 26);
            this.orderDetails.TabIndex = 0;
            this.orderDetails.Text = "Order Details";
            // 
            // ordegrid
            // 
            this.ordegrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordegrid.ColumnCount = 2;
            this.ordegrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordegrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordegrid.Controls.Add(this.customerName30002, 0, 0);
            this.ordegrid.Controls.Add(this.orderDate, 0, 1);
            this.ordegrid.Controls.Add(this.branchLocation, 0, 2);
            this.ordegrid.Controls.Add(this.orderType, 0, 3);
            this.ordegrid.Controls.Add(this.actualCustomerName, 1, 0);
            this.ordegrid.Controls.Add(this.actualOrderDate, 1, 1);
            this.ordegrid.Controls.Add(this.pharmacyID, 1, 2);
            this.ordegrid.Controls.Add(this.productName, 0, 4);
            this.ordegrid.Controls.Add(this.companyName, 0, 5);
            this.ordegrid.Controls.Add(this.quantity, 0, 6);
            this.ordegrid.Controls.Add(this.unitPrice, 0, 7);
            this.ordegrid.Controls.Add(this.discount, 0, 8);
            this.ordegrid.Controls.Add(this.productComboBox, 1, 4);
            this.ordegrid.Controls.Add(this.manufacturerLable, 1, 5);
            this.ordegrid.Controls.Add(this.quantity_Of_Product, 1, 6);
            this.ordegrid.Controls.Add(this.salePrice, 1, 7);
            this.ordegrid.Controls.Add(this.orderType30000012, 1, 3);
            this.ordegrid.Controls.Add(this.discount30000012, 1, 8);
            this.ordegrid.Location = new System.Drawing.Point(34, 89);
            this.ordegrid.Margin = new System.Windows.Forms.Padding(2);
            this.ordegrid.Name = "ordegrid";
            this.ordegrid.RowCount = 9;
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.ordegrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.ordegrid.Size = new System.Drawing.Size(443, 297);
            this.ordegrid.TabIndex = 0;
            // 
            // customerName30002
            // 
            this.customerName30002.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerName30002.AutoSize = true;
            this.customerName30002.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName30002.Location = new System.Drawing.Point(2, 6);
            this.customerName30002.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerName30002.Name = "customerName30002";
            this.customerName30002.Size = new System.Drawing.Size(137, 20);
            this.customerName30002.TabIndex = 4;
            this.customerName30002.Text = "Customer Name";
            // 
            // orderDate
            // 
            this.orderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderDate.AutoSize = true;
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(2, 38);
            this.orderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(98, 20);
            this.orderDate.TabIndex = 6;
            this.orderDate.Text = "Order Date";
            // 
            // branchLocation
            // 
            this.branchLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.branchLocation.AutoSize = true;
            this.branchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLocation.Location = new System.Drawing.Point(2, 70);
            this.branchLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.branchLocation.Name = "branchLocation";
            this.branchLocation.Size = new System.Drawing.Size(140, 20);
            this.branchLocation.TabIndex = 7;
            this.branchLocation.Text = "Branch Location";
            // 
            // orderType
            // 
            this.orderType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderType.AutoSize = true;
            this.orderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderType.Location = new System.Drawing.Point(2, 102);
            this.orderType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderType.Name = "orderType";
            this.orderType.Size = new System.Drawing.Size(97, 20);
            this.orderType.TabIndex = 5;
            this.orderType.Text = "Order Type";
            // 
            // actualCustomerName
            // 
            this.actualCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualCustomerName.AutoSize = true;
            this.actualCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualCustomerName.Location = new System.Drawing.Point(308, 6);
            this.actualCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualCustomerName.Name = "actualCustomerName";
            this.actualCustomerName.Size = new System.Drawing.Size(47, 20);
            this.actualCustomerName.TabIndex = 9;
            this.actualCustomerName.Text = "lable";
            // 
            // actualOrderDate
            // 
            this.actualOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualOrderDate.AutoSize = true;
            this.actualOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualOrderDate.Location = new System.Drawing.Point(308, 38);
            this.actualOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualOrderDate.Name = "actualOrderDate";
            this.actualOrderDate.Size = new System.Drawing.Size(47, 20);
            this.actualOrderDate.TabIndex = 10;
            this.actualOrderDate.Text = "lable";
            // 
            // pharmacyID
            // 
            this.pharmacyID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pharmacyID.AutoSize = true;
            this.pharmacyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacyID.Location = new System.Drawing.Point(308, 70);
            this.pharmacyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pharmacyID.Name = "pharmacyID";
            this.pharmacyID.Size = new System.Drawing.Size(47, 20);
            this.pharmacyID.TabIndex = 11;
            this.pharmacyID.Text = "lable";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(2, 134);
            this.productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(122, 20);
            this.productName.TabIndex = 15;
            this.productName.Text = "Product Name";
            // 
            // companyName
            // 
            this.companyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(2, 166);
            this.companyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(134, 20);
            this.companyName.TabIndex = 14;
            this.companyName.Text = "Company Name";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(2, 198);
            this.quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(76, 20);
            this.quantity.TabIndex = 18;
            this.quantity.Text = "Quantity";
            // 
            // unitPrice
            // 
            this.unitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unitPrice.AutoSize = true;
            this.unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(2, 230);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(87, 20);
            this.unitPrice.TabIndex = 16;
            this.unitPrice.Text = "Unit Price";
            // 
            // discount
            // 
            this.discount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(2, 266);
            this.discount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(80, 20);
            this.discount.TabIndex = 18;
            this.discount.Text = "Discount";
            // 
            // productComboBox
            // 
            this.productComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(223, 130);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(218, 21);
            this.productComboBox.TabIndex = 34;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            this.productComboBox.SelectionChangeCommitted += new System.EventHandler(this.productComboBox_SelectionChangeCommitted);
            this.productComboBox.SelectedValueChanged += new System.EventHandler(this.productComboBox_SelectedValueChanged);
            this.productComboBox.TextChanged += new System.EventHandler(this.productComboBox_TextChanged);
            // 
            // manufacturerLable
            // 
            this.manufacturerLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturerLable.AutoSize = true;
            this.manufacturerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLable.Location = new System.Drawing.Point(303, 166);
            this.manufacturerLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLable.Name = "manufacturerLable";
            this.manufacturerLable.Size = new System.Drawing.Size(57, 20);
            this.manufacturerLable.TabIndex = 35;
            this.manufacturerLable.Text = "label1";
            // 
            // quantity_Of_Product
            // 
            this.quantity_Of_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity_Of_Product.Location = new System.Drawing.Point(223, 194);
            this.quantity_Of_Product.Margin = new System.Windows.Forms.Padding(2);
            this.quantity_Of_Product.Name = "quantity_Of_Product";
            this.quantity_Of_Product.Size = new System.Drawing.Size(218, 20);
            this.quantity_Of_Product.TabIndex = 32;
            // 
            // salePrice
            // 
            this.salePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salePrice.AutoSize = true;
            this.salePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePrice.Location = new System.Drawing.Point(308, 230);
            this.salePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salePrice.Name = "salePrice";
            this.salePrice.Size = new System.Drawing.Size(47, 20);
            this.salePrice.TabIndex = 23;
            this.salePrice.Text = "lable";
            // 
            // orderType30000012
            // 
            this.orderType30000012.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderType30000012.AutoSize = true;
            this.orderType30000012.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderType30000012.Location = new System.Drawing.Point(303, 102);
            this.orderType30000012.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderType30000012.Name = "orderType30000012";
            this.orderType30000012.Size = new System.Drawing.Size(57, 20);
            this.orderType30000012.TabIndex = 36;
            this.orderType30000012.Text = "label1";
            // 
            // discount30000012
            // 
            this.discount30000012.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discount30000012.AutoSize = true;
            this.discount30000012.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount30000012.Location = new System.Drawing.Point(303, 266);
            this.discount30000012.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discount30000012.Name = "discount30000012";
            this.discount30000012.Size = new System.Drawing.Size(57, 20);
            this.discount30000012.TabIndex = 37;
            this.discount30000012.Text = "label1";
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.shadowGridPanel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.cartTable);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dispalyCustomerAttribute);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerOrder";
            this.Text = "CustomerOrder";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.dispalyCustomerAttribute.ResumeLayout(false);
            this.dispalyCustomerAttribute.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.cartTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayCartItems)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.shadowGridPanel.ResumeLayout(false);
            this.orderShadowPanel.ResumeLayout(false);
            this.addOrder.ResumeLayout(false);
            this.orderHeader.ResumeLayout(false);
            this.orderHeader.PerformLayout();
            this.ordegrid.ResumeLayout(false);
            this.ordegrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label newOrder;
        private System.Windows.Forms.Label customerOrdersLable;
        private System.Windows.Forms.TableLayoutPanel dispalyCustomerAttribute;
        private Guna.UI2.WinForms.Guna2TextBox contactNumber3001;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label contactNumber;
        private Guna.UI2.WinForms.Guna2TextBox customerName3001;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button addCustomer;
        private System.Windows.Forms.TableLayoutPanel cartTable;
        private Guna.UI2.WinForms.Guna2DataGridView displayCartItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label grandTotal;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.TableLayoutPanel shadowGridPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel orderShadowPanel;
        private System.Windows.Forms.TableLayoutPanel addOrder;
        private Guna.UI2.WinForms.Guna2Button add_To_Cart;
        private System.Windows.Forms.TableLayoutPanel orderHeader;
        private System.Windows.Forms.Label orderDetails;
        private System.Windows.Forms.TableLayoutPanel ordegrid;
        private System.Windows.Forms.TextBox quantity_Of_Product;
        private System.Windows.Forms.Label salePrice;
        private System.Windows.Forms.Label customerName30002;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label branchLocation;
        private System.Windows.Forms.Label orderType;
        private System.Windows.Forms.Label actualCustomerName;
        private System.Windows.Forms.Label actualOrderDate;
        private System.Windows.Forms.Label pharmacyID;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label discount;
        private Guna.UI2.WinForms.Guna2Button confirmOrder;
        private System.Windows.Forms.Label manufacturerLable;
        private System.Windows.Forms.Label orderType30000012;
        private System.Windows.Forms.Label discount30000012;
        private System.Windows.Forms.Label discountLable3001;
        private System.Windows.Forms.Label discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_of_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrices;
    }
}