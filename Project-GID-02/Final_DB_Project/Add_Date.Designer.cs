
namespace Final_DB_Project
{
    partial class Add_Date
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
            this.add_date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.add_date_button = new Guna.UI2.WinForms.Guna2Button();
            this.add_date_table = new System.Windows.Forms.TableLayoutPanel();
            this.add_date_panel = new System.Windows.Forms.Panel();
            this.add_date_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datePanel = new System.Windows.Forms.Panel();
            this.add_date_table.SuspendLayout();
            this.add_date_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_date_picker
            // 
            this.add_date_picker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_date_picker.CheckedState.Parent = this.add_date_picker;
            this.add_date_picker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.add_date_picker.ForeColor = System.Drawing.Color.White;
            this.add_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.add_date_picker.HoverState.Parent = this.add_date_picker;
            this.add_date_picker.Location = new System.Drawing.Point(129, 9);
            this.add_date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.add_date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.add_date_picker.Name = "add_date_picker";
            this.add_date_picker.ShadowDecoration.Parent = this.add_date_picker;
            this.add_date_picker.Size = new System.Drawing.Size(200, 36);
            this.add_date_picker.TabIndex = 0;
            this.add_date_picker.Value = new System.DateTime(2022, 4, 18, 21, 30, 5, 871);
            // 
            // add_date_button
            // 
            this.add_date_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_date_button.BorderRadius = 20;
            this.add_date_button.CheckedState.Parent = this.add_date_button;
            this.add_date_button.CustomImages.Parent = this.add_date_button;
            this.add_date_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_date_button.ForeColor = System.Drawing.Color.White;
            this.add_date_button.HoverState.Parent = this.add_date_button;
            this.add_date_button.Location = new System.Drawing.Point(462, 5);
            this.add_date_button.Name = "add_date_button";
            this.add_date_button.ShadowDecoration.Parent = this.add_date_button;
            this.add_date_button.Size = new System.Drawing.Size(180, 44);
            this.add_date_button.TabIndex = 2;
            this.add_date_button.Text = "Add";
            this.add_date_button.Click += new System.EventHandler(this.add_date_button_Click);
            // 
            // add_date_table
            // 
            this.add_date_table.ColumnCount = 2;
            this.add_date_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.add_date_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.add_date_table.Controls.Add(this.add_date_panel, 0, 0);
            this.add_date_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_date_table.Location = new System.Drawing.Point(0, 0);
            this.add_date_table.Name = "add_date_table";
            this.add_date_table.RowCount = 1;
            this.add_date_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.add_date_table.Size = new System.Drawing.Size(918, 62);
            this.add_date_table.TabIndex = 2;
            // 
            // add_date_panel
            // 
            this.add_date_panel.Controls.Add(this.add_date_label);
            this.add_date_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_date_panel.Location = new System.Drawing.Point(3, 3);
            this.add_date_panel.Name = "add_date_panel";
            this.add_date_panel.Size = new System.Drawing.Size(453, 56);
            this.add_date_panel.TabIndex = 1;
            // 
            // add_date_label
            // 
            this.add_date_label.AutoSize = true;
            this.add_date_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_date_label.Location = new System.Drawing.Point(16, 19);
            this.add_date_label.Name = "add_date_label";
            this.add_date_label.Size = new System.Drawing.Size(81, 21);
            this.add_date_label.TabIndex = 0;
            this.add_date_label.Text = "Add Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.add_date_picker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_date_button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 54);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // datePanel
            // 
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePanel.Location = new System.Drawing.Point(0, 116);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(918, 420);
            this.datePanel.TabIndex = 4;
            // 
            // Add_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 536);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.add_date_table);
            this.Name = "Add_Date";
            this.Text = "Add_Date";
            this.Load += new System.EventHandler(this.Add_Date_Load);
            this.add_date_table.ResumeLayout(false);
            this.add_date_panel.ResumeLayout(false);
            this.add_date_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker add_date_picker;
        public Guna.UI2.WinForms.Guna2Button add_date_button;
        private System.Windows.Forms.TableLayoutPanel add_date_table;
        private System.Windows.Forms.Panel add_date_panel;
        private System.Windows.Forms.Label add_date_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel datePanel;
    }
}