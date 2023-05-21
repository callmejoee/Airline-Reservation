using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Airline_Reservation
{
    public partial class addFlight : Form
    {
        public addFlight()
        {
            InitializeComponent();
        }
        SqlConnection newCon = new SqlConnection("Data Source=DESKTOP-IGR9GMI;Initial Catalog=FlightReservationSystem;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flightID.Text == "" || planeID.Text == "" || source.Text == "" || destination.Text == "" || available_seats.Text == "")
            {
                MessageBox.Show("Please enter all info");
            }
            else
            {
                try
                {
                    newCon.Open();
                    string query = "INSERT INTO dbo.FLIGHT values('" + flightID.Text + "', '" + planeID.Text + "', '" + "A0001','" + source.Text + "', '" + destination.Text + "', '"
                    + dep_date.Value + "', '" + arrival_date.Value + "', '" + int.Parse(available_seats.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, newCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminHome home = new adminHome();
            home.Show();
            this.Hide();
        }
    }
}
