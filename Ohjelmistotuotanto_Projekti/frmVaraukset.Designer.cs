
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
            this.dtpVarauksen_loppupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpVarauksen_alkupvm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnLaske = new System.Windows.Forms.Button();
            this.rtbLasku = new System.Windows.Forms.RichTextBox();
            this.btnLisaaLasku = new System.Windows.Forms.Button();
            this.tbLasku_ID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnEtsiMokit = new System.Windows.Forms.Button();
            this.dgvVapaat = new System.Windows.Forms.DataGridView();
            this.cbAlue2 = new System.Windows.Forms.ComboBox();
            this.label164 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAsiakasTiedot = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLisaaVarauksenPalvelu = new System.Windows.Forms.Button();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.cbPalvelut = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudLkm = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
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
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapaat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakasTiedot)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLkm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVarauksen_loppupvm
            // 
            this.dtpVarauksen_loppupvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksen_loppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksen_loppupvm.Location = new System.Drawing.Point(216, 172);
            this.dtpVarauksen_loppupvm.Name = "dtpVarauksen_loppupvm";
            this.dtpVarauksen_loppupvm.Size = new System.Drawing.Size(212, 22);
            this.dtpVarauksen_loppupvm.TabIndex = 35;
            // 
            // dtpVarauksen_alkupvm
            // 
            this.dtpVarauksen_alkupvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksen_alkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksen_alkupvm.Location = new System.Drawing.Point(216, 131);
            this.dtpVarauksen_alkupvm.Name = "dtpVarauksen_alkupvm";
            this.dtpVarauksen_alkupvm.Size = new System.Drawing.Size(212, 22);
            this.dtpVarauksen_alkupvm.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "varauksen loppupvm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Varauksen alkupvm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Majoituksen varaus";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnLaske);
            this.panel1.Controls.Add(this.rtbLasku);
            this.panel1.Controls.Add(this.btnLisaaLasku);
            this.panel1.Controls.Add(this.tbLasku_ID);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.tbAlv);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.tbSumma);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(670, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 282);
            this.panel1.TabIndex = 56;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(202, 18);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(155, 36);
            this.btnTyhjenna.TabIndex = 74;
            this.btnTyhjenna.Text = "Tyhjennä tekstikentät";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(343, 73);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(261, 39);
            this.btnLaske.TabIndex = 0;
            this.btnLaske.Text = "Laske kokonaishinta";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // rtbLasku
            // 
            this.rtbLasku.Location = new System.Drawing.Point(19, 71);
            this.rtbLasku.Name = "rtbLasku";
            this.rtbLasku.Size = new System.Drawing.Size(254, 176);
            this.rtbLasku.TabIndex = 64;
            this.rtbLasku.Text = "";
            // 
            // btnLisaaLasku
            // 
            this.btnLisaaLasku.Location = new System.Drawing.Point(529, 240);
            this.btnLisaaLasku.Name = "btnLisaaLasku";
            this.btnLisaaLasku.Size = new System.Drawing.Size(75, 23);
            this.btnLisaaLasku.TabIndex = 73;
            this.btnLisaaLasku.Text = "Lisää";
            this.btnLisaaLasku.UseVisualStyleBackColor = true;
            this.btnLisaaLasku.Click += new System.EventHandler(this.btnLisaaLasku_Click);
            // 
            // tbLasku_ID
            // 
            this.tbLasku_ID.Location = new System.Drawing.Point(490, 130);
            this.tbLasku_ID.Name = "tbLasku_ID";
            this.tbLasku_ID.Size = new System.Drawing.Size(114, 22);
            this.tbLasku_ID.TabIndex = 69;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 25);
            this.label19.TabIndex = 64;
            this.label19.Text = "Laskutus";
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(490, 212);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(114, 22);
            this.tbAlv.TabIndex = 72;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(340, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 65;
            this.label20.Text = "Lasku ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(340, 173);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 17);
            this.label22.TabIndex = 67;
            this.label22.Text = "Summa";
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(490, 170);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(114, 22);
            this.tbSumma.TabIndex = 71;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(340, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 17);
            this.label23.TabIndex = 68;
            this.label23.Text = "Alv";
            // 
            // btnEtsiMokit
            // 
            this.btnEtsiMokit.Location = new System.Drawing.Point(216, 205);
            this.btnEtsiMokit.Name = "btnEtsiMokit";
            this.btnEtsiMokit.Size = new System.Drawing.Size(212, 27);
            this.btnEtsiMokit.TabIndex = 65;
            this.btnEtsiMokit.Text = "Etsi";
            this.btnEtsiMokit.UseVisualStyleBackColor = true;
            this.btnEtsiMokit.Click += new System.EventHandler(this.btnEtsiMokit_Click);
            // 
            // dgvVapaat
            // 
            this.dgvVapaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVapaat.Location = new System.Drawing.Point(479, 87);
            this.dgvVapaat.Name = "dgvVapaat";
            this.dgvVapaat.RowHeadersWidth = 51;
            this.dgvVapaat.RowTemplate.Height = 24;
            this.dgvVapaat.Size = new System.Drawing.Size(390, 107);
            this.dgvVapaat.TabIndex = 64;
            this.dgvVapaat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVapaat_MouseClick);
            // 
            // cbAlue2
            // 
            this.cbAlue2.FormattingEnabled = true;
            this.cbAlue2.Location = new System.Drawing.Point(216, 87);
            this.cbAlue2.Name = "cbAlue2";
            this.cbAlue2.Size = new System.Drawing.Size(212, 24);
            this.cbAlue2.TabIndex = 63;
            this.cbAlue2.SelectedIndexChanged += new System.EventHandler(this.cbAlue2_SelectedIndexChanged);
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(35, 90);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(81, 17);
            this.label164.TabIndex = 62;
            this.label164.Text = "Valitse alue";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dgvAsiakasTiedot);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.dtpVarauksen_alkupvm);
            this.panel3.Controls.Add(this.dgvVapaat);
            this.panel3.Controls.Add(this.dtpVarauksen_loppupvm);
            this.panel3.Controls.Add(this.btnEtsiMokit);
            this.panel3.Controls.Add(this.cbAlue2);
            this.panel3.Controls.Add(this.label164);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1447, 251);
            this.panel3.TabIndex = 66;
            // 
            // dgvAsiakasTiedot
            // 
            this.dgvAsiakasTiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakasTiedot.Location = new System.Drawing.Point(1088, 71);
            this.dgvAsiakasTiedot.Name = "dgvAsiakasTiedot";
            this.dgvAsiakasTiedot.RowHeadersWidth = 51;
            this.dgvAsiakasTiedot.RowTemplate.Height = 24;
            this.dgvAsiakasTiedot.Size = new System.Drawing.Size(315, 123);
            this.dgvAsiakasTiedot.TabIndex = 1;
            this.dgvAsiakasTiedot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAsiakasTiedot_MouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 25);
            this.label16.TabIndex = 66;
            this.label16.Text = "Etsi vapaana olevat mökit";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1092, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Valitse asiakas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.btnTyhjenna);
            this.panel4.Controls.Add(this.btnTakaisin);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1480, 76);
            this.panel4.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(365, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "Palvelu ID";
            // 
            // btnLisaaVarauksenPalvelu
            // 
            this.btnLisaaVarauksenPalvelu.Location = new System.Drawing.Point(368, 119);
            this.btnLisaaVarauksenPalvelu.Name = "btnLisaaVarauksenPalvelu";
            this.btnLisaaVarauksenPalvelu.Size = new System.Drawing.Size(75, 23);
            this.btnLisaaVarauksenPalvelu.TabIndex = 62;
            this.btnLisaaVarauksenPalvelu.Text = "Lisää";
            this.btnLisaaVarauksenPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaVarauksenPalvelu.Click += new System.EventHandler(this.btnLisaaVarauksenPalvelu_Click);
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(486, 71);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(126, 22);
            this.tbPalveluID.TabIndex = 61;
            // 
            // cbPalvelut
            // 
            this.cbPalvelut.FormattingEnabled = true;
            this.cbPalvelut.Location = new System.Drawing.Point(176, 71);
            this.cbPalvelut.Name = "cbPalvelut";
            this.cbPalvelut.Size = new System.Drawing.Size(126, 24);
            this.cbPalvelut.TabIndex = 57;
            this.cbPalvelut.SelectedIndexChanged += new System.EventHandler(this.cbPalvelut_SelectedIndexChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "Lukumäärä";
            // 
            // nudLkm
            // 
            this.nudLkm.Location = new System.Drawing.Point(176, 120);
            this.nudLkm.Name = "nudLkm";
            this.nudLkm.Size = new System.Drawing.Size(126, 22);
            this.nudLkm.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 25);
            this.label14.TabIndex = 56;
            this.label14.Text = "Lisää palvelu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Valitse palvelut";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnPoista);
            this.panel2.Controls.Add(this.dgvPalvelut);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.nudLkm);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbPalvelut);
            this.panel2.Controls.Add(this.tbPalveluID);
            this.panel2.Controls.Add(this.btnLisaaVarauksenPalvelu);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(15, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 282);
            this.panel2.TabIndex = 57;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(537, 118);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 25);
            this.btnPoista.TabIndex = 65;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(31, 170);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersWidth = 51;
            this.dgvPalvelut.RowTemplate.Height = 24;
            this.dgvPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalvelut.Size = new System.Drawing.Size(581, 81);
            this.dgvPalvelut.TabIndex = 64;
            this.dgvPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPalvelut_MouseClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.dtpVahvistus_pvm);
            this.panel5.Controls.Add(this.dgvVaraukset);
            this.panel5.Controls.Add(this.btnEtsi);
            this.panel5.Controls.Add(this.btnLisaa_varaus);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.tbMokki_ID);
            this.panel5.Controls.Add(this.tbAsiakas_ID);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tbVaraus_ID);
            this.panel5.Controls.Add(this.dtpVarattu_pvm);
            this.panel5.Controls.Add(this.btnPoista_varaus);
            this.panel5.Controls.Add(this.btnPaivita_varaus);
            this.panel5.Location = new System.Drawing.Point(13, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1446, 277);
            this.panel5.TabIndex = 68;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 25);
            this.label17.TabIndex = 56;
            this.label17.Text = "Hallitse varauksia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Varauksen päivämäärä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Vahvistus päivä";
            // 
            // dtpVahvistus_pvm
            // 
            this.dtpVahvistus_pvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVahvistus_pvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVahvistus_pvm.Location = new System.Drawing.Point(264, 235);
            this.dtpVahvistus_pvm.Name = "dtpVahvistus_pvm";
            this.dtpVahvistus_pvm.Size = new System.Drawing.Size(193, 22);
            this.dtpVahvistus_pvm.TabIndex = 51;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(648, 74);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersWidth = 51;
            this.dgvVaraukset.RowTemplate.Height = 24;
            this.dgvVaraukset.Size = new System.Drawing.Size(783, 186);
            this.dgvVaraukset.TabIndex = 41;
            this.dgvVaraukset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVaraukset_MouseClick);
            // 
            // btnEtsi
            // 
            this.btnEtsi.Location = new System.Drawing.Point(407, 74);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(75, 23);
            this.btnEtsi.TabIndex = 55;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // btnLisaa_varaus
            // 
            this.btnLisaa_varaus.Location = new System.Drawing.Point(555, 74);
            this.btnLisaa_varaus.Name = "btnLisaa_varaus";
            this.btnLisaa_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa_varaus.TabIndex = 52;
            this.btnLisaa_varaus.Text = "Lisää";
            this.btnLisaa_varaus.UseVisualStyleBackColor = true;
            this.btnLisaa_varaus.Click += new System.EventHandler(this.btnLisaa_varaus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "MokkiID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "AsiakasID";
            // 
            // tbMokki_ID
            // 
            this.tbMokki_ID.Location = new System.Drawing.Point(264, 112);
            this.tbMokki_ID.Name = "tbMokki_ID";
            this.tbMokki_ID.Size = new System.Drawing.Size(89, 22);
            this.tbMokki_ID.TabIndex = 49;
            // 
            // tbAsiakas_ID
            // 
            this.tbAsiakas_ID.Location = new System.Drawing.Point(264, 150);
            this.tbAsiakas_ID.Name = "tbAsiakas_ID";
            this.tbAsiakas_ID.Size = new System.Drawing.Size(89, 22);
            this.tbAsiakas_ID.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "VarausID";
            // 
            // tbVaraus_ID
            // 
            this.tbVaraus_ID.Location = new System.Drawing.Point(264, 74);
            this.tbVaraus_ID.Name = "tbVaraus_ID";
            this.tbVaraus_ID.Size = new System.Drawing.Size(89, 22);
            this.tbVaraus_ID.TabIndex = 47;
            // 
            // dtpVarattu_pvm
            // 
            this.dtpVarattu_pvm.CustomFormat = "yyyy-MM-dd";
            this.dtpVarattu_pvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarattu_pvm.Location = new System.Drawing.Point(264, 191);
            this.dtpVarattu_pvm.Name = "dtpVarattu_pvm";
            this.dtpVarattu_pvm.Size = new System.Drawing.Size(193, 22);
            this.dtpVarattu_pvm.TabIndex = 50;
            // 
            // btnPoista_varaus
            // 
            this.btnPoista_varaus.Location = new System.Drawing.Point(555, 234);
            this.btnPoista_varaus.Name = "btnPoista_varaus";
            this.btnPoista_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnPoista_varaus.TabIndex = 53;
            this.btnPoista_varaus.Text = "Poista";
            this.btnPoista_varaus.UseVisualStyleBackColor = true;
            this.btnPoista_varaus.Click += new System.EventHandler(this.btnPoista_varaus_Click);
            // 
            // btnPaivita_varaus
            // 
            this.btnPaivita_varaus.Location = new System.Drawing.Point(555, 149);
            this.btnPaivita_varaus.Name = "btnPaivita_varaus";
            this.btnPaivita_varaus.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita_varaus.TabIndex = 54;
            this.btnPaivita_varaus.Text = "Päivitä";
            this.btnPaivita_varaus.UseVisualStyleBackColor = true;
            this.btnPaivita_varaus.Click += new System.EventHandler(this.btnPaivita_varaus_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(24, 18);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(155, 36);
            this.btnTakaisin.TabIndex = 57;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 916);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1498, 963);
            this.Name = "frmVaraukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Vauraukset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapaat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakasTiedot)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLkm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpVarauksen_loppupvm;
        private System.Windows.Forms.DateTimePicker dtpVarauksen_alkupvm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEtsiMokit;
        private System.Windows.Forms.DataGridView dgvVapaat;
        private System.Windows.Forms.ComboBox cbAlue2;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvAsiakasTiedot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.TextBox tbLasku_ID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLisaaLasku;
        private System.Windows.Forms.RichTextBox rtbLasku;
        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLisaaVarauksenPalvelu;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.ComboBox cbPalvelut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudLkm;
        private System.Windows.Forms.Label label14;
        protected internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPalvelut;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnTakaisin;
    }
}