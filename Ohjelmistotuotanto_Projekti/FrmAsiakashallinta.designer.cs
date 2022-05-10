
namespace Ohjelmistotuotanto_Projekti
{
    partial class FrmAsiakashallinta
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
            this.tbPostnum = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPuhnum = new System.Windows.Forms.TextBox();
            this.lbPostnum = new System.Windows.Forms.Label();
            this.lbEtunimi = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbSukunimi = new System.Windows.Forms.Label();
            this.lbPuhnum = new System.Windows.Forms.Label();
            this.btnLisaaTieto = new System.Windows.Forms.Button();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.lbPostitoimipaikka = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.lbAsiakashallinta = new System.Windows.Forms.Label();
            this.lbAsiakasOtsake = new System.Windows.Forms.Label();
            this.lbAsiakasID = new System.Windows.Forms.Label();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.dgvFullAsiakas = new System.Windows.Forms.DataGridView();
            this.lbPostinro = new System.Windows.Forms.Label();
            this.btnTakaisin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullAsiakas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPostnum
            // 
            this.tbPostnum.Location = new System.Drawing.Point(19, 164);
            this.tbPostnum.MaxLength = 5;
            this.tbPostnum.Name = "tbPostnum";
            this.tbPostnum.Size = new System.Drawing.Size(219, 20);
            this.tbPostnum.TabIndex = 2;
            this.tbPostnum.Leave += new System.EventHandler(this.tbPostnum_Leave);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(19, 249);
            this.tbSukunimi.MaxLength = 40;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(219, 20);
            this.tbSukunimi.TabIndex = 4;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(19, 205);
            this.tbEtunimi.MaxLength = 20;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(219, 20);
            this.tbEtunimi.TabIndex = 3;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(19, 293);
            this.tbLahiosoite.MaxLength = 40;
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(219, 20);
            this.tbLahiosoite.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(19, 337);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbPuhnum
            // 
            this.tbPuhnum.Location = new System.Drawing.Point(19, 378);
            this.tbPuhnum.MaxLength = 15;
            this.tbPuhnum.Name = "tbPuhnum";
            this.tbPuhnum.Size = new System.Drawing.Size(219, 20);
            this.tbPuhnum.TabIndex = 7;
            this.tbPuhnum.Leave += new System.EventHandler(this.tbPuhnum_Leave);
            // 
            // lbPostnum
            // 
            this.lbPostnum.AutoSize = true;
            this.lbPostnum.Location = new System.Drawing.Point(16, 148);
            this.lbPostnum.Name = "lbPostnum";
            this.lbPostnum.Size = new System.Drawing.Size(65, 13);
            this.lbPostnum.TabIndex = 9;
            this.lbPostnum.Text = "Postinumero";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(16, 189);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lbEtunimi.TabIndex = 10;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(16, 321);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(16, 277);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lbLahiosoite.TabIndex = 12;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(16, 233);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lbSukunimi.TabIndex = 11;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbPuhnum
            // 
            this.lbPuhnum.AutoSize = true;
            this.lbPuhnum.Location = new System.Drawing.Point(16, 362);
            this.lbPuhnum.Name = "lbPuhnum";
            this.lbPuhnum.Size = new System.Drawing.Size(77, 13);
            this.lbPuhnum.TabIndex = 14;
            this.lbPuhnum.Text = "Puhelinnumero";
            // 
            // btnLisaaTieto
            // 
            this.btnLisaaTieto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaTieto.Location = new System.Drawing.Point(19, 417);
            this.btnLisaaTieto.Name = "btnLisaaTieto";
            this.btnLisaaTieto.Size = new System.Drawing.Size(219, 51);
            this.btnLisaaTieto.TabIndex = 15;
            this.btnLisaaTieto.Text = "Lisää asiakas";
            this.btnLisaaTieto.UseVisualStyleBackColor = true;
            this.btnLisaaTieto.Click += new System.EventHandler(this.btnLisaaTieto_Click);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(19, 120);
            this.tbPostitoimipaikka.MaxLength = 45;
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(219, 20);
            this.tbPostitoimipaikka.TabIndex = 1;
            // 
            // lbPostitoimipaikka
            // 
            this.lbPostitoimipaikka.AutoSize = true;
            this.lbPostitoimipaikka.Location = new System.Drawing.Point(16, 104);
            this.lbPostitoimipaikka.Name = "lbPostitoimipaikka";
            this.lbPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lbPostitoimipaikka.TabIndex = 8;
            this.lbPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(19, 474);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(219, 51);
            this.btnPoista.TabIndex = 16;
            this.btnPoista.Text = "Poista asiakas";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // lbAsiakashallinta
            // 
            this.lbAsiakashallinta.AutoSize = true;
            this.lbAsiakashallinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsiakashallinta.Location = new System.Drawing.Point(12, 9);
            this.lbAsiakashallinta.Name = "lbAsiakashallinta";
            this.lbAsiakashallinta.Size = new System.Drawing.Size(283, 42);
            this.lbAsiakashallinta.TabIndex = 17;
            this.lbAsiakashallinta.Text = "Asiakashallinta";
            // 
            // lbAsiakasOtsake
            // 
            this.lbAsiakasOtsake.AutoSize = true;
            this.lbAsiakasOtsake.Location = new System.Drawing.Point(16, 60);
            this.lbAsiakasOtsake.Name = "lbAsiakasOtsake";
            this.lbAsiakasOtsake.Size = new System.Drawing.Size(58, 13);
            this.lbAsiakasOtsake.TabIndex = 19;
            this.lbAsiakasOtsake.Text = "Asiakas ID";
            // 
            // lbAsiakasID
            // 
            this.lbAsiakasID.AutoSize = true;
            this.lbAsiakasID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsiakasID.Location = new System.Drawing.Point(16, 82);
            this.lbAsiakasID.Name = "lbAsiakasID";
            this.lbAsiakasID.Size = new System.Drawing.Size(11, 13);
            this.lbAsiakasID.TabIndex = 20;
            this.lbAsiakasID.Text = "-";
            // 
            // btnPaivita
            // 
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(19, 531);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(219, 51);
            this.btnPaivita.TabIndex = 21;
            this.btnPaivita.Text = "Päivitä asiakas";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // dgvFullAsiakas
            // 
            this.dgvFullAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFullAsiakas.Location = new System.Drawing.Point(301, 12);
            this.dgvFullAsiakas.Name = "dgvFullAsiakas";
            this.dgvFullAsiakas.Size = new System.Drawing.Size(846, 627);
            this.dgvFullAsiakas.TabIndex = 22;
            this.dgvFullAsiakas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFullAsiakas_CellMouseClick);
            // 
            // lbPostinro
            // 
            this.lbPostinro.AutoSize = true;
            this.lbPostinro.Location = new System.Drawing.Point(187, 60);
            this.lbPostinro.Name = "lbPostinro";
            this.lbPostinro.Size = new System.Drawing.Size(0, 13);
            this.lbPostinro.TabIndex = 23;
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin.Location = new System.Drawing.Point(19, 588);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(219, 51);
            this.btnTakaisin.TabIndex = 24;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // FrmAsiakashallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 657);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.lbPostinro);
            this.Controls.Add(this.dgvFullAsiakas);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lbAsiakasID);
            this.Controls.Add(this.lbAsiakasOtsake);
            this.Controls.Add(this.lbAsiakashallinta);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaaTieto);
            this.Controls.Add(this.lbPuhnum);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLahiosoite);
            this.Controls.Add(this.lbSukunimi);
            this.Controls.Add(this.lbEtunimi);
            this.Controls.Add(this.lbPostnum);
            this.Controls.Add(this.lbPostitoimipaikka);
            this.Controls.Add(this.tbPuhnum);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLahiosoite);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbPostnum);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Name = "FrmAsiakashallinta";
            this.Text = "Asiakashallinta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullAsiakas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPostnum;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPuhnum;
        private System.Windows.Forms.Label lbPostnum;
        private System.Windows.Forms.Label lbEtunimi;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbSukunimi;
        private System.Windows.Forms.Label lbPuhnum;
        private System.Windows.Forms.Button btnLisaaTieto;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
        private System.Windows.Forms.Label lbPostitoimipaikka;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Label lbAsiakashallinta;
        private System.Windows.Forms.Label lbAsiakasOtsake;
        private System.Windows.Forms.Label lbAsiakasID;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.DataGridView dgvFullAsiakas;
        private System.Windows.Forms.Label lbPostinro;
        private System.Windows.Forms.Button btnTakaisin;
    }
}

