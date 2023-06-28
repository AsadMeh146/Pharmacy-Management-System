
namespace Final_DB_Project
{
    partial class Add_Pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Pharmacy));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pharmacyLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.pharmacyContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phar_add_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.phar_title__table = new System.Windows.Forms.TableLayoutPanel();
            this.phar_title_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.phar_title__table.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pharmacyLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pharmacyContactNumber, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1228, 145);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(3, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(203, 28);
            this.label30.TabIndex = 3;
            this.label30.Text = "Pharmacy Location :";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(3, 95);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(179, 28);
            this.label31.TabIndex = 4;
            this.label31.Text = "Contact Number :";
            // 
            // pharmacyLocation
            // 
            this.pharmacyLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pharmacyLocation.DefaultText = "";
            this.pharmacyLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pharmacyLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pharmacyLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pharmacyLocation.DisabledState.Parent = this.pharmacyLocation;
            this.pharmacyLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pharmacyLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacyLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pharmacyLocation.FocusedState.Parent = this.pharmacyLocation;
            this.pharmacyLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pharmacyLocation.HoverState.Parent = this.pharmacyLocation;
            this.pharmacyLocation.Location = new System.Drawing.Point(373, 6);
            this.pharmacyLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pharmacyLocation.Name = "pharmacyLocation";
            this.pharmacyLocation.PasswordChar = '\0';
            this.pharmacyLocation.PlaceholderText = "enter pharmacy location";
            this.pharmacyLocation.SelectedText = "";
            this.pharmacyLocation.ShadowDecoration.Parent = this.pharmacyLocation;
            this.pharmacyLocation.Size = new System.Drawing.Size(850, 62);
            this.pharmacyLocation.TabIndex = 11;
            // 
            // pharmacyContactNumber
            // 
            this.pharmacyContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pharmacyContactNumber.DefaultText = "";
            this.pharmacyContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pharmacyContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pharmacyContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pharmacyContactNumber.DisabledState.Parent = this.pharmacyContactNumber;
            this.pharmacyContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pharmacyContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacyContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pharmacyContactNumber.FocusedState.Parent = this.pharmacyContactNumber;
            this.pharmacyContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pharmacyContactNumber.HoverState.Parent = this.pharmacyContactNumber;
            this.pharmacyContactNumber.Location = new System.Drawing.Point(373, 79);
            this.pharmacyContactNumber.Margin = new System.Windows.Forms.Padding(5);
            this.pharmacyContactNumber.Name = "pharmacyContactNumber";
            this.pharmacyContactNumber.PasswordChar = '\0';
            this.pharmacyContactNumber.PlaceholderText = "enter contact number";
            this.pharmacyContactNumber.SelectedText = "";
            this.pharmacyContactNumber.ShadowDecoration.Parent = this.pharmacyContactNumber;
            this.pharmacyContactNumber.Size = new System.Drawing.Size(850, 61);
            this.pharmacyContactNumber.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 293);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1223, 361);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 357);
            this.dataGridView1.TabIndex = 1;
            // 
            // phar_add_btn
            // 
            this.phar_add_btn.AllowAnimations = true;
            this.phar_add_btn.AllowMouseEffects = true;
            this.phar_add_btn.AllowToggling = false;
            this.phar_add_btn.AnimationSpeed = 200;
            this.phar_add_btn.AutoGenerateColors = false;
            this.phar_add_btn.AutoRoundBorders = false;
            this.phar_add_btn.AutoSizeLeftIcon = true;
            this.phar_add_btn.AutoSizeRightIcon = true;
            this.phar_add_btn.BackColor = System.Drawing.Color.Transparent;
            this.phar_add_btn.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.phar_add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phar_add_btn.BackgroundImage")));
            this.phar_add_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.phar_add_btn.ButtonText = "Add";
            this.phar_add_btn.ButtonTextMarginLeft = 0;
            this.phar_add_btn.ColorContrastOnClick = 45;
            this.phar_add_btn.ColorContrastOnHover = 45;
            this.phar_add_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.phar_add_btn.CustomizableEdges = borderEdges2;
            this.phar_add_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.phar_add_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.phar_add_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.phar_add_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.phar_add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phar_add_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.phar_add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.phar_add_btn.ForeColor = System.Drawing.Color.White;
            this.phar_add_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phar_add_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.phar_add_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.phar_add_btn.IconMarginLeft = 11;
            this.phar_add_btn.IconPadding = 10;
            this.phar_add_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phar_add_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.phar_add_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.phar_add_btn.IconSize = 25;
            this.phar_add_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.phar_add_btn.IdleBorderRadius = 30;
            this.phar_add_btn.IdleBorderThickness = 1;
            this.phar_add_btn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.phar_add_btn.IdleIconLeftImage = null;
            this.phar_add_btn.IdleIconRightImage = null;
            this.phar_add_btn.IndicateFocus = false;
            this.phar_add_btn.Location = new System.Drawing.Point(4, 4);
            this.phar_add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.phar_add_btn.Name = "phar_add_btn";
            this.phar_add_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.phar_add_btn.OnDisabledState.BorderRadius = 30;
            this.phar_add_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.phar_add_btn.OnDisabledState.BorderThickness = 1;
            this.phar_add_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.phar_add_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.phar_add_btn.OnDisabledState.IconLeftImage = null;
            this.phar_add_btn.OnDisabledState.IconRightImage = null;
            this.phar_add_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.phar_add_btn.onHoverState.BorderRadius = 30;
            this.phar_add_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.phar_add_btn.onHoverState.BorderThickness = 1;
            this.phar_add_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.phar_add_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.phar_add_btn.onHoverState.IconLeftImage = null;
            this.phar_add_btn.onHoverState.IconRightImage = null;
            this.phar_add_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.phar_add_btn.OnIdleState.BorderRadius = 30;
            this.phar_add_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.phar_add_btn.OnIdleState.BorderThickness = 1;
            this.phar_add_btn.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.phar_add_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.phar_add_btn.OnIdleState.IconLeftImage = null;
            this.phar_add_btn.OnIdleState.IconRightImage = null;
            this.phar_add_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.phar_add_btn.OnPressedState.BorderRadius = 30;
            this.phar_add_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.phar_add_btn.OnPressedState.BorderThickness = 1;
            this.phar_add_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.phar_add_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.phar_add_btn.OnPressedState.IconLeftImage = null;
            this.phar_add_btn.OnPressedState.IconRightImage = null;
            this.phar_add_btn.Size = new System.Drawing.Size(1211, 60);
            this.phar_add_btn.TabIndex = 48;
            this.phar_add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phar_add_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.phar_add_btn.TextMarginLeft = 0;
            this.phar_add_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.phar_add_btn.UseDefaultRadiusAndThickness = true;
            this.phar_add_btn.Click += new System.EventHandler(this.phar_add_btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.phar_add_btn, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 221);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1219, 68);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // phar_title__table
            // 
            this.phar_title__table.ColumnCount = 1;
            this.phar_title__table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.phar_title__table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.phar_title__table.Controls.Add(this.phar_title_label, 0, 0);
            this.phar_title__table.Dock = System.Windows.Forms.DockStyle.Top;
            this.phar_title__table.Location = new System.Drawing.Point(0, 0);
            this.phar_title__table.Margin = new System.Windows.Forms.Padding(4);
            this.phar_title__table.Name = "phar_title__table";
            this.phar_title__table.RowCount = 1;
            this.phar_title__table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.phar_title__table.Size = new System.Drawing.Size(1228, 69);
            this.phar_title__table.TabIndex = 11;
            // 
            // phar_title_label
            // 
            this.phar_title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phar_title_label.AutoSize = true;
            this.phar_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phar_title_label.Location = new System.Drawing.Point(510, 15);
            this.phar_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phar_title_label.Name = "phar_title_label";
            this.phar_title_label.Size = new System.Drawing.Size(208, 38);
            this.phar_title_label.TabIndex = 1;
            this.phar_title_label.Text = "Add Pharmacy";
            // 
            // Add_Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 654);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.phar_title__table);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Pharmacy";
            this.Text = "Add_Pharmacy";
            this.Load += new System.EventHandler(this.Add_Pharmacy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.phar_title__table.ResumeLayout(false);
            this.phar_title__table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private Guna.UI2.WinForms.Guna2TextBox pharmacyLocation;
        private Guna.UI2.WinForms.Guna2TextBox pharmacyContactNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton phar_add_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel phar_title__table;
        private System.Windows.Forms.Label phar_title_label;
    }
}