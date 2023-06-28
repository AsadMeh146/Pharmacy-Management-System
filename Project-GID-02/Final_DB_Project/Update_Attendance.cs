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
    public partial class Update_Attendance : Form
    {
        int pharId = Form2.return_PharId();
        int checkLoop1 = 0;
        int checkLoop = 0;
        public Update_Attendance()
        {
            InitializeComponent();
        }

        private void refresh_attendance_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT EmployeeDetails.RegistrationNumber,AttendanceDate.Id,EmployeeDetails.Name,AttendanceDate.Date,Lookup.Name AS Status FROM AttendanceStatus INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = AttendanceStatus.[Employee ID] INNER JOIN AttendanceDate ON AttendanceStatus.[Attendance ID] = AttendanceDate.Id INNER JOIN Lookup ON Lookup.Id = AttendanceStatus.[Attendance Status] WHERE EmployeeDetails.[Pharmacy Id] = @PharId", con);
            cmd.Parameters.AddWithValue("@PharId", pharId);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            update_atten_grid.DataSource = dt5;
            update_atten_grid.Columns["RegistrationNumber"].Visible = false;
            update_atten_grid.Columns["Id"].Visible = false;
        }
        private void refreshAttendance()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT EmployeeDetails.RegistrationNumber,AttendanceDate.Id,EmployeeDetails.Name,AttendanceDate.Date,Lookup.Name AS Status FROM AttendanceStatus INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = AttendanceStatus.[Employee ID] INNER JOIN AttendanceDate ON AttendanceStatus.[Attendance ID] = AttendanceDate.Id INNER JOIN Lookup ON Lookup.Id = AttendanceStatus.[Attendance Status] WHERE EmployeeDetails.[Pharmacy Id] = @PharId", con);
            cmd.Parameters.AddWithValue("@PharId", pharId);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            update_atten_grid.DataSource = dt5;
            update_atten_grid.Columns["RegistrationNumber"].Visible = false;
            update_atten_grid.Columns["Id"].Visible = false;
        }
        private void update_attedance_btn_Click(object sender, EventArgs e)
        {
            checkLoop = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Update_Atten", con);
            t7_cmd.ExecuteNonQuery();
            int rowIndex = update_atten_grid.CurrentCell.RowIndex;
            int colIndex = update_atten_grid.CurrentCell.ColumnIndex;
            string columnHeader = update_atten_grid.Columns[colIndex].HeaderText;
            int id = 0;
            bool getStatus = false;
            if (columnHeader == "Name" || columnHeader == "Date")
            {
                MessageBox.Show("You cannot change this value");
            }
            else
            {
                string emp_id = update_atten_grid.Rows[rowIndex].Cells[0].Value.ToString();
                string att_id = update_atten_grid.Rows[rowIndex].Cells[1].Value.ToString();
                string att_status = update_atten_grid.Rows[rowIndex].Cells[4].Value.ToString();
                SqlCommand cmd3 = new SqlCommand("SELECT Id,Name FROM Lookup WHERE Category = 'ATTENDANCE_STATUS' ", con);
                SqlDataReader DR3 = cmd3.ExecuteReader();

                while (DR3.Read())
                {
                    if (DR3["Name"].ToString() == att_status)
                    {
                        id = int.Parse(DR3["Id"].ToString());
                        getStatus = true;
                        break;
                    }
                    else
                    {
                        getStatus = false;
                    }
                }
                DR3.Close();
                if (getStatus == true)
                {
                    SqlCommand cmd10 = new SqlCommand("Update AttendanceStatus SET [Attendance Status] = @Status WHERE [Employee ID] = @ID AND [Attendance Id] = @AttenId", con);
                    cmd10.Parameters.AddWithValue("@ID", int.Parse(emp_id));
                    cmd10.Parameters.AddWithValue("@AttenId", int.Parse(att_id));
                    cmd10.Parameters.AddWithValue("@Status", id);
                    SqlDataAdapter da5 = new SqlDataAdapter(cmd10);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    checkLoop = 1;
                    MessageBox.Show("Successfully Updated");
                    update_atten_grid.DataSource = dt5;
                }
                if (checkLoop == 1)
                {
                    SqlCommand t11_cmd = new SqlCommand("COMMIT TRAN Update_Atten", con);
                    t11_cmd.ExecuteNonQuery();
                }
                else if (checkLoop == 0)
                {
                    SqlCommand t11_cmd = new SqlCommand("ROLLBACK TRAN Update_Atten", con);
                    t11_cmd.ExecuteNonQuery();
                }
                else if (getStatus == false)
                {
                    MessageBox.Show("Invalid attendance status");
                    refreshAttendance();

                }

            }
        }

        private void delete_attendance_btn_Click(object sender, EventArgs e)
        {
            checkLoop1 = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Update_Atten", con);
            t7_cmd.ExecuteNonQuery();
            int rowIndex = update_atten_grid.CurrentCell.RowIndex;
            int colIndex = update_atten_grid.CurrentCell.ColumnIndex;
            string emp_id = update_atten_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string att_id = update_atten_grid.Rows[rowIndex].Cells[1].Value.ToString();
            
            SqlCommand cmd = new SqlCommand("DELETE FROM AttendanceStatus WHERE [Employee ID] = @Name AND [Attendance ID] = @Id", con);
            cmd.Parameters.AddWithValue("@Name", int.Parse(emp_id));
            cmd.Parameters.AddWithValue("@Id", int.Parse(att_id));
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            checkLoop1 = 1;
            if (checkLoop1 == 1)
            {
                SqlCommand t11_cmd = new SqlCommand("COMMIT TRAN Update_Atten", con);
                t11_cmd.ExecuteNonQuery();
            }
            else if (checkLoop1 == 0)
            {
                SqlCommand t11_cmd = new SqlCommand("ROLLBACK TRAN Update_Atten", con);
                t11_cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Deleted successfully");
        }

        private void search_atten_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT EmployeeDetails.RegistrationNumber,AttendanceDate.Id,EmployeeDetails.Name,AttendanceDate.Date,Lookup.Name AS Status FROM AttendanceStatus INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = AttendanceStatus.[Employee ID] INNER JOIN AttendanceDate ON AttendanceStatus.[Attendance ID] = AttendanceDate.Id INNER JOIN Lookup ON Lookup.Id = AttendanceStatus.[Attendance Status] WHERE EmployeeDetails.[Pharmacy Id] = @PharId AND EmployeeDetails.Name = @Name", con);
            cmd.Parameters.AddWithValue("@PharId", pharId);
            cmd.Parameters.AddWithValue("@Name", search_name_btn.Text);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            update_atten_grid.DataSource = dt5;
            update_atten_grid.Columns["RegistrationNumber"].Visible = false;
            update_atten_grid.Columns["Id"].Visible = false;
        }

        private void Update_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}
