
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmVaraukset
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbEnintaan = new System.Windows.Forms.TextBox();
            this.tbVahintaan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpVarauksen_alkupvm = new System.Windows.Forms.DateTimePicker();
            this.dgvVapaat = new System.Windows.Forms.DataGridView();
            this.dtpVarauksen_loppupvm = new System.Windows.Forms.DateTimePicker();
            this.btnEtsiMokit = new System.Windows.Forms.Button();
            this.cbAlue2 = new System.Windows.Forms.ComboBox();
            this.label164 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAsiakasTiedot = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpVahvistus_pvm = new System.Windows.Forms.DateTimePicker();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.btnLisaa_varaus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMokki_ID = new System.Windows.Forms.TextBox();
            this.tbAsiakas_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVaraus_ID = new System.Windows.Forms.TextBox();
            this.dtpVarattu_pvm = new System.Windows.Forms.DateTimePicker();
            this.btnPoista_varaus = new System.Windows.Forms.Button();
            this.btnPaivita_varaus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudLkm = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPalvelut = new System.Windows.Forms.ComboBox();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.btnLisaaVarauksenPalvelu = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLaske = new System.Windows.Forms.Button();
            this.rtbLasku = new System.Windows.Forms.RichTextBox();
            this.btnLisaaLasku = new System.Windows.Forms.Button();
            this.tbLasku_ID = new System.Windows.Forms.TextBox();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakasTiedot)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLkm)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Majoituksen varaus";
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(182, 12);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(205, 29);
            this.btnTyhjenna.TabIndex = 74;
            this.btnTyhjenna.Text = "Tyhjennä tekstikentät";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.btnTyhjenna);
            this.panel4.Controls.Add(this.btnTakaisin);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1480, 58);
            this.panel4.TabIndex = 67;
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(12, 12);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(155, 29);
            this.btnTakaisin.TabIndex = 57;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.tbEnintaan);
            this.groupBox1.Controls.Add(this.tbVahintaan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpVarauksen_alkupvm);
            this.groupBox1.Controls.Add(this.dgvVapaat);
            this.groupBox1.Controls.Add(this.dtpVarauksen_loppupvm);
            this.groupBox1.Controls.Add(this.btnEtsiMokit);
            this.groupBox1.Controls.Add(this.cbAlue2);
            this.groupBox1.Controls.Add(this.label164);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 251);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vapaana olevat mökit";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(209, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 88;
            this.label21.Text = "-";
            // 
            // tbEnintaan
            // 
            this.tbEnintaan.Location = new System.Drawing.Point(225, 134);
            this.tbEnintaan.Name = "tbEnintaan";
            this.tbEnintaan.Size = new System.Drawing.Size(161, 22);
            this.tbEnintaan.TabIndex = 2;
            // 
            // tbVahintaan
            // 
            this.tbVahintaan.Location = new System.Drawing.Point(42, 134);
            this.tbVahintaan.Name = "tbVahintaan";
            this.tbVahintaan.Size = new System.Drawing.Size(161, 22);
            this.tbVahintaan.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "Valitse hintaluokka";
            // 
            // dtpVarauksen_alkupvm
            // 
            this.dtpVarauksen_alkupvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksen_alkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksen_alkupvm.Location = new System.Drawing.Point(40, 201);
            this.dtpVarauksen_alkupvm.Name = "dtpVarauksen_alkupvm";
            this.dtpVarauksen_alkupvm.Size = new System.Drawing.Size(163, 22);
            this.dtpVarauksen_alkupvm.TabIndex = 3;
            // 
            // dgvVapaat
            // 
            this.dgvVapaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVapaat.Location = new System.Drawing.Point(603, 43);
            this.dgvVapaat.Name = "dgvVapaat";
            this.dgvVapaat.RowHeadersWidth = 51;
            this.dgvVapaat.RowTemplate.Height = 24;
            this.dgvVapaat.Size = new System.Drawing.Size(489, 180);
            this.dgvVapaat.TabIndex = 6;
            this.dgvVapaat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVapaat_MouseClick);
            // 
            // dtpVarauksen_loppupvm
            // 
            this.dtpVarauksen_loppupvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksen_loppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksen_loppupvm.Location = new System.Drawing.Point(223, 201);
            this.dtpVarauksen_loppupvm.Name = "dtpVarauksen_loppupvm";
            this.dtpVarauksen_loppupvm.Size = new System.Drawing.Size(163, 22);
            this.dtpVarauksen_loppupvm.TabIndex = 4;
            // 
            // btnEtsiMokit
            // 
            this.btnEtsiMokit.Location = new System.Drawing.Point(444, 196);
            this.btnEtsiMokit.Name = "btnEtsiMokit";
            this.btnEtsiMokit.Size = new System.Drawing.Size(116, 27);
            this.btnEtsiMokit.TabIndex = 5;
            this.btnEtsiMokit.Text = "Etsi";
            this.btnEtsiMokit.UseVisualStyleBackColor = true;
            this.btnEtsiMokit.Click += new System.EventHandler(this.btnEtsiMokit_Click);
            // 
            // cbAlue2
            // 
            this.cbAlue2.FormattingEnabled = true;
            this.cbAlue2.Location = new System.Drawing.Point(42, 63);
            this.cbAlue2.Name = "cbAlue2";
            this.cbAlue2.Size = new System.Drawing.Size(163, 24);
            this.cbAlue2.TabIndex = 0;
            this.cbAlue2.SelectedIndexChanged += new System.EventHandler(this.cbAlue2_SelectedIndexChanged);
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(39, 43);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(81, 17);
            this.label164.TabIndex = 79;
            this.label164.Text = "Valitse alue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Saapumispäivä";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Lähtöpäivä";
            // 
            // dgvAsiakasTiedot
            // 
            this.dgvAsiakasTiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakasTiedot.Location = new System.Drawing.Point(21, 43);
            this.dgvAsiakasTiedot.Name = "dgvAsiakasTiedot";
            this.dgvAsiakasTiedot.RowHeadersWidth = 51;
            this.dgvAsiakasTiedot.RowTemplate.Height = 24;
            this.dgvAsiakasTiedot.Size = new System.Drawing.Size(290, 180);
            this.dgvAsiakasTiedot.TabIndex = 0;
            this.dgvAsiakasTiedot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAsiakasTiedot_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAsiakasTiedot);
            this.groupBox2.Location = new System.Drawing.Point(1133, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 251);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asiakas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpVahvistus_pvm);
            this.groupBox3.Controls.Add(this.dgvVaraukset);
            this.groupBox3.Controls.Add(this.btnEtsi);
            this.groupBox3.Controls.Add(this.btnLisaa_varaus);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbMokki_ID);
            this.groupBox3.Controls.Add(this.tbAsiakas_ID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbVaraus_ID);
            this.groupBox3.Controls.Add(this.dtpVarattu_pvm);
            this.groupBox3.Controls.Add(this.btnPoista_varaus);
            this.groupBox3.Controls.Add(this.btnPaivita_varaus);
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1456, 277);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hallitse varauksia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Varauksen päivä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Vahvistus päivä";
            // 
            // dtpVahvistus_pvm
            // 
            this.dtpVahvistus_pvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVahvistus_pvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVahvistus_pvm.Location = new System.Drawing.Point(304, 185);
            this.dtpVahvistus_pvm.Name = "dtpVahvistus_pvm";
            this.dtpVahvistus_pvm.Size = new System.Drawing.Size(193, 22);
            this.dtpVahvistus_pvm.TabIndex = 5;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(603, 37);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersWidth = 51;
            this.dgvVaraukset.RowTemplate.Height = 24;
            this.dgvVaraukset.Size = new System.Drawing.Size(829, 223);
            this.dgvVaraukset.TabIndex = 9;
            this.dgvVaraukset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVaraukset_MouseClick);
            // 
            // btnEtsi
            // 
            this.btnEtsi.Location = new System.Drawing.Point(304, 56);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(75, 23);
            this.btnEtsi.TabIndex = 1;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // btnLisaa_varaus
            // 
            this.btnLisaa_varaus.Location = new System.Drawing.Point(423, 237);
            this.btnLisaa_varaus.Name = "btnLisaa_varaus";
            this.btnLisaa_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa_varaus.TabIndex = 8;
            this.btnLisaa_varaus.Text = "Lisää";
            this.btnLisaa_varaus.UseVisualStyleBackColor = true;
            this.btnLisaa_varaus.Click += new System.EventHandler(this.btnLisaa_varaus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mokki ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Asiakas ID";
            // 
            // tbMokki_ID
            // 
            this.tbMokki_ID.Location = new System.Drawing.Point(42, 125);
            this.tbMokki_ID.Name = "tbMokki_ID";
            this.tbMokki_ID.Size = new System.Drawing.Size(193, 22);
            this.tbMokki_ID.TabIndex = 2;
            // 
            // tbAsiakas_ID
            // 
            this.tbAsiakas_ID.Location = new System.Drawing.Point(304, 125);
            this.tbAsiakas_ID.Name = "tbAsiakas_ID";
            this.tbAsiakas_ID.Size = new System.Drawing.Size(193, 22);
            this.tbAsiakas_ID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Varaus ID";
            // 
            // tbVaraus_ID
            // 
            this.tbVaraus_ID.Location = new System.Drawing.Point(42, 57);
            this.tbVaraus_ID.Name = "tbVaraus_ID";
            this.tbVaraus_ID.Size = new System.Drawing.Size(193, 22);
            this.tbVaraus_ID.TabIndex = 0;
            // 
            // dtpVarattu_pvm
            // 
            this.dtpVarattu_pvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarattu_pvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarattu_pvm.Location = new System.Drawing.Point(42, 185);
            this.dtpVarattu_pvm.Name = "dtpVarattu_pvm";
            this.dtpVarattu_pvm.Size = new System.Drawing.Size(193, 22);
            this.dtpVarattu_pvm.TabIndex = 4;
            // 
            // btnPoista_varaus
            // 
            this.btnPoista_varaus.Location = new System.Drawing.Point(42, 237);
            this.btnPoista_varaus.Name = "btnPoista_varaus";
            this.btnPoista_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnPoista_varaus.TabIndex = 6;
            this.btnPoista_varaus.Text = "Poista";
            this.btnPoista_varaus.UseVisualStyleBackColor = true;
            this.btnPoista_varaus.Click += new System.EventHandler(this.btnPoista_varaus_Click);
            // 
            // btnPaivita_varaus
            // 
            this.btnPaivita_varaus.Location = new System.Drawing.Point(304, 237);
            this.btnPaivita_varaus.Name = "btnPaivita_varaus";
            this.btnPaivita_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita_varaus.TabIndex = 7;
            this.btnPaivita_varaus.Text = "Päivitä";
            this.btnPaivita_varaus.UseVisualStyleBackColor = true;
            this.btnPaivita_varaus.Click += new System.EventHandler(this.btnPaivita_varaus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nudLkm);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cbPalvelut);
            this.groupBox4.Controls.Add(this.tbPalveluID);
            this.groupBox4.Controls.Add(this.btnLisaaVarauksenPalvelu);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 604);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 231);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lisää palveluita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Palvelu";
            // 
            // nudLkm
            // 
            this.nudLkm.Location = new System.Drawing.Point(40, 185);
            this.nudLkm.Name = "nudLkm";
            this.nudLkm.Size = new System.Drawing.Size(159, 22);
            this.nudLkm.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lukumäärä";
            // 
            // cbPalvelut
            // 
            this.cbPalvelut.FormattingEnabled = true;
            this.cbPalvelut.Location = new System.Drawing.Point(40, 64);
            this.cbPalvelut.Name = "cbPalvelut";
            this.cbPalvelut.Size = new System.Drawing.Size(159, 24);
            this.cbPalvelut.TabIndex = 0;
            this.cbPalvelut.SelectedIndexChanged += new System.EventHandler(this.cbPalvelut_SelectedIndexChanged_1);
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(40, 125);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(159, 22);
            this.tbPalveluID.TabIndex = 1;
            // 
            // btnLisaaVarauksenPalvelu
            // 
            this.btnLisaaVarauksenPalvelu.Location = new System.Drawing.Point(249, 183);
            this.btnLisaaVarauksenPalvelu.Name = "btnLisaaVarauksenPalvelu";
            this.btnLisaaVarauksenPalvelu.Size = new System.Drawing.Size(94, 23);
            this.btnLisaaVarauksenPalvelu.TabIndex = 3;
            this.btnLisaaVarauksenPalvelu.Text = "Lisää";
            this.btnLisaaVarauksenPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaVarauksenPalvelu.Click += new System.EventHandler(this.btnLisaaVarauksenPalvelu_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Palvelu ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.btnLaske);
            this.groupBox5.Controls.Add(this.rtbLasku);
            this.groupBox5.Controls.Add(this.btnLisaaLasku);
            this.groupBox5.Controls.Add(this.tbLasku_ID);
            this.groupBox5.Controls.Add(this.tbAlv);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.tbSumma);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(402, 604);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1066, 231);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Laskutus";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(442, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 17);
            this.label16.TabIndex = 86;
            this.label16.Text = "Laske veroton kokonaishinta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(748, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 85;
            this.label14.Text = "Lisää lasku";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 84;
            this.label11.Text = "Laskun erittely";
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(445, 76);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(188, 23);
            this.btnLaske.TabIndex = 1;
            this.btnLaske.Text = "Laske";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // rtbLasku
            // 
            this.rtbLasku.Location = new System.Drawing.Point(43, 63);
            this.rtbLasku.Name = "rtbLasku";
            this.rtbLasku.Size = new System.Drawing.Size(303, 142);
            this.rtbLasku.TabIndex = 0;
            this.rtbLasku.Text = "";
            // 
            // btnLisaaLasku
            // 
            this.btnLisaaLasku.Location = new System.Drawing.Point(927, 182);
            this.btnLisaaLasku.Name = "btnLisaaLasku";
            this.btnLisaaLasku.Size = new System.Drawing.Size(114, 23);
            this.btnLisaaLasku.TabIndex = 5;
            this.btnLisaaLasku.Text = "Lisää";
            this.btnLisaaLasku.UseVisualStyleBackColor = true;
            this.btnLisaaLasku.Click += new System.EventHandler(this.btnLisaaLasku_Click);
            // 
            // tbLasku_ID
            // 
            this.tbLasku_ID.Location = new System.Drawing.Point(751, 113);
            this.tbLasku_ID.Name = "tbLasku_ID";
            this.tbLasku_ID.Size = new System.Drawing.Size(114, 22);
            this.tbLasku_ID.TabIndex = 2;
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(751, 183);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(114, 22);
            this.tbAlv.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(748, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 77;
            this.label20.Text = "Lasku ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(924, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 17);
            this.label22.TabIndex = 78;
            this.label22.Text = "Summa";
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(927, 113);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(114, 22);
            this.tbSumma.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(748, 163);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 17);
            this.label23.TabIndex = 79;
            this.label23.Text = "Alv";
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 848);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(1498, 895);
            this.Name = "frmVaraukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVaraukset_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakasTiedot)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLkm)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbEnintaan;
        private System.Windows.Forms.TextBox tbVahintaan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpVarauksen_alkupvm;
        private System.Windows.Forms.DataGridView dgvVapaat;
        private System.Windows.Forms.DateTimePicker dtpVarauksen_loppupvm;
        private System.Windows.Forms.Button btnEtsiMokit;
        private System.Windows.Forms.ComboBox cbAlue2;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAsiakasTiedot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVahvistus_pvm;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.Button btnEtsi;
        private System.Windows.Forms.Button btnLisaa_varaus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMokki_ID;
        private System.Windows.Forms.TextBox tbAsiakas_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVaraus_ID;
        private System.Windows.Forms.DateTimePicker dtpVarattu_pvm;
        private System.Windows.Forms.Button btnPoista_varaus;
        private System.Windows.Forms.Button btnPaivita_varaus;
        private System.Windows.Forms.GroupBox groupBox4;
        protected internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudLkm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPalvelut;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.Button btnLisaaVarauksenPalvelu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.RichTextBox rtbLasku;
        private System.Windows.Forms.Button btnLisaaLasku;
        private System.Windows.Forms.TextBox tbLasku_ID;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.Label label23;
    }
}