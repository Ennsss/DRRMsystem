using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Assuming you're using SQL Server


namespace DRRMSystem
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.WindowState = FormWindowState.Maximized;
            UpdateIncidentCount();
            UpdateDisasterCount();
            UpdateIncidentDetails();
            UpdateDisasterDetails();
            UpdateTopPlaces();
            UpdateDisasterPlace();
        }

        private void FormDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void UpdateIncidentCount()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True"; // Provide your connection string here
            string query = "SELECT COUNT(incident) FROM tblMain"; // Query to count incidents

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int incidentCount = (int)command.ExecuteScalar(); // ExecuteScalar() is used to retrieve a single value
                label2.Text = incidentCount.ToString(); // Update label2 with the count
            }
        }
        private void UpdateDisasterCount()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True"; // Provide your connection string here
            string query = "SELECT COUNT(disaster) FROM tblDisasterMain"; // Query to count incidents

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int incidentCount = (int)command.ExecuteScalar(); // ExecuteScalar() is used to retrieve a single value
                label28.Text = incidentCount.ToString(); 
            }
        }
        private void UpdateIncidentDetails()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";
            string query = "SELECT TOP 1 firstname, lastname, place, incident FROM tblMain ORDER BY incident DESC"; // Query to get the latest incident details

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); // ExecuteReader() is used to retrieve multiple rows

                if (reader.Read()) // Check if there is data to read
                {
                    label32.Text = reader["firstname"].ToString() + " " + reader["lastname"].ToString(); // Concatenate firstname and lastname
                    label33.Text = reader["place"].ToString(); // Update label33 with the latest incident place
                    label34.Text = reader["incident"].ToString(); // Update label34 with the latest incident type
                }
                else
                {
                    // If there are no incidents in the database, set labels to display "No data"
                    label32.Text = "No data";
                    label33.Text = "No data";
                    label34.Text = "No data";
                }
            }
        }
        private void UpdateDisasterDetails()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";
            string query = "SELECT TOP 1 firstname, lastname, place, disaster FROM tblDisasterMain ORDER BY disaster DESC"; // Query to get the latest incident details

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label29.Text = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                    label30.Text = reader["place"].ToString(); 
                    label31.Text = reader["disaster"].ToString();
                }
                else
                {
                    
                    label29.Text = "No data";
                    label30.Text = "No data";
                    label31.Text = "No data";
                }
            }
        }
        private void UpdateTopPlaces()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";
            string query = "SELECT TOP 3 place, COUNT(incident) as IncidentCount FROM tblMain GROUP BY place ORDER BY IncidentCount DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Initialize an index for labels
                int labelIndex = 0;

                // Loop through the top 3 places
                while (reader.Read() && labelIndex < 3)
                {
                    // Update labels with place names and incident counts
                    switch (labelIndex)
                    {
                        case 0:
                            label10.Text = reader["place"].ToString() + " (" + reader["IncidentCount"].ToString() + " incidents)";
                            break;
                        case 1:
                            label11.Text = reader["place"].ToString() + " (" + reader["IncidentCount"].ToString() + " incidents)";
                            break;
                        case 2:
                            label9.Text = reader["place"].ToString() + " (" + reader["IncidentCount"].ToString() + " incidents)";
                            break;
                    }

                    labelIndex++;
                }

                // If there are less than 3 places in the database, set remaining labels to display "No data"
                while (labelIndex < 3)
                {
                    switch (labelIndex)
                    {
                        case 0:
                            label10.Text = "No data";
                            break;
                        case 1:
                            label11.Text = "No data";
                            break;
                        case 2:
                            label9.Text = "No data";
                            break;
                    }

                    labelIndex++;
                }
            }
        }
        private void UpdateDisasterPlace()
        {
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";
            string query = "SELECT TOP 3 place, COUNT(disaster) as DisasterCount FROM tblDisasterMain GROUP BY place ORDER BY DisasterCount DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Initialize an index for labels
                int labelIndex = 0;

                // Loop through the top 3 places
                while (reader.Read() && labelIndex < 3)
                {
                    // Update labels with place names and incident counts
                    switch (labelIndex)
                    {
                        case 0:
                            label16.Text = reader["place"].ToString() + " (" + reader["DisasterCount"].ToString() + " disaster )";
                            break;
                        case 1:
                            label15.Text = reader["place"].ToString() + " (" + reader["DisasterCount"].ToString() + " disaster)";
                            break;
                        case 2:
                            label17.Text = reader["place"].ToString() + " (" + reader["DisasterCount"].ToString() + " disaster)";
                            break;
                    }

                    labelIndex++;
                }

                // If there are less than 3 places in the database, set remaining labels to display "No data"
                while (labelIndex < 3)
                {
                    switch (labelIndex)
                    {
                        case 0:
                            label16.Text = "No data";
                            break;
                        case 1:
                            label15.Text = "No data";
                            break;
                        case 2:
                            label17.Text = "No data";
                            break;
                    }

                    labelIndex++;
                }
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
