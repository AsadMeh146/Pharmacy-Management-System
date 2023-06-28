
namespace Final_DB_Project
{
    partial class Update_Attendance
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
            this.tableLayoutPanel1071 = new System.Windows.Forms.TableLayoutPanel();
            this.update_atten_grid = new System.Windows.Forms.DataGridView();
            this.view_attendance_panel = new System.Windows.Forms.TableLayoutPanel();
            this.search_atten_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_label = new System.Windows.Forms.Label();
            this.search_name_btn = new Guna.UI2.WinForms.Guna2TextBox();
            this.atten_btn_table = new System.Windows.Forms.TableLayoutPanel();
            this.delete_attendance_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_attedance_btn = new Guna.UI2.WinForms.Guna2Button();
            this.refresh_attendance = new Guna.UI2.WinForms.Guna2Button();
            this.update_attendace_title = new System.Windows.Forms.TableLayoutPanel();
            this.title_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1071.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_atten_grid)).BeginInit();
            this.view_attendance_panel.SuspendLayout();
            this.atten_btn_table.SuspendLayout();
            this.update_attendace_title.SuspendLayout();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1071
            // 
            this.tableLayoutPanel1071.ColumnCount = 1;
            this.tableLayoutPanel1071.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1071.Controls.Add(this.update_atten_grid, 0, 0);
            this.tableLayoutPanel1071.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1071.Location = new System.Drawing.Point(0, 166);
            this.tableLayoutPanel1071.Name = "tableLayoutPanel1071";
            this.tableLayoutPanel1071.RowCount = 1;
            this.tableLayoutPanel1071.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1071.Size = new System.Drawing.Size(919, 378);
            this.tableLayoutPanel1071.TabIndex = 15;
            // 
            // update_atten_grid
            // 
            this.update_atten_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.update_atten_grid.BackgroundColor = System.Drawing.Color.White;
            this.update_atten_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.update_atten_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_atten_grid.GridColor = System.Drawing.Color.White;
            this.update_atten_grid.Location = new System.Drawing.Point(3, 3);
            this.update_atten_grid.Name = "update_atten_grid";
            this.update_atten_grid.Size = new System.Drawing.Size(913, 372);
            this.update_atten_grid.TabIndex = 0;
            // 
            // view_attendance_panel
            // 
            this.view_attendance_panel.ColumnCount = 3;
            this.view_attendance_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.view_attendance_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.view_attendance_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.view_attendance_panel.Controls.Add(this.search_atten_btn, 2, 0);
            this.view_attendance_panel.Controls.Add(this.search_label, 0, 0);
            this.view_attendance_panel.Controls.Add(this.search_name_btn, 1, 0);
            this.view_attendance_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_attendance_panel.Location = new System.Drawing.Point(0, 113);
            this.view_attendance_panel.Name = "view_attendance_panel";
            this.view_attendance_panel.RowCount = 1;
            this.view_attendance_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.view_attendance_panel.Size = new System.Drawing.Size(919, 53);
            this.view_attendance_panel.TabIndex = 14;
            // 
            // search_atten_btn
            // 
            this.search_atten_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_atten_btn.BorderRadius = 20;
            this.search_atten_btn.CheckedState.Parent = this.search_atten_btn;
            this.search_atten_btn.CustomImages.Parent = this.search_atten_btn;
            this.search_atten_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_atten_btn.ForeColor = System.Drawing.Color.White;
            this.search_atten_btn.HoverState.Parent = this.search_atten_btn;
            this.search_atten_btn.Location = new System.Drawing.Point(709, 4);
            this.search_atten_btn.Name = "search_atten_btn";
            this.search_atten_btn.ShadowDecoration.Parent = this.search_atten_btn;
            this.search_atten_btn.Size = new System.Drawing.Size(180, 45);
            this.search_atten_btn.TabIndex = 6;
            this.search_atten_btn.Text = "Search";
            this.search_atten_btn.Click += new System.EventHandler(this.search_atten_btn_Click);
            // 
            // search_label
            // 
            this.search_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_label.Location = new System.Drawing.Point(105, 16);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(146, 21);
            this.search_label.TabIndex = 0;
            this.search_label.Text = "Search By Name : ";
            // 
            // search_name_btn
            // 
            this.search_name_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_name_btn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_name_btn.DefaultText = "";
            this.search_name_btn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_name_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_name_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_name_btn.DisabledState.Parent = this.search_name_btn;
            this.search_name_btn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_name_btn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_name_btn.FocusedState.Parent = this.search_name_btn;
            this.search_name_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_name_btn.HoverState.Parent = this.search_name_btn;
            this.search_name_btn.Location = new System.Drawing.Point(359, 8);
            this.search_name_btn.Name = "search_name_btn";
            this.search_name_btn.PasswordChar = '\0';
            this.search_name_btn.PlaceholderText = "";
            this.search_name_btn.SelectedText = "";
            this.search_name_btn.ShadowDecoration.Parent = this.search_name_btn;
            this.search_name_btn.Size = new System.Drawing.Size(200, 36);
            this.search_name_btn.TabIndex = 1;
            // 
            // atten_btn_table
            // 
            this.atten_btn_table.ColumnCount = 3;
            this.atten_btn_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65217F));
            this.atten_btn_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34783F));
            this.atten_btn_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.atten_btn_table.Controls.Add(this.delete_attendance_btn, 0, 0);
            this.atten_btn_table.Controls.Add(this.update_attedance_btn, 0, 0);
            this.atten_btn_table.Controls.Add(this.refresh_attendance, 0, 0);
            this.atten_btn_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.atten_btn_table.Location = new System.Drawing.Point(0, 53);
            this.atten_btn_table.Name = "atten_btn_table";
            this.atten_btn_table.RowCount = 1;
            this.atten_btn_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.atten_btn_table.Size = new System.Drawing.Size(919, 60);
            this.atten_btn_table.TabIndex = 13;
            // 
            // delete_attendance_btn
            // 
            this.delete_attendance_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_attendance_btn.BorderRadius = 20;
            this.delete_attendance_btn.CheckedState.Parent = this.delete_attendance_btn;
            this.delete_attendance_btn.CustomImages.Parent = this.delete_attendance_btn;
            this.delete_attendance_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.delete_attendance_btn.ForeColor = System.Drawing.Color.White;
            this.delete_attendance_btn.HoverState.Parent = this.delete_attendance_btn;
            this.delete_attendance_btn.Location = new System.Drawing.Point(700, 7);
            this.delete_attendance_btn.Name = "delete_attendance_btn";
            this.delete_attendance_btn.ShadowDecoration.Parent = this.delete_attendance_btn;
            this.delete_attendance_btn.Size = new System.Drawing.Size(180, 45);
            this.delete_attendance_btn.TabIndex = 7;
            this.delete_attendance_btn.Text = "Delete";
            this.delete_attendance_btn.Click += new System.EventHandler(this.delete_attendance_btn_Click);
            // 
            // update_attedance_btn
            // 
            this.update_attedance_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_attedance_btn.BorderRadius = 20;
            this.update_attedance_btn.CheckedState.Parent = this.update_attedance_btn;
            this.update_attedance_btn.CustomImages.Parent = this.update_attedance_btn;
            this.update_attedance_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.update_attedance_btn.ForeColor = System.Drawing.Color.White;
            this.update_attedance_btn.HoverState.Parent = this.update_attedance_btn;
            this.update_attedance_btn.Location = new System.Drawing.Point(398, 7);
            this.update_attedance_btn.Name = "update_attedance_btn";
            this.update_attedance_btn.ShadowDecoration.Parent = this.update_attedance_btn;
            this.update_attedance_btn.Size = new System.Drawing.Size(180, 45);
            this.update_attedance_btn.TabIndex = 6;
            this.update_attedance_btn.Text = "Update";
            this.update_attedance_btn.Click += new System.EventHandler(this.update_attedance_btn_Click);
            // 
            // refresh_attendance
            // 
            this.refresh_attendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh_attendance.BorderRadius = 20;
            this.refresh_attendance.CheckedState.Parent = this.refresh_attendance;
            this.refresh_attendance.CustomImages.Parent = this.refresh_attendance;
            this.refresh_attendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.refresh_attendance.ForeColor = System.Drawing.Color.White;
            this.refresh_attendance.HoverState.Parent = this.refresh_attendance;
            this.refresh_attendance.Location = new System.Drawing.Point(67, 7);
            this.refresh_attendance.Name = "refresh_attendance";
            this.refresh_attendance.ShadowDecoration.Parent = this.refresh_attendance;
            this.refresh_attendance.Size = new System.Drawing.Size(180, 45);
            this.refresh_attendance.TabIndex = 5;
            this.refresh_attendance.Text = "Refresh";
            this.refresh_attendance.Click += new System.EventHandler(this.refresh_attendance_Click);
            // 
            // update_attendace_title
            // 
            this.update_attendace_title.ColumnCount = 2;
            this.update_attendace_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_attendace_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_attendace_title.Controls.Add(this.title_panel, 0, 0);
            this.update_attendace_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.update_attendace_title.Location = new System.Drawing.Point(0, 0);
            this.update_attendace_title.Name = "update_attendace_title";
            this.update_attendace_title.RowCount = 1;
            this.update_attendace_title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.update_attendace_title.Size = new System.Drawing.Size(919, 53);
            this.update_attendace_title.TabIndex = 12;
            // 
            // title_panel
            // 
            this.title_panel.Controls.Add(this.title_label);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_panel.Location = new System.Drawing.Point(3, 3);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(453, 47);
            this.title_panel.TabIndex = 4;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.title_label.Location = new System.Drawing.Point(16, 15);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(211, 21);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "View / Update Attendance";
            // 
            // Update_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.tableLayoutPanel1071);
            this.Controls.Add(this.view_attendance_panel);
            this.Controls.Add(this.atten_btn_table);
            this.Controls.Add(this.update_attendace_title);
            this.Name = "Update_Attendance";
            this.Text = "Update_Attendance";
            this.Load += new System.EventHandler(this.Update_Attendance_Load);
            this.tableLayoutPanel1071.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update_atten_grid)).EndInit();
            this.view_attendance_panel.ResumeLayout(false);
            this.view_attendance_panel.PerformLayout();
            this.atten_btn_table.ResumeLayout(false);
            this.update_attendace_title.ResumeLayout(false);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1071;
        private System.Windows.Forms.DataGridView update_atten_grid;
        private System.Windows.Forms.TableLayoutPanel view_attendance_panel;
        private Guna.UI2.WinForms.Guna2Button search_atten_btn;
        private System.Windows.Forms.Label search_label;
        private Guna.UI2.WinForms.Guna2TextBox search_name_btn;
        private System.Windows.Forms.TableLayoutPanel atten_btn_table;
        private Guna.UI2.WinForms.Guna2Button delete_attendance_btn;
        private Guna.UI2.WinForms.Guna2Button update_attedance_btn;
        private Guna.UI2.WinForms.Guna2Button refresh_attendance;
        private System.Windows.Forms.TableLayoutPanel update_attendace_title;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Label title_label;
    }
}