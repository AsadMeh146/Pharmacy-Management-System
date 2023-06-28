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
    public partial class View_Update_Employee : Form
    {
        int pharId = Form2.return_PharId();
        int status_id = 0;
        int checkLoop = 0;
        public View_Update_Employee()
        {
            InitializeComponent();
        }

        private void guna2Button1026_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
          
            SqlCommand cmd = new SqlCommand("SELECT Pharmacy.Id,EmployeeDetails.RegistrationNumber,EmployeeDetails.Name,EmployeeDetails.PIN,EmployeeDetails.CNIC,EmployeeDetails.Gender,EmployeeDetails.Salary,R2.Designation,EmployeeDetails.[Date Of Birth],EmployeeDetails.City,EmployeeDetails.Country,EmployeeDetails.Address,Pharmacy.Location,R1.Status,EmployeeDetails.[Hire Date],EmployeeDetails.Email,EmployeeDetails.ContactNumber FROM(SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Status FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.Status = Lookup.Id) AS R1 INNER JOIN (SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Designation FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.[Designation] = Lookup.Id) AS R2 ON R1.RegistrationNumber = R2.RegistrationNumber INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber INNER JOIN Pharmacy ON EmployeeDetails.[Pharmacy Id] = Pharmacy.Id WHERE Pharmacy.Id = @pharId", con);
            cmd.Parameters.AddWithValue("@pharId", pharId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            show_emp_grid.DataSource = dt;
            show_emp_grid.Columns["Id"].Visible = false;
            show_emp_grid.Columns["RegistrationNumber"].Visible = false;
        }

        private void guna2Button1025_Click(object sender, EventArgs e)
        {
            checkLoop = 0;   
            var con = Configuration.getInstance().getConnection();
            
            int rowIndex = show_emp_grid.CurrentCell.RowIndex;
            int colIndex = show_emp_grid.CurrentCell.ColumnIndex;
            bool checkCNIC = false;
            bool checkEmail = false;
            bool checkContact = false;
            bool adminFound = false;
            bool checkPhar = false;
            bool designCheck = false;
            bool checkStatus = false;
            bool pharCheck = false;
            bool noAdmin = false;
            bool checkDate = false;
            int pharmacy = 0;
            Dictionary<string, string> getLookup = new Dictionary<string, string>();
            Dictionary<string, string> getPharmacy = new Dictionary<string, string>();
            Dictionary<string, string> getStatus = new Dictionary<string, string>();
         
            SqlCommand cmd8 = new SqlCommand("SELECT Id,Name FROM LookUp", con);
            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            foreach (DataRow row in dt8.Rows)
            {
                getStatus.Add(row["Id"].ToString(), row["Name"].ToString());
            }
            //string updateValue = show_emp_grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            //string query = columnHeader + " =@" + columnHeader;

            string columnHeader = show_emp_grid.Columns[colIndex].HeaderText;
            //to get values of tuple from datagrid
            string emp_phid = show_emp_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string emp_id = show_emp_grid.Rows[rowIndex].Cells[1].Value.ToString();
            string emp_name = show_emp_grid.Rows[rowIndex].Cells[2].Value.ToString();
            string emp_pin = show_emp_grid.Rows[rowIndex].Cells[3].Value.ToString();
            string emp_cnic = show_emp_grid.Rows[rowIndex].Cells[4].Value.ToString();
            string emp_gender = show_emp_grid.Rows[rowIndex].Cells[5].Value.ToString();
            string emp_salary = show_emp_grid.Rows[rowIndex].Cells[6].Value.ToString();
            string emp_designation = show_emp_grid.Rows[rowIndex].Cells[7].Value.ToString();
            string emp_dob = show_emp_grid.Rows[rowIndex].Cells[8].Value.ToString();
            string emp_city = show_emp_grid.Rows[rowIndex].Cells[9].Value.ToString();
            string emp_country = show_emp_grid.Rows[rowIndex].Cells[10].Value.ToString();
            string emp_address = show_emp_grid.Rows[rowIndex].Cells[11].Value.ToString();
            string emp_pharid = show_emp_grid.Rows[rowIndex].Cells[12].Value.ToString();
            string emp_status = show_emp_grid.Rows[rowIndex].Cells[13].Value.ToString();
            string emp_hiredate = show_emp_grid.Rows[rowIndex].Cells[14].Value.ToString();
            string emp_email = show_emp_grid.Rows[rowIndex].Cells[15].Value.ToString();
            string emp_contactnumber = show_emp_grid.Rows[rowIndex].Cells[16].Value.ToString();

            // to check email contact cnic designation already exists or not
            SqlCommand cmd1 = new SqlCommand("SELECT CNIC FROM EmployeeDetails WHERE RegistrationNumber <> @Id", con);
            cmd1.Parameters.AddWithValue("@Id", emp_id);
            SqlDataReader myReader = cmd1.ExecuteReader();
            while (myReader.Read())
            {
                if (emp_cnic == myReader.GetValue(0).ToString())
                {
                    checkCNIC = true;
                    break;
                }
            }
            myReader.Close();


            SqlCommand cmd3 = new SqlCommand("SELECT Email FROM EmployeeDetails  WHERE RegistrationNumber <> @Id", con);
            cmd3.Parameters.AddWithValue("@Id", emp_id);
            SqlDataReader myReader2 = cmd3.ExecuteReader();
            while (myReader2.Read())
            {
                if (emp_email == myReader2.GetValue(0).ToString())
                {
                    checkEmail = true;
                    break;
                }
            }
            myReader2.Close();
            SqlCommand cmd4 = new SqlCommand("SELECT ContactNumber FROM EmployeeDetails  WHERE RegistrationNumber <> @Id", con);
            cmd4.Parameters.AddWithValue("@Id", emp_id);
            SqlDataReader myReader3 = cmd4.ExecuteReader();
            while (myReader3.Read())
            {
                if (emp_contactnumber == myReader3.GetValue(0).ToString())
                {
                    checkContact = true;
                    break;
                }
            }
            myReader3.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT Designation FROM EmployeeDetails WHERE RegistrationNumber <> @Id AND Designation = 'Admin' AND [Pharmacy Id] = @PharId", con);
            cmd2.Parameters.AddWithValue("@Id", emp_id);
            cmd2.Parameters.AddWithValue("@PharId", pharId);
            SqlDataReader myReader1 = cmd2.ExecuteReader();
            if (myReader1.HasRows && columnHeader == "Designation")
            {
                while (myReader1.Read())
                {
                    if (emp_designation == myReader1.GetValue(0).ToString())
                    {
                        adminFound = true;

                        break;
                    }
                }
            }
            else if (!(myReader1.HasRows) && columnHeader != "Designation")
            {
                noAdmin = false;
            }
            else if (!(myReader1.HasRows) && columnHeader == "Designation")
            {
                noAdmin = true;
            }

            myReader1.Close();

            SqlCommand cmd5 = new SqlCommand("SELECT Location FROM Pharmacy WHERE Id <> @Id", con);
            cmd5.Parameters.AddWithValue("@Id", emp_phid);
            SqlDataReader myReader4 = cmd5.ExecuteReader();
            while (myReader4.Read())
            {
                if (emp_pharid != myReader4.GetValue(0).ToString())
                {
                    checkPhar = true;
                }
                else
                {
                    checkPhar = false;
                }
            }
            myReader4.Close();
            SqlCommand cmd7 = new SqlCommand("SELECT Name FROM Lookup ", con);
            SqlDataReader myReader5 = cmd7.ExecuteReader();
            while (myReader5.Read())
            {
                if (emp_status != myReader5.GetValue(0).ToString())
                {
                    checkStatus = true;
                }
                else
                {
                    checkStatus = false;
                    break;
                }

            }
            myReader5.Close();
            //desginationCheck = new Dictionary<string, string>();
            //SqlCommand cmd6 = new SqlCommand("SELECT Name FROM LookUp WHERE Category = 'EMPLOYEE_DESIGNATION' ", con);
            //SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            //DataTable dt6 = new DataTable();
            //da6.Fill(dt6);
            //foreach (DataRow rows in dt6.Rows)
            //{
            //    desginationCheck.Add(rows["Name"].ToString(), rows["Name"].ToString());
            //}
            SqlCommand cmd11 = new SqlCommand("SELECT Id,Name FROM Lookup", con);
            SqlDataAdapter da10 = new SqlDataAdapter(cmd11);
            DataTable dt10 = new DataTable();
            da10.Fill(dt10);
            foreach (DataRow rows in dt10.Rows)
            {
                getLookup.Add(rows["Id"].ToString(), rows["Name"].ToString());
            }
            foreach (KeyValuePair<string, string> getKeys in getLookup)
            {
                if (getKeys.Value != emp_designation)
                {
                    designCheck = true;
                }
                else
                {
                    designCheck = false;
                    break;
                }
            }
            if (DateTime.Parse(emp_dob) >= DateTime.Parse(emp_hiredate))
            {
                checkDate = true;
            }

            //SqlCommand cmd11 = new SqlCommand("SELECT Id,Name FROM Lookup", con);
            //SqlDataAdapter da10 = new SqlDataAdapter(cmd11);
            //DataTable dt10 = new DataTable();
            //da10.Fill(dt10);
            //foreach (DataRow rows in dt10.Rows)
            //{
            //    getLookup.Add(rows["Id"].ToString(), rows["Name"].ToString());
            //}

            SqlCommand cmd12 = new SqlCommand("SELECT Id,Location FROM Pharmacy", con);
            SqlDataAdapter da9 = new SqlDataAdapter(cmd12);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);
            foreach (DataRow rows in dt9.Rows)
            {
                getPharmacy.Add(rows["Id"].ToString(), rows["Location"].ToString());
            }


            //foreach (KeyValuePair<string, string> getKeys in getLookup)
            //{
            //    if (getKeys.Value != emp_gender)
            //    {
            //        genderCheck = true;

            //    }
            //    else
            //    {
            //        genderCheck = false;
            //        break;
            //    }

            //}
            foreach (KeyValuePair<string, string> getKeys in getPharmacy)
            {
                if (emp_pharid != getKeys.Value)
                {
                    pharCheck = true;

                }
                else
                {
                    pharCheck = false;
                    break;
                }
            }
            if (checkStatus == false)
            {
                foreach (KeyValuePair<string, string> getKeys in getStatus)
                {
                    if (getKeys.Value == emp_status)
                    {
                        status_id = int.Parse(getKeys.Key);
                    }

                }

            }
            if (pharCheck == false)
            {
                foreach (KeyValuePair<string, string> getKeys in getPharmacy)
                {
                    if (getKeys.Value == emp_pharid)
                    {
                        pharmacy = int.Parse(getKeys.Key);
                    }

                }
                //pharmacy = int.Parse(getPharmacy[emp_pharid]);
            }

            //if (genderCheck == false)
            //{
            //    foreach (KeyValuePair<string, string> getKeys in getLookup)
            //    {
            //        if (getKeys.Value == emp_gender)
            //        {
            //            gender = int.Parse(getKeys.Key);
            //        }

            //    }

            //}

            if (checkContact == false && checkCNIC == false && checkEmail == false && checkDate == false && checkPhar == false && adminFound == false && designCheck == false && pharCheck == false && noAdmin == false && columnHeader != "Gender")
            {
                checkLoop = 1;
                SqlCommand getId = new SqlCommand("SELECT Id FROM Lookup WHERE Name = @name", con);
                getId.Parameters.AddWithValue("@name", emp_designation);
                SqlCommand cmd10 = new SqlCommand("Update EmployeeDetails SET Name = @Name,PIN =  @PIN,CNIC = @CNIC,Gender = @Gender,Salary = @Salary,Designation = @Designation,[Date Of Birth] = @DOB,City = @City,Country = @Country,Address = @Address,[Pharmacy Id] = @PharId,Status = @Status,[Hire Date] = @HireDate , Email = @Email , ContactNumber = @Contact WHERE RegistrationNumber = @ID", con);
                cmd10.Parameters.AddWithValue("@ID", int.Parse(emp_id));
                cmd10.Parameters.AddWithValue("@Name", emp_name);
                cmd10.Parameters.AddWithValue("@PIN", emp_pin);
                cmd10.Parameters.AddWithValue("@CNIC", emp_cnic);
                cmd10.Parameters.AddWithValue("@Gender", emp_gender);
                cmd10.Parameters.AddWithValue("@Salary", int.Parse(emp_salary));
                cmd10.Parameters.AddWithValue("@Designation", int.Parse(getId.ExecuteScalar().ToString()));
                cmd10.Parameters.AddWithValue("@DOB", DateTime.Parse(emp_dob));
                cmd10.Parameters.AddWithValue("@City", emp_city);
                cmd10.Parameters.AddWithValue("@Country", emp_country);
                cmd10.Parameters.AddWithValue("@Address", emp_address);
                cmd10.Parameters.AddWithValue("@PharId", pharmacy);
                cmd10.Parameters.AddWithValue("@Status", status_id);
                cmd10.Parameters.AddWithValue("@HireDate", DateTime.Parse(emp_hiredate));
                cmd10.Parameters.AddWithValue("@Email", emp_email);
                cmd10.Parameters.AddWithValue("@Contact", emp_contactnumber);
                SqlDataAdapter da5 = new SqlDataAdapter(cmd10);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                MessageBox.Show("Successfully Updated");
                show_emp_grid.DataSource = dt5;
            }
            
            if (checkEmail == true)
            {
                MessageBox.Show("Same Email already exists");
                refreshEmployee();
            }
            if (checkDate == true)
            {
                MessageBox.Show("Date is not valid exists");
                refreshEmployee();
            }
            if (checkContact == true)
            {
                MessageBox.Show("Same Contact already exists");
                refreshEmployee();
            }
            if (checkCNIC == true)
            {
                MessageBox.Show("Same CNIC already exists");
                refreshEmployee();
            }
            if (checkPhar == true)
            {
                MessageBox.Show("Pharmacy not exist");
                refreshEmployee();
            }
            if (adminFound == true)
            {
                MessageBox.Show("Admin already exist in that pharmacy");
                refreshEmployee();
            }
            if (designCheck == true)
            {
                MessageBox.Show("Designation not exist in that pharmacy");
                refreshEmployee();
            }
            if (noAdmin == true)
            {
                MessageBox.Show("You cannot change designation of this employee");
                refreshEmployee();
            }
            if (checkStatus == true)
            {
                MessageBox.Show("Invalid status");
                refreshEmployee();
            }

            if (pharCheck == true)
            {
                MessageBox.Show("Invalid Pharmacy");
                refreshEmployee();

            }
            if (columnHeader == "Gender")
            {
                MessageBox.Show("You cannot change gender of employee");
                refreshEmployee();
            }
        }
        private void refreshEmployee()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Pharmacy.Id,EmployeeDetails.RegistrationNumber,EmployeeDetails.Name,EmployeeDetails.PIN,EmployeeDetails.CNIC,EmployeeDetails.Gender,EmployeeDetails.Salary,R2.Designation,EmployeeDetails.[Date Of Birth],EmployeeDetails.City,EmployeeDetails.Country,EmployeeDetails.Address,Pharmacy.Location,R1.Status,EmployeeDetails.[Hire Date],EmployeeDetails.Email,EmployeeDetails.ContactNumber FROM(SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Status FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.Status = Lookup.Id) AS R1 INNER JOIN (SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Designation FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.[Designation] = Lookup.Id) AS R2 ON R1.RegistrationNumber = R2.RegistrationNumber INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber INNER JOIN Pharmacy ON EmployeeDetails.[Pharmacy Id] = Pharmacy.Id WHERE Pharmacy.Id = @pharId", con);
            cmd.Parameters.AddWithValue("@pharId", pharId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            show_emp_grid.DataSource = dt;
            show_emp_grid.Columns["Id"].Visible = false;
            show_emp_grid.Columns["RegistrationNumber"].Visible = false;
        }

        private void guna2Button1028_Click(object sender, EventArgs e)
        {
            bool isFound = false;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Pharmacy.Id,EmployeeDetails.RegistrationNumber,EmployeeDetails.Name,EmployeeDetails.PIN,EmployeeDetails.CNIC,EmployeeDetails.Gender,EmployeeDetails.Salary,R2.Designation,EmployeeDetails.[Date Of Birth],EmployeeDetails.City,EmployeeDetails.Country,EmployeeDetails.Address,Pharmacy.Location,R1.Status,EmployeeDetails.[Hire Date],EmployeeDetails.Email,EmployeeDetails.ContactNumber FROM(SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Status FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.Status = Lookup.Id) AS R1 INNER JOIN (SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Designation FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.[Designation] = Lookup.Id) AS R2 ON R1.RegistrationNumber = R2.RegistrationNumber INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber INNER JOIN Pharmacy ON EmployeeDetails.[Pharmacy Id] = Pharmacy.Id WHERE Pharmacy.Id = @pharId", con);
            cmd.Parameters.AddWithValue("@pharId", pharId);
            cmd.Parameters.AddWithValue("@Name", search_emp.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow rows in dt.Rows)
            {
                if (rows["RegistrationNumber"].ToString() == "")
                {
                    isFound = true;
                }
            }
            if (isFound == true)
            {
                MessageBox.Show("Employee not found");
            }
            else
            {
                show_emp_grid.DataSource = dt;
                show_emp_grid.Columns["Id"].Visible = false;
                show_emp_grid.Columns["RegistrationNumber"].Visible = false;
            }
        }
        private void showEmployeeData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Pharmacy.Id,EmployeeDetails.RegistrationNumber,EmployeeDetails.Name,EmployeeDetails.PIN,EmployeeDetails.CNIC,EmployeeDetails.Gender,EmployeeDetails.Salary,R2.Designation,EmployeeDetails.[Date Of Birth],EmployeeDetails.City,EmployeeDetails.Country,EmployeeDetails.Address,Pharmacy.Location,R1.Status,EmployeeDetails.[Hire Date],EmployeeDetails.Email,EmployeeDetails.ContactNumber FROM(SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Status FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.Status = Lookup.Id) AS R1 INNER JOIN (SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Designation FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.[Designation] = Lookup.Id) AS R2 ON R1.RegistrationNumber = R2.RegistrationNumber INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber INNER JOIN Pharmacy ON EmployeeDetails.[Pharmacy Id] = Pharmacy.Id WHERE Pharmacy.Id = @pharId", con);
            cmd.Parameters.AddWithValue("@pharId", pharId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            show_emp_grid.DataSource = dt;
            show_emp_grid.Columns["Id"].Visible = false;
            show_emp_grid.Columns["RegistrationNumber"].Visible = false;
        }
        private void View_Update_Employee_Load(object sender, EventArgs e)
        {
            showEmployeeData();
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1027_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = show_emp_grid.CurrentCell.RowIndex;
            int colIndex = show_emp_grid.CurrentCell.ColumnIndex;
            string emp_id = show_emp_grid.Rows[rowIndex].Cells[1].Value.ToString();
            string emp_designation = show_emp_grid.Rows[rowIndex].Cells[7].Value.ToString();
            if (emp_designation == "Admin")
            {
                MessageBox.Show("You cannot delete admin");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeDetails WHERE RegistrationNumber = @Id", con);
                cmd.Parameters.AddWithValue("@Id", emp_id);
            }
            

        }
    }
}
