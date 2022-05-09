using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ohjelmistotuotanto_Projekti
{
    public partial class frmPalveluidenRaportointi : Form
    {
        public frmPalveluidenRaportointi()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=ruutti;Allow User Variables=True");
        MySqlCommand command;
        private void frmPalveluidenRaportointi_Load(object sender, EventArgs e)
        {
            OpenConnection();
            MySqlDataReader mdr1;
            string select1 = "SELECT * FROM alue";
            command = new MySqlCommand(select1, connection);
            mdr1 = command.ExecuteReader();

            while (mdr1.Read())
            {
                cbAlue.Items.Add(mdr1["nimi"]);
            }
            CloseConnection();
        }
        //avataan yhteys
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //suljetaan yhteys
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;password=ruutti");
            using (command = new MySqlCommand("SELECT p.nimi, p.palvelu_id, p.kuvaus, p.hinta, v.varaus_id, p.alue_id" +
                " FROM varaus v INNER JOIN varauksen_palvelut vp" +
                " ON v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku AND v.varaus_id = vp.varaus_id" +
                " INNER JOIN palvelu p ON vp.palvelu_id = p.palvelu_id" +
                " INNER JOIN alue a ON p.alue_id = a.alue_id AND a.nimi = @Vali", conn))
            {
                using (MySqlDataAdapter adapter2 = new MySqlDataAdapter(command))
                {


                    OpenConnection();
                    command.Parameters.AddWithValue("@Vali", cbAlue.Text);
                    command.Parameters.AddWithValue("@Alku", dtpMista.Text);
                    command.Parameters.AddWithValue("@Loppu", dtpMihin.Text);

                    try
                    {
                        DataTable dt = new DataTable();
                        adapter2.Fill(dt);
                        dgvRaporttip.DataSource = dt;
                        CloseConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Haku epäonnistui");
                    }
                    if (dgvRaporttip.Rows.Count == 1)
                    {
                        MessageBox.Show("Ei palveluja varattuna alueella " + cbAlue.Text + "\n" + dtpMista.Text + " - " + dtpMihin.Text + " aikana");
                    }
                }
            }
        }

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

       
    }
}
