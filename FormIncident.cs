using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.InteropServices;

namespace DRRMSystem
{
    public partial class FormIncident : Form
    {
        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        private int currentIndex = 0;
        public static FormIncident instance;
        public event EventHandler<Tuple<string, DateTime>> DisasterEntered;
        // Import the necessary WinAPI functions
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        // Function to apply rounded corners to a RichTextBox control
        private void ApplyRoundedCornersToRichTextBox(System.Windows.Forms.RichTextBox richTextBox, int radius)
        {
            // Create a region with rounded corners
            IntPtr handle = CreateRoundRectRgn(0, 0, richTextBox.Width, richTextBox.Height, radius, radius);

            // Set the region to the RichTextBox control
            SetWindowRgn(richTextBox.Handle, handle, true);
        }



        public FormIncident()
        {
            InitializeComponent();
            instance = this;
            PopulateDisasters();
            datepick.MaxDate = DateTime.Today;
            datepicktimeocc.Format = DateTimePickerFormat.Custom;
            datepicktimeocc.CustomFormat = "HH:mm:ss tt";
            datepickrespond.Format = DateTimePickerFormat.Custom;
            datepickrespond.CustomFormat = "HH:mm:ss tt";

            datepickarrival.Format = DateTimePickerFormat.Custom;
            datepickarrival.CustomFormat = "HH:mm:ss tt";

            datepickdepart.Format = DateTimePickerFormat.Custom;
            datepickdepart.CustomFormat = "HH:mm:ss tt";

            datepickbase.Format = DateTimePickerFormat.Custom;
            datepickbase.CustomFormat = "HH:mm:ss tt";
            tbIncident.TextChanged += tbIncident_TextChanged;
            ApplyRoundedCornersToRichTextBox(rtxtDetails, 25);
            ApplyRoundedCornersToRichTextBox(rtxtNotes, 25);
            ApplyRoundedCornersToRichTextBox(rtxtDiagnosis, 25);
            rtxtDetails.ContentsResized += rtxtDetails_ContentsResized;
            rtxtDiagnosis.ContentsResized += rtxtDiagnosis_ContentsResized;
            rtxtNotes.ContentsResized += rtxtNotes_ContentsResized;


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtlastname.Text == "LAST NAME")
            {
                txtlastname.Text = "";
                txtlastname.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtlastname.Text == "")
            {
                txtlastname.Text = "LAST NAME";
                txtlastname.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "FIRST NAME")
            {
                txtFirstname.Text = "";
                txtFirstname.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                txtFirstname.Text = "FIRST NAME";
                txtFirstname.ForeColor = Color.Gray;
            }
        }

    
        private List<string> selectedRespondents = new List<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsDuplicateData(txtlastname.Text, txtFirstname.Text, tbIncident.Text, cbPlace.Text, txtAge.Text))
            {
                MessageBox.Show("Duplicate entry detected. Data not inserted.");
                return;
            }
            string dtIncident = "";
            if (cbCarCrash.Checked)
            {
                dtIncident = "Car Crash";
            }
            else if (cbFight.Checked)
            {
                dtIncident = "Fight";
            }
            else if (cbRob.Checked)
            {
                dtIncident = "Robbery";
            }
            else if (cbdnt.Checked)
            {
                dtIncident = "N/A";
            }
            else
            {
                dtIncident = tbIncident.Text;
            }
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into tblMain (lastname, firstname, date, incident, place, respondent, age) Values (@lastname, @firstname, @date, @incident, @place, @respondent, @age)", conn);
            cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);       
            cmd.Parameters.AddWithValue("@incident", dtIncident);
            cmd.Parameters.AddWithValue("@place", cbPlace.Text);
            cmd.Parameters.AddWithValue("@respondent", lbRespondent.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
           

            DateTime dateValue;
            if (DateTime.TryParse(datepick.Text, out dateValue))
            {  
                cmd.Parameters.AddWithValue("@date", dateValue.ToString("yyyy-MM-dd"));
            }
            else
            {
                MessageBox.Show("Invalid date format");
                return;
            }


            DialogResult result = MessageBox.Show("Continue Printing?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                System.Drawing.Image Picture = pictureBox1.Image;
                List<string> respondents = new List<string>();
                foreach (var item in lbRespondent.Items)
                {
                    respondents.Add(item.ToString()); 
                }
                string Incident = "";
                if (cbCarCrash.Checked)
                {
                    Incident = "Car Crash";
                }
                else if (cbFight.Checked)
                {
                    Incident = "Fight";
                }
                else if (cbRob.Checked)
                {
                    Incident = "Robbery";
                }
                else if (cbdnt.Checked)
                {
                    Incident = "N/A";
                }
                else{
                    Incident = tbIncident.Text;
                }
                string Details = "";
                string Injuries = "";
                string Notes = "";
                if (!String.IsNullOrWhiteSpace(rtxtDetails.Text))
                {
                    Details = rtxtDetails.Text;
                }
                if (!String.IsNullOrWhiteSpace(rtxtDiagnosis.Text))
                {
                    Injuries = rtxtDiagnosis.Text;
                }
                if (!String.IsNullOrWhiteSpace(rtxtNotes.Text))
                {
                    Notes = rtxtNotes.Text;
                }
           

                Formfinalprint finalprint = new Formfinalprint(Picture, datepick.Text, txtFirstname.Text, 
                    txtlastname.Text, respondents, Details, Injuries, Notes, 
                    datepicktimeocc.Text, cbPlace.Text, txtAddy.Text, Incident, txtAge.Text, datepickrespond.Text, datepickarrival.Text,
                    datepickbase.Text, datepickdepart.Text, txtPrep.Text, txtCheck.Text, txtAppr.Text, txtNoted.Text);
                finalprint.Show();
                DisasterEntered?.Invoke(this, Tuple.Create(cbPlace.Text, dateValue));
                
                // Reset form fields
                ResetFormFields();
                ValidateFields();

            }
        }
        private bool IsDuplicateData(string lastName, string firstName, string incident, string place, string age)
        {
            bool isDuplicate = false;
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";

            // Construct the query to check for duplicate data
            string query = "SELECT COUNT(*) FROM tblMain WHERE lastname = @lastname AND firstname = @firstname AND incident = @incident AND place = @place AND age = @age";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@lastname", lastName);
                    command.Parameters.AddWithValue("@firstname", firstName);
                    command.Parameters.AddWithValue("@incident", incident);
                    command.Parameters.AddWithValue("@place", place);
                    command.Parameters.AddWithValue("@age", age);

                    // Open the database connection
                    connection.Open();

                    // Execute the query to check for duplicates
                    int count = (int)command.ExecuteScalar();

                    // Check if any duplicate records were found
                    if (count > 0)
                    {
                        isDuplicate = true;
                    }
                }
            }

            return isDuplicate;
        }

        private void ResetFormFields()
        {
            txtlastname.Text = "";
            txtFirstname.Text = "";
            datepick.Text = "";
            lbRespondent.Items.Clear();
            tbIncident.Text = "";
            datepicktimeocc.Text = "";
            cbPlace.Text = "";
            txtAddy.Text = "";
            txtAge.Text = "";
            rtxtNotes.Text = "";
            rtxtDetails.Text = "";
            rtxtDiagnosis.Text = "";
            pictureBox1.Image = null;
            cbRespondents.Text = "";
            lbRespondent.Items.Clear();
            txtPrep.Text = "";
            txtCheck.Text = "";
            txtAppr.Text = "";
            txtNoted.Text = "";
            datepickarrival.Text = "";
            datepickbase.Text = "";
            datepickrespond.Text = "";
            datepickdepart.Text = "";
        }
        private bool ValidateFields()
        {

            return !string.IsNullOrWhiteSpace(txtlastname.Text) &&
          !string.IsNullOrWhiteSpace(txtFirstname.Text) &&
          !string.IsNullOrWhiteSpace(cbPlace.Text) &&
          !string.IsNullOrWhiteSpace(txtAge.Text) &&
          DateTime.TryParse(datepick.Text, out _) &&
          !string.IsNullOrWhiteSpace(txtCheck.Text) &&
          !string.IsNullOrWhiteSpace(txtAppr.Text) &&
          !string.IsNullOrWhiteSpace(txtPrep.Text) &&
          !string.IsNullOrWhiteSpace(txtNoted.Text);
        }


        private void lbRespondent_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRespondents.Clear();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                lbRespondent.Items.Add(txtPrep.Text);


                txtPrep.Clear();

                e.Handled = true;

            }
        }

        private void disastertype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string value = cbPlace.Text.Trim();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    cbPlace.Items.Add(value);

                }
            }
        }



        private void btnInsert_Click_1(object sender, EventArgs e)
        {
           openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Iterate through selected files and add them to the images list
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    // Load the image and add it to the list
                    System.Drawing.Image image = System.Drawing.Image.FromFile(fileName);
                    images.Add(image);
                }
                // Display the first image in the PictureBox
                pictureBox1.Image = images[0];
                // Reset the current index
                currentIndex = 0;
            }

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbPicture;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into TBLImage(path_image)Values( @pathimage)", conn);
            cmd.Parameters.AddWithValue("pathimage", openFileDialog1.FileName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void PopulateDisasters()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbDisasterType;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT nameofdisaster FROM tbDisasterType", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbPlace.Items.Add(reader["nameofdisaster"].ToString());
                }
            }
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            //change the database for this 
            if (!string.IsNullOrEmpty(cbPlace.Text))
            {
                // Generate a unique id (replace this with your own logic if needed)
                int uniqueId = GenerateUniqueId();

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbDisasterType;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbDisasterType(id, nameofdisaster) VALUES (@id, @nameofdisaster)", conn);
                    cmd.Parameters.AddWithValue("@id", uniqueId);
                    cmd.Parameters.AddWithValue("@nameofdisaster", cbPlace.Text);
                    cmd.ExecuteNonQuery();
                }

                // Add the new item to the ComboBox
                cbPlace.Items.Add(cbPlace.Text);

                // Clear the text entered in the ComboBox
                cbPlace.Text = "";
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.ListViewItem item in lbRespondent.SelectedItems)
            {
                lbRespondent.Items.Remove(item);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private int GenerateUniqueId()
        {

            return 1;
        }


        private void Formhome_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.WindowState = FormWindowState.Maximized;
            button1.Enabled = false;


        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }

        }

        private void txtFirstname_Enter(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "First name")
            {
                txtFirstname.Text = "";
                txtFirstname.ForeColor = Color.Black;
            }
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {

        }

        private void txtlastname_Enter(object sender, EventArgs e)
        {

        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                lbRespondent.Items.Add(txtPrep.Text);


                txtPrep.Clear();

                e.Handled = true;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepick_ValueChanged_1(object sender, EventArgs e)
        {
            // Ensure selected date is not in the future
            if (datepick.Value > DateTime.Today)
            {
        
                datepick.Value = DateTime.Today; // Reset to today's date
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRespondent_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }







        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }
        private void timeoccurred_ValueChanged(object sender, EventArgs e)
        {

        }
        private void SetMilitaryTimeFormat(System.Windows.Forms.Control.ControlCollection controls)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void disastertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void datepick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbRespondent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Formhome_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void datepickrespond_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepickarrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepickdepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepickbase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbcarcrash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbfight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbdnt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbIncident_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }
        public void UpdateIncidentLabel(string incidentText)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbRespondent.Items.Add(cbRespondents.Text);


            cbRespondents.Items.Clear();
        }
        private const int MaxLength = 1000; // Set your desired maximum length

        private void rtxtDetails_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int desiredWidth = 320;
            int desiredHeight = 144;

            var richTextBox = (System.Windows.Forms.RichTextBox)sender;

            int newHeight = e.NewRectangle.Height;
            int newWidth = e.NewRectangle.Width;

            // Calculate the scale ratio
            float widthScale = (float)desiredWidth / newWidth;
            float heightScale = (float)desiredHeight / newHeight;

            // Choose the minimum scale to ensure that the content fits within the desired size
            float scale = Math.Min(widthScale, heightScale);

      



        }

        private void rtxtDiagnosis_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int desiredWidth = 456;
            int desiredHeight = 191;
            var richTextBox = (System.Windows.Forms.RichTextBox)sender;

            int newHeight = e.NewRectangle.Height;
            int newWidth = e.NewRectangle.Width;

            // Calculate the scale ratio
            float widthScale = (float)desiredWidth / newWidth;
            float heightScale = (float)desiredHeight / newHeight;

            // Choose the minimum scale to ensure that the content fits within the desired size
            float scale = Math.Min(widthScale, heightScale);

        }

        private void rtxtNotes_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int desiredWidth = 391;
            int desiredHeight = 424;
            var richTextBox = (System.Windows.Forms.RichTextBox)sender;

            int newHeight = e.NewRectangle.Height;
            int newWidth = e.NewRectangle.Width;

            // Calculate the scale ratio
            float widthScale = (float)desiredWidth / newWidth;
            float heightScale = (float)desiredHeight / newHeight;

            float scale = Math.Min(widthScale, heightScale);
            if (rtxtNotes.TextLength >= MaxLength)
            {

            }
        }
        private bool maxCharacterMessageBoxShown = false;

        private void rtxtDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && rtxtDetails.TextLength >= MaxLength && !maxCharacterMessageBoxShown)
            {
                e.Handled = true; // Prevent further key presses
                MessageBox.Show("Maximum character limit reached.");
                maxCharacterMessageBoxShown = true;
            }

        }

        private void rtxtDiagnosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && rtxtDiagnosis.TextLength >= MaxLength && !maxCharacterMessageBoxShown)
            {
                e.Handled = true; // Prevent further key presses
                MessageBox.Show("Maximum character limit reached.");
                maxCharacterMessageBoxShown = true;
            }

        }

        private void rtxtNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && rtxtNotes.TextLength >= MaxLength && !maxCharacterMessageBoxShown)
            {
                e.Handled = true; // Prevent further key presses
                MessageBox.Show("Maximum character limit reached.");
                maxCharacterMessageBoxShown = true;
            }

        }

        private void rtxtDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {

            if (currentIndex < images.Count - 1)
            {
                currentIndex++;
                pictureBox1.Image = images[currentIndex];
            }
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                pictureBox1.Image = images[currentIndex];
            }
        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void txtAddy_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void cbRespondents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if all fields are filled in
            if (ValidateFields())
            {
                // Enable the submit button if all fields are filled
                button1.Enabled = true;
            }
            else
            {
                // Disable the submit button if any field is empty
                button1.Enabled = false;
            }
        }

        private void cbCarCrash_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}