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
    public partial class frmRaportointi : Form
    {
        public frmRaportointi()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=ruutti;Allow User Variables=True");
        MySqlCommand command;

        private void frmRaportointi_Load(object sender, EventArgs e)
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

            OpenConnection();
            MySqlDataReader mdr2;
            string select2 = "SELECT * FROM alue";
            command = new MySqlCommand(select2, connection);
            mdr2 = command.ExecuteReader();

            while (mdr2.Read())
            {
                cbAlue2.Items.Add(mdr2["nimi"]);
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

        //Etsii halutuilla vaihtoehdoilla
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            using (command = new MySqlCommand("SELECT p.palvelu_id AS PalveluID, p.nimi AS Nimi, p.alue_id AS AlueID, v.varaus_id AS VarausID, " +
                "p.kuvaus AS Kuvaus, p.hinta AS Hinta" +
                " FROM varaus v INNER JOIN varauksen_palvelut vp" +
                " ON v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku AND v.varaus_id = vp.varaus_id" +
                " INNER JOIN palvelu p ON vp.palvelu_id = p.palvelu_id" +
                " INNER JOIN alue a ON p.alue_id = a.alue_id AND a.nimi = @Vali", connection))
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

        private void btnTakaisin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

        private void btnNaytaKaikki_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.palvelu_id AS PalveluID, p.nimi AS Nimi, p.alue_id AS AlueID, v.varaus_id AS VarausID, " +
                "p.kuvaus AS Kuvaus, p.hinta AS Hinta" +
                " FROM varauksen_palvelut vp" +
                " INNER JOIN varaus v ON vp.varaus_id = v.varaus_id" +
                " INNER JOIN  palvelu p ON vp.palvelu_id = p.palvelu_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvRaporttip.DataSource = table;
        }

        private void btnEtsiMajoitus_Click(object sender, EventArgs e)
        {
            using (command = new MySqlCommand("SELECT varaus_id AS VarausID, asiakas_id AS AsiakasID, mokki_mokki_id AS MokkiID," +
                " varattu_pvm AS Varauspaiva, vahvistus_pvm AS Vahvistuspaiva, varattu_alkupvm AS Saapumispaiva," +
                " varattu_loppupvm AS Lahtopaiva" +
                " FROM varaus v INNER JOIN mokki m ON v.mokki_mokki_id = m.mokki_id AND" +
                " v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku" +
                " INNER JOIN alue a ON m.alue_id = a.alue_id AND a.nimi = @Vali", connection))
            {
                using (MySqlDataAdapter adapter2 = new MySqlDataAdapter(command))
                {


                    OpenConnection();
                    command.Parameters.AddWithValue("@Vali", cbAlue2.Text);
                    command.Parameters.AddWithValue("@Alku", dtpMista2.Text);
                    command.Parameters.AddWithValue("@Loppu", dtpMihin2.Text);

                    try
                    {
                        DataTable dt = new DataTable();
                        adapter2.Fill(dt);
                        dgvRaporttim.DataSource = dt;
                        CloseConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Haku epäonnistui");
                    }
                    if (dgvRaporttim.Rows.Count == 1)
                    {
                        MessageBox.Show("Ei mökkejä varattuna alueella " + cbAlue2.Text + "\n" + dtpMista2.Text + " - " + dtpMihin2.Text + " aikana");
                    }
                }
            }
        }

        private void btnEtsiKaikkiM_Click(object sender, EventArgs e)
        {
            string query = "SELECT varaus_id AS VarausID, asiakas_id AS AsiakasID, mokki_mokki_id AS MokkiID," +
                " varattu_pvm AS Varauspaiva, vahvistus_pvm AS Vahvistuspaiva, varattu_alkupvm AS Saapumispaiva," +
                " varattu_loppupvm AS Lahtopaiva FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvRaporttim.DataSource = table;
        }

    }
}
