using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Customer cus = new Add_Customer();
            cus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addFlight flight = new addFlight();
            flight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Flights flights = new View_Flights();
            flights.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View_Customers view_Customers = new View_Customers();
            view_Customers.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addAircraft aircraft = new addAircraft();
            aircraft.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
