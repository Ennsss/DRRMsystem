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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
namespace DRRMSystem
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }



        private void Formsettings_Load(object sender, EventArgs e)
        {

        }

        private void btnFire_Click(object sender, EventArgs e)
        {

        }

        private void btnFlood_Click(object sender, EventArgs e)
        {

        }

        private void btnFire_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.AutoZoom = true;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            // Set landscape mode
            printDocument1.DefaultPageSettings.Landscape = true;

            // Show print preview dialog
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a bitmap of the form
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            // Draw the bitmap onto the print page
            e.Graphics.DrawImage(bmp, e.PageBounds);

            // Dispose of the bitmap to free up resources
            bmp.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
