using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_DB_Project
{
    public partial class Update_Date : Form
    {
        public Update_Date()
        {
            InitializeComponent();
        }

        private void date_refresh_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM AttendanceDate", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            show_date_grid.DataSource = dt;
            show_date_grid.Columns["Id"].Visible = false;
        }

        private void date_update_Click(object sender, EventArgs e)
        {
            int rowIndex = show_date_grid.CurrentCell.RowIndex;
            int colIndex = show_date_grid.CurrentCell.ColumnIndex;
            var con = Configuration.getInstance().getConnection();
            string columnHeader = show_date_grid.Columns[colIndex].HeaderText;
            //to get values of tuple from datagrid
            string date_id = show_date_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string date = show_date_grid.Rows[rowIndex].Cells[1].Value.ToString();
            SqlCommand cmd10 = new SqlCommand("Update AttendanceDate SET Date = @Date WHERE Id = @ID", con);
            cmd10.Parameters.AddWithValue("@ID", int.Parse(date_id));
            cmd10.Parameters.AddWithValue("@Date", DateTime.Parse(date));
            SqlDataAdapter da5 = new SqlDataAdapter(cmd10);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            MessageBox.Show("Successfully Updated");
            show_date_grid.DataSource = dt5;
        }

        private void date_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = show_date_grid.CurrentCell.RowIndex;
            int colIndex = show_date_grid.CurrentCell.ColumnIndex;
            var con = Configuration.getInstance().getConnection();
            string columnHeader = show_date_grid.Columns[colIndex].HeaderText;
            //to get values of tuple from datagrid
            string date_id = show_date_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string date = show_date_grid.Rows[rowIndex].Cells[1].Value.ToString();
            SqlCommand cmd10 = new SqlCommand("DELETE FROM AttendanceStatus WHERE [Attendance ID] = @ID;DELETE FROM AttendanceDate WHERE Id = @ID", con);
            cmd10.Parameters.AddWithValue("@ID", int.Parse(date_id));
            SqlDataAdapter da5 = new SqlDataAdapter(cmd10);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            MessageBox.Show("Successfully Deleted");
            show_date_grid.DataSource = dt5;
        }

        private void Update_Date_Load(object sender, EventArgs e)
        {

        }
    }
}
