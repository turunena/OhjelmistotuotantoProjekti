using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto_Projekti
{
    public partial class frmValikko : Form
    {
        public frmValikko()
        {
            InitializeComponent();
        }

        private void btnPoistu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlueet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlueet alueet = new frmAlueet();
            alueet.ShowDialog();
            this.Close();
        }

        private void btnMokit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMokit mokit = new frmMokit();
            mokit.ShowDialog();
            this.Close();
        }

        private void btnMajoitus_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVaraukset varaukset = new frmVaraukset();
            varaukset.ShowDialog();
            this.Close();
        }

        private void btnRaportointi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRaportointi pRapsa = new frmRaportointi();
            pRapsa.ShowDialog();
            this.Close();
        }
        private void btnPalvelut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPalvelut palvelut = new frmPalvelut();
            palvelut.ShowDialog();
            this.Close();
        }

        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAsiakashallinta asiakasHallinta = new FrmAsiakashallinta();
            asiakasHallinta.ShowDialog();
            this.Close();
        }

        private void btnLaskut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLaskut laskujenHallinta = new frmLaskut();
            laskujenHallinta.ShowDialog();
            this.Close();
        }
    }
}
