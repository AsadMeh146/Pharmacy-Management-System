
namespace Final_DB_Project
{
    partial class Employee_Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Loan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.laon_app_table = new System.Windows.Forms.TableLayoutPanel();
            this.label50 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.purposeLoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeName = new System.Windows.Forms.Label();
            this.loanAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.apply_loan_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loan_title_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.laon_app_table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // laon_app_table
            // 
            this.laon_app_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laon_app_table.ColumnCount = 2;
            this.laon_app_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laon_app_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laon_app_table.Controls.Add(this.label50, 0, 0);
            this.laon_app_table.Controls.Add(this.label57, 0, 1);
            this.laon_app_table.Controls.Add(this.purposeLoan, 1, 1);
            this.laon_app_table.Controls.Add(this.employeeName, 1, 0);
            this.laon_app_table.Controls.Add(this.label51, 0, 2);
            this.laon_app_table.Controls.Add(this.label52, 0, 3);
            this.laon_app_table.Controls.Add(this.loanAmount, 1, 2);
            this.laon_app_table.Controls.Add(this.currentDate, 1, 3);
            this.laon_app_table.Location = new System.Drawing.Point(225, 124);
            this.laon_app_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laon_app_table.Name = "laon_app_table";
            this.laon_app_table.RowCount = 4;
            this.laon_app_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.laon_app_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.laon_app_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.laon_app_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.laon_app_table.Size = new System.Drawing.Size(825, 316);
            this.laon_app_table.TabIndex = 1;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(3, 25);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(177, 28);
            this.label50.TabIndex = 3;
            this.label50.Text = "Employee Name :";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label57.Location = new System.Drawing.Point(3, 104);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(176, 28);
            this.label57.TabIndex = 4;
            this.label57.Text = "Purpose of Loan :";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label51.Location = new System.Drawing.Point(3, 183);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(99, 28);
            this.label51.TabIndex = 5;
            this.label51.Text = "Amount :";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label52.Location = new System.Drawing.Point(3, 262);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(129, 28);
            this.label52.TabIndex = 22;
            this.label52.Text = "Apply Date :";
            // 
            // currentDate
            // 
            this.currentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(581, 264);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(75, 25);
            this.currentDate.TabIndex = 29;
            this.currentDate.Text = "label56";
            // 
            // purposeLoan
            // 
            this.purposeLoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purposeLoan.DefaultText = "";
            this.purposeLoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purposeLoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purposeLoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purposeLoan.DisabledState.Parent = this.purposeLoan;
            this.purposeLoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purposeLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purposeLoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purposeLoan.FocusedState.Parent = this.purposeLoan;
            this.purposeLoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purposeLoan.HoverState.Parent = this.purposeLoan;
            this.purposeLoan.Location = new System.Drawing.Point(417, 84);
            this.purposeLoan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.purposeLoan.Name = "purposeLoan";
            this.purposeLoan.PasswordChar = '\0';
            this.purposeLoan.PlaceholderText = "enter purpose of loan";
            this.purposeLoan.SelectedText = "";
            this.purposeLoan.ShadowDecoration.Parent = this.purposeLoan;
            this.purposeLoan.Size = new System.Drawing.Size(403, 69);
            this.purposeLoan.TabIndex = 30;
            // 
            // employeeName
            // 
            this.employeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(581, 27);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(75, 25);
            this.employeeName.TabIndex = 26;
            this.employeeName.Text = "label54";
            // 
            // loanAmount
            // 
            this.loanAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loanAmount.DefaultText = "";
            this.loanAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loanAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loanAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loanAmount.DisabledState.Parent = this.loanAmount;
            this.loanAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loanAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loanAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loanAmount.FocusedState.Parent = this.loanAmount;
            this.loanAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loanAmount.HoverState.Parent = this.loanAmount;
            this.loanAmount.Location = new System.Drawing.Point(417, 164);
            this.loanAmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.PasswordChar = '\0';
            this.loanAmount.PlaceholderText = "enter amount";
            this.loanAmount.SelectedText = "";
            this.loanAmount.ShadowDecoration.Parent = this.loanAmount;
            this.loanAmount.Size = new System.Drawing.Size(403, 67);
            this.loanAmount.TabIndex = 31;
            // 
            // apply_loan_btn
            // 
            this.apply_loan_btn.AllowAnimations = true;
            this.apply_loan_btn.AllowMouseEffects = true;
            this.apply_loan_btn.AllowToggling = false;
            this.apply_loan_btn.AnimationSpeed = 200;
            this.apply_loan_btn.AutoGenerateColors = false;
            this.apply_loan_btn.AutoRoundBorders = false;
            this.apply_loan_btn.AutoSizeLeftIcon = true;
            this.apply_loan_btn.AutoSizeRightIcon = true;
            this.apply_loan_btn.BackColor = System.Drawing.Color.Transparent;
            this.apply_loan_btn.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.apply_loan_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apply_loan_btn.BackgroundImage")));
            this.apply_loan_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply_loan_btn.ButtonText = "Apply";
            this.apply_loan_btn.ButtonTextMarginLeft = 0;
            this.apply_loan_btn.ColorContrastOnClick = 45;
            this.apply_loan_btn.ColorContrastOnHover = 45;
            this.apply_loan_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.apply_loan_btn.CustomizableEdges = borderEdges2;
            this.apply_loan_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.apply_loan_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.apply_loan_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.apply_loan_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.apply_loan_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apply_loan_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.apply_loan_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.apply_loan_btn.ForeColor = System.Drawing.Color.White;
            this.apply_loan_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apply_loan_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.apply_loan_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.apply_loan_btn.IconMarginLeft = 11;
            this.apply_loan_btn.IconPadding = 10;
            this.apply_loan_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apply_loan_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.apply_loan_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.apply_loan_btn.IconSize = 25;
            this.apply_loan_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.apply_loan_btn.IdleBorderRadius = 30;
            this.apply_loan_btn.IdleBorderThickness = 1;
            this.apply_loan_btn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.apply_loan_btn.IdleIconLeftImage = null;
            this.apply_loan_btn.IdleIconRightImage = null;
            this.apply_loan_btn.IndicateFocus = false;
            this.apply_loan_btn.Location = new System.Drawing.Point(4, 4);
            this.apply_loan_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apply_loan_btn.Name = "apply_loan_btn";
            this.apply_loan_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.apply_loan_btn.OnDisabledState.BorderRadius = 30;
            this.apply_loan_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply_loan_btn.OnDisabledState.BorderThickness = 1;
            this.apply_loan_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.apply_loan_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.apply_loan_btn.OnDisabledState.IconLeftImage = null;
            this.apply_loan_btn.OnDisabledState.IconRightImage = null;
            this.apply_loan_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.apply_loan_btn.onHoverState.BorderRadius = 30;
            this.apply_loan_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply_loan_btn.onHoverState.BorderThickness = 1;
            this.apply_loan_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.apply_loan_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.apply_loan_btn.onHoverState.IconLeftImage = null;
            this.apply_loan_btn.onHoverState.IconRightImage = null;
            this.apply_loan_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.apply_loan_btn.OnIdleState.BorderRadius = 30;
            this.apply_loan_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply_loan_btn.OnIdleState.BorderThickness = 1;
            this.apply_loan_btn.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.apply_loan_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.apply_loan_btn.OnIdleState.IconLeftImage = null;
            this.apply_loan_btn.OnIdleState.IconRightImage = null;
            this.apply_loan_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.apply_loan_btn.OnPressedState.BorderRadius = 30;
            this.apply_loan_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply_loan_btn.OnPressedState.BorderThickness = 1;
            this.apply_loan_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.apply_loan_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.apply_loan_btn.OnPressedState.IconLeftImage = null;
            this.apply_loan_btn.OnPressedState.IconRightImage = null;
            this.apply_loan_btn.Size = new System.Drawing.Size(817, 55);
            this.apply_loan_btn.TabIndex = 51;
            this.apply_loan_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apply_loan_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.apply_loan_btn.TextMarginLeft = 0;
            this.apply_loan_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.apply_loan_btn.UseDefaultRadiusAndThickness = true;
            this.apply_loan_btn.Click += new System.EventHandler(this.apply_loan_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.loan_title_label, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 67);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // loan_title_label
            // 
            this.loan_title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loan_title_label.AutoSize = true;
            this.loan_title_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_title_label.Location = new System.Drawing.Point(509, 14);
            this.loan_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loan_title_label.Name = "loan_title_label";
            this.loan_title_label.Size = new System.Drawing.Size(239, 38);
            this.loan_title_label.TabIndex = 2;
            this.loan_title_label.Text = "Loan Application";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.apply_loan_btn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(225, 444);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(825, 63);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // Employee_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 633);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.laon_app_table);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Employee_Loan";
            this.Text = "Employee_Loan";
            this.Load += new System.EventHandler(this.Employee_Loan_Load);
            this.laon_app_table.ResumeLayout(false);
            this.laon_app_table.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel laon_app_table;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label currentDate;
        private Guna.UI2.WinForms.Guna2TextBox purposeLoan;
        private System.Windows.Forms.Label employeeName;
        private Guna.UI2.WinForms.Guna2TextBox loanAmount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton apply_loan_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label loan_title_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}