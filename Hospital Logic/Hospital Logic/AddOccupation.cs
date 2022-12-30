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
    public partial class AddOccupation : Form
    {
        public AddOccupation()
        {
            InitializeComponent();
        }

        private void occupantExecBtn_Click(object sender, EventArgs e)
        {


            //Address of SQL server and Database
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";

            //Establish connection
            SqlConnection con = new SqlConnection(conString);

            //Open Connection
            con.Open();

            //Prepare Query
            string orderId = OrderIdtxt.Text;
            string orderName = OrderNametxt.Text;
            string Query = "INSERT INTO Occupation (occupationId,occupationName) VALUES ('" + orderId + "' , '" + orderName + "')";

            //Execute Query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //Close connection
            con.Close();

            //Show MessageBox
            MessageBox.Show("Data successfully saved");
            Visible= false;
        }
    }
}
