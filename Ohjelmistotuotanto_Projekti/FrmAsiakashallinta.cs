using System;
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


namespace Ohjelmistotuotanto_Projekti
{
    public partial class FrmAsiakashallinta : Form
    {
        bool bOnnistui;//tämä boolean on varattuna tekstikenttien tarkistuksiin
        MySqlCommand command;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;password=ruutti");

        //funktio joka avaa tietokantayhteyden suorittaakseen kyselyn
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //funktio joka sulkee tietokantayhteyden suoritettuaan kyselyn
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //funktio joka tuo taulukkoon tiedot asiakas ja posti tauluista ilman dublikaattitietoja
        public void populateDGV()
        {
            string query = "SELECT a.asiakas_id AS AsiakasID, p.toimipaikka AS Postitoimipaikka, a.postinro AS Postinumero, a.etunimi AS Etunimi, a.sukunimi AS Sukunimi, a.lahiosoite AS Lahiosoite, a.email AS Email, a.puhelinnro AS Puhelinnumero FROM asiakas a JOIN posti p ON a.postinro = p.postinro ORDER BY a.asiakas_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvFullAsiakas.DataSource = table;
        }

        //funktio joka suorittaa kyselyn
        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    
                }
                else
                {
                    
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

    public FrmAsiakashallinta()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbAsiakasID.Text = "-";
            //tuo ohjelman avatessa tiedot taulukkoon
            populateDGV();
        }

        private void btnLisaaTieto_Click(object sender, EventArgs e)
        {//Lisää uuden asiakkaan tekstikenttiin syötetyn tiedon perusteella
         //suorittaa kyselyn joka lisää ensin postinron ja toimipaikan koska asiakas taulu ei toimi ilman posti taulussa jo löytyvää postinumeroa
            if (MessageBox.Show("Haluatko lisätä asiakkaan näillä tiedoilla?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //suorittaa postitauluun tietoja lisäävän kyselyn estäen samalla duplikaatin luomisen
                string insertQuery1 = "insert into posti(postinro, toimipaikka) values(" + tbPostnum.Text + ",'" + tbPostitoimipaikka.Text + "') ON DUPLICATE KEY UPDATE postinro='" + tbPostnum.Text + "'";

                ExecuteMyQuery(insertQuery1);
                
                //kun postitaulun tiedot annettu niin suorittaa asiakastauluun tietoja lisäävän kyselyn
                string insertQuery2 = "insert into asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) values(" + tbPostnum.Text + ",'" + tbEtunimi.Text + "','" + tbSukunimi.Text + "','" + tbLahiosoite.Text + "','" + tbEmail.Text + "','" + tbPuhnum.Text + "')";

                //suorittaa kyselyn jossa lisää loputkin asiakkaan tiedot tauluun
                ExecuteMyQuery(insertQuery2);

                MessageBox.Show("Asiakas lisätty");
            }
            
            //päivittää taulukon tiedot
            populateDGV();

            //lisäyksen jälkeen tyhjentää rivit
            tbPostitoimipaikka.Text = "";
            tbPostnum.Text = "";
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbLahiosoite.Text = "";
            tbEmail.Text = "";
            tbPuhnum.Text = "";
        }
        
        private void btnPoista_Click(object sender, EventArgs e)
        {
            //Poistaa asiakastaulusta valitut tiedot ja päivittää taulun näkymän ohjelmassa
            if(MessageBox.Show("Haluatko varmasti poistaa valitsemasi asiakkaan?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //poistaa valitun asiakastaulussa olevan asiakkaan
                string deleteQuery1 = "DELETE FROM asiakas WHERE asiakas_id = "+int.Parse(lbAsiakasID.Text);

                ExecuteMyQuery(deleteQuery1);

                //päivittää taulukon tiedot
                populateDGV();

                //tyhjentää tekstikenttien rivit
                lbAsiakasID.Text = "-";
                tbPostitoimipaikka.Text = "";
                tbPostnum.Text = "";
                tbEtunimi.Text = "";
                tbSukunimi.Text = "";
                tbLahiosoite.Text = "";
                tbEmail.Text = "";
                tbPuhnum.Text = "";
            }
        }
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti päivittää valitun asiakkaan tiedot?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //johtuen siitä, että postinro on pääavain eikä anna constraintin takia päivittää itseään niin kierretään asia siten että tehdään ensin kysely, jossa lisätään
                //uusi postinro posti tauluun jos sitä ei jo ole ja seuraavassa kyselyssä voimme päivittää asian asiakastauluun ja päivittää asiakkaalle allokoidun postinron
                //HUOM! jos päivitettävä postinro on jo olemassa niin ensimmäinen kysely ei lisää toista samanlaista postinroa vaan "siirtyy" seuraavaan kyselyyn
                string updateQuery1 = "insert into posti(postinro, toimipaikka) values(" + tbPostnum.Text + ",'" + tbPostitoimipaikka.Text + "') ON DUPLICATE KEY UPDATE postinro='" + tbPostnum.Text + "'";

                ExecuteMyQuery(updateQuery1); 
                
                //tämä on "varsinainen" päivityskysely jolla päivitetään asiakkaan tiedot asiakastauluun
                string updateQuery2 = "UPDATE asiakas SET postinro='" + tbPostnum.Text + "', etunimi='" + tbEtunimi.Text + "', sukunimi='" + tbSukunimi.Text + "', lahiosoite='" + tbLahiosoite.Text + "', email='" + tbEmail.Text + "', puhelinnro='" + tbPuhnum.Text + "' WHERE asiakas_id =" + int.Parse(lbAsiakasID.Text);

                ExecuteMyQuery(updateQuery2);

                //päivittää taulukon tiedot
                populateDGV();
            }
        }
        private void tbPuhnum_Leave(object sender, EventArgs e)
        {//tekee tarkistuksen siitä onko numero annettu oikein
            string puhnum = tbPuhnum.Text;
            puhnum = puhnum.Replace(" ", "");
            puhnum = puhnum.Replace("-", "");
            puhnum = puhnum.Replace(",", ""); 

            //numeron max pituus asetettu tekstikentän propertyjen kautta eli ei voi antaa tietokannassa määriteltyä pituutta isompaa merkkijonoa
            double num;//double on puhtaasti sen takia, koska jostain syystä tarkistus int tyyppisenä väittää että numeroa ei ole annettu oikein jos sen pituus on yli 10 merkkiä
            bOnnistui = double.TryParse(puhnum, out num);

            if(bOnnistui == false)
            {
                if(tbPuhnum.Text != "")//tämä on sen takia, että antaa poistua kentästä jos kenttä on tyhjä
                {
                    MessageBox.Show("Puhelinnumeroa ei annettu oikein.\r\rKenttään sallitaan numerot, välit ja väliviiva.\rTyhjennä kenttä poistuaksesi siitä tai anna numero oikein.", "Virhe puhelinnumeroa annettaessa");
                    tbPuhnum.Focus();//tämä estämään se ettei mene läpi vääränlaisia arvoja
                }
            }
        }

        private void tbPostnum_Leave(object sender, EventArgs e)
        {
            string postnum = tbPostnum.Text;
            postnum = postnum.Replace(" ", "");//muotoillaan teksti tarkistusta varten

            if(postnum.Length != 0 && postnum.Length != 5)//tarkistaa että postinumero on oikean pituinen (postinumerot ovat aina 5 numeron pituisia)
            {
                MessageBox.Show("Postinumeron pituuden pitää olla 5 numeroa tai kenttä pitää jättää tyhjäksi.", "Tarkista postinumeron pituus");
                tbPostnum.Focus();//tämän ansiosta käyttäjä ei pääse vahingossakaan lisäämään vääränmuotoista postinumeroa
            }
            else
            {
                double pnum;
                bOnnistui = double.TryParse(postnum, out pnum);//tarkistaa että onko kyseessä numerosarja

                if (bOnnistui == false)
                {
                    if (tbPostnum.Text != "")//tämä on sen takia, että antaa poistua kentästä jos kenttä on tyhjä
                    {
                        MessageBox.Show("Postinumeroa ei annettu oikein.\r\rKenttään sallitaan vain numeroita.", "Tarkista postinumero");
                        tbPostnum.Focus();//tämä estämään se ettei mene läpi vääränlaisia arvoja
                    }
                }
            }
        }

        //alla oleva toimii siten, että kun klikkaa taulukon riviä niin se hakee tiedot esille tiedoille sopiviin tekstikenttiin ja labeleihin
        private void dgvFullAsiakas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbAsiakasID.Text = dgvFullAsiakas.CurrentRow.Cells[0].Value.ToString();
            tbPostitoimipaikka.Text = dgvFullAsiakas.CurrentRow.Cells[1].Value.ToString();
            tbPostnum.Text = dgvFullAsiakas.CurrentRow.Cells[2].Value.ToString();
            tbEtunimi.Text = dgvFullAsiakas.CurrentRow.Cells[3].Value.ToString();
            tbSukunimi.Text = dgvFullAsiakas.CurrentRow.Cells[4].Value.ToString();
            tbLahiosoite.Text = dgvFullAsiakas.CurrentRow.Cells[5].Value.ToString();
            tbEmail.Text = dgvFullAsiakas.CurrentRow.Cells[6].Value.ToString();
            tbPuhnum.Text = dgvFullAsiakas.CurrentRow.Cells[7].Value.ToString();
            lbPostinro.Text = dgvFullAsiakas.CurrentRow.Cells[2].Value.ToString();
        }

        //vie takaisin päävalikkoon
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }
    }
}
