﻿
namespace Ohjelmistotuotanto_Projekti
{
    partial class frmValikko
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPoistu = new System.Windows.Forms.Button();
            this.btnRaportointiMajoitus = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnMajoitus = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnMokit = new System.Windows.Forms.Button();
            this.btnAlueet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPoistu);
            this.panel1.Controls.Add(this.btnRaportointiMajoitus);
            this.panel1.Controls.Add(this.btnAsiakkaat);
            this.panel1.Controls.Add(this.btnMajoitus);
            this.panel1.Controls.Add(this.btnPalvelut);
            this.panel1.Controls.Add(this.btnMokit);
            this.panel1.Controls.Add(this.btnAlueet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 523);
            this.panel1.TabIndex = 0;
            // 
            // btnPoistu
            // 
            this.btnPoistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistu.Location = new System.Drawing.Point(337, 446);
            this.btnPoistu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoistu.Name = "btnPoistu";
            this.btnPoistu.Size = new System.Drawing.Size(335, 52);
            this.btnPoistu.TabIndex = 51;
            this.btnPoistu.Text = "Poistu";
            this.btnPoistu.UseVisualStyleBackColor = true;
            this.btnPoistu.Click += new System.EventHandler(this.btnPoistu_Click);
            // 
            // btnRaportointiMajoitus
            // 
            this.btnRaportointiMajoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportointiMajoitus.Location = new System.Drawing.Point(496, 289);
            this.btnRaportointiMajoitus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaportointiMajoitus.Name = "btnRaportointiMajoitus";
            this.btnRaportointiMajoitus.Size = new System.Drawing.Size(501, 108);
            this.btnRaportointiMajoitus.TabIndex = 50;
            this.btnRaportointiMajoitus.Text = "Raportointi";
            this.btnRaportointiMajoitus.UseVisualStyleBackColor = true;
            this.btnRaportointiMajoitus.Click += new System.EventHandler(this.btnRaportointi_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.Location = new System.Drawing.Point(40, 289);
            this.btnAsiakkaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(448, 108);
            this.btnAsiakkaat.TabIndex = 49;
            this.btnAsiakkaat.Text = "Asiakkaiden hallinta";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnMajoitus
            // 
            this.btnMajoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMajoitus.Location = new System.Drawing.Point(496, 182);
            this.btnMajoitus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMajoitus.Name = "btnMajoitus";
            this.btnMajoitus.Size = new System.Drawing.Size(501, 100);
            this.btnMajoitus.TabIndex = 48;
            this.btnMajoitus.Text = "Majoitusvarausten hallinta";
            this.btnMajoitus.UseVisualStyleBackColor = true;
            this.btnMajoitus.Click += new System.EventHandler(this.btnMajoitus_Click);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalvelut.Location = new System.Drawing.Point(40, 182);
            this.btnPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(448, 100);
            this.btnPalvelut.TabIndex = 47;
            this.btnPalvelut.Text = "Palveluiden hallinta";
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnPalvelut_Click);
            // 
            // btnMokit
            // 
            this.btnMokit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokit.Location = new System.Drawing.Point(496, 71);
            this.btnMokit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMokit.Name = "btnMokit";
            this.btnMokit.Size = new System.Drawing.Size(501, 103);
            this.btnMokit.TabIndex = 46;
            this.btnMokit.Text = "Mökkien hallinta";
            this.btnMokit.UseVisualStyleBackColor = true;
            this.btnMokit.Click += new System.EventHandler(this.btnMokit_Click);
            // 
            // btnAlueet
            // 
            this.btnAlueet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlueet.Location = new System.Drawing.Point(40, 71);
            this.btnAlueet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlueet.Name = "btnAlueet";
            this.btnAlueet.Size = new System.Drawing.Size(448, 103);
            this.btnAlueet.TabIndex = 45;
            this.btnAlueet.Text = "Alueiden hallinta";
            this.btnAlueet.UseVisualStyleBackColor = true;
            this.btnAlueet.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "Valikko";
            // 
            // frmValikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmValikko";
            this.Text = "Mökkivarausohjelma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoistu;
        private System.Windows.Forms.Button btnRaportointiMajoitus;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnMajoitus;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Button btnMokit;
        private System.Windows.Forms.Button btnAlueet;
    }
}