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
    public partial class AddMedicationOrder : Form
    {
        public AddMedicationOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-I830V2D;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string medicationOrderId = MedicationOrderIdtxt.Text;
            string orderQTY = OrderQtyTxt.Text;
            string boughtDate = BoughtDatetxt.Text;
            string dueDate = DueDateTxt.Text;
            string orderCost = OrderCosttxt.Text;
            string medicationId = MedicationIdtxt.Text;

            string Query = "INSERT INTO MedicationOrder (medicationOrderId , orderQTY,boughtDate,dueDate,orderCost,medicationId) VALUES ('" + medicationId + "' , '" + orderQTY + "','" + boughtDate + "' , '" + dueDate + "' , '" + orderCost + "' , '" + medicationId + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data successfully saved");
            Visible = false;
        }
    }
}
