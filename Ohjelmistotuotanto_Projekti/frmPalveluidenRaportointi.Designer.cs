
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmRaportointi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNaytaKaikki = new System.Windows.Forms.Button();
            this.dtpMihin = new System.Windows.Forms.DateTimePicker();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.dgvRaporttip = new System.Windows.Forms.DataGridView();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMista = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEtsiKaikkiM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlue2 = new System.Windows.Forms.ComboBox();
            this.btnEtsiMajoitus = new System.Windows.Forms.Button();
            this.dtpMihin2 = new System.Windows.Forms.DateTimePicker();
            this.dtpMista2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRaporttim = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporttip)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporttim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNaytaKaikki);
            this.tabPage1.Controls.Add(this.dtpMihin);
            this.tabPage1.Controls.Add(this.btnEtsi);
            this.tabPage1.Controls.Add(this.dgvRaporttip);
            this.tabPage1.Controls.Add(this.cbAlue);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpMista);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(792, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Palvelut";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNaytaKaikki
            // 
            this.btnNaytaKaikki.Location = new System.Drawing.Point(19, 178);
            this.btnNaytaKaikki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNaytaKaikki.Name = "btnNaytaKaikki";
            this.btnNaytaKaikki.Size = new System.Drawing.Size(140, 23);
            this.btnNaytaKaikki.TabIndex = 30;
            this.btnNaytaKaikki.Text = "Näytä kaikki";
            this.btnNaytaKaikki.UseVisualStyleBackColor = true;
            this.btnNaytaKaikki.Click += new System.EventHandler(this.btnNaytaKaikki_Click);
            // 
            // dtpMihin
            // 
            this.dtpMihin.CustomFormat = "yyyy-MM-dd";
            this.dtpMihin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMihin.Location = new System.Drawing.Point(573, 116);
            this.dtpMihin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMihin.Name = "dtpMihin";
            this.dtpMihin.Size = new System.Drawing.Size(200, 22);
            this.dtpMihin.TabIndex = 28;
            // 
            // btnEtsi
            // 
            this.btnEtsi.Location = new System.Drawing.Point(633, 178);
            this.btnEtsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(140, 23);
            this.btnEtsi.TabIndex = 29;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // dgvRaporttip
            // 
            this.dgvRaporttip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporttip.Location = new System.Drawing.Point(19, 223);
            this.dgvRaporttip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRaporttip.Name = "dgvRaporttip";
            this.dgvRaporttip.RowHeadersWidth = 51;
            this.dgvRaporttip.RowTemplate.Height = 24;
            this.dgvRaporttip.Size = new System.Drawing.Size(755, 197);
            this.dgvRaporttip.TabIndex = 24;
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(19, 116);
            this.cbAlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(200, 24);
            this.cbAlue.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Valitse alue";
            // 
            // dtpMista
            // 
            this.dtpMista.CustomFormat = "yyyy-MM-dd";
            this.dtpMista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMista.Location = new System.Drawing.Point(291, 116);
            this.dtpMista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMista.Name = "dtpMista";
            this.dtpMista.Size = new System.Drawing.Size(200, 22);
            this.dtpMista.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mistä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mihin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnTakaisin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 62);
            this.panel2.TabIndex = 21;
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(27, 18);
            this.btnTakaisin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(75, 23);
            this.btnTakaisin.TabIndex = 1;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palveluiden raportointi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEtsiKaikkiM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbAlue2);
            this.tabPage2.Controls.Add(this.btnEtsiMajoitus);
            this.tabPage2.Controls.Add(this.dtpMihin2);
            this.tabPage2.Controls.Add(this.dtpMista2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvRaporttim);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(792, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Majoitus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEtsiKaikkiM
            // 
            this.btnEtsiKaikkiM.Location = new System.Drawing.Point(19, 178);
            this.btnEtsiKaikkiM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtsiKaikkiM.Name = "btnEtsiKaikkiM";
            this.btnEtsiKaikkiM.Size = new System.Drawing.Size(140, 23);
            this.btnEtsiKaikkiM.TabIndex = 19;
            this.btnEtsiKaikkiM.Text = "Näytä kaikki";
            this.btnEtsiKaikkiM.UseVisualStyleBackColor = true;
            this.btnEtsiKaikkiM.Click += new System.EventHandler(this.btnEtsiKaikkiM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valitse alue";
            // 
            // cbAlue2
            // 
            this.cbAlue2.FormattingEnabled = true;
            this.cbAlue2.Location = new System.Drawing.Point(19, 116);
            this.cbAlue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlue2.Name = "cbAlue2";
            this.cbAlue2.Size = new System.Drawing.Size(200, 24);
            this.cbAlue2.TabIndex = 12;
            // 
            // btnEtsiMajoitus
            // 
            this.btnEtsiMajoitus.Location = new System.Drawing.Point(633, 178);
            this.btnEtsiMajoitus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtsiMajoitus.Name = "btnEtsiMajoitus";
            this.btnEtsiMajoitus.Size = new System.Drawing.Size(140, 23);
            this.btnEtsiMajoitus.TabIndex = 18;
            this.btnEtsiMajoitus.Text = "Etsi";
            this.btnEtsiMajoitus.UseVisualStyleBackColor = true;
            this.btnEtsiMajoitus.Click += new System.EventHandler(this.btnEtsiMajoitus_Click);
            // 
            // dtpMihin2
            // 
            this.dtpMihin2.CustomFormat = "yyyy-MM-dd";
            this.dtpMihin2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMihin2.Location = new System.Drawing.Point(573, 116);
            this.dtpMihin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMihin2.Name = "dtpMihin2";
            this.dtpMihin2.Size = new System.Drawing.Size(200, 22);
            this.dtpMihin2.TabIndex = 17;
            // 
            // dtpMista2
            // 
            this.dtpMista2.CustomFormat = "yyyy-MM-dd";
            this.dtpMista2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMista2.Location = new System.Drawing.Point(291, 116);
            this.dtpMista2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMista2.Name = "dtpMista2";
            this.dtpMista2.Size = new System.Drawing.Size(200, 22);
            this.dtpMista2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mihin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mistä";
            // 
            // dgvRaporttim
            // 
            this.dgvRaporttim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporttim.Location = new System.Drawing.Point(19, 223);
            this.dgvRaporttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRaporttim.Name = "dgvRaporttim";
            this.dgvRaporttim.RowHeadersWidth = 51;
            this.dgvRaporttim.RowTemplate.Height = 24;
            this.dgvRaporttim.Size = new System.Drawing.Size(755, 197);
            this.dgvRaporttim.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 62);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Majoitusten raportointi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRaportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRaportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.frmRaportointi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporttip)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporttim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNaytaKaikki;
        private System.Windows.Forms.DateTimePicker dtpMihin;
        private System.Windows.Forms.Button btnEtsi;
        private System.Windows.Forms.DataGridView dgvRaporttip;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEtsiMajoitus;
        private System.Windows.Forms.DateTimePicker dtpMihin2;
        private System.Windows.Forms.DateTimePicker dtpMista2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRaporttim;
        private System.Windows.Forms.ComboBox cbAlue2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEtsiKaikkiM;
    }
}