
namespace Final_DB_Project
{
    partial class New_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Attendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.loan_request_title_table = new System.Windows.Forms.TableLayoutPanel();
            this.loan_request_title_panel = new System.Windows.Forms.Panel();
            this.loan_request_title_label = new System.Windows.Forms.Label();
            this.attendance_table = new System.Windows.Forms.TableLayoutPanel();
            this.att_emp_label = new System.Windows.Forms.Label();
            this.attendance_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emp_data_view = new System.Windows.Forms.DataGridView();
            this.loan_request_title_table.SuspendLayout();
            this.loan_request_title_panel.SuspendLayout();
            this.attendance_table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_data_view)).BeginInit();
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
            this.loan_request_title_table.Name = "loan_request_title_table";
            this.loan_request_title_table.RowCount = 1;
            this.loan_request_title_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loan_request_title_table.Size = new System.Drawing.Size(907, 56);
            this.loan_request_title_table.TabIndex = 11;
            // 
            // loan_request_title_panel
            // 
            this.loan_request_title_panel.Controls.Add(this.loan_request_title_label);
            this.loan_request_title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loan_request_title_panel.Location = new System.Drawing.Point(3, 3);
            this.loan_request_title_panel.Name = "loan_request_title_panel";
            this.loan_request_title_panel.Size = new System.Drawing.Size(447, 50);
            this.loan_request_title_panel.TabIndex = 2;
            // 
            // loan_request_title_label
            // 
            this.loan_request_title_label.AutoSize = true;
            this.loan_request_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_request_title_label.Location = new System.Drawing.Point(18, 10);
            this.loan_request_title_label.Name = "loan_request_title_label";
            this.loan_request_title_label.Size = new System.Drawing.Size(139, 30);
            this.loan_request_title_label.TabIndex = 0;
            this.loan_request_title_label.Text = "Attendance ";
            // 
            // attendance_table
            // 
            this.attendance_table.ColumnCount = 3;
            this.attendance_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47663F));
            this.attendance_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52337F));
            this.attendance_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.attendance_table.Controls.Add(this.attendance_box, 1, 0);
            this.attendance_table.Controls.Add(this.bunifuButton1, 1, 1);
            this.attendance_table.Controls.Add(this.att_emp_label, 0, 0);
            this.attendance_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendance_table.Location = new System.Drawing.Point(0, 56);
            this.attendance_table.Name = "attendance_table";
            this.attendance_table.RowCount = 2;
            this.attendance_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.75591F));
            this.attendance_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.24409F));
            this.attendance_table.Size = new System.Drawing.Size(907, 127);
            this.attendance_table.TabIndex = 12;
            // 
            // att_emp_label
            // 
            this.att_emp_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.att_emp_label.AutoSize = true;
            this.att_emp_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.att_emp_label.Location = new System.Drawing.Point(74, 23);
            this.att_emp_label.Name = "att_emp_label";
            this.att_emp_label.Size = new System.Drawing.Size(146, 21);
            this.att_emp_label.TabIndex = 0;
            this.att_emp_label.Text = "Attendance Date :";
            // 
            // attendance_box
            // 
            this.attendance_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attendance_box.BackColor = System.Drawing.Color.Transparent;
            this.attendance_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.attendance_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attendance_box.FocusedColor = System.Drawing.Color.Empty;
            this.attendance_box.FocusedState.Parent = this.attendance_box;
            this.attendance_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.attendance_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.attendance_box.FormattingEnabled = true;
            this.attendance_box.HoverState.Parent = this.attendance_box;
            this.attendance_box.ItemHeight = 30;
            this.attendance_box.ItemsAppearance.Parent = this.attendance_box;
            this.attendance_box.Location = new System.Drawing.Point(298, 15);
            this.attendance_box.Name = "attendance_box";
            this.attendance_box.ShadowDecoration.Parent = this.attendance_box;
            this.attendance_box.Size = new System.Drawing.Size(219, 36);
            this.attendance_box.TabIndex = 3;
            this.attendance_box.SelectedIndexChanged += new System.EventHandler(this.attendance_box_SelectedIndexChanged);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Save";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 30;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(383, 77);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 30;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 30;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 30;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 30;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton1.TabIndex = 47;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.emp_data_view, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 344);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // emp_data_view
            // 
            this.emp_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_data_view.BackgroundColor = System.Drawing.Color.White;
            this.emp_data_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emp_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_data_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_data_view.GridColor = System.Drawing.Color.White;
            this.emp_data_view.Location = new System.Drawing.Point(3, 3);
            this.emp_data_view.Name = "emp_data_view";
            this.emp_data_view.Size = new System.Drawing.Size(901, 338);
            this.emp_data_view.TabIndex = 1;
            this.emp_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_data_view_CellClick);
            this.emp_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_data_view_CellContentClick);
            // 
            // New_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attendance_table);
            this.Controls.Add(this.loan_request_title_table);
            this.Name = "New_Attendance";
            this.Text = "New_Attendance";
            this.Load += new System.EventHandler(this.New_Attendance_Load);
            this.loan_request_title_table.ResumeLayout(false);
            this.loan_request_title_panel.ResumeLayout(false);
            this.loan_request_title_panel.PerformLayout();
            this.attendance_table.ResumeLayout(false);
            this.attendance_table.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emp_data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loan_request_title_table;
        private System.Windows.Forms.Panel loan_request_title_panel;
        private System.Windows.Forms.Label loan_request_title_label;
        private System.Windows.Forms.TableLayoutPanel attendance_table;
        private System.Windows.Forms.Label att_emp_label;
        private Guna.UI2.WinForms.Guna2ComboBox attendance_box;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView emp_data_view;
    }
}