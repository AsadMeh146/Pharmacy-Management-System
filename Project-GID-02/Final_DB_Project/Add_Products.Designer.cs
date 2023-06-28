
namespace Final_DB_Project
{
    partial class Add_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Products));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.products_title_tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.product_title_panel = new System.Windows.Forms.Panel();
            this.product_title_label = new System.Windows.Forms.Label();
            this.add_products_tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.medicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.medicineTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.medicinePurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.medicineSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.medicineCompanyName = new System.Windows.Forms.Label();
            this.medicineManufacturinfgDate = new System.Windows.Forms.Label();
            this.medicineExpiryDate = new System.Windows.Forms.Label();
            this.medicineDescription = new System.Windows.Forms.Label();
            this.companyNameCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.manufacturingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.expiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.add_medicine_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.show_products_table = new System.Windows.Forms.DataGridView();
            this.products_title_tablePanel.SuspendLayout();
            this.product_title_panel.SuspendLayout();
            this.add_products_tablePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_products_table)).BeginInit();
            this.SuspendLayout();
            // 
            // products_title_tablePanel
            // 
            this.products_title_tablePanel.ColumnCount = 2;
            this.products_title_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.products_title_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.products_title_tablePanel.Controls.Add(this.product_title_panel, 0, 0);
            this.products_title_tablePanel.Location = new System.Drawing.Point(0, 0);
            this.products_title_tablePanel.Name = "products_title_tablePanel";
            this.products_title_tablePanel.RowCount = 1;
            this.products_title_tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.products_title_tablePanel.Size = new System.Drawing.Size(924, 54);
            this.products_title_tablePanel.TabIndex = 0;
            // 
            // product_title_panel
            // 
            this.product_title_panel.Controls.Add(this.product_title_label);
            this.product_title_panel.Location = new System.Drawing.Point(3, 3);
            this.product_title_panel.Name = "product_title_panel";
            this.product_title_panel.Size = new System.Drawing.Size(456, 47);
            this.product_title_panel.TabIndex = 0;
            // 
            // product_title_label
            // 
            this.product_title_label.AutoSize = true;
            this.product_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_title_label.Location = new System.Drawing.Point(22, 9);
            this.product_title_label.Name = "product_title_label";
            this.product_title_label.Size = new System.Drawing.Size(155, 30);
            this.product_title_label.TabIndex = 1;
            this.product_title_label.Text = "Add Products";
            // 
            // add_products_tablePanel
            // 
            this.add_products_tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_products_tablePanel.ColumnCount = 4;
            this.add_products_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.add_products_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.add_products_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.add_products_tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.add_products_tablePanel.Controls.Add(this.label30, 0, 0);
            this.add_products_tablePanel.Controls.Add(this.label31, 0, 1);
            this.add_products_tablePanel.Controls.Add(this.label32, 0, 2);
            this.add_products_tablePanel.Controls.Add(this.label33, 0, 3);
            this.add_products_tablePanel.Controls.Add(this.medicineName, 1, 0);
            this.add_products_tablePanel.Controls.Add(this.medicineTypeComboBox, 1, 1);
            this.add_products_tablePanel.Controls.Add(this.medicinePurchasePrice, 1, 2);
            this.add_products_tablePanel.Controls.Add(this.medicineSalePrice, 1, 3);
            this.add_products_tablePanel.Controls.Add(this.medicineCompanyName, 2, 0);
            this.add_products_tablePanel.Controls.Add(this.medicineManufacturinfgDate, 2, 1);
            this.add_products_tablePanel.Controls.Add(this.medicineExpiryDate, 2, 2);
            this.add_products_tablePanel.Controls.Add(this.medicineDescription, 2, 3);
            this.add_products_tablePanel.Controls.Add(this.companyNameCombobox, 3, 0);
            this.add_products_tablePanel.Controls.Add(this.manufacturingDate, 3, 1);
            this.add_products_tablePanel.Controls.Add(this.expiryDate, 3, 2);
            this.add_products_tablePanel.Controls.Add(this.description, 3, 3);
            this.add_products_tablePanel.Location = new System.Drawing.Point(0, 53);
            this.add_products_tablePanel.Name = "add_products_tablePanel";
            this.add_products_tablePanel.RowCount = 4;
            this.add_products_tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.add_products_tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.add_products_tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.add_products_tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.add_products_tablePanel.Size = new System.Drawing.Size(924, 187);
            this.add_products_tablePanel.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(2, 11);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(139, 21);
            this.label30.TabIndex = 3;
            this.label30.Text = "Medicine Name :";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(2, 54);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(129, 21);
            this.label31.TabIndex = 4;
            this.label31.Text = "Medicine Type :";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(2, 97);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(129, 21);
            this.label32.TabIndex = 5;
            this.label32.Text = "Purchase Price :";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(2, 147);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 21);
            this.label33.TabIndex = 6;
            this.label33.Text = "Sale Price :";
            // 
            // medicineName
            // 
            this.medicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicineName.DefaultText = "";
            this.medicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineName.DisabledState.Parent = this.medicineName;
            this.medicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineName.FocusedState.Parent = this.medicineName;
            this.medicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineName.HoverState.Parent = this.medicineName;
            this.medicineName.Location = new System.Drawing.Point(235, 5);
            this.medicineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medicineName.Name = "medicineName";
            this.medicineName.PasswordChar = '\0';
            this.medicineName.PlaceholderText = "enter medicine name";
            this.medicineName.SelectedText = "";
            this.medicineName.ShadowDecoration.Parent = this.medicineName;
            this.medicineName.Size = new System.Drawing.Size(223, 33);
            this.medicineName.TabIndex = 11;
            // 
            // medicineTypeComboBox
            // 
            this.medicineTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.medicineTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.medicineTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineTypeComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.medicineTypeComboBox.FocusedState.Parent = this.medicineTypeComboBox;
            this.medicineTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.medicineTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.medicineTypeComboBox.FormattingEnabled = true;
            this.medicineTypeComboBox.HoverState.Parent = this.medicineTypeComboBox;
            this.medicineTypeComboBox.ItemHeight = 30;
            this.medicineTypeComboBox.Items.AddRange(new object[] {
            "select medicine type"});
            this.medicineTypeComboBox.ItemsAppearance.Parent = this.medicineTypeComboBox;
            this.medicineTypeComboBox.Location = new System.Drawing.Point(233, 45);
            this.medicineTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.medicineTypeComboBox.Name = "medicineTypeComboBox";
            this.medicineTypeComboBox.ShadowDecoration.Parent = this.medicineTypeComboBox;
            this.medicineTypeComboBox.Size = new System.Drawing.Size(227, 36);
            this.medicineTypeComboBox.TabIndex = 21;
            // 
            // medicinePurchasePrice
            // 
            this.medicinePurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicinePurchasePrice.DefaultText = "";
            this.medicinePurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medicinePurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medicinePurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicinePurchasePrice.DisabledState.Parent = this.medicinePurchasePrice;
            this.medicinePurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicinePurchasePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicinePurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicinePurchasePrice.FocusedState.Parent = this.medicinePurchasePrice;
            this.medicinePurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicinePurchasePrice.HoverState.Parent = this.medicinePurchasePrice;
            this.medicinePurchasePrice.Location = new System.Drawing.Point(235, 91);
            this.medicinePurchasePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medicinePurchasePrice.Name = "medicinePurchasePrice";
            this.medicinePurchasePrice.PasswordChar = '\0';
            this.medicinePurchasePrice.PlaceholderText = "enter purchase price";
            this.medicinePurchasePrice.SelectedText = "";
            this.medicinePurchasePrice.ShadowDecoration.Parent = this.medicinePurchasePrice;
            this.medicinePurchasePrice.Size = new System.Drawing.Size(223, 33);
            this.medicinePurchasePrice.TabIndex = 22;
            // 
            // medicineSalePrice
            // 
            this.medicineSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicineSalePrice.DefaultText = "";
            this.medicineSalePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medicineSalePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medicineSalePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineSalePrice.DisabledState.Parent = this.medicineSalePrice;
            this.medicineSalePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineSalePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineSalePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineSalePrice.FocusedState.Parent = this.medicineSalePrice;
            this.medicineSalePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineSalePrice.HoverState.Parent = this.medicineSalePrice;
            this.medicineSalePrice.Location = new System.Drawing.Point(235, 134);
            this.medicineSalePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medicineSalePrice.Name = "medicineSalePrice";
            this.medicineSalePrice.PasswordChar = '\0';
            this.medicineSalePrice.PlaceholderText = "enter sale price";
            this.medicineSalePrice.SelectedText = "";
            this.medicineSalePrice.ShadowDecoration.Parent = this.medicineSalePrice;
            this.medicineSalePrice.Size = new System.Drawing.Size(223, 48);
            this.medicineSalePrice.TabIndex = 23;
            // 
            // medicineCompanyName
            // 
            this.medicineCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medicineCompanyName.AutoSize = true;
            this.medicineCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicineCompanyName.Location = new System.Drawing.Point(464, 11);
            this.medicineCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicineCompanyName.Name = "medicineCompanyName";
            this.medicineCompanyName.Size = new System.Drawing.Size(141, 21);
            this.medicineCompanyName.TabIndex = 24;
            this.medicineCompanyName.Text = "Company Name :";
            // 
            // medicineManufacturinfgDate
            // 
            this.medicineManufacturinfgDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medicineManufacturinfgDate.AutoSize = true;
            this.medicineManufacturinfgDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicineManufacturinfgDate.Location = new System.Drawing.Point(464, 54);
            this.medicineManufacturinfgDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicineManufacturinfgDate.Name = "medicineManufacturinfgDate";
            this.medicineManufacturinfgDate.Size = new System.Drawing.Size(172, 21);
            this.medicineManufacturinfgDate.TabIndex = 25;
            this.medicineManufacturinfgDate.Text = "Manufacturing Date :";
            // 
            // medicineExpiryDate
            // 
            this.medicineExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medicineExpiryDate.AutoSize = true;
            this.medicineExpiryDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicineExpiryDate.Location = new System.Drawing.Point(464, 97);
            this.medicineExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicineExpiryDate.Name = "medicineExpiryDate";
            this.medicineExpiryDate.Size = new System.Drawing.Size(107, 21);
            this.medicineExpiryDate.TabIndex = 26;
            this.medicineExpiryDate.Text = "Expiry Date :";
            // 
            // medicineDescription
            // 
            this.medicineDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medicineDescription.AutoSize = true;
            this.medicineDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.medicineDescription.Location = new System.Drawing.Point(464, 147);
            this.medicineDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicineDescription.Name = "medicineDescription";
            this.medicineDescription.Size = new System.Drawing.Size(106, 21);
            this.medicineDescription.TabIndex = 27;
            this.medicineDescription.Text = "Description :";
            // 
            // companyNameCombobox
            // 
            this.companyNameCombobox.BackColor = System.Drawing.Color.Transparent;
            this.companyNameCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyNameCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companyNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyNameCombobox.FocusedColor = System.Drawing.Color.Empty;
            this.companyNameCombobox.FocusedState.Parent = this.companyNameCombobox;
            this.companyNameCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companyNameCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.companyNameCombobox.FormattingEnabled = true;
            this.companyNameCombobox.HoverState.Parent = this.companyNameCombobox;
            this.companyNameCombobox.ItemHeight = 30;
            this.companyNameCombobox.Items.AddRange(new object[] {
            "select company name"});
            this.companyNameCombobox.ItemsAppearance.Parent = this.companyNameCombobox;
            this.companyNameCombobox.Location = new System.Drawing.Point(695, 2);
            this.companyNameCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.companyNameCombobox.Name = "companyNameCombobox";
            this.companyNameCombobox.ShadowDecoration.Parent = this.companyNameCombobox;
            this.companyNameCombobox.Size = new System.Drawing.Size(227, 36);
            this.companyNameCombobox.TabIndex = 28;
            // 
            // manufacturingDate
            // 
            this.manufacturingDate.CheckedState.Parent = this.manufacturingDate;
            this.manufacturingDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manufacturingDate.FillColor = System.Drawing.Color.RoyalBlue;
            this.manufacturingDate.ForeColor = System.Drawing.Color.White;
            this.manufacturingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.manufacturingDate.HoverState.Parent = this.manufacturingDate;
            this.manufacturingDate.Location = new System.Drawing.Point(695, 45);
            this.manufacturingDate.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.manufacturingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.manufacturingDate.Name = "manufacturingDate";
            this.manufacturingDate.ShadowDecoration.Parent = this.manufacturingDate;
            this.manufacturingDate.Size = new System.Drawing.Size(227, 39);
            this.manufacturingDate.TabIndex = 29;
            this.manufacturingDate.Value = new System.DateTime(2022, 4, 15, 20, 19, 30, 517);
            // 
            // expiryDate
            // 
            this.expiryDate.CheckedState.Parent = this.expiryDate;
            this.expiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expiryDate.FillColor = System.Drawing.Color.RoyalBlue;
            this.expiryDate.ForeColor = System.Drawing.Color.White;
            this.expiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.expiryDate.HoverState.Parent = this.expiryDate;
            this.expiryDate.Location = new System.Drawing.Point(695, 88);
            this.expiryDate.Margin = new System.Windows.Forms.Padding(2);
            this.expiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.expiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ShadowDecoration.Parent = this.expiryDate;
            this.expiryDate.Size = new System.Drawing.Size(227, 39);
            this.expiryDate.TabIndex = 30;
            this.expiryDate.Value = new System.DateTime(2022, 4, 15, 20, 19, 30, 517);
            // 
            // description
            // 
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Location = new System.Drawing.Point(696, 132);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(225, 52);
            this.description.TabIndex = 31;
            // 
            // add_medicine_btn
            // 
            this.add_medicine_btn.AllowAnimations = true;
            this.add_medicine_btn.AllowMouseEffects = true;
            this.add_medicine_btn.AllowToggling = false;
            this.add_medicine_btn.AnimationSpeed = 200;
            this.add_medicine_btn.AutoGenerateColors = false;
            this.add_medicine_btn.AutoRoundBorders = false;
            this.add_medicine_btn.AutoSizeLeftIcon = true;
            this.add_medicine_btn.AutoSizeRightIcon = true;
            this.add_medicine_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_medicine_btn.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.add_medicine_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_medicine_btn.BackgroundImage")));
            this.add_medicine_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_medicine_btn.ButtonText = "Add";
            this.add_medicine_btn.ButtonTextMarginLeft = 0;
            this.add_medicine_btn.ColorContrastOnClick = 45;
            this.add_medicine_btn.ColorContrastOnHover = 45;
            this.add_medicine_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.add_medicine_btn.CustomizableEdges = borderEdges1;
            this.add_medicine_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_medicine_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add_medicine_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add_medicine_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add_medicine_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_medicine_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.add_medicine_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_medicine_btn.ForeColor = System.Drawing.Color.White;
            this.add_medicine_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_medicine_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.add_medicine_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.add_medicine_btn.IconMarginLeft = 11;
            this.add_medicine_btn.IconPadding = 10;
            this.add_medicine_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_medicine_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.add_medicine_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.add_medicine_btn.IconSize = 25;
            this.add_medicine_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine_btn.IdleBorderRadius = 30;
            this.add_medicine_btn.IdleBorderThickness = 1;
            this.add_medicine_btn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.add_medicine_btn.IdleIconLeftImage = null;
            this.add_medicine_btn.IdleIconRightImage = null;
            this.add_medicine_btn.IndicateFocus = false;
            this.add_medicine_btn.Location = new System.Drawing.Point(3, 3);
            this.add_medicine_btn.Name = "add_medicine_btn";
            this.add_medicine_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add_medicine_btn.OnDisabledState.BorderRadius = 30;
            this.add_medicine_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_medicine_btn.OnDisabledState.BorderThickness = 1;
            this.add_medicine_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add_medicine_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add_medicine_btn.OnDisabledState.IconLeftImage = null;
            this.add_medicine_btn.OnDisabledState.IconRightImage = null;
            this.add_medicine_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add_medicine_btn.onHoverState.BorderRadius = 30;
            this.add_medicine_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_medicine_btn.onHoverState.BorderThickness = 1;
            this.add_medicine_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add_medicine_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.add_medicine_btn.onHoverState.IconLeftImage = null;
            this.add_medicine_btn.onHoverState.IconRightImage = null;
            this.add_medicine_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine_btn.OnIdleState.BorderRadius = 30;
            this.add_medicine_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_medicine_btn.OnIdleState.BorderThickness = 1;
            this.add_medicine_btn.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.add_medicine_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.add_medicine_btn.OnIdleState.IconLeftImage = null;
            this.add_medicine_btn.OnIdleState.IconRightImage = null;
            this.add_medicine_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add_medicine_btn.OnPressedState.BorderRadius = 30;
            this.add_medicine_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_medicine_btn.OnPressedState.BorderThickness = 1;
            this.add_medicine_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add_medicine_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.add_medicine_btn.OnPressedState.IconLeftImage = null;
            this.add_medicine_btn.OnPressedState.IconRightImage = null;
            this.add_medicine_btn.Size = new System.Drawing.Size(909, 46);
            this.add_medicine_btn.TabIndex = 48;
            this.add_medicine_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_medicine_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_medicine_btn.TextMarginLeft = 0;
            this.add_medicine_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.add_medicine_btn.UseDefaultRadiusAndThickness = true;
            this.add_medicine_btn.Click += new System.EventHandler(this.add_medicine_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.add_medicine_btn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 242);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 52);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // show_products_table
            // 
            this.show_products_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_products_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_products_table.BackgroundColor = System.Drawing.Color.White;
            this.show_products_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_products_table.Location = new System.Drawing.Point(6, 297);
            this.show_products_table.Margin = new System.Windows.Forms.Padding(2);
            this.show_products_table.Name = "show_products_table";
            this.show_products_table.RowHeadersWidth = 51;
            this.show_products_table.RowTemplate.Height = 24;
            this.show_products_table.Size = new System.Drawing.Size(909, 214);
            this.show_products_table.TabIndex = 4;
            // 
            // Add_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 520);
            this.Controls.Add(this.show_products_table);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.add_products_tablePanel);
            this.Controls.Add(this.products_title_tablePanel);
            this.Name = "Add_Products";
            this.Text = "Add_Products";
            this.Load += new System.EventHandler(this.Add_Products_Load);
            this.products_title_tablePanel.ResumeLayout(false);
            this.product_title_panel.ResumeLayout(false);
            this.product_title_panel.PerformLayout();
            this.add_products_tablePanel.ResumeLayout(false);
            this.add_products_tablePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_products_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel products_title_tablePanel;
        private System.Windows.Forms.Panel product_title_panel;
        private System.Windows.Forms.Label product_title_label;
        private System.Windows.Forms.TableLayoutPanel add_products_tablePanel;
        private Guna.UI2.WinForms.Guna2ComboBox medicineTypeComboBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private Guna.UI2.WinForms.Guna2TextBox medicineName;
        private Guna.UI2.WinForms.Guna2TextBox medicinePurchasePrice;
        private Guna.UI2.WinForms.Guna2TextBox medicineSalePrice;
        private System.Windows.Forms.Label medicineCompanyName;
        private System.Windows.Forms.Label medicineManufacturinfgDate;
        private System.Windows.Forms.Label medicineExpiryDate;
        private System.Windows.Forms.Label medicineDescription;
        private Guna.UI2.WinForms.Guna2ComboBox companyNameCombobox;
        private Guna.UI2.WinForms.Guna2DateTimePicker manufacturingDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker expiryDate;
        private System.Windows.Forms.TextBox description;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton add_medicine_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView show_products_table;
    }
}