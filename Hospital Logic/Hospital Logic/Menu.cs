using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Logic
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOccupation addOccupation = new AddOccupation();
            addOccupation.Show();
            Visible= false;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            Visible= false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddHealthStatus addHealthStatus = new AddHealthStatus();
            addHealthStatus.Show();
            Visible= false;
        }

        private void cityBtn_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity();
            addCity.Show();
            Visible= false;
        }

        private void countryBtn_Click(object sender, EventArgs e)
        {
            AddCountry addCountryadd = new AddCountry();
            addCountryadd.Show();
            Visible= false;
        }

        private void HospitalEmployeeButton_Click(object sender, EventArgs e)
        {
            AddHospitalEmployee addHospitalEmployee = new AddHospitalEmployee();
            addHospitalEmployee.Show();
            Visible= false;
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
            Visible= false;
        }

        private void MedicationBtn_Click(object sender, EventArgs e)
        {
            AddMedication addMedication = new AddMedication();
            addMedication.Show();
            Visible= false;
        }

        private void MedicationOrderBtn_Click(object sender, EventArgs e)
        {
            AddMedicationOrder addMedicationOrder = new AddMedicationOrder();
            addMedicationOrder.Show();
            Visible= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCity deleteCity = new DeleteCity();
            deleteCity.Show();
            Visible = false;
        }

        private void DelteOccupationBtn_Click(object sender, EventArgs e)
        {
            DeleteOccupation deleteOccupation = new DeleteOccupation();
            deleteOccupation.Show();
            Visible = false;
        }

        private void DeltePatientBtn_Click(object sender, EventArgs e)
        {
            DeletePatient deletePatient = new DeletePatient();
            deletePatient.Show();
            Visible = false;    
        }

        private void DeleteHealthStatusBtn_Click(object sender, EventArgs e)
        {
            DeleteHealthStatus deleteHealthStatus = new DeleteHealthStatus();
            deleteHealthStatus.Show();
            Visible = false;
        }

        private void DeleteCountryBtn_Click(object sender, EventArgs e)
        {
            DeleteCountry deleteCountry = new DeleteCountry();
            deleteCountry.Show();
            Visible = false;
        }

        private void DeleteHospitalEmployeeBtn_Click(object sender, EventArgs e)
        {
            DeleteHospitalEmployee deleteHospitalEmployee = new DeleteHospitalEmployee();
            deleteHospitalEmployee.Show();
            Visible = false;
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            DeleteDepartment deleteDepartment = new DeleteDepartment();
            deleteDepartment.Show();
            Visible = false;
        }

        private void DeleteMedicationBtn_Click(object sender, EventArgs e)
        {
            DeleteMedication deleteMedication = new DeleteMedication();
            deleteMedication.Show();
            Visible = false;
        }

        private void DeleteMedicationOrderBtn_Click(object sender, EventArgs e)
        {
            DeleteMedicationOrder deleteMedicationOrder = new DeleteMedicationOrder();
            deleteMedicationOrder.Show();
            Visible = false;
        }

        private void ShowOccupationsBtn_Click(object sender, EventArgs e)  
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Occupation";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nOccupation ID  Occupation Name");
            Console.WriteLine("---------------  ---------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                while(rdr.Read())
                {
                    Console.WriteLine("{0}  {1}"
                        , rdr["occupationId"], rdr["occupationName"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void ShowPatientsBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Patnt";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nPatient ID   ID Card   First Name   Last Name   Address    Martial Status   Age   Phone   Registration Date   Sex   Occupation ID   Country ID   City ID");
            Console.WriteLine("------------   -------   ----------   ---------   -------    --------------   ---   ------  -----------------   ---   -------------   ----------   --------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}  {8}  {9}  {10}  {11}  {12}"
                        , rdr["pId"], rdr["idCard"], rdr["firstName"], rdr["lastName"], rdr["address"], rdr["martialStatus"], rdr["age"], rdr["phone"], rdr["registrationDate"], rdr["sex"], rdr["occupationId"], rdr["countryId"], rdr["cityId"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void ShowHealthStatusBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT ISNULL(pId,'Null'),ISNULL(currentHealth,'Null'),ISNULL(disability,'Null'),ISNULL(mentalHealth,'Null'),ISNULL(medication,'Null'),ISNULL(medicalHistory,'Null'),ISNULL(geneticInformation,'Null')FROM dbo.healthStatus";

            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nPatient ID   Current Heatlh  Disability   Mental Health   Medication   Medical History   Genetic Information");
            Console.WriteLine("------------   --------------  ----------   -------------   ----------   ---------------   --------------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}"
                        , rdr["pId"],rdr["currentHealth"], rdr["disability"], rdr["mentalHealth"], rdr["medication"], rdr["medicalHistory"], rdr["geneticInformation"]);
                }
            }
            //GIving error I cannot solve
            con.Close();
            this.Close();
        }

        private void ShowCityBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.City";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nCity ID   City Name");
            Console.WriteLine("---------   ---------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}  {1}"
                        , rdr["cityId"], rdr["cityName"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void ShowCountryBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Country";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nCountry ID    Country Name");
            Console.WriteLine("------------    ------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}  {1}"
                        , rdr["countryId"], rdr["countryName"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void showHospitalEmployeeBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Hospital_Employee";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nEmployee ID   First Name   Last Name   Address   Martial Status   Age   Phone   Hire Date   attrition Date   Sex   Country ID   City ID   Department ID");
            Console.WriteLine("-------------   ----------   ---------   -------   --------------   ---   -----   ----------  --------------    --   ----------   --------  --------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}   {1}  {2}  {3}    {4}    {5}    {6}    {7}    {8}    {9}    {10}    {11}    {12}"
                        , rdr["employeeId"], rdr["firstName"], rdr["lastName"], rdr["address"], rdr["martialStatus"], rdr["age"], rdr["phone"], rdr["hireDate"], rdr["attritionDate"], rdr["sex"], rdr["countryId"], rdr["cityId"],rdr["departmentId"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void ShowDepartmentBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Department";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nDepartment ID  Department Name");
            Console.WriteLine("---------------  ---------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}  {1}"
                        , rdr["departmentId"], rdr["departmentName"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void showMedicationsBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.Medication";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nMedication ID   Medication Name   Symptoms   Disease Treatments   Expiry Date   Medication Quantity");
            Console.WriteLine("---------------  ---------------    --------   ------------------   -----------    ------------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}"
                        , rdr["medicationId"], rdr["medicationName"] , rdr["symptoms"], rdr["diseaseTreatment"] , rdr["expiryDate"] , rdr["medicationQTY"]);
                }
            }
            con.Close();
            this.Close();
        }

        private void showMedicationOrdersBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string Query = "SELECT* FROM dbo.MedicationOrder";


            SqlCommand cmd = new SqlCommand(Query, con);

            Console.WriteLine("\nMedication Order ID   Order Quantity   Bought Date   Due Date   Order Cost   Medication ID");
            Console.WriteLine("---------------------   -------------     --------      ------    ----------   -------------");


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}"
                        , rdr["medicationOrderId"], rdr["orderQTY"], rdr["boughtDate"], rdr["dueDate"], rdr["orderCost"], rdr["medicationId"]);
                }
            }
            con.Close();
            this.Close();
        }
    }
}

