
namespace Final_DB_Project
{
    partial class Loan_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan_Request));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loan_request_title_table = new System.Windows.Forms.TableLayoutPanel();
            this.loan_request_title_panel = new System.Windows.Forms.Panel();
            this.loan_request_title_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_loan_requestName = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchBar20003 = new Guna.UI2.WinForms.Guna2TextBox();
            this.loanRequestPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dispalyLoanRequests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.loan_request_title_table.SuspendLayout();
            this.loan_request_title_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.loanRequestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispalyLoanRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // loan_request_title_table
            // 
            this.loan_request_title_table.ColumnCount = 2;
            this.loan_request_title_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loan_request_title_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loan_request_title_table.Controls.Add(this.loan_request_title_panel, 0, 0);
            this.loan_request_title_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.loan_request_title_table.Location = new System.Drawing.Point(0, 0);
            this.loan_request_title_table.Margin = new System.Windows.Forms.Padding(4);
            this.loan_request_title_table.Name = "loan_request_title_table";
            this.loan_request_title_table.RowCount = 1;
            this.loan_request_title_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loan_request_title_table.Size = new System.Drawing.Size(1233, 69);
            this.loan_request_title_table.TabIndex = 10;
            this.loan_request_title_table.Paint += new System.Windows.Forms.PaintEventHandler(this.loan_request_title_table_Paint);
            // 
            // loan_request_title_panel
            // 
            this.loan_request_title_panel.Controls.Add(this.loan_request_title_label);
            this.loan_request_title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loan_request_title_panel.Location = new System.Drawing.Point(4, 4);
            this.loan_request_title_panel.Margin = new System.Windows.Forms.Padding(4);
            this.loan_request_title_panel.Name = "loan_request_title_panel";
            this.loan_request_title_panel.Size = new System.Drawing.Size(608, 61);
            this.loan_request_title_panel.TabIndex = 2;
            // 
            // loan_request_title_label
            // 
            this.loan_request_title_label.AutoSize = true;
            this.loan_request_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_request_title_label.Location = new System.Drawing.Point(24, 12);
            this.loan_request_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loan_request_title_label.Name = "loan_request_title_label";
            this.loan_request_title_label.Size = new System.Drawing.Size(204, 38);
            this.loan_request_title_label.TabIndex = 0;
            this.loan_request_title_label.Text = "Loan Requests";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel1.Controls.Add(this.search_loan_requestName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar20003, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1233, 76);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // search_loan_requestName
            // 
            this.search_loan_requestName.AllowAnimations = true;
            this.search_loan_requestName.AllowMouseEffects = true;
            this.search_loan_requestName.AllowToggling = false;
            this.search_loan_requestName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_loan_requestName.AnimationSpeed = 200;
            this.search_loan_requestName.AutoGenerateColors = false;
            this.search_loan_requestName.AutoRoundBorders = false;
            this.search_loan_requestName.AutoSizeLeftIcon = true;
            this.search_loan_requestName.AutoSizeRightIcon = true;
            this.search_loan_requestName.BackColor = System.Drawing.Color.Transparent;
            this.search_loan_requestName.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.search_loan_requestName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_loan_requestName.BackgroundImage")));
            this.search_loan_requestName.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_loan_requestName.ButtonText = "Search";
            this.search_loan_requestName.ButtonTextMarginLeft = 0;
            this.search_loan_requestName.ColorContrastOnClick = 45;
            this.search_loan_requestName.ColorContrastOnHover = 45;
            this.search_loan_requestName.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.search_loan_requestName.CustomizableEdges = borderEdges1;
            this.search_loan_requestName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search_loan_requestName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_loan_requestName.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_loan_requestName.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_loan_requestName.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.search_loan_requestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_loan_requestName.ForeColor = System.Drawing.Color.White;
            this.search_loan_requestName.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_loan_requestName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.search_loan_requestName.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.search_loan_requestName.IconMarginLeft = 11;
            this.search_loan_requestName.IconPadding = 10;
            this.search_loan_requestName.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_loan_requestName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.search_loan_requestName.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.search_loan_requestName.IconSize = 25;
            this.search_loan_requestName.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.search_loan_requestName.IdleBorderRadius = 30;
            this.search_loan_requestName.IdleBorderThickness = 1;
            this.search_loan_requestName.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.search_loan_requestName.IdleIconLeftImage = null;
            this.search_loan_requestName.IdleIconRightImage = null;
            this.search_loan_requestName.IndicateFocus = false;
            this.search_loan_requestName.Location = new System.Drawing.Point(590, 4);
            this.search_loan_requestName.Margin = new System.Windows.Forms.Padding(4);
            this.search_loan_requestName.Name = "search_loan_requestName";
            this.search_loan_requestName.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_loan_requestName.OnDisabledState.BorderRadius = 30;
            this.search_loan_requestName.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_loan_requestName.OnDisabledState.BorderThickness = 1;
            this.search_loan_requestName.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_loan_requestName.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_loan_requestName.OnDisabledState.IconLeftImage = null;
            this.search_loan_requestName.OnDisabledState.IconRightImage = null;
            this.search_loan_requestName.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_loan_requestName.onHoverState.BorderRadius = 30;
            this.search_loan_requestName.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_loan_requestName.onHoverState.BorderThickness = 1;
            this.search_loan_requestName.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_loan_requestName.onHoverState.ForeColor = System.Drawing.Color.White;
            this.search_loan_requestName.onHoverState.IconLeftImage = null;
            this.search_loan_requestName.onHoverState.IconRightImage = null;
            this.search_loan_requestName.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.search_loan_requestName.OnIdleState.BorderRadius = 30;
            this.search_loan_requestName.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_loan_requestName.OnIdleState.BorderThickness = 1;
            this.search_loan_requestName.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.search_loan_requestName.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.search_loan_requestName.OnIdleState.IconLeftImage = null;
            this.search_loan_requestName.OnIdleState.IconRightImage = null;
            this.search_loan_requestName.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_loan_requestName.OnPressedState.BorderRadius = 30;
            this.search_loan_requestName.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_loan_requestName.OnPressedState.BorderThickness = 1;
            this.search_loan_requestName.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_loan_requestName.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.search_loan_requestName.OnPressedState.IconLeftImage = null;
            this.search_loan_requestName.OnPressedState.IconRightImage = null;
            this.search_loan_requestName.Size = new System.Drawing.Size(222, 68);
            this.search_loan_requestName.TabIndex = 47;
            this.search_loan_requestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_loan_requestName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_loan_requestName.TextMarginLeft = 0;
            this.search_loan_requestName.TextPadding = new System.Windows.Forms.Padding(0);
            this.search_loan_requestName.UseDefaultRadiusAndThickness = true;
            this.search_loan_requestName.Click += new System.EventHandler(this.search_loan_requestName_Click);
            // 
            // searchBar20003
            // 
            this.searchBar20003.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar20003.DefaultText = "";
            this.searchBar20003.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBar20003.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar20003.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar20003.DisabledState.Parent = this.searchBar20003;
            this.searchBar20003.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar20003.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar20003.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar20003.FocusedState.Parent = this.searchBar20003;
            this.searchBar20003.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar20003.HoverState.Parent = this.searchBar20003;
            this.searchBar20003.IconRight = ((System.Drawing.Image)(resources.GetObject("searchBar20003.IconRight")));
            this.searchBar20003.Location = new System.Drawing.Point(5, 5);
            this.searchBar20003.Margin = new System.Windows.Forms.Padding(5);
            this.searchBar20003.Name = "searchBar20003";
            this.searchBar20003.PasswordChar = '\0';
            this.searchBar20003.PlaceholderText = "search company by name";
            this.searchBar20003.SelectedText = "";
            this.searchBar20003.ShadowDecoration.Parent = this.searchBar20003;
            this.searchBar20003.Size = new System.Drawing.Size(576, 66);
            this.searchBar20003.TabIndex = 1;
            // 
            // loanRequestPanel
            // 
            this.loanRequestPanel.ColumnCount = 1;
            this.loanRequestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loanRequestPanel.Controls.Add(this.dispalyLoanRequests, 0, 0);
            this.loanRequestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loanRequestPanel.Location = new System.Drawing.Point(0, 145);
            this.loanRequestPanel.Name = "loanRequestPanel";
            this.loanRequestPanel.RowCount = 1;
            this.loanRequestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loanRequestPanel.Size = new System.Drawing.Size(1233, 516);
            this.loanRequestPanel.TabIndex = 12;
            // 
            // dispalyLoanRequests
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dispalyLoanRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dispalyLoanRequests.BackgroundColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispalyLoanRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dispalyLoanRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dispalyLoanRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dispalyLoanRequests.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dispalyLoanRequests.DefaultCellStyle = dataGridViewCellStyle3;
            this.dispalyLoanRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dispalyLoanRequests.EnableHeadersVisualStyles = false;
            this.dispalyLoanRequests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dispalyLoanRequests.Location = new System.Drawing.Point(3, 3);
            this.dispalyLoanRequests.Name = "dispalyLoanRequests";
            this.dispalyLoanRequests.RowHeadersVisible = false;
            this.dispalyLoanRequests.RowHeadersWidth = 51;
            this.dispalyLoanRequests.RowTemplate.Height = 24;
            this.dispalyLoanRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dispalyLoanRequests.Size = new System.Drawing.Size(1227, 510);
            this.dispalyLoanRequests.TabIndex = 0;
            this.dispalyLoanRequests.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dispalyLoanRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dispalyLoanRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dispalyLoanRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dispalyLoanRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dispalyLoanRequests.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dispalyLoanRequests.ThemeStyle.HeaderStyle.Height = 4;
            this.dispalyLoanRequests.ThemeStyle.ReadOnly = false;
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.Height = 24;
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dispalyLoanRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dispalyLoanRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dispalyLoanRequests_CellClick);
            // 
            // Loan_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 661);
            this.Controls.Add(this.loanRequestPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.loan_request_title_table);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loan_Request";
            this.Text = "Loan_Request";
            this.Load += new System.EventHandler(this.Loan_Request_Load);
            this.loan_request_title_table.ResumeLayout(false);
            this.loan_request_title_panel.ResumeLayout(false);
            this.loan_request_title_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.loanRequestPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dispalyLoanRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loan_request_title_table;
        private System.Windows.Forms.Panel loan_request_title_panel;
        private System.Windows.Forms.Label loan_request_title_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton search_loan_requestName;
        private Guna.UI2.WinForms.Guna2TextBox searchBar20003;
        private System.Windows.Forms.TableLayoutPanel loanRequestPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dispalyLoanRequests;
    }
}