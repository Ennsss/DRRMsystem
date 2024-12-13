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


namespace DRRMSystem
{
    public partial class Formfinalprint : Form
    {
        private static Formfinalprint instance;
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Date { get; set; }

        public string selectedincident{ get; set; }
        public List<string> Respondents { get; set; }
        public string details { get; set; }
        public string injuries { get; set; }  
        public string place {  get; set; }
        public string addy { get; set; }
        public string notes { get; set; }   
        public string incident { get; set; }
        public string respond { get; set; }
        public string arrival { get; set; }
        public string departure{ get; set; }
        public string backonbase { get; set; }
        public string age { get; set; }
        public string timeoccured { get; set; }
        public string prep{ get; set; }
        public string check {  get; set; }
        public string approve { get; set; }
        public string noted{ get; set; }
        private FormIncident formIncidentInstance;

       



        private Image Picture;
        public Formfinalprint(Image picture, string date,  string firstname, string lastname, List<string> respondents, 
            string Details, string Injuries, string Notes, 
            string TimeOccured, string Place, string Addy, string Incident, 
            string Age, string Respond, string Arrival,string Depart, string BackonBase, string Prep, string Check, string Approve, string Noted)
        {
            InitializeComponent();
            instance = this;

            // Assigning values
            Picture = picture;
            Date = date;
            Firstname = firstname;
            Lastname = lastname;
            Respondents = respondents;
            details = Details;
            injuries = Injuries;
            notes = Notes;  
            timeoccured = TimeOccured;
            place = Place;
            addy = Addy;
            incident = Incident;
            age = Age;
            respond = Respond;
            arrival = Arrival;
            departure = Depart;
            backonbase = BackonBase;
            prep =Prep;
            check = Check;
            approve = Approve;
            noted = Noted;

            // Set the image
            if (picture != null)
            {
                pictureBoxPrint.Image = picture;
            }

            PopulateLabels();
            PopulateRespondents();
        }

        private void PopulateLabels()
        {
            label12.Text = Date;
  
            label14.Text = $"{Lastname}, {Firstname}";
            label9.Text = details;
            label13.Text = injuries;
            label25.Text = notes;
            label34.Text = timeoccured;
            label29.Text = place;
            label27.Text = addy;
            lbIncident.Text = incident;
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
        public void UpdateLabelText(string text)
        {
         
        }

        private void PopulateRespondents()
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


        private void button1_Click_1(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.AutoZoom = true;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            printDocument1.DefaultPageSettings.Landscape = true;


            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(bmp, e.PageBounds);

            bmp.Dispose();
        }




        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formfinalprint_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
                
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Formfinalprint_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}