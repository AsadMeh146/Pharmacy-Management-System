
namespace Final_DB_Project
{
    partial class Add_Shipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Shipper));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.shipper_title_table = new System.Windows.Forms.TableLayoutPanel();
            this.shipper_title_panel = new System.Windows.Forms.Panel();
            this.shipper_title_label = new System.Windows.Forms.Label();
            this.shipper_info_panel = new System.Windows.Forms.TableLayoutPanel();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.shipperName = new Guna.UI2.WinForms.Guna2TextBox();
            this.shipperContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.shipperAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.shipperCompanyNameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.show_shipper_panel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.displayShippers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.add_shipp_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shipper_title_table.SuspendLayout();
            this.shipper_title_panel.SuspendLayout();
            this.shipper_info_panel.SuspendLayout();
            this.show_shipper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayShippers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipper_title_table
            // 
            this.shipper_title_table.ColumnCount = 2;
            this.shipper_title_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shipper_title_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shipper_title_table.Controls.Add(this.shipper_title_panel, 0, 0);
            this.shipper_title_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipper_title_table.Location = new System.Drawing.Point(0, 0);
            this.shipper_title_table.Name = "shipper_title_table";
            this.shipper_title_table.RowCount = 1;
            this.shipper_title_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shipper_title_table.Size = new System.Drawing.Size(921, 54);
            this.shipper_title_table.TabIndex = 0;
            // 
            // shipper_title_panel
            // 
            this.shipper_title_panel.Controls.Add(this.shipper_title_label);
            this.shipper_title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipper_title_panel.Location = new System.Drawing.Point(3, 3);
            this.shipper_title_panel.Name = "shipper_title_panel";
            this.shipper_title_panel.Size = new System.Drawing.Size(454, 48);
            this.shipper_title_panel.TabIndex = 0;
            // 
            // shipper_title_label
            // 
            this.shipper_title_label.AutoSize = true;
            this.shipper_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipper_title_label.Location = new System.Drawing.Point(20, 7);
            this.shipper_title_label.Name = "shipper_title_label";
            this.shipper_title_label.Size = new System.Drawing.Size(152, 30);
            this.shipper_title_label.TabIndex = 2;
            this.shipper_title_label.Text = "Add Shippers";
            // 
            // shipper_info_panel
            // 
            this.shipper_info_panel.ColumnCount = 4;
            this.shipper_info_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shipper_info_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shipper_info_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shipper_info_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shipper_info_panel.Controls.Add(this.label44, 0, 0);
            this.shipper_info_panel.Controls.Add(this.label46, 2, 0);
            this.shipper_info_panel.Controls.Add(this.label45, 0, 1);
            this.shipper_info_panel.Controls.Add(this.label47, 2, 1);
            this.shipper_info_panel.Controls.Add(this.shipperName, 1, 0);
            this.shipper_info_panel.Controls.Add(this.shipperContactNumber, 1, 1);
            this.shipper_info_panel.Controls.Add(this.shipperAddress, 3, 1);
            this.shipper_info_panel.Controls.Add(this.shipperCompanyNameComboBox, 3, 0);
            this.shipper_info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipper_info_panel.Location = new System.Drawing.Point(0, 54);
            this.shipper_info_panel.Name = "shipper_info_panel";
            this.shipper_info_panel.RowCount = 2;
            this.shipper_info_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shipper_info_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shipper_info_panel.Size = new System.Drawing.Size(921, 114);
            this.shipper_info_panel.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label44.Location = new System.Drawing.Point(2, 18);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(127, 21);
            this.label44.TabIndex = 5;
            this.label44.Text = "Shipper Name :";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label46.Location = new System.Drawing.Point(462, 18);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(141, 21);
            this.label46.TabIndex = 9;
            this.label46.Text = "Company Name :";
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label45.Location = new System.Drawing.Point(2, 75);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(144, 21);
            this.label45.TabIndex = 10;
            this.label45.Text = "Contact Number :";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label47.Location = new System.Drawing.Point(462, 75);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(78, 21);
            this.label47.TabIndex = 11;
            this.label47.Text = "Address :";
            // 
            // shipperName
            // 
            this.shipperName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shipperName.DefaultText = "";
            this.shipperName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shipperName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shipperName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperName.DisabledState.Parent = this.shipperName;
            this.shipperName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperName.FocusedState.Parent = this.shipperName;
            this.shipperName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperName.HoverState.Parent = this.shipperName;
            this.shipperName.Location = new System.Drawing.Point(234, 5);
            this.shipperName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipperName.Name = "shipperName";
            this.shipperName.PasswordChar = '\0';
            this.shipperName.PlaceholderText = "enter shipper name";
            this.shipperName.SelectedText = "";
            this.shipperName.ShadowDecoration.Parent = this.shipperName;
            this.shipperName.Size = new System.Drawing.Size(222, 47);
            this.shipperName.TabIndex = 13;
            // 
            // shipperContactNumber
            // 
            this.shipperContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shipperContactNumber.DefaultText = "";
            this.shipperContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shipperContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shipperContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperContactNumber.DisabledState.Parent = this.shipperContactNumber;
            this.shipperContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperContactNumber.FocusedState.Parent = this.shipperContactNumber;
            this.shipperContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperContactNumber.HoverState.Parent = this.shipperContactNumber;
            this.shipperContactNumber.Location = new System.Drawing.Point(234, 62);
            this.shipperContactNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipperContactNumber.Name = "shipperContactNumber";
            this.shipperContactNumber.PasswordChar = '\0';
            this.shipperContactNumber.PlaceholderText = "enter contact number";
            this.shipperContactNumber.SelectedText = "";
            this.shipperContactNumber.ShadowDecoration.Parent = this.shipperContactNumber;
            this.shipperContactNumber.Size = new System.Drawing.Size(222, 47);
            this.shipperContactNumber.TabIndex = 14;
            // 
            // shipperAddress
            // 
            this.shipperAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shipperAddress.DefaultText = "";
            this.shipperAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.shipperAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.shipperAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperAddress.DisabledState.Parent = this.shipperAddress;
            this.shipperAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.shipperAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperAddress.FocusedState.Parent = this.shipperAddress;
            this.shipperAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shipperAddress.HoverState.Parent = this.shipperAddress;
            this.shipperAddress.Location = new System.Drawing.Point(694, 63);
            this.shipperAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.shipperAddress.Name = "shipperAddress";
            this.shipperAddress.PasswordChar = '\0';
            this.shipperAddress.PlaceholderText = "enter shipper address";
            this.shipperAddress.SelectedText = "";
            this.shipperAddress.ShadowDecoration.Parent = this.shipperAddress;
            this.shipperAddress.Size = new System.Drawing.Size(223, 45);
            this.shipperAddress.TabIndex = 20;
            // 
            // shipperCompanyNameComboBox
            // 
            this.shipperCompanyNameComboBox.BackColor = System.Drawing.Color.Transparent;
            this.shipperCompanyNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipperCompanyNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.shipperCompanyNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipperCompanyNameComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.shipperCompanyNameComboBox.FocusedState.Parent = this.shipperCompanyNameComboBox;
            this.shipperCompanyNameComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shipperCompanyNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.shipperCompanyNameComboBox.FormattingEnabled = true;
            this.shipperCompanyNameComboBox.HoverState.Parent = this.shipperCompanyNameComboBox;
            this.shipperCompanyNameComboBox.ItemHeight = 30;
            this.shipperCompanyNameComboBox.ItemsAppearance.Parent = this.shipperCompanyNameComboBox;
            this.shipperCompanyNameComboBox.Location = new System.Drawing.Point(692, 2);
            this.shipperCompanyNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.shipperCompanyNameComboBox.Name = "shipperCompanyNameComboBox";
            this.shipperCompanyNameComboBox.ShadowDecoration.Parent = this.shipperCompanyNameComboBox;
            this.shipperCompanyNameComboBox.Size = new System.Drawing.Size(227, 36);
            this.shipperCompanyNameComboBox.TabIndex = 21;
            // 
            // show_shipper_panel
            // 
            this.show_shipper_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_shipper_panel.ColumnCount = 1;
            this.show_shipper_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.show_shipper_panel.Controls.Add(this.dataGridView4, 0, 1);
            this.show_shipper_panel.Controls.Add(this.displayShippers, 0, 0);
            this.show_shipper_panel.Location = new System.Drawing.Point(0, 231);
            this.show_shipper_panel.Name = "show_shipper_panel";
            this.show_shipper_panel.RowCount = 2;
            this.show_shipper_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.show_shipper_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.show_shipper_panel.Size = new System.Drawing.Size(917, 288);
            this.show_shipper_panel.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(2, 274);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(913, 12);
            this.dataGridView4.TabIndex = 6;
            // 
            // displayShippers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.displayShippers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.displayShippers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayShippers.BackgroundColor = System.Drawing.Color.Gray;
            this.displayShippers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayShippers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayShippers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayShippers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.displayShippers.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayShippers.DefaultCellStyle = dataGridViewCellStyle3;
            this.displayShippers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayShippers.EnableHeadersVisualStyles = false;
            this.displayShippers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayShippers.Location = new System.Drawing.Point(2, 2);
            this.displayShippers.Margin = new System.Windows.Forms.Padding(2);
            this.displayShippers.Name = "displayShippers";
            this.displayShippers.RowHeadersVisible = false;
            this.displayShippers.RowHeadersWidth = 51;
            this.displayShippers.RowTemplate.Height = 24;
            this.displayShippers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayShippers.Size = new System.Drawing.Size(913, 268);
            this.displayShippers.TabIndex = 7;
            this.displayShippers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.displayShippers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.displayShippers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.displayShippers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.displayShippers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.displayShippers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.displayShippers.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.displayShippers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayShippers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.displayShippers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.displayShippers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayShippers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.displayShippers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.displayShippers.ThemeStyle.HeaderStyle.Height = 4;
            this.displayShippers.ThemeStyle.ReadOnly = false;
            this.displayShippers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.displayShippers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayShippers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayShippers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.displayShippers.ThemeStyle.RowsStyle.Height = 24;
            this.displayShippers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayShippers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // add_shipp_btn
            // 
            this.add_shipp_btn.AllowAnimations = true;
            this.add_shipp_btn.AllowMouseEffects = true;
            this.add_shipp_btn.AllowToggling = false;
            this.add_shipp_btn.AnimationSpeed = 200;
            this.add_shipp_btn.AutoGenerateColors = false;
            this.add_shipp_btn.AutoRoundBorders = false;
            this.add_shipp_btn.AutoSizeLeftIcon = true;
            this.add_shipp_btn.AutoSizeRightIcon = true;
            this.add_shipp_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_shipp_btn.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.add_shipp_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_shipp_btn.BackgroundImage")));
            this.add_shipp_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_shipp_btn.ButtonText = "Add";
            this.add_shipp_btn.ButtonTextMarginLeft = 0;
            this.add_shipp_btn.ColorContrastOnClick = 45;
            this.add_shipp_btn.ColorContrastOnHover = 45;
            this.add_shipp_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.add_shipp_btn.CustomizableEdges = borderEdges1;
            this.add_shipp_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_shipp_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add_shipp_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add_shipp_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add_shipp_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_shipp_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.add_shipp_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_shipp_btn.ForeColor = System.Drawing.Color.White;
            this.add_shipp_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_shipp_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.add_shipp_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.add_shipp_btn.IconMarginLeft = 11;
            this.add_shipp_btn.IconPadding = 10;
            this.add_shipp_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_shipp_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.add_shipp_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.add_shipp_btn.IconSize = 25;
            this.add_shipp_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.add_shipp_btn.IdleBorderRadius = 30;
            this.add_shipp_btn.IdleBorderThickness = 1;
            this.add_shipp_btn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.add_shipp_btn.IdleIconLeftImage = null;
            this.add_shipp_btn.IdleIconRightImage = null;
            this.add_shipp_btn.IndicateFocus = false;
            this.add_shipp_btn.Location = new System.Drawing.Point(3, 3);
            this.add_shipp_btn.Name = "add_shipp_btn";
            this.add_shipp_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.add_shipp_btn.OnDisabledState.BorderRadius = 30;
            this.add_shipp_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_shipp_btn.OnDisabledState.BorderThickness = 1;
            this.add_shipp_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.add_shipp_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.add_shipp_btn.OnDisabledState.IconLeftImage = null;
            this.add_shipp_btn.OnDisabledState.IconRightImage = null;
            this.add_shipp_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add_shipp_btn.onHoverState.BorderRadius = 30;
            this.add_shipp_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_shipp_btn.onHoverState.BorderThickness = 1;
            this.add_shipp_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.add_shipp_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.add_shipp_btn.onHoverState.IconLeftImage = null;
            this.add_shipp_btn.onHoverState.IconRightImage = null;
            this.add_shipp_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.add_shipp_btn.OnIdleState.BorderRadius = 30;
            this.add_shipp_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_shipp_btn.OnIdleState.BorderThickness = 1;
            this.add_shipp_btn.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.add_shipp_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.add_shipp_btn.OnIdleState.IconLeftImage = null;
            this.add_shipp_btn.OnIdleState.IconRightImage = null;
            this.add_shipp_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add_shipp_btn.OnPressedState.BorderRadius = 30;
            this.add_shipp_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.add_shipp_btn.OnPressedState.BorderThickness = 1;
            this.add_shipp_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.add_shipp_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.add_shipp_btn.OnPressedState.IconLeftImage = null;
            this.add_shipp_btn.OnPressedState.IconRightImage = null;
            this.add_shipp_btn.Size = new System.Drawing.Size(910, 51);
            this.add_shipp_btn.TabIndex = 51;
            this.add_shipp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_shipp_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_shipp_btn.TextMarginLeft = 0;
            this.add_shipp_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.add_shipp_btn.UseDefaultRadiusAndThickness = true;
            this.add_shipp_btn.Click += new System.EventHandler(this.add_shipp_btn_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.add_shipp_btn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 171);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 57);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Add_Shipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.show_shipper_panel);
            this.Controls.Add(this.shipper_info_panel);
            this.Controls.Add(this.shipper_title_table);
            this.Name = "Add_Shipper";
            this.Text = "Add_Shipper";
            this.Load += new System.EventHandler(this.Add_Shipper_Load);
            this.shipper_title_table.ResumeLayout(false);
            this.shipper_title_panel.ResumeLayout(false);
            this.shipper_title_panel.PerformLayout();
            this.shipper_info_panel.ResumeLayout(false);
            this.shipper_info_panel.PerformLayout();
            this.show_shipper_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayShippers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel shipper_title_table;
        private System.Windows.Forms.Panel shipper_title_panel;
        private System.Windows.Forms.Label shipper_title_label;
        private System.Windows.Forms.TableLayoutPanel shipper_info_panel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TableLayoutPanel show_shipper_panel;
        private Guna.UI2.WinForms.Guna2TextBox shipperName;
        private Guna.UI2.WinForms.Guna2TextBox shipperContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox shipperAddress;
        private Guna.UI2.WinForms.Guna2ComboBox shipperCompanyNameComboBox;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton add_shipp_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView displayShippers;
    }
}