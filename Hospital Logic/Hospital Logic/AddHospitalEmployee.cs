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
    public partial class AddHospitalEmployee : Form
    {
        public AddHospitalEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string employeeId = EmployeeIdtxt.Text;
            string firstName = FirstNametxt.Text;
            string lastName = LastNametxt.Text;
            string address = Addresstxt.Text;
            string martialStatus = MartialStatustxt.Text;
            string age = Agetxt.Text;
            string phone = phonetxt.Text;
            string hireDate = HireDatetxt.Text;
            string attritionDate = AttritionDatetxt.Text;
            string sex = Sextxt.Text;
            string countryId = CountryIdtxt.Text;
            string cityId = CityIdtxt.Text;
            string departmentId = DepartmentIdtxt.Text;

            string Query = "INSERT INTO Hospital_Employee ( employeeId, firstName , lastName,address,martialStatus,age,phone,hireDate,attritionDate,sex,countryId,cityId,departmentId) VALUES ('" + employeeId + "' , '" + firstName + "' , '" + lastName + "' , '" + address + "'" + "'" + martialStatus + "' , '" + age + "' , '" + phone + "' , '" + hireDate + "' , '" + attritionDate + "' , '" + sex + "'" + "'" + countryId + "' , '" + cityId + "' , '" +"' , '"+departmentId+"')";


            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
