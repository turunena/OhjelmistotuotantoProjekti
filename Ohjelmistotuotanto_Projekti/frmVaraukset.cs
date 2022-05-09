﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using Microsoft.Build.Framework.XamlTypes;
using System.IO;

//form ja funktiot
//mökkien haku
//asiakkaan haku
//varausten hallinta
//palvelut

namespace Ohjelmistotuotanto_Projekti
{
    public partial class frmVaraukset : Form
    {
        public frmVaraukset()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=ruutti;Allow User Variables=True");
        MySqlCommand command;

        private void Vauraukset_Load(object sender, EventArgs e)
        {
            populateDGV();
            populateDGV2();
            populateCB();
        }

        public void populateDGV()
        {
            string query = "SELECT * FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraukset.DataSource = table;
        }

        public void populateDGV2()
        {
            string query = "SELECT * FROM varauksen_palvelut";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvPalvelut.DataSource = table;
        }
        public void populateCB()
        {
            //haetaan alueet tietokannasta combobox:iin
            OpenConnection();
            MySqlDataReader mdr1;
            string select1 = "SELECT * FROM alue";
            command = new MySqlCommand(select1, connection);
            mdr1 = command.ExecuteReader();

            while (mdr1.Read())
            {
                cbAlue2.Items.Add(mdr1["nimi"]);
            }
            CloseConnection();

            //haetaan asiakkaat
            string query = "SELECT concat(sukunimi, ' ', etunimi) AS Nimi, asiakas_id FROM asiakas GROUP BY Nimi";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvAsiakasTiedot.DataSource = table;
        }

        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
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


        //Mökit

        //toimii
        //kun alue valitaan palveluihin tulee tieto mitä sillä alueella on
        private void cbAlue2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hakee palvelut combobox:iin tiedot
            MySqlDataReader mdr2;
            string select2 = "SELECT p.nimi FROM palvelu p JOIN alue a ON p.alue_id = a.alue_id WHERE a.nimi = @vali";
            OpenConnection();
            command = new MySqlCommand(select2, connection);
            command.Parameters.AddWithValue("@vali", cbAlue2.Text);
            command.Prepare();
            mdr2 = command.ExecuteReader();

            while (mdr2.Read())
            {
                cbPalvelut.Items.Add(mdr2["nimi"]);
            }
            CloseConnection();
        }

        //toimii
        //etsii vapaana olevat mökit paikan ja ajan perusteella
        private void btnEtsiMokit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;password=ruutti");
            using (command = new MySqlCommand("SELECT m.mokki_id, m.alue_id, m.mokkinimi, m.kuvaus" +
                " FROM mokki m INNER JOIN alue a ON m.alue_id = a.alue_id AND a.nimi = @Vali" +
                " WHERE NOT EXISTS" +
                " (SELECT * FROM varaus v WHERE m.mokki_id = v.mokki_mokki_id AND" +
                " v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku)", conn))
            {
                using (MySqlDataAdapter adapter2 = new MySqlDataAdapter(command))
                {

                    
                    OpenConnection();
                    command.Parameters.AddWithValue("@Vali", cbAlue2.Text);
                    command.Parameters.AddWithValue("@Alku", dtpVarauksen_alkupvm.Text);
                    command.Parameters.AddWithValue("@Loppu", dtpVarauksen_loppupvm.Text);

                    try
                    {
                        DataTable dt = new DataTable();
                        adapter2.Fill(dt);
                        dgvVapaat.DataSource = dt;
                        CloseConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Haku epäonnistui");
                    }
                    if (dgvVapaat.Rows.Count == 1)
                    {
                        MessageBox.Show("Ei vapaita mökkejä paikassa " + cbAlue2.Text + "\n" + dtpVarauksen_alkupvm.Text + " - " + dtpVarauksen_loppupvm.Text + " aikana");
                    }
                }              
            }
        }
        //toimii
        //vie mokki id:n varausten hallintaan
        private void dgvVapaat_MouseClick(object sender, MouseEventArgs e)
        {
            tbMokki_ID.Text = dgvVapaat.CurrentRow.Cells[0].Value.ToString();
        }

        //asiakkaat

        //toimii
        //vie asiakas id:n varausten hallintaan
        private void dgvAsiakasTiedot_MouseClick(object sender, MouseEventArgs e)
        {
            tbAsiakas_ID.Text = dgvAsiakasTiedot.CurrentRow.Cells[1].Value.ToString();
        }

        //varausten hallinta

        //toimii
        //klikkaamalla datagridview:in riviä tiedot siirtyvät tekstikenttiin
        private void dgvVaraukset_MouseClick(object sender, MouseEventArgs e)
        {
            tbVaraus_ID.Text = dgvVaraukset.CurrentRow.Cells[0].Value.ToString();
            tbAsiakas_ID.Text = dgvVaraukset.CurrentRow.Cells[1].Value.ToString();
            tbMokki_ID.Text = dgvVaraukset.CurrentRow.Cells[2].Value.ToString();
            dtpVarattu_pvm.Text = dgvVaraukset.CurrentRow.Cells[3].Value.ToString();
            dtpVahvistus_pvm.Text = dgvVaraukset.CurrentRow.Cells[4].Value.ToString();
            dtpVarauksen_alkupvm.Text = dgvVaraukset.CurrentRow.Cells[5].Value.ToString();
            dtpVarauksen_loppupvm.Text = dgvVaraukset.CurrentRow.Cells[6].Value.ToString();
        }

        //toimii
        //lisätään varaus
        private void btnLisaa_varaus_Click(object sender, EventArgs e)
        {
                try
                {
                //lisätään varaus tietokantaan
                    int varausID = int.Parse(tbVaraus_ID.Text);
                    string insertQuery = "insert into varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, " +
                        "varattu_alkupvm, varattu_loppupvm) values(" + varausID + ",'" + tbAsiakas_ID.Text + "','" + tbMokki_ID.Text + "','" +
                        dtpVarattu_pvm.Text + "','" + dtpVahvistus_pvm.Text + "','" + dtpVarauksen_alkupvm.Text + "','" + dtpVarauksen_loppupvm.Text + "')";                   
                    ExecuteMyQuery(insertQuery);
                    populateDGV();

                    //vie id:t richtextboxiin
                    rtbLasku.Text = "Varaus ID: " + tbVaraus_ID.Text;
                    rtbLasku.Text += Environment.NewLine + "Asiakas ID: " + tbAsiakas_ID.Text;
                    rtbLasku.Text += Environment.NewLine + "Mökki ID: " + tbMokki_ID.Text;
                    rtbLasku.Text += Environment.NewLine + " ";

                    //haetaan mökin hinta, vierailupäivien määrä ja lasketaan yöpymisen hinta
                    OpenConnection();
                    MySqlDataReader mdr;
                    string select = "SELECT datediff(varattu_loppupvm, varattu_alkupvm) AS erotus, datediff(varattu_loppupvm, varattu_alkupvm)*m.hinta AS kokosum," +
                        " m.hinta FROM varaus INNER JOIN " +
                        "mokki m ON mokki_mokki_id = m.mokki_id AND varaus_id = " + tbVaraus_ID.Text;               
                    command = new MySqlCommand(select, connection);
                    command.Prepare();
                    mdr = command.ExecuteReader();

                //vie tiedot richtextboxiin
                    while (mdr.Read())
                    {
                        rtbLasku.Text += Environment.NewLine + "Mökki hinta: " + mdr["hinta"];
                        rtbLasku.Text += Environment.NewLine + "Päivät: " + mdr["erotus"];
                        rtbLasku.Text += Environment.NewLine + "Yöpymisen kokonaishinta: " + mdr["kokosum"];
                        rtbLasku.Text += Environment.NewLine + " ";
                    }
                    CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lisääminen epäonnistui");
                }
        }

        //toimii
        //poistetaan valittu varaus
        private void btnPoista_varaus_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM varaus WHERE varaus_id = " + int.Parse(tbVaraus_ID.Text);
                ExecuteMyQuery(deleteQuery);
                populateDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Poistaminen epäonnistui");
            }

        }

        //toimii
        //päivitetään valittu varaus
        private void btnPaivita_varaus_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE varaus SET asiakas_id='" + tbAsiakas_ID.Text + "',mokki_mokki_id='" + tbMokki_ID.Text
                + "',varattu_pvm='" + dtpVarattu_pvm.Text + "',vahvistus_pvm='" + dtpVahvistus_pvm.Text + "',varattu_alkupvm='" + dtpVarauksen_alkupvm.Text
                + "',varattu_loppupvm='" + dtpVarauksen_loppupvm.Text + "' WHERE varaus_id =" + int.Parse(tbVaraus_ID.Text);
            ExecuteMyQuery(updateQuery);
            populateDGV();
        }

        //toimii
        //etsitään tiedot varaus id:llä
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = "SELECT * FROM varaus WHERE varaus_id = " + tbVaraus_ID.Text;
            command = new MySqlCommand(select, connection);
            OpenConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                tbAsiakas_ID.Text = mdr.GetInt32("asiakas_id").ToString();
                tbMokki_ID.Text = mdr.GetInt32("mokki_mokki_id").ToString();
                dtpVarattu_pvm.Text = mdr.GetDateTime("varattu_pvm").ToString();
                dtpVahvistus_pvm.Text = mdr.GetDateTime("vahvistus_pvm").ToString();
                dtpVarauksen_alkupvm.Text = mdr.GetDateTime("varattu_alkupvm").ToString();
                dtpVarauksen_loppupvm.Text = mdr.GetDateTime("varattu_loppupvm").ToString();
            }
            else
            {
                MessageBox.Show("Etsintä epäonnistui");
            }

            CloseConnection();
        }

        //Palvelut


        //toimii
        private void btnLisaaVarauksenPalvelu_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = int.Parse(tbVaraus_ID.Text);
                string insertQuery = "insert into varauksen_palvelut(varaus_id, palvelu_id, lkm) values(" + varausID + ",'" + tbPalveluID.Text + "','" + nudLkm.Text + "')";
                ExecuteMyQuery(insertQuery);
                populateDGV2();

                //haetaan palvelut ja lasketaan niiden hinnat
                OpenConnection();
                MySqlDataReader mdr2;
                string select2 = "SELECT p.hinta, p.alv, p.nimi, vp.lkm, (p.hinta/100*p.alv+p.hinta)*vp.lkm AS kerrottu FROM palvelu p " +
                    "INNER JOIN varauksen_palvelut vp ON vp.palvelu_id = p.palvelu_id AND vp.varaus_id = " + tbVaraus_ID.Text;
                command = new MySqlCommand(select2, connection);
                command.Prepare();
                mdr2 = command.ExecuteReader();

                while (mdr2.Read())
                {
                    rtbLasku.Text += Environment.NewLine + "Palvelu: " + mdr2["nimi"];
                    rtbLasku.Text += Environment.NewLine + "Palvelun hinta: " + mdr2["hinta"];
                    rtbLasku.Text += Environment.NewLine + "Alv: " + mdr2["alv"];

                    rtbLasku.Text += Environment.NewLine + "Palveluiden määrä: " + mdr2["lkm"];
                    rtbLasku.Text += Environment.NewLine + "Palvelun lopullinen hinta: " + mdr2["kerrottu"];
                    rtbLasku.Text += Environment.NewLine + " ";
                }
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Lisääminen epäonnistui");
            }
        }

        //toimii
        //palvelu id:een haku textboxiin
        private void cbPalvelut_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlDataReader mdr;
            string select = "SELECT palvelu_id FROM palvelu WHERE nimi = @vali";
            OpenConnection();
            command = new MySqlCommand(select, connection);
            command.Parameters.AddWithValue("@vali", cbPalvelut.Text);
            command.Prepare();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                tbPalveluID.Text = Convert.ToString(mdr["palvelu_id"]);
            }
            CloseConnection();
        }

        //toimii
        //lasketaan laskun summa
        private void btnLaske_Click(object sender, EventArgs e)
        {
            //haetaan palvelut ja lasketaan niiden hinnat
            OpenConnection();
            MySqlDataReader mdr2;
            string select2 = "SELECT COALESCE(SUM((p.hinta / 100 * p.alv + p.hinta) * vp.lkm),0)+" +
                "datediff(varattu_loppupvm, varattu_alkupvm)*m.hinta AS kokonaishinta" +
                " FROM palvelu p INNER JOIN varauksen_palvelut vp ON vp.palvelu_id = p.palvelu_id AND vp.varaus_id = @Vali" +
                " INNER JOIN varaus v ON @Vali = v.varaus_id" +
                " INNER JOIN mokki m ON v.mokki_mokki_id = m.mokki_id";
            command = new MySqlCommand(select2, connection);
            command.Parameters.AddWithValue("@Vali", tbVaraus_ID.Text);
            command.Prepare();
            mdr2 = command.ExecuteReader();

            while (mdr2.Read())
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";

                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

                rtbLasku.Text += Environment.NewLine + "Kokonais kustannukset: " + mdr2["kokonaishinta"];
                rtbLasku.Text += Environment.NewLine + " ";
                // tbSumma.Text = Convert.ToString(mdr2["kokonaishinta"]);

                tbSumma.Text = Convert.ToString(mdr2["kokonaishinta"]);
            }
            CloseConnection();
        }

        //ei toimi
        private void btnLisaaLasku_Click(object sender, EventArgs e)
        {
            try
            {
                int laskuID = int.Parse(tbLasku_ID.Text);
                string insertQuery = "insert into lasku(lasku_id, varaus_id, summa, alv) values(" + laskuID + ",'" + int.Parse(tbVaraus_ID.Text) + "','" + tbSumma.Text + "','" +
                   tbAlv.Text + "')";
                ExecuteMyQuery(insertQuery);
            }
            catch
            {
                MessageBox.Show("Lisääminen epäonnistui");
            }
        }

        //ei toimi
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                // OpenConnection();
                int rowIndex = dgvPalvelut.CurrentCell.RowIndex;
                dgvPalvelut.Rows.RemoveAt(rowIndex);
                //populateDGV();
                // CloseConnection();
            }
            catch
            {
                MessageBox.Show("lol");
            }
        }


        private void dgvPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            cbAlue2.Text = " ";
            cbPalvelut.Text = " ";
            tbAsiakas_ID.Text = " ";
            tbLasku_ID.Text = " ";
            tbAlv.Text = " ";
            tbMokki_ID.Text = " ";
            tbPalveluID.Text = " ";
            tbSumma.Text = " ";
            tbVaraus_ID.Text = " ";
            nudLkm.Text = "0";
            rtbLasku.Text = " ";
            dtpVahvistus_pvm.Value = DateTime.Today;
            dtpVarattu_pvm.Value = DateTime.Today;
            dtpVarauksen_alkupvm.Value = DateTime.Today;
            dtpVarauksen_loppupvm.Value = DateTime.Today;
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
