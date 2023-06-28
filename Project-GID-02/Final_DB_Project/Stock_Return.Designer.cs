
namespace Final_DB_Project
{
    partial class Stock_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Return));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerOrdersLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.search_order = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.search_Stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.displayReturnOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.return_all_stock_order = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayReturnOrders)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerOrdersLable
            // 
            this.customerOrdersLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerOrdersLable.AutoSize = true;
            this.customerOrdersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrdersLable.Location = new System.Drawing.Point(318, 12);
            this.customerOrdersLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerOrdersLable.Name = "customerOrdersLable";
            this.customerOrdersLable.Size = new System.Drawing.Size(281, 31);
            this.customerOrdersLable.TabIndex = 2;
            this.customerOrdersLable.Text = "Return Stock Orders";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel2.Controls.Add(this.search_order, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_Stock, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(918, 56);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // search_order
            // 
            this.search_order.AllowAnimations = true;
            this.search_order.AllowMouseEffects = true;
            this.search_order.AllowToggling = false;
            this.search_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_order.AnimationSpeed = 200;
            this.search_order.AutoGenerateColors = false;
            this.search_order.AutoRoundBorders = false;
            this.search_order.AutoSizeLeftIcon = true;
            this.search_order.AutoSizeRightIcon = true;
            this.search_order.BackColor = System.Drawing.Color.Transparent;
            this.search_order.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.search_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_order.BackgroundImage")));
            this.search_order.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_order.ButtonText = "Search";
            this.search_order.ButtonTextMarginLeft = 0;
            this.search_order.ColorContrastOnClick = 45;
            this.search_order.ColorContrastOnHover = 45;
            this.search_order.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.search_order.CustomizableEdges = borderEdges3;
            this.search_order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search_order.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_order.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_order.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_order.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.search_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_order.ForeColor = System.Drawing.Color.White;
            this.search_order.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_order.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.search_order.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.search_order.IconMarginLeft = 11;
            this.search_order.IconPadding = 10;
            this.search_order.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_order.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.search_order.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.search_order.IconSize = 25;
            this.search_order.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.search_order.IdleBorderRadius = 30;
            this.search_order.IdleBorderThickness = 1;
            this.search_order.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.search_order.IdleIconLeftImage = null;
            this.search_order.IdleIconRightImage = null;
            this.search_order.IndicateFocus = false;
            this.search_order.Location = new System.Drawing.Point(701, 8);
            this.search_order.Name = "search_order";
            this.search_order.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_order.OnDisabledState.BorderRadius = 30;
            this.search_order.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_order.OnDisabledState.BorderThickness = 1;
            this.search_order.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_order.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_order.OnDisabledState.IconLeftImage = null;
            this.search_order.OnDisabledState.IconRightImage = null;
            this.search_order.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_order.onHoverState.BorderRadius = 30;
            this.search_order.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_order.onHoverState.BorderThickness = 1;
            this.search_order.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_order.onHoverState.ForeColor = System.Drawing.Color.White;
            this.search_order.onHoverState.IconLeftImage = null;
            this.search_order.onHoverState.IconRightImage = null;
            this.search_order.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.search_order.OnIdleState.BorderRadius = 30;
            this.search_order.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_order.OnIdleState.BorderThickness = 1;
            this.search_order.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.search_order.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.search_order.OnIdleState.IconLeftImage = null;
            this.search_order.OnIdleState.IconRightImage = null;
            this.search_order.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_order.OnPressedState.BorderRadius = 30;
            this.search_order.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_order.OnPressedState.BorderThickness = 1;
            this.search_order.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_order.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.search_order.OnPressedState.IconLeftImage = null;
            this.search_order.OnPressedState.IconRightImage = null;
            this.search_order.Size = new System.Drawing.Size(150, 39);
            this.search_order.TabIndex = 48;
            this.search_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_order.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_order.TextMarginLeft = 0;
            this.search_order.TextPadding = new System.Windows.Forms.Padding(0);
            this.search_order.UseDefaultRadiusAndThickness = true;
            this.search_order.Click += new System.EventHandler(this.search_order_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Order Id:";
            // 
            // search_Stock
            // 
            this.search_Stock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_Stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_Stock.DefaultText = "";
            this.search_Stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_Stock.DisabledState.Parent = this.search_Stock;
            this.search_Stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_Stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_Stock.FocusedState.Parent = this.search_Stock;
            this.search_Stock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_Stock.HoverState.Parent = this.search_Stock;
            this.search_Stock.Location = new System.Drawing.Point(276, 10);
            this.search_Stock.Name = "search_Stock";
            this.search_Stock.PasswordChar = '\0';
            this.search_Stock.PlaceholderText = "";
            this.search_Stock.SelectedText = "";
            this.search_Stock.ShadowDecoration.Parent = this.search_Stock;
            this.search_Stock.Size = new System.Drawing.Size(226, 36);
            this.search_Stock.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.displayReturnOrders, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(918, 289);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // displayReturnOrders
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.displayReturnOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.displayReturnOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayReturnOrders.BackgroundColor = System.Drawing.Color.White;
            this.displayReturnOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayReturnOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayReturnOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayReturnOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.displayReturnOrders.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayReturnOrders.DefaultCellStyle = dataGridViewCellStyle6;
            this.displayReturnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayReturnOrders.EnableHeadersVisualStyles = false;
            this.displayReturnOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayReturnOrders.Location = new System.Drawing.Point(2, 2);
            this.displayReturnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.displayReturnOrders.Name = "displayReturnOrders";
            this.displayReturnOrders.RowHeadersVisible = false;
            this.displayReturnOrders.RowHeadersWidth = 51;
            this.displayReturnOrders.RowTemplate.Height = 24;
            this.displayReturnOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayReturnOrders.Size = new System.Drawing.Size(914, 285);
            this.displayReturnOrders.TabIndex = 1;
            this.displayReturnOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.displayReturnOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.displayReturnOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.displayReturnOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.displayReturnOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.displayReturnOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.displayReturnOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.displayReturnOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayReturnOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.displayReturnOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.displayReturnOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayReturnOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.displayReturnOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.displayReturnOrders.ThemeStyle.HeaderStyle.Height = 4;
            this.displayReturnOrders.ThemeStyle.ReadOnly = false;
            this.displayReturnOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.displayReturnOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.displayReturnOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.displayReturnOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.displayReturnOrders.ThemeStyle.RowsStyle.Height = 24;
            this.displayReturnOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.displayReturnOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.displayReturnOrders.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.displayReturnOrders_CellBeginEdit);
            this.displayReturnOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayReturnOrders_CellClick);
            this.displayReturnOrders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayReturnOrders_CellEndEdit);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.79803F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.20197F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.tableLayoutPanel4.Controls.Add(this.return_all_stock_order, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 401);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(918, 54);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // return_all_stock_order
            // 
            this.return_all_stock_order.AllowAnimations = true;
            this.return_all_stock_order.AllowMouseEffects = true;
            this.return_all_stock_order.AllowToggling = false;
            this.return_all_stock_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.return_all_stock_order.AnimationSpeed = 200;
            this.return_all_stock_order.AutoGenerateColors = false;
            this.return_all_stock_order.AutoRoundBorders = false;
            this.return_all_stock_order.AutoSizeLeftIcon = true;
            this.return_all_stock_order.AutoSizeRightIcon = true;
            this.return_all_stock_order.BackColor = System.Drawing.Color.Transparent;
            this.return_all_stock_order.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.return_all_stock_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("return_all_stock_order.BackgroundImage")));
            this.return_all_stock_order.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.return_all_stock_order.ButtonText = "Return All";
            this.return_all_stock_order.ButtonTextMarginLeft = 0;
            this.return_all_stock_order.ColorContrastOnClick = 45;
            this.return_all_stock_order.ColorContrastOnHover = 45;
            this.return_all_stock_order.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.return_all_stock_order.CustomizableEdges = borderEdges4;
            this.return_all_stock_order.DialogResult = System.Windows.Forms.DialogResult.None;
            this.return_all_stock_order.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.return_all_stock_order.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.return_all_stock_order.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.return_all_stock_order.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.return_all_stock_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.return_all_stock_order.ForeColor = System.Drawing.Color.White;
            this.return_all_stock_order.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.return_all_stock_order.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.return_all_stock_order.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.return_all_stock_order.IconMarginLeft = 11;
            this.return_all_stock_order.IconPadding = 10;
            this.return_all_stock_order.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.return_all_stock_order.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.return_all_stock_order.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.return_all_stock_order.IconSize = 25;
            this.return_all_stock_order.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.return_all_stock_order.IdleBorderRadius = 30;
            this.return_all_stock_order.IdleBorderThickness = 1;
            this.return_all_stock_order.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.return_all_stock_order.IdleIconLeftImage = null;
            this.return_all_stock_order.IdleIconRightImage = null;
            this.return_all_stock_order.IndicateFocus = false;
            this.return_all_stock_order.Location = new System.Drawing.Point(20, 7);
            this.return_all_stock_order.Name = "return_all_stock_order";
            this.return_all_stock_order.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.return_all_stock_order.OnDisabledState.BorderRadius = 30;
            this.return_all_stock_order.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.return_all_stock_order.OnDisabledState.BorderThickness = 1;
            this.return_all_stock_order.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.return_all_stock_order.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.return_all_stock_order.OnDisabledState.IconLeftImage = null;
            this.return_all_stock_order.OnDisabledState.IconRightImage = null;
            this.return_all_stock_order.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.return_all_stock_order.onHoverState.BorderRadius = 30;
            this.return_all_stock_order.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.return_all_stock_order.onHoverState.BorderThickness = 1;
            this.return_all_stock_order.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.return_all_stock_order.onHoverState.ForeColor = System.Drawing.Color.White;
            this.return_all_stock_order.onHoverState.IconLeftImage = null;
            this.return_all_stock_order.onHoverState.IconRightImage = null;
            this.return_all_stock_order.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.return_all_stock_order.OnIdleState.BorderRadius = 30;
            this.return_all_stock_order.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.return_all_stock_order.OnIdleState.BorderThickness = 1;
            this.return_all_stock_order.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.return_all_stock_order.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.return_all_stock_order.OnIdleState.IconLeftImage = null;
            this.return_all_stock_order.OnIdleState.IconRightImage = null;
            this.return_all_stock_order.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.return_all_stock_order.OnPressedState.BorderRadius = 30;
            this.return_all_stock_order.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.return_all_stock_order.OnPressedState.BorderThickness = 1;
            this.return_all_stock_order.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.return_all_stock_order.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.return_all_stock_order.OnPressedState.IconLeftImage = null;
            this.return_all_stock_order.OnPressedState.IconRightImage = null;
            this.return_all_stock_order.Size = new System.Drawing.Size(150, 39);
            this.return_all_stock_order.TabIndex = 49;
            this.return_all_stock_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.return_all_stock_order.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.return_all_stock_order.TextMarginLeft = 0;
            this.return_all_stock_order.TextPadding = new System.Windows.Forms.Padding(0);
            this.return_all_stock_order.UseDefaultRadiusAndThickness = true;
            this.return_all_stock_order.Click += new System.EventHandler(this.return_all_stock_order_Click);
            // 
            // Stock_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 529);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Stock_Return";
            this.Text = "Stock_Return";
            this.Load += new System.EventHandler(this.Stock_Return_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayReturnOrders)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerOrdersLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_Stock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton search_order;
        private Guna.UI2.WinForms.Guna2DataGridView displayReturnOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton return_all_stock_order;
    }
}