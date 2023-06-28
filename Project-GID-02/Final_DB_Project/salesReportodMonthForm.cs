using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_DB_Project
{
    public partial class salesReportodMonthForm : Form
    {
        public salesReportodMonthForm()
        {
            InitializeComponent();
        }

        private void salesReportodMonthForm_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = @"sales_Report_of_month.rpt";
            string fpath = Path.Combine(path, reportpath);
            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
