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

namespace DRRMSystem
{
    public partial class Formhistory : Form
    {
        public Formhistory()
        {
            InitializeComponent();
        }

        private void Formhistory_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            DateTime date = dateTimePicker.Value.Date;

            try
            {
                // Debugging: Display the search criteria
                MessageBox.Show($"Searching for: Last Name = {lastName}, First Name = {firstName}, Date = {date}");

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbSearch;Integrated Security=True"))
                {
                    conn.Open();

                    // Debugging: Display the constructed SQL query
                    string query = ("SELECT last_name, first_name, date, disastertype FROM tblSearch WHERE last_name = @lastName AND first_name = @firstName AND date = @date");

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@date", date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear previous results from ListBox
                        listHistory.Items.Clear();

                        // Iterate through the results and format them
                        while (reader.Read())
                        {
                            string result = $"{reader["last_name"]} {reader["first_name"]} - {reader["date"]} = {reader["disastertype"]}";
                            listHistory.Items.Add(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listHistory.Items.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formhistory_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
