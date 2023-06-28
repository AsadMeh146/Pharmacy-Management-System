
namespace Final_DB_Project
{
    partial class ReceiveOrder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerOrdersLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.check_btn = new Guna.UI2.WinForms.Guna2Button();
            this.orderId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orderDetails_view = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_view)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerOrdersLable
            // 
            this.customerOrdersLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerOrdersLable.AutoSize = true;
            this.customerOrdersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrdersLable.Location = new System.Drawing.Point(291, 8);
            this.customerOrdersLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerOrdersLable.Name = "customerOrdersLable";
            this.customerOrdersLable.Size = new System.Drawing.Size(299, 31);
            this.customerOrdersLable.TabIndex = 2;
            this.customerOrdersLable.Text = "Receive Stock Orders";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel2.Controls.Add(this.check_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // check_btn
            // 
            this.check_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.check_btn.BorderRadius = 20;
            this.check_btn.CheckedState.Parent = this.check_btn;
            this.check_btn.CustomImages.Parent = this.check_btn;
            this.check_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.check_btn.ForeColor = System.Drawing.Color.White;
            this.check_btn.HoverState.Parent = this.check_btn;
            this.check_btn.Location = new System.Drawing.Point(505, 4);
            this.check_btn.Name = "check_btn";
            this.check_btn.ShadowDecoration.Parent = this.check_btn;
            this.check_btn.Size = new System.Drawing.Size(180, 44);
            this.check_btn.TabIndex = 3;
            this.check_btn.Text = "Check";
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // orderId
            // 
            this.orderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderId.DefaultText = "";
            this.orderId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.orderId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.orderId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderId.DisabledState.Parent = this.orderId;
            this.orderId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderId.FocusedState.Parent = this.orderId;
            this.orderId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderId.HoverState.Parent = this.orderId;
            this.orderId.Location = new System.Drawing.Point(254, 8);
            this.orderId.Name = "orderId";
            this.orderId.PasswordChar = '\0';
            this.orderId.PlaceholderText = "";
            this.orderId.SelectedText = "";
            this.orderId.ShadowDecoration.Parent = this.orderId;
            this.orderId.Size = new System.Drawing.Size(200, 36);
            this.orderId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check Order Id :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.orderDetails_view, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(882, 317);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // orderDetails_view
            // 
            this.orderDetails_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetails_view.BackgroundColor = System.Drawing.Color.White;
            this.orderDetails_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetails_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetails_view.Location = new System.Drawing.Point(3, 3);
            this.orderDetails_view.Name = "orderDetails_view";
            this.orderDetails_view.Size = new System.Drawing.Size(876, 311);
            this.orderDetails_view.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 639F));
            this.tableLayoutPanel4.Controls.Add(this.guna2Button1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 417);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(882, 48);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(31, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 42);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Receive";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ReceiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 504);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReceiveOrder";
            this.Text = "ReceiveOrder";
            this.Load += new System.EventHandler(this.ReceiveOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_view)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerOrdersLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public Guna.UI2.WinForms.Guna2Button check_btn;
        private Guna.UI2.WinForms.Guna2TextBox orderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderDetails_view;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}