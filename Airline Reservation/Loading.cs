using System.Data.SqlClient;

namespace Airline_Reservation
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string conString= "Data Source=DESKTOP-IGR9GMI;Initial Catalog=FlightReservationSystem;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                MessageBox.Show("Connected to Database successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
    }
}