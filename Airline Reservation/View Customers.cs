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
    public partial class View_Customers : Form
    {
        public View_Customers()
        {
            InitializeComponent();
        }
        SqlConnection newCon = new SqlConnection("Data Source=DESKTOP-IGR9GMI;Initial Catalog=FlightReservationSystem;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void populate()
        {
            newCon.Open();
            string query = "SELECT * FROM dbo.CUSTOMER";
            SqlDataAdapter sda = new SqlDataAdapter(query, newCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pass_list.DataSource = ds.Tables[0];
            newCon.Close();
        }

        private void View_Customers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Customer add = new Add_Customer();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passIDt.Text == "")
            {
                MessageBox.Show("Enter PassengerID");
            }
            else
            {
                try
                {
                    newCon.Open();
                    string query = "DELETE from dbo.CUSTOMER where CUST_ID =" + "'" + passIDt.Text + "'" + ";";
                    SqlCommand cmd = new SqlCommand(query, newCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted");
                    newCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
