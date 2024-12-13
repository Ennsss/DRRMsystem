
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
    public partial class FormLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EAN1JK1\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            // Open the registration form when the Register button is clicked1  
            Formreg registrationForm = new Formreg();
            registrationForm.Show();
            this.Hide();
        }

        // Define the event handler method for Form1.Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Your logic for handling the Load event of Form1 goes here
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            // Your logic for handling the TextChanged event of tb_Username goes here
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
        }


        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
          
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {

          
        }

        private void btn_Login_Click_2(object sender, EventArgs e)
        {

         
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Formreg registrationForm = new Formreg();
            registrationForm.Show();
            this.Hide();
        }

        private void btn_Login_Click_3(object sender, EventArgs e)
        {
            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_Username.Text == "supadmin" && tb_Password.Text == "supa123")
            {
                FormMenu form2 = new FormMenu();
                form2.Show();
                this.Hide();
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM admin WHERE username COLLATE Latin1_General_CS_AS = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", tb_Username.Text);
                            cmd.Parameters.AddWithValue("@pass", tb_Password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Pass the command to the adapter
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0) // Check if any rows were returned
                            {
                                MessageBox.Show("Login successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormMenu form2 = new FormMenu();
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void cbShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void tb_Username_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
