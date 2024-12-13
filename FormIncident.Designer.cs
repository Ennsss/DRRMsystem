namespace DRRMSystem
{
    partial class FormIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncident));
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAddy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtDetails = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtxtDiagnosis = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbRespondents = new System.Windows.Forms.ComboBox();
            this.datepickarrival = new System.Windows.Forms.DateTimePicker();
            this.datepickdepart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAppr = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNoted = new System.Windows.Forms.TextBox();
            this.datepickbase = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.datepicktimeocc = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.datepickrespond = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tbIncident = new System.Windows.Forms.TextBox();
            this.cbCarCrash = new System.Windows.Forms.CheckBox();
            this.cbFight = new System.Windows.Forms.CheckBox();
            this.cbRob = new System.Windows.Forms.CheckBox();
            this.cbdnt = new System.Windows.Forms.CheckBox();
            this.lbRespondent = new System.Windows.Forms.ListBox();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtlastname.ForeColor = System.Drawing.Color.Black;
            this.txtlastname.Location = new System.Drawing.Point(389, 304);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(185, 24);
            this.txtlastname.TabIndex = 1;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            this.txtlastname.Enter += new System.EventHandler(this.txtlastname_Enter);
            this.txtlastname.Leave += new System.EventHandler(this.txtlastname_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(201)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1652, 925);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 119);
            this.button1.TabIndex = 9;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME OF VICTIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(181, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(181, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "INCIDENT TYPE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datepick
            // 
            this.datepick.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.datepick.Location = new System.Drawing.Point(239, 87);
            this.datepick.MaxDate = new System.DateTime(2024, 5, 8, 17, 49, 9, 0);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(380, 22);
            this.datepick.TabIndex = 2;
            this.datepick.Value = new System.DateTime(2024, 5, 8, 0, 0, 0, 0);
            this.datepick.ValueChanged += new System.EventHandler(this.datepick_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(461, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "IMAGES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(192, 304);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(185, 24);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            this.txtFirstname.Enter += new System.EventHandler(this.txtFirstname_Enter);
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // cbPlace
            // 
            this.cbPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.cbPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Items.AddRange(new object[] {
            "",
            "105 Street",
            "10th Avenue",
            "155 Street",
            "1st Avenue",
            "1st Street",
            "2nd Avenue",
            "2nd Street",
            "3rd Avenue",
            "4th Avenue",
            "51st Engr Street",
            "5th Avenue",
            "6th Avenue",
            "6th Street",
            "7th Avenue",
            "7th Street",
            "8th Avenue",
            "9th Avenue",
            "Abraham Street",
            "Acacia Street",
            "Almond Street",
            "Anuana Street",
            "Apitong Street",
            "Atis Street",
            "Avocado Street",
            "Azucena Street",
            "B. Medina Street",
            "Bagong Anyo Street",
            "Banuyo Street",
            "Bautista Street",
            "Birmingham Street",
            "Bridgestone Street",
            "Cadena de Amor Street",
            "Camia Street",
            "Champaca Street",
            "Charmain Street",
            "Chico Street",
            "Countryside Avenue",
            "Dahlia Street",
            "Dama De Noche Street",
            "Dao Street",
            "David Street",
            "De Castro Avenue",
            "Dma Compound",
            "Don Bosco",
            "Duhat Street",
            "Eagle Street",
            "East Bank Road (secondary)",
            "Eireene Extension",
            "Everlasting Street",
            "F. Legaspi Street (secondary)",
            "Falcon Street",
            "Gumamela Street",
            "Ilang-Ilang Street",
            "Intramuros Street",
            "Ipil Street",
            "Jacob Street",
            "Jasmin Street",
            "Jordan",
            "Joshua Street",
            "Juliana Uno Street",
            "Kalantas Street",
            "Kaunlaran Street",
            "Latvia",
            "Lirio Street",
            "M-14 Street (service)",
            "M-16 Street (service)",
            "M-79 Street (service)",
            "M. Lobeban Street",
            "M. Salamat Street",
            "Macalintal Street",
            "Maharlika Street",
            "Main Street",
            "Maligaya Street",
            "Malta",
            "Mangga Street",
            "Marietta Street",
            "Marikit Street",
            "Masagana Street",
            "Mayapis Street",
            "Mayumi Street",
            "Meleguas Street",
            "Metrogreen Drive",
            "Metrogreen Street",
            "Metropolis Street",
            "Michael Raymundo Street",
            "Molave Street",
            "Moralla Street",
            "Morocco",
            "Moses Street\t",
            "Narra",
            "Narra Street",
            "New Society Street (tertiary)",
            "Northwood Street",
            "Ortigas Avenue Extension (primary)",
            "Oval Street",
            "Palm",
            "Paradise Extension\t",
            "Real Street",
            "Recoletos Street",
            "Rissa Street",
            "Riverside Drive",
            "Roberto Antonio Street (tertiary)",
            "Ronaldo Isidro Street",
            "Rosabel Theresa Street",
            "Rose Street",
            "Saint Jude Street",
            "Sampaguita Street",
            "Santalia Street",
            "Santol Street",
            "Tangili Street",
            "Tramo Street",
            "V. Lualhati Street"});
            this.cbPlace.Location = new System.Drawing.Point(192, 365);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(382, 23);
            this.cbPlace.TabIndex = 3;
            this.cbPlace.SelectedIndexChanged += new System.EventHandler(this.cbPlace_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(177, 819);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "RESPONDENT/REPRESENTATIVE";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(905, 503);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 35);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "ATTACH";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 864);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // txtAddy
            // 
            this.txtAddy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtAddy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddy.Location = new System.Drawing.Point(194, 424);
            this.txtAddy.Name = "txtAddy";
            this.txtAddy.Size = new System.Drawing.Size(380, 23);
            this.txtAddy.TabIndex = 27;
            this.txtAddy.TextChanged += new System.EventHandler(this.txtAddy_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "PLACE";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "DETAILS";
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.rtxtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDetails.Location = new System.Drawing.Point(600, 277);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtDetails.Size = new System.Drawing.Size(320, 144);
            this.rtxtDetails.TabIndex = 31;
            this.rtxtDetails.Text = "";
            this.rtxtDetails.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtxtDetails_ContentsResized);
            this.rtxtDetails.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.rtxtDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtDetails_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(876, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "OTHERS";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "ADDRESS";
            // 
            // rtxtDiagnosis
            // 
            this.rtxtDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.rtxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDiagnosis.Location = new System.Drawing.Point(926, 277);
            this.rtxtDiagnosis.Name = "rtxtDiagnosis";
            this.rtxtDiagnosis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtDiagnosis.Size = new System.Drawing.Size(456, 191);
            this.rtxtDiagnosis.TabIndex = 47;
            this.rtxtDiagnosis.Text = "";
            this.rtxtDiagnosis.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtxtDiagnosis_ContentsResized);
            this.rtxtDiagnosis.TextChanged += new System.EventHandler(this.rtxtDiagnosis_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(927, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "DIAGNOSIS/INJURIES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(172, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 31);
            this.label13.TabIndex = 48;
            this.label13.Text = "VICTIM DETAILS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label14.Location = new System.Drawing.Point(176, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(266, 31);
            this.label14.TabIndex = 49;
            this.label14.Text = "INCIDENT DETAILS";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.rtxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(1397, 277);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtNotes.Size = new System.Drawing.Size(391, 424);
            this.rtxtNotes.TabIndex = 51;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtxtNotes_ContentsResized);
            this.rtxtNotes.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.Location = new System.Drawing.Point(1392, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "NOTE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(176, 778);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(325, 31);
            this.label15.TabIndex = 52;
            this.label15.Text = "RESPONDENT DETAILS";
            // 
            // cbRespondents
            // 
            this.cbRespondents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.cbRespondents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRespondents.FormattingEnabled = true;
            this.cbRespondents.Location = new System.Drawing.Point(185, 861);
            this.cbRespondents.Name = "cbRespondents";
            this.cbRespondents.Size = new System.Drawing.Size(235, 23);
            this.cbRespondents.TabIndex = 53;
            this.cbRespondents.SelectedIndexChanged += new System.EventHandler(this.cbRespondents_SelectedIndexChanged);
            // 
            // datepickarrival
            // 
            this.datepickarrival.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepickarrival.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datepickarrival.Location = new System.Drawing.Point(932, 875);
            this.datepickarrival.Name = "datepickarrival";
            this.datepickarrival.ShowUpDown = true;
            this.datepickarrival.Size = new System.Drawing.Size(234, 26);
            this.datepickarrival.TabIndex = 54;
            this.datepickarrival.ValueChanged += new System.EventHandler(this.datepickarrival_ValueChanged);
            // 
            // datepickdepart
            // 
            this.datepickdepart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepickdepart.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datepickdepart.Location = new System.Drawing.Point(1397, 832);
            this.datepickdepart.Name = "datepickdepart";
            this.datepickdepart.ShowUpDown = true;
            this.datepickdepart.Size = new System.Drawing.Size(234, 26);
            this.datepickdepart.TabIndex = 55;
            this.datepickdepart.ValueChanged += new System.EventHandler(this.datepickdepart_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(719, 837);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 24);
            this.label16.TabIndex = 57;
            this.label16.Text = "RESPONDING TIME";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(719, 877);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 24);
            this.label17.TabIndex = 58;
            this.label17.Text = "TIME OF ARRIVAL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1184, 834);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 24);
            this.label18.TabIndex = 59;
            this.label18.Text = "TIME OF DEPARTURE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1184, 875);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 24);
            this.label19.TabIndex = 60;
            this.label19.Text = "BACK ON BASE";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtPrep
            // 
            this.txtPrep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtPrep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrep.Location = new System.Drawing.Point(723, 968);
            this.txtPrep.Name = "txtPrep";
            this.txtPrep.Size = new System.Drawing.Size(185, 26);
            this.txtPrep.TabIndex = 8;
            this.txtPrep.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtPrep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(718, 927);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "PREPARED BY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label20.Location = new System.Drawing.Point(917, 927);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 25);
            this.label20.TabIndex = 62;
            this.label20.Text = "CHECKED BY";
            // 
            // txtCheck
            // 
            this.txtCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheck.Location = new System.Drawing.Point(922, 968);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(185, 26);
            this.txtCheck.TabIndex = 61;
            this.txtCheck.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label21.Location = new System.Drawing.Point(1124, 927);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 25);
            this.label21.TabIndex = 64;
            this.label21.Text = "APPROVED BY";
            // 
            // txtAppr
            // 
            this.txtAppr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtAppr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppr.Location = new System.Drawing.Point(1126, 968);
            this.txtAppr.Name = "txtAppr";
            this.txtAppr.Size = new System.Drawing.Size(185, 26);
            this.txtAppr.TabIndex = 63;
            this.txtAppr.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label22.Location = new System.Drawing.Point(1329, 927);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 25);
            this.label22.TabIndex = 66;
            this.label22.Text = "NOTED BY";
            // 
            // txtNoted
            // 
            this.txtNoted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtNoted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoted.Location = new System.Drawing.Point(1331, 968);
            this.txtNoted.Name = "txtNoted";
            this.txtNoted.Size = new System.Drawing.Size(168, 26);
            this.txtNoted.TabIndex = 65;
            this.txtNoted.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // datepickbase
            // 
            this.datepickbase.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepickbase.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datepickbase.Location = new System.Drawing.Point(1397, 875);
            this.datepickbase.Name = "datepickbase";
            this.datepickbase.ShowUpDown = true;
            this.datepickbase.Size = new System.Drawing.Size(234, 26);
            this.datepickbase.TabIndex = 56;
            this.datepickbase.ValueChanged += new System.EventHandler(this.datepickbase_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(173, 452);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 25);
            this.label23.TabIndex = 67;
            this.label23.Text = "AGE";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAge.Location = new System.Drawing.Point(226, 460);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 23);
            this.txtAge.TabIndex = 68;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.Location = new System.Drawing.Point(694, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 20);
            this.label24.TabIndex = 70;
            this.label24.Text = "TIME OCCURED";
            // 
            // datepicktimeocc
            // 
            this.datepicktimeocc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepicktimeocc.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datepicktimeocc.Location = new System.Drawing.Point(841, 82);
            this.datepicktimeocc.Name = "datepicktimeocc";
            this.datepicktimeocc.ShowUpDown = true;
            this.datepicktimeocc.Size = new System.Drawing.Size(255, 26);
            this.datepicktimeocc.TabIndex = 69;
            this.datepicktimeocc.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(435, 864);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 20);
            this.button4.TabIndex = 77;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datepickrespond
            // 
            this.datepickrespond.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datepickrespond.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datepickrespond.Location = new System.Drawing.Point(932, 832);
            this.datepickrespond.Name = "datepickrespond";
            this.datepickrespond.ShowUpDown = true;
            this.datepickrespond.Size = new System.Drawing.Size(234, 26);
            this.datepickrespond.TabIndex = 79;
            this.datepickrespond.ValueChanged += new System.EventHandler(this.datepickrespond_ValueChanged);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(106)))));
            this.label26.Location = new System.Drawing.Point(-4, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(1840, 23);
            this.label26.TabIndex = 81;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(106)))));
            this.label27.Location = new System.Drawing.Point(-52, 743);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1840, 19);
            this.label27.TabIndex = 82;
            // 
            // tbIncident
            // 
            this.tbIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.tbIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIncident.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbIncident.Location = new System.Drawing.Point(969, 159);
            this.tbIncident.Name = "tbIncident";
            this.tbIncident.Size = new System.Drawing.Size(255, 23);
            this.tbIncident.TabIndex = 83;
            this.tbIncident.TextChanged += new System.EventHandler(this.tbIncident_TextChanged);
            // 
            // cbCarCrash
            // 
            this.cbCarCrash.AutoSize = true;
            this.cbCarCrash.Location = new System.Drawing.Point(377, 163);
            this.cbCarCrash.Name = "cbCarCrash";
            this.cbCarCrash.Size = new System.Drawing.Size(99, 24);
            this.cbCarCrash.TabIndex = 84;
            this.cbCarCrash.Text = "Car Crash";
            this.cbCarCrash.UseVisualStyleBackColor = true;
            this.cbCarCrash.CheckedChanged += new System.EventHandler(this.cbCarCrash_CheckedChanged);
            // 
            // cbFight
            // 
            this.cbFight.AutoSize = true;
            this.cbFight.Location = new System.Drawing.Point(532, 163);
            this.cbFight.Name = "cbFight";
            this.cbFight.Size = new System.Drawing.Size(64, 24);
            this.cbFight.TabIndex = 85;
            this.cbFight.Text = "Fight";
            this.cbFight.UseVisualStyleBackColor = true;
            // 
            // cbRob
            // 
            this.cbRob.AutoSize = true;
            this.cbRob.Location = new System.Drawing.Point(658, 163);
            this.cbRob.Name = "cbRob";
            this.cbRob.Size = new System.Drawing.Size(88, 24);
            this.cbRob.TabIndex = 86;
            this.cbRob.Text = "Robbery";
            this.cbRob.UseVisualStyleBackColor = true;
            // 
            // cbdnt
            // 
            this.cbdnt.AutoSize = true;
            this.cbdnt.Location = new System.Drawing.Point(805, 161);
            this.cbdnt.Name = "cbdnt";
            this.cbdnt.Size = new System.Drawing.Size(54, 24);
            this.cbdnt.TabIndex = 87;
            this.cbdnt.Text = "N/A";
            this.cbdnt.UseVisualStyleBackColor = true;
            // 
            // lbRespondent
            // 
            this.lbRespondent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(185)))), ((int)(((byte)(171)))));
            this.lbRespondent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRespondent.FormattingEnabled = true;
            this.lbRespondent.ItemHeight = 20;
            this.lbRespondent.Location = new System.Drawing.Point(185, 890);
            this.lbRespondent.Name = "lbRespondent";
            this.lbRespondent.Size = new System.Drawing.Size(360, 82);
            this.lbRespondent.TabIndex = 88;
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrevImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrevImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevImage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevImage.Location = new System.Drawing.Point(905, 544);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(86, 35);
            this.btnPrevImage.TabIndex = 89;
            this.btnPrevImage.Text = "PREVIOUS IMAGE";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNextImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextImage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(905, 585);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(86, 35);
            this.btnNextImage.TabIndex = 90;
            this.btnNextImage.Text = "NEXT IMAGE";
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(749, 136);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(602, 137);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(478, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(321, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1552, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1673, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormIncident
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1800, 1084);
            this.ControlBox = false;
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.lbRespondent);
            this.Controls.Add(this.cbdnt);
            this.Controls.Add(this.cbRob);
            this.Controls.Add(this.cbFight);
            this.Controls.Add(this.cbCarCrash);
            this.Controls.Add(this.tbIncident);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.datepickrespond);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.datepicktimeocc);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtNoted);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAppr);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.datepickbase);
            this.Controls.Add(this.datepickdepart);
            this.Controls.Add(this.datepickarrival);
            this.Controls.Add(this.cbRespondents);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rtxtDiagnosis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.rtxtDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrep);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlastname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIncident";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Formhome";
            this.Load += new System.EventHandler(this.Formhome_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtlastname;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker datepick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private TextBox txtFirstname;
        private ComboBox cbPlace;
        private Label label5;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnInsert;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private TextBox txtAddy;
        private Label label7;
        private Label label8;
        private RichTextBox rtxtDetails;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label10;
        private Label label11;
        private RichTextBox rtxtDiagnosis;
        private Label label12;
        private Label label13;
        private Label label14;
        private RichTextBox rtxtNotes;
        private Label label9;
        private Label label15;
        private ComboBox cbRespondents;
        private DateTimePicker datepickarrival;
        private DateTimePicker datepickdepart;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtPrep;
        private Label label6;
        private Label label20;
        private TextBox txtCheck;
        private Label label21;
        private TextBox txtAppr;
        private Label label22;
        private TextBox txtNoted;
        private DateTimePicker datepickbase;
        private Label label23;
        private TextBox txtAge;
        private Label label24;
        private DateTimePicker datepicktimeocc;
        private Button button4;
        private DateTimePicker datepickrespond;
        private Label label26;
        private Label label27;
        private TextBox tbIncident;
        private CheckBox cbCarCrash;
        private CheckBox cbFight;
        private CheckBox cbRob;
        private CheckBox cbdnt;
        private ListBox lbRespondent;
        private Button btnPrevImage;
        private Button btnNextImage;
        private ImageList imageList1;
    }
}