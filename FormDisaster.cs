using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRRMSystem
{
    public partial class FormDisaster : Form
    {
        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        public event EventHandler<Tuple<string, DateTime>> DisasterEntered;
        private int currentIndex = 0;
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

        public FormDisaster()
        {
 
            InitializeComponent();
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
            tbDisaster.TextChanged += tbDisaster_TextChanged;
            ApplyRoundedCornersToRichTextBox(rtxtDetails, 25);
            ApplyRoundedCornersToRichTextBox(rtxtNotes, 25);
            ApplyRoundedCornersToRichTextBox(rtxtDiagnosis, 25);
            rtxtDetails.ContentsResized += rtxtDetails_ContentsResized;
            rtxtDiagnosis.ContentsResized += rtxtDiagnosis_ContentsResized;
            rtxtNotes.ContentsResized += rtxtNotes_ContentsResized;
        }
        private int GenerateUniqueId()
        {

            return 1;
        }

        private void FormDisaster_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.WindowState = FormWindowState.Maximized;
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsDuplicateData(txtlastname.Text, txtFirstname.Text, tbDisaster.Text, cbPlace.Text, txtAge.Text))
            {
                MessageBox.Show("Duplicate entry detected. Data not inserted.");
                return;
            }

            int uniqueId = GenerateUniqueId();
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age should be a valid number.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dtIncident = "";
            if (cbFire.Checked)
            {
                dtIncident = "Fire ";
            }
            else if (cbEarth.Checked)
            {
                dtIncident = "Earthquake";
            }
            else if (cbFlood.Checked)
            {
                dtIncident = "Flood";
            }
            else if (cbTyp.Checked)
            {
                dtIncident = "Typhoon";
            }
            else
            {
                dtIncident = tbDisaster.Text;
            }
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into tblDisasterMain (id, lastname, firstname, date, disaster, place, respondent, age) Values (@id, @lastname, @firstname, @date, @disaster, @place, @respondent, @age)", conn);
            cmd.Parameters.AddWithValue("@id", uniqueId);
            cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@disaster", dtIncident);
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

            string disasterList = "";
            if (cbEarth.Checked)
                disasterList += "Earthquake, ";
            if (cbFire.Checked)
                disasterList += "Fire, ";
            if (cbFlood.Checked)
                disasterList += "Flood, ";
            if (cbTyp.Checked)
                disasterList += "Typhoon, ";

            // Remove the trailing comma and space if any
            if (!string.IsNullOrEmpty(disasterList))
                disasterList = disasterList.TrimEnd(' ', ',');

            cmd.Parameters.AddWithValue("@disasterList", disasterList);
           
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
                string Disaster = "";
                if (cbFire.Checked)
                {
                    Disaster = "Fire ";
                }
                if (cbFlood.Checked)
                {
                    Disaster = "Flood";
                }
                else if (cbEarth.Checked)
                {
                    Disaster = "Earth ";
                }
                else if (cbTyp.Checked)
                {
                    Disaster = "Typhoon";
                }
                else
                {
                    Disaster = tbDisaster.Text;
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
                string severity = string.Empty;
                if (rbNorm.Checked)
                {
                    severity = "Normal";
                }
                else if (rbYell.Checked)
                {
                    severity= "Minor Alert";
                }
                else if (rbOrange.Checked)
                {
                    severity = "Moderate Alert";
                }
                else if (rbRed.Checked)
                {
                    severity = "Major Alert";
                }

                FormDisasterPrint printDisaster = new FormDisasterPrint(Picture, datepick.Text, txtFirstname.Text,
                    txtlastname.Text, respondents,  Details, Injuries, Notes,
                    datepicktimeocc.Text, cbPlace.Text, txtAddy.Text, Disaster,txtAge.Text, datepickrespond.Text, datepickarrival.Text,
                    datepickbase.Text, datepickdepart.Text, txtPrep.Text, txtCheck.Text, txtAppr.Text, 
                    txtNoted.Text , severity);
                printDisaster.Show();
                     DisasterEntered?.Invoke(this, Tuple.Create(cbPlace.Text, dateValue));

                ResetFormFields();
                ValidateFields();
            }
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
        private void ResetFormFields()
        {
            txtlastname.Text = "";
            txtFirstname.Text = "";
            datepick.Text = "";
            lbRespondent.Items.Clear();
            tbDisaster.Text = "";
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
        private bool IsDuplicateData(string lastName, string firstName, string disaster, string place, string age)
        {
            bool isDuplicate = false;
            string connectionString = "Data Source=DESKTOP-EAN1JK1\\SQLEXPRESS;Initial Catalog=dbMain;Integrated Security=True";

            // Construct the query to check for duplicate data
            string query = "SELECT COUNT(*) FROM tblDisasterMain WHERE lastname = @lastname AND firstname = @firstname AND @disaster = @disaster AND place = @place AND age = @age";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@lastname", lastName);
                    command.Parameters.AddWithValue("@firstname", firstName);
                    command.Parameters.AddWithValue("@disaster", disaster);
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

        private void rtxtDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tbDisaster_TextChanged(object sender, EventArgs e)
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

        private void datepick_ValueChanged(object sender, EventArgs e)
        {
            // Ensure selected date is not in the future
            if (datepick.Value > DateTime.Today)
            {

                datepick.Value = DateTime.Today; // Reset to today's date
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbRespondent.Items.Add(cbRespondents.Text);


            cbRespondents.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.ListViewItem item in lbRespondent.SelectedItems)
            {
                lbRespondent.Items.Remove(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtAddy_TextChanged(object sender, EventArgs e)
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

        private void txtAge_TextChanged(object sender, EventArgs e)
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

        private void cbRespondents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRespondent_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtPrep_TextChanged(object sender, EventArgs e)
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

        private void txtCheck_TextChanged(object sender, EventArgs e)
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

        private void txtAppr_TextChanged(object sender, EventArgs e)
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

        private void txtNoted_TextChanged(object sender, EventArgs e)
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
    }
}
