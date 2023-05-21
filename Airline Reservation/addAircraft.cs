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
/*using System.Data.SqlClient;*/

namespace Airline_Reservation
{
    public partial class addAircraft : Form
    {
        public addAircraft()
        {
            InitializeComponent();
        }
        SqlConnection newCon = new SqlConnection("Data Source=DESKTOP-IGR9GMI;Initial Catalog=FlightReservationSystem;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (planeID.Text == "" || model.Text == "" || airline.Text == "")
            {
                MessageBox.Show("Please enter all info");
            }
            else
            {
                try
                {
                    newCon.Open();
                    string query = "INSERT INTO dbo.PLANE values('" + planeID.Text + "', '" + "A0001','" + model.Text + "', '" + airline.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, newCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Plane Recorded Successfully");
                    newCon.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    newCon.Close();
                }
            }
        }
    }
}
