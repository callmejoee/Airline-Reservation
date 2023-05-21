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
                finally
                {
                    newCon.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passIDt.Text == null || ssn.Text == null || email.Text == null || password.Text == null)
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    newCon.Open();
                    string query = "UPDATE dbo.CUSTOMER" +
                        " set CUST_ID ='" + passIDt.Text + "'," + "F_NAME = '" + firstName.Text + "'," +
                        "L_NAME = '" + lastName.Text + "'," + "CITY = '" +
                        city.Text + "'," + "COUNTRY ='" + country.Text + "'," +
                        "DOB = '" + date.Value + "'," + "SSN ='" + int.Parse(ssn.Text) + "'," +
                        "EMAIL ='" + email.Text + "'," + "PASSWORD ='" + password.Text + "'," +
                        "GENDER = '" + gender.Text + "'," + "NATIONALITY ='" + nationality.Text + "'" +
                        "WHERE CUST_ID = '" + passIDt.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, newCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated");
                    newCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pass_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            passIDt.Text = pass_list.SelectedRows[0].Cells[0].Value.ToString();
            firstName.Text = pass_list.SelectedRows[0].Cells[1].Value.ToString();
            lastName.Text = pass_list.SelectedRows[0].Cells[2].Value.ToString();
            city.Text = pass_list.SelectedRows[0].Cells[3].Value.ToString();
            country.Text = pass_list.SelectedRows[0].Cells[4].Value.ToString();
            date.Value = (DateTime)pass_list.SelectedRows[0].Cells[5].Value;
            ssn.Text = pass_list.SelectedRows[0].Cells[6].Value.ToString();
            email.Text = pass_list.SelectedRows[0].Cells[7].Value.ToString();
            password.Text = pass_list.SelectedRows[0].Cells[8].Value.ToString();
            gender.Text = pass_list.SelectedRows[0].Cells[9].Value.ToString();
            nationality.Text = pass_list.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
