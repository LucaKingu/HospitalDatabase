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
           // removecity
        }
    }
}
