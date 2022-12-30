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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string departmentId = depIdtxt.Text;
            string departmentName = depNametxt.Text;

            string Query = "INSERT INTO Department (departmentId , departmentName) VALUES ('" + departmentId + "' , '" + departmentName + "')";


            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
