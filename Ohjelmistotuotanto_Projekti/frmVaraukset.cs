using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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

        private void frmVaraukset_Load(object sender, EventArgs e)
        {
            populateDGV();

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

        public void populateDGV()
        {
            string query = "SELECT varaus_id AS VarausID, asiakas_id AS AsiakasID, mokki_mokki_id AS MokkiID, varattu_pvm AS Varauspaiva," +
                " vahvistus_pvm AS Vahvistuspaiva, " +
                    "varattu_alkupvm AS Saapumispaiva, varattu_loppupvm AS Lahtopaiva FROM varaus";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvVaraukset.DataSource = table;
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

        //kun alue valitaan palveluihin tulee tieto mitä sillä alueella on
        private void cbAlue2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPalvelut.Text = " ";
            cbPalvelut.Items.Clear();
            tbPalveluID.Text = " ";


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

        //etsii vapaana olevat mökit paikan ja ajan perusteella
        private void btnEtsiMokit_Click(object sender, EventArgs e)
        {
            using (command = new MySqlCommand("SELECT m.mokkinimi AS Nimi, m.mokki_id AS MokkiID, m.alue_id AS AlueID, " +
                "m.kuvaus As Kuvaus, m.varustelu AS Varustelu, m.hinta AS Hinta " +
                " FROM mokki m INNER JOIN alue a ON m.hinta > @Vhinta AND m.hinta < @Ehinta AND m.alue_id = a.alue_id AND a.nimi = @Alue" +
                " WHERE NOT EXISTS" +
                " (SELECT * FROM varaus v WHERE m.mokki_id = v.mokki_mokki_id AND" +
                " v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku)", connection))
            {
                using (MySqlDataAdapter adapter2 = new MySqlDataAdapter(command))
                {
                    OpenConnection();
                    command.Parameters.AddWithValue("@Alue", cbAlue2.Text);
                    command.Parameters.AddWithValue("@Vhinta", tbVahintaan.Text);
                    command.Parameters.AddWithValue("@Ehinta", tbEnintaan.Text);
                    command.Parameters.AddWithValue("@Alku", dtpVarauksen_alkupvm.Text);
                    command.Parameters.AddWithValue("@Loppu", dtpVarauksen_loppupvm.Text);

                    string VahStr = tbVahintaan.Text.Trim();
                    string EnStr = tbEnintaan.Text.Trim();//poistaa ylimääräiset
                    int vah = 0;
                    int en = 0;
                    bool ok1 = int.TryParse(VahStr, out vah);
                    bool ok2 = int.TryParse(EnStr, out en);
                    tbVahintaan.Text = VahStr;
                    tbEnintaan.Text = EnStr;

                    if (string.IsNullOrEmpty(cbAlue2.Text))
                    {
                        MessageBox.Show("Valitse alue");
                    }
                    else if (!ok1 || vah < 0)
                    {
                        MessageBox.Show("Mökin vähintään hinta puuttuu tai ei ole kokonaisluku");
                    }
                    else if (!ok2 || en < 0)
                    {
                        MessageBox.Show("Mökin enintään hinta puuttuu tai ei ole kokonaisluku");
                    }
                    else
                    {
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
                            MessageBox.Show("Ei vapaita mökkejä valituilla ehdoilla " + "\n" + "paikassa " + cbAlue2.Text);
                        }
                    }


                }
            }
        }

        //vie mokki id:n varausten hallintaan
        private void dgvVapaat_MouseClick(object sender, MouseEventArgs e)
        {
            tbMokki_ID.Text = dgvVapaat.CurrentRow.Cells[1].Value.ToString();
        }

        //vie asiakas id:n varausten hallintaan
        private void dgvAsiakasTiedot_MouseClick(object sender, MouseEventArgs e)
        {
            tbAsiakas_ID.Text = dgvAsiakasTiedot.CurrentRow.Cells[1].Value.ToString();
        }

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

        //lisätään varaus
        private void btnLisaa_varaus_Click(object sender, EventArgs e)
        {
            try
            {
                //lisätään varaus tietokantaan
                int varausID = int.Parse(tbVaraus_ID.Text);
                int asiakasID = int.Parse(tbAsiakas_ID.Text);
                int mokkiID = int.Parse(tbMokki_ID.Text);
                string insertQuery = "insert into varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, " +
                    "varattu_alkupvm, varattu_loppupvm) values(" + varausID + ",'" + asiakasID + "','" + mokkiID + "','" +
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

        //päivitetään valittu varaus
        private void btnPaivita_varaus_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE varaus SET asiakas_id='" + tbAsiakas_ID.Text + "',mokki_mokki_id='" + tbMokki_ID.Text
                + "',varattu_pvm='" + dtpVarattu_pvm.Text + "',vahvistus_pvm='" + dtpVahvistus_pvm.Text + "',varattu_alkupvm='" + dtpVarauksen_alkupvm.Text
                + "',varattu_loppupvm='" + dtpVarauksen_loppupvm.Text + "' WHERE varaus_id =" + int.Parse(tbVaraus_ID.Text);
                ExecuteMyQuery(updateQuery);
                populateDGV();
            }
            catch
            {
                MessageBox.Show("Päivitys epäonnistui");
            }
            
        }

        //etsitään tiedot varaus id:llä
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Ei löydy varausta");
                }

                CloseConnection();
            }
            catch
            {
                MessageBox.Show("VarausID puuttuu tai ei ole kokonaisluku");
            }
        }

        private void btnLisaaVarauksenPalvelu_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = int.Parse(tbVaraus_ID.Text);
                string insertQuery = "insert into varauksen_palvelut(varaus_id, palvelu_id, lkm) values(" + varausID + ",'" + tbPalveluID.Text + "','" + nudLkm.Text + "')";
                ExecuteMyQuery(insertQuery);

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
                tbSumma.Text = Convert.ToString(mdr2["kokonaishinta"]);
            }
            CloseConnection();
        }

        //lisää laskun tietokantaan
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
            tbVahintaan.Text = " ";
            tbEnintaan.Text = " ";
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
