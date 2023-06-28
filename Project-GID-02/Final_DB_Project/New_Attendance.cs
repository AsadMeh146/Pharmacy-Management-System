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
    public partial class New_Attendance : Form
    {
        int pharId = Form2.return_PharId();
        int get_id = 0;
        int get_status_id = 0;
        bool attenFound = false;
        int checkLoop = 0;
        Dictionary<string, string> getEmp = null;
        public New_Attendance()
        {
            InitializeComponent();
        }

        private void attendance_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var con = Configuration.getInstance().getConnection();
            int get_id = 0;
            SqlCommand cmd3 = new SqlCommand("SELECT Id,Date FROM AttendanceDate ", con);
            SqlDataReader DR3 = cmd3.ExecuteReader();

            while (DR3.Read())
            {
                if (DateTime.Parse(DR3["Date"].ToString()) == DateTime.Parse(attendance_box.SelectedItem.ToString()))
                {
                    get_id = int.Parse(DR3["Id"].ToString());
                }
            }
            DR3.Close();
            SqlCommand cmd = new SqlCommand(" SELECT EmployeeDetails.RegistrationNumber,EmployeeDetails.Name FROM (SELECT RegistrationNumber FROM EmployeeDetails EXCEPT ( SELECT [Employee ID] FROM AttendanceStatus WHERE [Attendance ID] = @searchId)) AS R1 INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber AND EmployeeDetails.Status = (SELECT Id FROM Lookup WHERE Name = 'Active') AND EmployeeDetails.[Pharmacy Id] = @PharId", con);
            cmd.Parameters.AddWithValue("@searchID", get_id);
            cmd.Parameters.AddWithValue("@PharId", pharId);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            
            emp_data_view.DataSource = dt5;
            emp_data_view.Visible = true;
            
        }
        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        public void addButtonsInColumns()
        {
            btn.Name = "Status";
            btn.Text = "Absent";
            btn.UseColumnTextForButtonValue = true;
            emp_data_view.Columns.Insert(2, btn);
            
            
        }
        private void New_Attendance_Load(object sender, EventArgs e)
        {
            attendance_box.Items.Clear();
            var con = Configuration.getInstance().getConnection();
 
            SqlCommand cmd = new SqlCommand(" SELECT EmployeeDetails.RegistrationNumber,EmployeeDetails.Name FROM (SELECT RegistrationNumber FROM EmployeeDetails EXCEPT ( SELECT [Employee ID] FROM AttendanceStatus )) AS R1 INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber AND EmployeeDetails.Status = (SELECT Id FROM Lookup WHERE Name = 'Active') AND EmployeeDetails.[Pharmacy Id] = @PharId", con);
           
            cmd.Parameters.AddWithValue("@PharId", pharId);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            emp_data_view.DataSource = dt5;
            emp_data_view.Visible = false;
            addButtonsInColumns();
            SqlCommand cmd3 = new SqlCommand("SELECT Date FROM AttendanceDate", con);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                attendance_box.Items.Add(DR3[0]);
            }
            DR3.Close();
           
        }

        private void emp_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = emp_data_view.CurrentCell.RowIndex;
            int colIndex = emp_data_view.CurrentCell.ColumnIndex;
            var con = Configuration.getInstance().getConnection();
            string columnHeader = emp_data_view.Columns[colIndex].HeaderText;
            string date_id = emp_data_view.Rows[rowIndex].Cells[1].Value.ToString();
            
        }

        private void emp_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == emp_data_view.Columns["Status"].Index && e.RowIndex >= 0)
            {
                checkLoop = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Insert_Att", con);
                t7_cmd.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("SELECT Id,Date FROM AttendanceDate ", con);
                SqlDataReader DR3 = cmd3.ExecuteReader();
                while (DR3.Read())
                {
                    if (DateTime.Parse(DR3["Date"].ToString()) == DateTime.Parse(attendance_box.SelectedItem.ToString()))
                    {
                        get_id = int.Parse(DR3["Id"].ToString());
                    }
                }
                DR3.Close();
                SqlCommand cmd4 = new SqlCommand("SELECT Id,Name FROM Lookup WHERE Name = 'Absent' ", con);
                SqlDataReader DR4 = cmd4.ExecuteReader();
                
                while (DR4.Read())
                {
                    get_status_id = int.Parse(DR4["Id"].ToString());
                }
                DR4.Close();
                int rowIndex = emp_data_view.CurrentCell.RowIndex;
                int colIndex = emp_data_view.CurrentCell.ColumnIndex;
                string emp_id = emp_data_view.Rows[rowIndex].Cells[1].Value.ToString();
                SqlCommand cmd5 = new SqlCommand("SELECT [Employee ID] AS EmpId,[Attendance ID] AS AttenId FROM AttendanceStatus ", con);
                SqlDataReader DR5 = cmd5.ExecuteReader();
                while (DR5.Read())
                {
                    if (get_id == int.Parse(DR5["AttenId"].ToString()) && int.Parse(emp_id) == int.Parse(DR5["EmpId"].ToString()))
                    {
                        attenFound = true;
                        break;
                    }
                    else
                    {
                        attenFound = false;
                    }
                }
                DR5.Close();
                if (attenFound == false)
                {
                    checkLoop = 1;
                    SqlCommand cmd = new SqlCommand("Insert into AttendanceStatus values (@Emp_Id,@Att_Id,@Status_Id)", con);
                    cmd.Parameters.AddWithValue("@Emp_Id", int.Parse(emp_id));
                    cmd.Parameters.AddWithValue("@Status_Id", get_status_id);
                    cmd.Parameters.AddWithValue("@Att_Id", get_id);
                    cmd.ExecuteNonQuery();

                }
                if (checkLoop == 1)
                {
                    SqlCommand t8_cmd = new SqlCommand("COMMIT TRAN Insert_Att", con);
                    t8_cmd.ExecuteNonQuery();
                }
                else if (checkLoop == 0)
                {
                    SqlCommand t8_cmd = new SqlCommand("ROLLBACK TRAN Insert_Att", con);
                    t8_cmd.ExecuteNonQuery();
                }
                else if (attenFound == true)
                {
                    MessageBox.Show("Attendance of this employee is already marked");
                }


            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            getEmp = new Dictionary<string, string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand t7_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  BEGIN TRAN Insert_Att1", con);
            t7_cmd.ExecuteNonQuery();
            checkLoop = 0;
            SqlCommand cmd3 = new SqlCommand("SELECT Id,Date FROM AttendanceDate ", con);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                if (DateTime.Parse(DR3["Date"].ToString()) == DateTime.Parse(attendance_box.SelectedItem.ToString()))
                {
                    get_id = int.Parse(DR3["Id"].ToString());
                }
            }
            DR3.Close();

            SqlCommand cmd5 = new SqlCommand("SELECT Id FROM Lookup WHERE Name = 'Present' ", con);
            SqlDataReader DR5 = cmd5.ExecuteReader();
            while (DR5.Read())
            {
                get_status_id = int.Parse(DR5["Id"].ToString());
            }
            DR5.Close();

            SqlCommand cmd4 = new SqlCommand("SELECT EmployeeDetails.RegistrationNumber,EmployeeDetails.Name FROM (SELECT RegistrationNumber FROM EmployeeDetails EXCEPT ( SELECT [Employee ID] FROM AttendanceStatus WHERE [Attendance ID] = @searchId AND [Attendance Status] = (SELECT Id FROM Lookup WHERE Name = 'Absent'))) AS R1 INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber AND EmployeeDetails.Status = (SELECT Id FROM Lookup WHERE Name = 'Active') AND EmployeeDetails.[Pharmacy Id] = @pharId ", con);
            cmd4.Parameters.AddWithValue("@pharId", pharId);
            cmd4.Parameters.AddWithValue("@searchId", get_id);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd4);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            foreach (DataRow rows in dt5.Rows)
            {
                getEmp.Add(rows["RegistrationNumber"].ToString(), rows["Name"].ToString());
            }
            foreach (KeyValuePair<string, string> get_Emp in getEmp)
            {
                SqlCommand cmd = new SqlCommand("Insert into AttendanceStatus values (@Emp_Id,@Att_Id,@Status_Id)", con);
                cmd.Parameters.AddWithValue("@Emp_Id", int.Parse(get_Emp.Key));
                cmd.Parameters.AddWithValue("@Status_Id", get_status_id);
                cmd.Parameters.AddWithValue("@Att_Id", get_id);
                cmd.ExecuteNonQuery();
                checkLoop = 1;
            }
            if (checkLoop == 1)
            {
                MessageBox.Show("Attendance Saved Successfully");
                SqlCommand t8_cmd = new SqlCommand("COMMIT TRAN Insert_Att1", con);
                t8_cmd.ExecuteNonQuery();
            }
            else if (checkLoop == 0)
            {
                SqlCommand t8_cmd = new SqlCommand("ROLLBACK TRAN Insert_Att1", con);
                t8_cmd.ExecuteNonQuery();
            }
            
        }
    }
}
