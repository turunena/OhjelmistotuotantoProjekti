
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmLaskut
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
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.labelsumma = new System.Windows.Forms.Label();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.labelalv = new System.Windows.Forms.Label();
            this.tbLaskuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.cbVarausID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin.Location = new System.Drawing.Point(17, 270);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(202, 58);
            this.btnTakaisin.TabIndex = 61;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(143, 127);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(129, 55);
            this.btnPaivita.TabIndex = 60;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(17, 188);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(120, 58);
            this.btnPoista.TabIndex = 59;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(17, 127);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(120, 55);
            this.btnLisaa.TabIndex = 58;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // labelsumma
            // 
            this.labelsumma.AutoSize = true;
            this.labelsumma.Location = new System.Drawing.Point(14, 85);
            this.labelsumma.Name = "labelsumma";
            this.labelsumma.Size = new System.Drawing.Size(42, 13);
            this.labelsumma.TabIndex = 49;
            this.labelsumma.Text = "Summa";
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(143, 101);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(129, 20);
            this.tbAlv.TabIndex = 47;
            // 
            // labelalv
            // 
            this.labelalv.AutoSize = true;
            this.labelalv.Location = new System.Drawing.Point(140, 85);
            this.labelalv.Name = "labelalv";
            this.labelalv.Size = new System.Drawing.Size(22, 13);
            this.labelalv.TabIndex = 45;
            this.labelalv.Text = "Alv";
            // 
            // tbLaskuID
            // 
            this.tbLaskuID.Location = new System.Drawing.Point(17, 62);
            this.tbLaskuID.Name = "tbLaskuID";
            this.tbLaskuID.Size = new System.Drawing.Size(120, 20);
            this.tbLaskuID.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Lasku Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Varaus Id";
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(318, 46);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.Size = new System.Drawing.Size(459, 282);
            this.dgvLaskut.TabIndex = 40;
            this.dgvLaskut.Click += new System.EventHandler(this.dgvLaskut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Laskujen hallinta";
            // 
            // btnHae
            // 
            this.btnHae.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHae.Location = new System.Drawing.Point(143, 188);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(129, 58);
            this.btnHae.TabIndex = 63;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(17, 101);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(120, 20);
            this.tbSumma.TabIndex = 64;
            // 
            // cbVarausID
            // 
            this.cbVarausID.FormattingEnabled = true;
            this.cbVarausID.Location = new System.Drawing.Point(143, 61);
            this.cbVarausID.Name = "cbVarausID";
            this.cbVarausID.Size = new System.Drawing.Size(129, 21);
            this.cbVarausID.TabIndex = 65;
            // 
            // frmLaskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 348);
            this.Controls.Add(this.cbVarausID);
            this.Controls.Add(this.tbSumma);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.labelsumma);
            this.Controls.Add(this.tbAlv);
            this.Controls.Add(this.labelalv);
            this.Controls.Add(this.tbLaskuID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLaskut);
            this.Controls.Add(this.label1);
            this.Name = "frmLaskut";
            this.Text = "Laskujen hallinta";
            this.Load += new System.EventHandler(this.frmLaskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label labelsumma;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.Label labelalv;
        private System.Windows.Forms.TextBox tbLaskuID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.ComboBox cbVarausID;
    }
}