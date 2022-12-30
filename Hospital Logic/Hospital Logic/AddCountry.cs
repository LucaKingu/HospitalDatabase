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
    public partial class AddCountry : Form
    {
        public AddCountry()
        {
            InitializeComponent();
        }

        private void CountryExecBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string countryId = CountryIdtxt.Text;
            string countryName = countryNametxt.Text;
            string riskOfForeignDiseases = riskOfForeignDiseasetxt.Text;

            string Query = "INSERT INTO Country (countryId , countryName , riskOfForeignDisease) VALUES ('" + countryId + "' , '" + countryName + "' , '"+riskOfForeignDiseases+"')";


            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
