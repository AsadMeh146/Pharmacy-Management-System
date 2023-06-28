
namespace Final_DB_Project
{
    partial class sale_repport_of_day_form
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
            this.sales_Report_of_Day1 = new Final_DB_Project.sales_Report_of_Day();
            this.sales_Report_of_Day2 = new Final_DB_Project.sales_Report_of_Day();
            this.sales_Report_of_Day3 = new Final_DB_Project.sales_Report_of_Day();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sales_Report_of_Day4 = new Final_DB_Project.sales_Report_of_Day();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.sales_Report_of_Day4;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1333, 694);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // sale_repport_of_day_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 694);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "sale_repport_of_day_form";
            this.Text = "sale_repport_of_day_form";
            this.ResumeLayout(false);

        }

        #endregion
        private sales_Report_of_Day sales_Report_of_Day1;
        private sales_Report_of_Day sales_Report_of_Day2;
        private sales_Report_of_Day sales_Report_of_Day3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private sales_Report_of_Day sales_Report_of_Day4;
    }
}