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


namespace DRRMSystem
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        FormIncident home;
        FormDisaster disaster;
        FormDashBoard dashboard;
        Formhistory history;
        FormChart settings;
        

        Formreg formreg;

        private void Form2_Load(object sender, EventArgs e)
        {
            button0.FlatStyle = FlatStyle.Flat;
            button0.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            panel1.BorderStyle = BorderStyle.None;
            menuContainer.BorderStyle = BorderStyle.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Database_FormClosed(object sender, FormClosedEventArgs e)
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (history == null)
            {
                history = new Formhistory();
                history.FormClosed += History_FormClosed;
                history.MdiParent = this;
                history.Show();
            }
            else { history.Activate(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (home == null)
            {
              FormDashBoard dashboard = new FormDashBoard();
                dashboard.FormClosed += DashBoard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (settings == null)
            {
                settings = new FormChart();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (home == null)
            {
                FormIncident home = new FormIncident();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width >= 175)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();
                    }
                }
            }
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void menuTransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 240)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (home == null)
            {
                FormDisaster disaster= new FormDisaster();
                disaster.FormClosed += Home_FormClosed;
                disaster.MdiParent = this;
                disaster.Show();
            }
            else
            {
                disaster.Activate();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}