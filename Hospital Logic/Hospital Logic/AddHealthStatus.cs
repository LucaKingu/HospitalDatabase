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
    public partial class AddHealthStatus : Form
    {
        public AddHealthStatus()
        {
            InitializeComponent();
        }

        private void HealthStatusExecuteBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string pid = patientIdtxt.Text;
            string currentHealth = CurrentHealthtxt.Text;
            string disability = Disabilitytxt.Text;
            string mentalHealth = MentalHealthtxt.Text;
            string medication = Medicationtxt.Text;
            string medicalHistory = MedicalHistorytxt.Text;
            string geneticInformation = geneticInformationtxt.Text;

            string Query = "INSERT INTO healthStatus(pid,currentHealth,disability,mentalHealth,medication,medicalHistory,geneticInformation) VALUES ('"+pid+"' , '"+currentHealth+"' , '"+disability+"' , '"+mentalHealth+"' , '"+medication+"' , '"+medicalHistory+"' , '"+geneticInformation+"')";



            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
