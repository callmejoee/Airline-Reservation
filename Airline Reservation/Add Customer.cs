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

namespace Airline_Reservation
{
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        SqlConnection newCon = new SqlConnection("Data Source=DESKTOP-IGR9GMI;Initial Catalog=FlightReservationSystem;Integrated Security=True");

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passID.Text == "" || ssn.Text == "" || email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please enter all info");
            }
            else
            {
                try
                {
                    newCon.Open();
                    string query = "INSERT INTO dbo.CUSTOMER values('" + passID.Text + "', '" + firstName.Text + "', '" + lastName.Text + "', '" + city.Text + "', '"  
                        + country.Text + "', '" + date.Value + "', '" + int.Parse(ssn.Text) + "', '" + email.Text + "', '" + 
                        password.Text + "', '" + gender.Text + "', '" + nationality.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, newCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    newCon.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
