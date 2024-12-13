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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DRRMSystem
{
    public partial class Formreg : Form
    {
        public Formreg()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=RYUSEI-PC\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True");



        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM admin WHERE username = '" + txtUsername.Text.Trim() + "'";
                        using (SqlCommand checkUSer = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUSer);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(txtUsername.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (first_name, last_name, username, password) " +
                                                   "VALUES (@first_name, @last_name, @username, @password)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@first_name", txtFname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@last_name", txtLname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Account Created", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FormLogin form = new FormLogin();
                                    form.Show();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }
        private void tbCreatePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            this.Hide();
        }
    }
}
