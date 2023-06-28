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
    public partial class Add_Employee : Form
    {
        int pharId = Form2.return_PharId();
        string empl_gender = "";
        int checkLoop = 0;
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void bunifuButton1000_Click(object sender, EventArgs e)
        {
            checkLoop = 0;
            //try
            //{
                var con = Configuration.getInstance().getConnection();
                //Dictionary<string, string> getIds = null;
                Dictionary<string, string> getStatus = null;
                Dictionary<string, string> adminCheck = null;
                //getIds = new Dictionary<string, string>();
                getStatus = new Dictionary<string, string>();
                adminCheck = new Dictionary<string, string>();
                bool getFound = true;
                bool checkEmail = false;
                bool checkContact = false;
                bool checkCNIC = false;
                bool adminFound = false;
                bool checkPass = false;
                DateTime dt_dob = this.emp_dob.Value.Date;
                DateTime dt_hd = this.emp_hire_date.Value.Date;
                if (emp_name.Text != "" && emp_mail.Text != "" && emp_contactNumber.Text != "" && emp_pin.Text != "" && emp_cnic.Text != "" && emp_salary.Text != "" && emp_city.Text != "" && emp_country.Text != "" && emp_address.Text != "")
                {
                    if (!(Regex.IsMatch(emp_name.Text, @"^[a-zA-Z]+$")))
                    {
                        MessageBox.Show("Please enter valid name");
                    }
                    if (!(Regex.IsMatch(emp_pin.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$")))
                    {
                        MessageBox.Show("Please enter PIN in required format");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_city.Text, @"^[a-zA-Z]+$")))
                    {
                        MessageBox.Show("Please Enter Valid City Name");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_country.Text, @"^[a-zA-Z]+$")))
                    {
                        MessageBox.Show("Please Enter Valid Country Name");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_salary.Text, @"^[0-9]+$")))
                    {
                        MessageBox.Show("Please Enter salary in correct format");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_cnic.Text, @"^[0-9]{13}$")))
                    {
                        MessageBox.Show("Please Enter Valid CNIC");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_contactNumber.Text, @"^[0]{1}[3]{1}[0-4]{1}[0-9]{1}[0-9]{7}$")))
                    {
                        MessageBox.Show("Please Enter valid contact number");
                        getFound = false;
                    }
                    if (!(Regex.IsMatch(emp_mail.Text, @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")))
                    {
                        MessageBox.Show("Please Enter valid email address");
                        getFound = false;
                    }
                    if (dt_dob >= dt_hd)
                    {
                        MessageBox.Show("Please enter valid hire date");
                        getFound = false;
                    }

                }
                else
                {
                    MessageBox.Show("Please fill missing fields");
                    getFound = false;
                }
                if (getFound == true)
                {
                    //emp_dob.CustomFormat = "MM/dd/yyyy hh:mm:ss";
                    //emp_hire_date.CustomFormat = "MM/dd/yyyy hh:mm:ss";

                    // To get ids of status and gender from lookup using dictionary

                    //SqlCommand cmd1 = new SqlCommand("SELECT Id,Name FROM Lookup", con);
                    //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    //DataTable dt1 = new DataTable();
                    //da1.Fill(dt1);

                    //SqlCommand t1_cmd = new SqlCommand("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE begin tran Insert_Employee", con);
                    //t1_cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("SELECT Id,Name FROM Lookup WHERE Category = 'EMPLOYEE_STATUS'", con);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    SqlCommand cmdQ = new SqlCommand("SELECT RegistrationNumber,Designation FROM EmployeeDetails WHERE Designation = (SELECT Id FROM Lookup WHERE Name = 'Admin') AND [Pharmacy Id] = @PharId ", con);
                    cmdQ.Parameters.AddWithValue("@PharId", pharId);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmdQ);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    //foreach (DataRow row in dt1.Rows)
                    //{
                    //    getIds.Add(row["Id"].ToString(), row["Name"].ToString());
                    //}
                    foreach (DataRow row in dt2.Rows)
                    {
                        getStatus.Add(row["Id"].ToString(), row["Name"].ToString());
                    }
                    foreach (DataRow row in dt3.Rows)
                    {
                        adminCheck.Add(row["RegistrationNumber"].ToString(), row["Designation"].ToString());
                    }
                    //foreach (KeyValuePair<string, string> getKey in getIds)
                    //{
                    //    if (getKey.Value == emp_gender.Text)
                    //    {
                    //        employee_gender = int.Parse(getKey.Key);
                    //    }
                    //}


                    foreach (KeyValuePair<string, string> getKeys in adminCheck)
                    {
                        if (getKeys.Value == emp_designation.Text && int.Parse(emp_pharmacy.Text) == pharId)
                        {
                            adminFound = true;
                        }
                    }

                    SqlCommand passCheck = new SqlCommand("SELECT PIN FROM EmployeeDetails", con);
                    passCheck.ExecuteNonQuery();
                    SqlDataReader myreader1 = passCheck.ExecuteReader();
                    while (myreader1.Read())
                    {
                        if (emp_pin.Text == myreader1.GetValue(0).ToString())
                        {
                            checkPass = true;
                            break;
                        }
                    }
                    myreader1.Close();
                    //To check CNIC / Phone Number / Email already exists
                    SqlCommand cmd3 = new SqlCommand("SELECT CNIC FROM EmployeeDetails", con);
                    SqlDataReader myReader = cmd3.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (emp_cnic.Text == myReader.GetValue(0).ToString())
                        {
                            checkCNIC = true;
                            break;
                        }
                    }
                    myReader.Close();

                    SqlCommand cmd4 = new SqlCommand("SELECT Email FROM EmployeeDetails", con);
                    SqlDataReader myReader1 = cmd4.ExecuteReader();
                    while (myReader1.Read())
                    {
                        if (emp_mail.Text == myReader1.GetValue(0).ToString())
                        {
                            checkEmail = true;
                            break;
                        }
                    }
                    myReader1.Close();
                    SqlCommand cmd5 = new SqlCommand("SELECT ContactNumber FROM EmployeeDetails", con);
                    SqlDataReader myReader2 = cmd5.ExecuteReader();
                    while (myReader2.Read())
                    {
                        if (emp_contactNumber.Text == myReader2.GetValue(0).ToString())
                        {
                            checkContact = true;
                            break;
                        }
                    }
                    myReader2.Close();

                    if (checkPass == false && checkContact == false && checkCNIC == false && checkEmail == false && adminFound == false)
                    {
                        checkLoop = 1;
                        int selectedIndex = emp_status.SelectedIndex;
                        int status_Id = int.Parse(getStatus.Keys.ElementAt(selectedIndex));
                        string emp_design1 = emp_designation.SelectedItem.ToString();
                        string getCNIC = emp_cnic.Text;
                        getCNIC = getCNIC[getCNIC.Length - 1].ToString();
                        if (int.Parse(getCNIC) % 2 == 0)
                        {
                            empl_gender = "F";
                        }
                        else if (int.Parse(getCNIC) % 2 != 0)
                        {
                            empl_gender = "M";
                        }
                        SqlCommand tcmd = new SqlCommand("SELECT Id FROM Lookup WHERE Name = @Name", con);
                        tcmd.Parameters.AddWithValue("@Name", emp_design1);

                        SqlCommand cmd = new SqlCommand("Insert into EmployeeDetails values (@Name,@PIN,@CNIC,@Gender,@Salary,@Designation,@DateOfBirth,@City,@Country,@Address,@PharmacyId,@Status,@HireDate,@Email,@ContactNumber)", con);
                        cmd.Parameters.AddWithValue("@Name", emp_name.Text);
                        cmd.Parameters.AddWithValue("@PIN", emp_pin.Text);
                        cmd.Parameters.AddWithValue("@CNIC", emp_cnic.Text);
                        cmd.Parameters.AddWithValue("@Gender", empl_gender);
                        cmd.Parameters.AddWithValue("@Salary", int.Parse(emp_salary.Text));
                        cmd.Parameters.AddWithValue("@Designation", int.Parse(tcmd.ExecuteScalar().ToString()));
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(emp_dob.Text));
                        cmd.Parameters.AddWithValue("@City", emp_city.Text);
                        cmd.Parameters.AddWithValue("@Country", emp_country.Text);
                        cmd.Parameters.AddWithValue("@Address", emp_address.Text);
                        cmd.Parameters.AddWithValue("@PharmacyId", pharId);

                        cmd.Parameters.AddWithValue("@Status", status_Id);
                        cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(emp_hire_date.Text));
                        cmd.Parameters.AddWithValue("@ContactNumber", emp_contactNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", emp_mail.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully Added");

                        }
                        //if (checkLoop == 1)
                        //{
                        //    SqlCommand t2_cmd = new SqlCommand("commit tran Insert_Employee", con);
                        //    t2_cmd.ExecuteNonQuery();
                        //    showEmployeeData();
                        //}
                        //else if (checkLoop == 0)
                        //{
                        //    SqlCommand t2_cmd = new SqlCommand("rollback tran Insert_Employee", con);
                        //    t2_cmd.ExecuteNonQuery();
                        //}
                        if (checkEmail == true)
                        {
                            MessageBox.Show("Same Email already exists");
                        }
                    if (checkPass == true)
                    {
                        MessageBox.Show("Enter new unique password");
                    }
                    if (checkContact == true)
                        {
                            MessageBox.Show("Same Contact already exists");
                        }
                        if (checkCNIC == true)
                        {
                            MessageBox.Show("Same CNIC already exists");
                        }
                        if (adminFound == true)
                        {
                            MessageBox.Show("Admin in that pharmacy already exist");
                        }
                    }
                
            //}
            //catch
            //{
            //    MessageBox.Show("Sorry for inconvinience");

            //}
        }
        private void showEmployeeData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("  SELECT Pharmacy.Id,EmployeeDetails.RegistrationNumber,EmployeeDetails.Name,EmployeeDetails.PIN,EmployeeDetails.CNIC,EmployeeDetails.Gender,EmployeeDetails.Salary,R2.Designation,EmployeeDetails.[Date Of Birth],EmployeeDetails.City,EmployeeDetails.Country,EmployeeDetails.Address,Pharmacy.Location,R1.Status,EmployeeDetails.[Hire Date],EmployeeDetails.Email,EmployeeDetails.ContactNumber FROM(SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Status FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.Status = Lookup.Id) AS R1 INNER JOIN (SELECT EmployeeDetails.RegistrationNumber, Lookup.Name AS Designation FROM EmployeeDetails INNER JOIN Lookup ON EmployeeDetails.[Designation] = Lookup.Id) AS R2 ON R1.RegistrationNumber = R2.RegistrationNumber INNER JOIN EmployeeDetails ON EmployeeDetails.RegistrationNumber = R1.RegistrationNumber INNER JOIN Pharmacy ON EmployeeDetails.[Pharmacy Id] = Pharmacy.Id WHERE Pharmacy.Id = @pharId", con);
            cmd.Parameters.AddWithValue("@PharId", pharId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            employee_Grid.DataSource = dt;
            employee_Grid.Columns["Id"].Visible = false;
            employee_Grid.Columns["RegistrationNumber"].Visible = false;

        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            emp_pharmacy.Text = pharId.ToString();
            showEmployeeData();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT Name FROM LookUp WHERE Category = 'EMPLOYEE_DESIGNATION' AND Name <> 'Admin' ", con);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                emp_designation.Items.Add(DR2[0]);
            }
            DR2.Close();
            SqlCommand cmd3 = new SqlCommand("SELECT Name FROM LookUp WHERE Category = 'EMPLOYEE_STATUS' ", con);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            while (DR3.Read())
            {
                emp_status.Items.Add(DR3[0]);
            }
            DR3.Close();

            
        }

        private void tableLayoutPanel1078_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
