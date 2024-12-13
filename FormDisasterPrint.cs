using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DRRMSystem
{
    public partial class FormDisasterPrint : Form
    {
        private static Formfinalprint instance;
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Date { get; set; }
        public string disaster { get; set; }
        public string selectedDisaster { get; set; }
        public List<string> Respondents { get; set; }
        public string evacuation { get; set; }
        public string damages { get; set; }
        public string notes { get; set; }
        public string place { get; set; }
        public string addy { get; set; }

        public string sever {  get; set; }
        public string respond { get; set; }
        public string arrival { get; set; }
        public string departure { get; set; }
        public string backonbase { get; set; }
        public string age { get; set; }
        public string timeoccured { get; set; }
        public string prep { get; set; }
        public string check { get; set; }
        public string approve { get; set; }
        public string noted { get; set; }

        private Image Picture;
        public FormDisasterPrint(Image picture, string date, string firstname, string lastname, List<string> respondents, 
            string Evacuation, string Damages, string Notes,
            string TimeOccured, string Place, string Addy, string Incident, 
            string Age, string Respond, string Arrival, string Depart, string BackonBase, string Prep, string Check, string Approve, 
            string Noted, string Sever)
        {
            InitializeComponent();
            Picture = picture;
            Date = date;
            Firstname = firstname;
            Lastname = lastname;
            Respondents = respondents;
            evacuation = Evacuation;
            damages = Damages;
            notes = Notes;
            timeoccured = TimeOccured;
            place = Place;
            addy = Addy;
            disaster = Incident;
            age = Age;
            respond = Respond;
            arrival = Arrival;
            departure = Depart;
            backonbase = BackonBase;
            prep = Prep;
            check = Check;
            approve = Approve;
            noted = Noted;
            sever = Sever;


            // Set the image
            if (picture != null)
            {
                pictureBoxPrint.Image = picture;
            }

            PopulateLabels();
   
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void PopulateLabels()
        {
            label12.Text = Date;
  
            label43.Text = disaster;
            label14.Text = $"{Lastname}, {Firstname}";
            label9.Text = evacuation;
            label13.Text = damages;
            label25.Text = notes;
            label34.Text = timeoccured;
            label29.Text = place;
            label27.Text = addy;
            label26.Text = sever;

            foreach (var respondent in Respondents)
            {
                listBox4.Items.Add(respondent);
            }
            label35.Text = respond;
            label36.Text = arrival;
            label37.Text = departure;
            label38.Text = backonbase;
            label30.Text = prep;
            label31.Text = check;
            label32.Text = approve;
            label33.Text = noted;
            label28.Text = age;

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.AutoZoom = true;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            printDocument1.DefaultPageSettings.Landscape = true;


            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(bmp, e.PageBounds);

            bmp.Dispose();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void lbDisaster_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
