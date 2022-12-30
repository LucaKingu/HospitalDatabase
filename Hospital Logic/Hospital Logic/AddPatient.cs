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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string pid = pIdtxt.Text;
            string idCard = idCardtxt.Text;
            string firstName = firstNametxt.Text;
            string lastName = lastNametxt.Text;
            string address = addresstxt.Text;
            string martialStatus = martialstatustxt.Text;
            string age = agetxt.Text;
            string phone = phonetxt.Text;
            string registrationDate = registrationDatetxt.Text;
            string sex = sextxt.Text;
            string occupationId = occIdtxt.Text;
            string countryId = countryIdtxt.Text;
            string cityId = cityIdtxt.Text;
            string Query = "INSERT INTO Patnt (pId,idCard,firstName,lastName,address,martialstatus,age,phone,registrationDate," +
                "sex,occupationId,countryId,cityId) VALUES ('" + pid + "' , '" + idCard + "' , '"+firstName+"' , '"+lastName+"'" +
                "'"+address+"' , '"+martialStatus+"' , '"+age+"' , '"+phone+"' , '"+registrationDate+"' , '"+sex+"' , '"+occupationId+"'" +
                "'"+countryId+"' , '"+cityId+"')";

            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible= false;
        }
    }
}
