
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmAlueet
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
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoistaAlue = new System.Windows.Forms.Button();
            this.btnLisaa2 = new System.Windows.Forms.Button();
            this.dgvKakkonen = new System.Windows.Forms.DataGridView();
            this.tbToiminta_AlueID2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToiminta_AlueNimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTakaisin2 = new System.Windows.Forms.Button();
            this.dgvPosti = new System.Windows.Forms.DataGridView();
            this.btnLisaaPosti = new System.Windows.Forms.Button();
            this.btnPoistaPosti = new System.Windows.Forms.Button();
            this.btnPaivitaPosti = new System.Windows.Forms.Button();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtoimipaikka = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKakkonen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPaivita
            // 
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(16, 143);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(316, 41);
            this.btnPaivita.TabIndex = 46;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoistaAlue
            // 
            this.btnPoistaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAlue.Location = new System.Drawing.Point(185, 92);
            this.btnPoistaAlue.Name = "btnPoistaAlue";
            this.btnPoistaAlue.Size = new System.Drawing.Size(147, 44);
            this.btnPoistaAlue.TabIndex = 45;
            this.btnPoistaAlue.Text = "Poista";
            this.btnPoistaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaAlue.Click += new System.EventHandler(this.btnPoistaAlue_Click_1);
            // 
            // btnLisaa2
            // 
            this.btnLisaa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa2.Location = new System.Drawing.Point(16, 90);
            this.btnLisaa2.Name = "btnLisaa2";
            this.btnLisaa2.Size = new System.Drawing.Size(147, 44);
            this.btnLisaa2.TabIndex = 44;
            this.btnLisaa2.Text = "Lisää";
            this.btnLisaa2.UseVisualStyleBackColor = true;
            this.btnLisaa2.Click += new System.EventHandler(this.btnLisaa2_Click_1);
            // 
            // dgvKakkonen
            // 
            this.dgvKakkonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKakkonen.Location = new System.Drawing.Point(371, 45);
            this.dgvKakkonen.Name = "dgvKakkonen";
            this.dgvKakkonen.Size = new System.Drawing.Size(417, 139);
            this.dgvKakkonen.TabIndex = 43;
            this.dgvKakkonen.Click += new System.EventHandler(this.dgvKakkonen_Click_1);
            // 
            // tbToiminta_AlueID2
            // 
            this.tbToiminta_AlueID2.Location = new System.Drawing.Point(16, 64);
            this.tbToiminta_AlueID2.Name = "tbToiminta_AlueID2";
            this.tbToiminta_AlueID2.Size = new System.Drawing.Size(143, 20);
            this.tbToiminta_AlueID2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Toiminta-AlueID";
            // 
            // tbToiminta_AlueNimi
            // 
            this.tbToiminta_AlueNimi.Location = new System.Drawing.Point(185, 61);
            this.tbToiminta_AlueNimi.Name = "tbToiminta_AlueNimi";
            this.tbToiminta_AlueNimi.Size = new System.Drawing.Size(147, 20);
            this.tbToiminta_AlueNimi.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Toiminta-alueen nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Toiminta-alueiden lisääminen";
            // 
            // btnTakaisin2
            // 
            this.btnTakaisin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin2.Location = new System.Drawing.Point(16, 397);
            this.btnTakaisin2.Name = "btnTakaisin2";
            this.btnTakaisin2.Size = new System.Drawing.Size(316, 41);
            this.btnTakaisin2.TabIndex = 47;
            this.btnTakaisin2.Text = "Takaisin";
            this.btnTakaisin2.UseVisualStyleBackColor = true;
            this.btnTakaisin2.Click += new System.EventHandler(this.btnTakaisin2_Click);
            // 
            // dgvPosti
            // 
            this.dgvPosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosti.Location = new System.Drawing.Point(371, 258);
            this.dgvPosti.Name = "dgvPosti";
            this.dgvPosti.Size = new System.Drawing.Size(417, 180);
            this.dgvPosti.TabIndex = 48;
            this.dgvPosti.Click += new System.EventHandler(this.dgvPosti_Click);
            // 
            // btnLisaaPosti
            // 
            this.btnLisaaPosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaPosti.Location = new System.Drawing.Point(16, 294);
            this.btnLisaaPosti.Name = "btnLisaaPosti";
            this.btnLisaaPosti.Size = new System.Drawing.Size(147, 44);
            this.btnLisaaPosti.TabIndex = 49;
            this.btnLisaaPosti.Text = "Lisää";
            this.btnLisaaPosti.UseVisualStyleBackColor = true;
            this.btnLisaaPosti.Click += new System.EventHandler(this.btnLisaaPosti_Click);
            // 
            // btnPoistaPosti
            // 
            this.btnPoistaPosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaPosti.Location = new System.Drawing.Point(185, 296);
            this.btnPoistaPosti.Name = "btnPoistaPosti";
            this.btnPoistaPosti.Size = new System.Drawing.Size(147, 44);
            this.btnPoistaPosti.TabIndex = 50;
            this.btnPoistaPosti.Text = "Poista";
            this.btnPoistaPosti.UseVisualStyleBackColor = true;
            this.btnPoistaPosti.Click += new System.EventHandler(this.btnPoistaPosti_Click);
            // 
            // btnPaivitaPosti
            // 
            this.btnPaivitaPosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivitaPosti.Location = new System.Drawing.Point(16, 350);
            this.btnPaivitaPosti.Name = "btnPaivitaPosti";
            this.btnPaivitaPosti.Size = new System.Drawing.Size(316, 41);
            this.btnPaivitaPosti.TabIndex = 51;
            this.btnPaivitaPosti.Text = "Päivitä";
            this.btnPaivitaPosti.UseVisualStyleBackColor = true;
            this.btnPaivitaPosti.Click += new System.EventHandler(this.btnPaivitaPosti_Click);
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(16, 258);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(147, 20);
            this.tbPostinro.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Postinumero";
            // 
            // tbtoimipaikka
            // 
            this.tbtoimipaikka.Location = new System.Drawing.Point(187, 258);
            this.tbtoimipaikka.Name = "tbtoimipaikka";
            this.tbtoimipaikka.Size = new System.Drawing.Size(147, 20);
            this.tbtoimipaikka.TabIndex = 53;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(184, 242);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(83, 13);
            this.label123.TabIndex = 52;
            this.label123.Text = "Postitoimipaikka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Postitoimipaikan lisääminen";
            // 
            // frmAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPostinro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtoimipaikka);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.btnPaivitaPosti);
            this.Controls.Add(this.btnPoistaPosti);
            this.Controls.Add(this.btnLisaaPosti);
            this.Controls.Add(this.dgvPosti);
            this.Controls.Add(this.btnTakaisin2);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoistaAlue);
            this.Controls.Add(this.btnLisaa2);
            this.Controls.Add(this.dgvKakkonen);
            this.Controls.Add(this.tbToiminta_AlueID2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbToiminta_AlueNimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "frmAlueet";
            this.Text = "Toiminta-alueiden lisääminen";
            this.Load += new System.EventHandler(this.frmAlueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKakkonen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoistaAlue;
        private System.Windows.Forms.Button btnLisaa2;
        private System.Windows.Forms.DataGridView dgvKakkonen;
        private System.Windows.Forms.TextBox tbToiminta_AlueID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbToiminta_AlueNimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTakaisin2;
        private System.Windows.Forms.DataGridView dgvPosti;
        private System.Windows.Forms.Button btnLisaaPosti;
        private System.Windows.Forms.Button btnPoistaPosti;
        private System.Windows.Forms.Button btnPaivitaPosti;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtoimipaikka;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label2;
    }
}