
namespace Final_DB_Project
{
    partial class Update_Date
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
            this.tableLayoutPanel1069 = new System.Windows.Forms.TableLayoutPanel();
            this.show_date_grid = new System.Windows.Forms.DataGridView();
            this.date_buttons_table = new System.Windows.Forms.TableLayoutPanel();
            this.date_delete = new Guna.UI2.WinForms.Guna2Button();
            this.date_update = new Guna.UI2.WinForms.Guna2Button();
            this.date_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.update_title = new System.Windows.Forms.TableLayoutPanel();
            this.update_title_panel = new System.Windows.Forms.Panel();
            this.update_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1069.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_date_grid)).BeginInit();
            this.date_buttons_table.SuspendLayout();
            this.update_title.SuspendLayout();
            this.update_title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1069
            // 
            this.tableLayoutPanel1069.ColumnCount = 1;
            this.tableLayoutPanel1069.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1069.Controls.Add(this.show_date_grid, 0, 0);
            this.tableLayoutPanel1069.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1069.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1069.Name = "tableLayoutPanel1069";
            this.tableLayoutPanel1069.RowCount = 1;
            this.tableLayoutPanel1069.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1069.Size = new System.Drawing.Size(922, 416);
            this.tableLayoutPanel1069.TabIndex = 11;
            // 
            // show_date_grid
            // 
            this.show_date_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_date_grid.BackgroundColor = System.Drawing.Color.White;
            this.show_date_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_date_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_date_grid.GridColor = System.Drawing.Color.White;
            this.show_date_grid.Location = new System.Drawing.Point(3, 3);
            this.show_date_grid.Name = "show_date_grid";
            this.show_date_grid.Size = new System.Drawing.Size(916, 410);
            this.show_date_grid.TabIndex = 0;
            // 
            // date_buttons_table
            // 
            this.date_buttons_table.ColumnCount = 3;
            this.date_buttons_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.61512F));
            this.date_buttons_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.38488F));
            this.date_buttons_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.date_buttons_table.Controls.Add(this.date_delete, 0, 0);
            this.date_buttons_table.Controls.Add(this.date_update, 0, 0);
            this.date_buttons_table.Controls.Add(this.date_refresh, 0, 0);
            this.date_buttons_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.date_buttons_table.Location = new System.Drawing.Point(0, 56);
            this.date_buttons_table.Name = "date_buttons_table";
            this.date_buttons_table.RowCount = 1;
            this.date_buttons_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.date_buttons_table.Size = new System.Drawing.Size(922, 57);
            this.date_buttons_table.TabIndex = 10;
            // 
            // date_delete
            // 
            this.date_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_delete.BorderRadius = 20;
            this.date_delete.CheckedState.Parent = this.date_delete;
            this.date_delete.CustomImages.Parent = this.date_delete;
            this.date_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.date_delete.ForeColor = System.Drawing.Color.White;
            this.date_delete.HoverState.Parent = this.date_delete;
            this.date_delete.Location = new System.Drawing.Point(700, 6);
            this.date_delete.Name = "date_delete";
            this.date_delete.ShadowDecoration.Parent = this.date_delete;
            this.date_delete.Size = new System.Drawing.Size(180, 45);
            this.date_delete.TabIndex = 4;
            this.date_delete.Text = "Delete";
            this.date_delete.Click += new System.EventHandler(this.date_delete_Click);
            // 
            // date_update
            // 
            this.date_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_update.BorderRadius = 20;
            this.date_update.CheckedState.Parent = this.date_update;
            this.date_update.CustomImages.Parent = this.date_update;
            this.date_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.date_update.ForeColor = System.Drawing.Color.White;
            this.date_update.HoverState.Parent = this.date_update;
            this.date_update.Location = new System.Drawing.Point(405, 6);
            this.date_update.Name = "date_update";
            this.date_update.ShadowDecoration.Parent = this.date_update;
            this.date_update.Size = new System.Drawing.Size(180, 45);
            this.date_update.TabIndex = 3;
            this.date_update.Text = "Update";
            this.date_update.Click += new System.EventHandler(this.date_update_Click);
            // 
            // date_refresh
            // 
            this.date_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_refresh.BorderRadius = 20;
            this.date_refresh.CheckedState.Parent = this.date_refresh;
            this.date_refresh.CustomImages.Parent = this.date_refresh;
            this.date_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.date_refresh.ForeColor = System.Drawing.Color.White;
            this.date_refresh.HoverState.Parent = this.date_refresh;
            this.date_refresh.Location = new System.Drawing.Point(76, 6);
            this.date_refresh.Name = "date_refresh";
            this.date_refresh.ShadowDecoration.Parent = this.date_refresh;
            this.date_refresh.Size = new System.Drawing.Size(180, 45);
            this.date_refresh.TabIndex = 2;
            this.date_refresh.Text = "Refresh";
            this.date_refresh.Click += new System.EventHandler(this.date_refresh_Click);
            // 
            // update_title
            // 
            this.update_title.ColumnCount = 2;
            this.update_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_title.Controls.Add(this.update_title_panel, 0, 0);
            this.update_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.update_title.Location = new System.Drawing.Point(0, 0);
            this.update_title.Name = "update_title";
            this.update_title.RowCount = 1;
            this.update_title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_title.Size = new System.Drawing.Size(922, 56);
            this.update_title.TabIndex = 9;
            // 
            // update_title_panel
            // 
            this.update_title_panel.Controls.Add(this.update_label);
            this.update_title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_title_panel.Location = new System.Drawing.Point(3, 3);
            this.update_title_panel.Name = "update_title_panel";
            this.update_title_panel.Size = new System.Drawing.Size(455, 50);
            this.update_title_panel.TabIndex = 2;
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.update_label.Location = new System.Drawing.Point(16, 15);
            this.update_label.Name = "update_label";
            this.update_label.Size = new System.Drawing.Size(151, 21);
            this.update_label.TabIndex = 0;
            this.update_label.Text = "View/Update Date";
            // 
            // Update_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 529);
            this.Controls.Add(this.tableLayoutPanel1069);
            this.Controls.Add(this.date_buttons_table);
            this.Controls.Add(this.update_title);
            this.Name = "Update_Date";
            this.Text = "Update_Date";
            this.Load += new System.EventHandler(this.Update_Date_Load);
            this.tableLayoutPanel1069.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_date_grid)).EndInit();
            this.date_buttons_table.ResumeLayout(false);
            this.update_title.ResumeLayout(false);
            this.update_title_panel.ResumeLayout(false);
            this.update_title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1069;
        private System.Windows.Forms.DataGridView show_date_grid;
        private System.Windows.Forms.TableLayoutPanel date_buttons_table;
        private Guna.UI2.WinForms.Guna2Button date_delete;
        private Guna.UI2.WinForms.Guna2Button date_update;
        private Guna.UI2.WinForms.Guna2Button date_refresh;
        private System.Windows.Forms.TableLayoutPanel update_title;
        private System.Windows.Forms.Panel update_title_panel;
        private System.Windows.Forms.Label update_label;
    }
}