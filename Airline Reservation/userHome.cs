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
    public partial class userHome : Form
    {
        public userHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Flights view_Flights = new View_Flights();
            view_Flights.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
