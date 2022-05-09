
namespace Ohjelmistotuotanto_Projekti
{
    partial class Form1
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
            this.tbToiminta_AlueID = new System.Windows.Forms.TextBox();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokkinimi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbToiminta_AlueID2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToiminta_AlueNimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvKakkonen = new System.Windows.Forms.DataGridView();
            this.btnLisaa2 = new System.Windows.Forms.Button();
            this.btnPoistaAlue = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alue_ja_MokkiDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYkkonen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKakkonen)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökkien lisääminen";
            // 
            // dgvYkkonen
            // 
            this.dgvYkkonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYkkonen.Location = new System.Drawing.Point(340, 182);
            this.dgvYkkonen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvYkkonen.Name = "dgvYkkonen";
            this.dgvYkkonen.RowHeadersWidth = 51;
            this.dgvYkkonen.Size = new System.Drawing.Size(1117, 510);
            this.dgvYkkonen.TabIndex = 1;
            this.dgvYkkonen.Click += new System.EventHandler(this.dgvYkkonen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toiminta-alueID";
            // 
            // tbToiminta_AlueID
            // 
            this.tbToiminta_AlueID.Location = new System.Drawing.Point(184, 218);
            this.tbToiminta_AlueID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbToiminta_AlueID.Name = "tbToiminta_AlueID";
            this.tbToiminta_AlueID.Size = new System.Drawing.Size(132, 22);
            this.tbToiminta_AlueID.TabIndex = 4;
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(16, 218);
            this.tbMokkiID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(132, 22);
            this.tbMokkiID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "MökkiID";
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(16, 314);
            this.tbKatuosoite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(300, 22);
            this.tbKatuosoite.TabIndex = 15;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.Location = new System.Drawing.Point(184, 266);
            this.tbMokkinimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(132, 22);
            this.tbMokkinimi.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Katuosoite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mökin nimi";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(16, 266);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(132, 22);
            this.tbPostinumero.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postinumero";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(16, 362);
            this.tbHinta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(300, 22);
            this.tbHinta.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 342);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hinta";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(16, 410);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(300, 22);
            this.tbKuvaus.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 390);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kuvaus";
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(16, 458);
            this.tbHenkilomaara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(300, 22);
            this.tbHenkilomaara.TabIndex = 23;
            // 
            // lbHenkilomaara
            // 
            this.lbHenkilomaara.AutoSize = true;
            this.lbHenkilomaara.Location = new System.Drawing.Point(12, 438);
            this.lbHenkilomaara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHenkilomaara.Name = "lbHenkilomaara";
            this.lbHenkilomaara.Size = new System.Drawing.Size(95, 17);
            this.lbHenkilomaara.TabIndex = 22;
            this.lbHenkilomaara.Text = "Henkilömäärä";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(16, 506);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(300, 22);
            this.tbVarustelu.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 486);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Varustelu";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(16, 564);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(296, 54);
            this.btnLisaa.TabIndex = 26;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Toiminta-alueiden lisääminen";
            // 
            // tbToiminta_AlueID2
            // 
            this.tbToiminta_AlueID2.Location = new System.Drawing.Point(15, 68);
            this.tbToiminta_AlueID2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbToiminta_AlueID2.Name = "tbToiminta_AlueID2";
            this.tbToiminta_AlueID2.Size = new System.Drawing.Size(131, 22);
            this.tbToiminta_AlueID2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Toiminta-AlueID";
            // 
            // tbToiminta_AlueNimi
            // 
            this.tbToiminta_AlueNimi.Location = new System.Drawing.Point(155, 68);
            this.tbToiminta_AlueNimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbToiminta_AlueNimi.Name = "tbToiminta_AlueNimi";
            this.tbToiminta_AlueNimi.Size = new System.Drawing.Size(149, 22);
            this.tbToiminta_AlueNimi.TabIndex = 29;
            this.tbToiminta_AlueNimi.TextChanged += new System.EventHandler(this.tbToiminta_AlueNimi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Toiminta-alueen nimi";
            // 
            // dgvKakkonen
            // 
            this.dgvKakkonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKakkonen.Location = new System.Drawing.Point(340, 48);
            this.dgvKakkonen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKakkonen.Name = "dgvKakkonen";
            this.dgvKakkonen.RowHeadersWidth = 51;
            this.dgvKakkonen.Size = new System.Drawing.Size(1117, 92);
            this.dgvKakkonen.TabIndex = 32;
            this.dgvKakkonen.Click += new System.EventHandler(this.dgvKakkonen_Click);
            // 
            // btnLisaa2
            // 
            this.btnLisaa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa2.Location = new System.Drawing.Point(15, 100);
            this.btnLisaa2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa2.Name = "btnLisaa2";
            this.btnLisaa2.Size = new System.Drawing.Size(132, 48);
            this.btnLisaa2.TabIndex = 33;
            this.btnLisaa2.Text = "Lisää";
            this.btnLisaa2.UseVisualStyleBackColor = true;
            this.btnLisaa2.Click += new System.EventHandler(this.btnLisaa2_Click);
            // 
            // btnPoistaAlue
            // 
            this.btnPoistaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAlue.Location = new System.Drawing.Point(155, 100);
            this.btnPoistaAlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoistaAlue.Name = "btnPoistaAlue";
            this.btnPoistaAlue.Size = new System.Drawing.Size(151, 48);
            this.btnPoistaAlue.TabIndex = 34;
            this.btnPoistaAlue.Text = "Poista";
            this.btnPoistaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaAlue.Click += new System.EventHandler(this.btnPoistaAlue_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(16, 625);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(296, 54);
            this.btnPoistaMokki.TabIndex = 35;
            this.btnPoistaMokki.Text = "Poista";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 706);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.btnPoistaAlue);
            this.Controls.Add(this.btnLisaa2);
            this.Controls.Add(this.dgvKakkonen);
            this.Controls.Add(this.tbToiminta_AlueID2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbToiminta_AlueNimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbHenkilomaara);
            this.Controls.Add(this.lbHenkilomaara);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokkinimi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMokkiID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbToiminta_AlueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvYkkonen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Alueiden ja mökkien hallinta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alue_ja_MokkiDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluejaMokkiDatasetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYkkonen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKakkonen)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYkkonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToiminta_AlueID;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokkinimi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPostinumero;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbToiminta_AlueID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbToiminta_AlueNimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKakkonen;
        private System.Windows.Forms.Button btnLisaa2;
        private System.Windows.Forms.Button btnPoistaAlue;
        private System.Windows.Forms.Button btnPoistaMokki;
    }
}

