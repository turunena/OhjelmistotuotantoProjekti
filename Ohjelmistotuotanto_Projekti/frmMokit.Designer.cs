
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmMokit
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
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alue_ja_MokkiDataset = new Ohjelmistotuotanto_Projekti.Alue_ja_MokkiDataset();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new Ohjelmistotuotanto_Projekti.Alue_ja_MokkiDatasetTableAdapters.alueTableAdapter();
            this.aluejaMokkiDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluejaMokkiDatasetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new Ohjelmistotuotanto_Projekti.Alue_ja_MokkiDatasetTableAdapters.mokkiTableAdapter();
            this.mokkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYkkonen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.lbHenkilomaara = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.btnPaivita2 = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.cbAlue_ID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alue_ja_MokkiDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYkkonen)).BeginInit();
            this.SuspendLayout();
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.alue_ja_MokkiDataset;
            // 
            // alue_ja_MokkiDataset
            // 
            this.alue_ja_MokkiDataset.DataSetName = "Alue_ja_MokkiDataset";
            this.alue_ja_MokkiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.alue_ja_MokkiDataset;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // aluejaMokkiDatasetBindingSource
            // 
            this.aluejaMokkiDatasetBindingSource.DataSource = this.alue_ja_MokkiDataset;
            this.aluejaMokkiDatasetBindingSource.Position = 0;
            // 
            // aluejaMokkiDatasetBindingSource1
            // 
            this.aluejaMokkiDatasetBindingSource1.DataSource = this.alue_ja_MokkiDataset;
            this.aluejaMokkiDatasetBindingSource1.Position = 0;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiBindingSource1
            // 
            this.mokkiBindingSource1.DataMember = "mokki";
            this.mokkiBindingSource1.DataSource = this.aluejaMokkiDatasetBindingSource1;
            // 
            // alueBindingSource1
            // 
            this.alueBindingSource1.DataMember = "alue";
            this.alueBindingSource1.DataSource = this.aluejaMokkiDatasetBindingSource1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökkien lisääminen";
            // 
            // dgvYkkonen
            // 
            this.dgvYkkonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYkkonen.Location = new System.Drawing.Point(264, 12);
            this.dgvYkkonen.Name = "dgvYkkonen";
            this.dgvYkkonen.Size = new System.Drawing.Size(909, 550);
            this.dgvYkkonen.TabIndex = 1;
            this.dgvYkkonen.Click += new System.EventHandler(this.dgvYkkonen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toiminta-alueID";
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(12, 54);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(109, 20);
            this.tbMokkiID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MökkiID";
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(12, 132);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(226, 20);
            this.tbKatuosoite.TabIndex = 15;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(138, 93);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(100, 20);
            this.tbMokkinimi.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Katuosoite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mökin nimi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postinumero";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(12, 171);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(226, 20);
            this.tbHinta.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hinta";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(12, 210);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(226, 20);
            this.tbKuvaus.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kuvaus";
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(12, 249);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(226, 20);
            this.tbHenkilomaara.TabIndex = 23;
            // 
            // lbHenkilomaara
            // 
            this.lbHenkilomaara.AutoSize = true;
            this.lbHenkilomaara.Location = new System.Drawing.Point(9, 233);
            this.lbHenkilomaara.Name = "lbHenkilomaara";
            this.lbHenkilomaara.Size = new System.Drawing.Size(72, 13);
            this.lbHenkilomaara.TabIndex = 22;
            this.lbHenkilomaara.Text = "Henkilömäärä";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(12, 288);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(226, 20);
            this.tbVarustelu.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Varustelu";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(11, 325);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(227, 46);
            this.btnLisaa.TabIndex = 26;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(11, 377);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(227, 51);
            this.btnPoistaMokki.TabIndex = 35;
            this.btnPoistaMokki.Text = "Poista";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnPaivita2
            // 
            this.btnPaivita2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita2.Location = new System.Drawing.Point(11, 434);
            this.btnPaivita2.Name = "btnPaivita2";
            this.btnPaivita2.Size = new System.Drawing.Size(227, 49);
            this.btnPaivita2.TabIndex = 36;
            this.btnPaivita2.Text = "Päivitä";
            this.btnPaivita2.UseVisualStyleBackColor = true;
            this.btnPaivita2.Click += new System.EventHandler(this.btnPaivita2_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin.Location = new System.Drawing.Point(11, 489);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(227, 49);
            this.btnTakaisin.TabIndex = 37;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // cbPostinro
            // 
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(11, 92);
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(110, 21);
            this.cbPostinro.TabIndex = 38;
            // 
            // cbAlue_ID
            // 
            this.cbAlue_ID.FormattingEnabled = true;
            this.cbAlue_ID.Location = new System.Drawing.Point(138, 54);
            this.cbAlue_ID.Name = "cbAlue_ID";
            this.cbAlue_ID.Size = new System.Drawing.Size(100, 21);
            this.cbAlue_ID.TabIndex = 39;
            // 
            // frmMokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 574);
            this.Controls.Add(this.cbAlue_ID);
            this.Controls.Add(this.cbPostinro);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnPaivita2);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbHenkilomaara);
            this.Controls.Add(this.lbHenkilomaara);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokkinimi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMokkiID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvYkkonen);
            this.Controls.Add(this.label1);
            this.Name = "frmMokit";
            this.Text = "Mökkien lisääminen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alue_ja_MokkiDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYkkonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Alue_ja_MokkiDataset alue_ja_MokkiDataset;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private Alue_ja_MokkiDatasetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.BindingSource aluejaMokkiDatasetBindingSource1;
        private System.Windows.Forms.BindingSource aluejaMokkiDatasetBindingSource;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private Alue_ja_MokkiDatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource mokkiBindingSource1;
        private System.Windows.Forms.BindingSource alueBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYkkonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.Label lbHenkilomaara;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnPaivita2;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.ComboBox cbPostinro;
        private System.Windows.Forms.ComboBox cbAlue_ID;
    }
}

