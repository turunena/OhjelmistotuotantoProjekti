﻿
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmMajoitusRaportti
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.dgvRaportti = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMista = new System.Windows.Forms.DateTimePicker();
            this.dtpMihin = new System.Windows.Forms.DateTimePicker();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Majoitusten raportointi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnTakaisin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse alue";
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(600, 100);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(140, 24);
            this.cbAlue.TabIndex = 3;
            // 
            // dgvRaportti
            // 
            this.dgvRaportti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaportti.Location = new System.Drawing.Point(26, 210);
            this.dgvRaportti.Name = "dgvRaportti";
            this.dgvRaportti.RowHeadersWidth = 51;
            this.dgvRaportti.RowTemplate.Height = 24;
            this.dgvRaportti.Size = new System.Drawing.Size(736, 210);
            this.dgvRaportti.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mistä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mihin";
            // 
            // dtpMista
            // 
            this.dtpMista.CustomFormat = "yyyy-MM-dd";
            this.dtpMista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMista.Location = new System.Drawing.Point(180, 98);
            this.dtpMista.Name = "dtpMista";
            this.dtpMista.Size = new System.Drawing.Size(200, 22);
            this.dtpMista.TabIndex = 7;
            // 
            // dtpMihin
            // 
            this.dtpMihin.CustomFormat = "yyyy-MM-dd";
            this.dtpMihin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMihin.Location = new System.Drawing.Point(180, 134);
            this.dtpMihin.Name = "dtpMihin";
            this.dtpMihin.Size = new System.Drawing.Size(200, 22);
            this.dtpMihin.TabIndex = 8;
            // 
            // btnEtsi
            // 
            this.btnEtsi.Location = new System.Drawing.Point(600, 137);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(75, 23);
            this.btnEtsi.TabIndex = 9;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(26, 19);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(75, 23);
            this.btnTakaisin.TabIndex = 1;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // frmMajoitusRaportti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.dtpMihin);
            this.Controls.Add(this.dtpMista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRaportti);
            this.Controls.Add(this.cbAlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMajoitusRaportti";
            this.Text = "frmMajoitusRaportti";
            this.Load += new System.EventHandler(this.frmMajoitusRaportti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaportti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.DataGridView dgvRaportti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMista;
        private System.Windows.Forms.DateTimePicker dtpMihin;
        private System.Windows.Forms.Button btnEtsi;
        private System.Windows.Forms.Button btnTakaisin;
    }
}