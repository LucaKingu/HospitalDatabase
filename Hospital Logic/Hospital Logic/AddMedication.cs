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
    public partial class AddMedication : Form
    {
        public AddMedication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string medicationId = MedicationIdtxt.Text;
            string medicationName = MedicationNametxt.Text;
            string symptoms = SymptomsTxt.Text;
            string diseaseTreatment = diseaseTreatmenttxt.Text;
            string expiryDate = expiryDatetxt.Text;
            string medicationQty = medicationqtyTxt.Text;

            string Query = "INSERT INTO Medication (medicationId , medicationName,symptoms,diseaseTreatment,expiryDate,medicationQTY) VALUES ('" + medicationId + "' , '" + medicationName + "','" + symptoms + "' , '" + diseaseTreatment + "' , '" + expiryDate + "' , '" + medicationQty + "')";


            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
