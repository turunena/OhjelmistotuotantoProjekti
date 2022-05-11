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
    public partial class frmPalvelut : Form
    {
        public frmPalvelut()
        {
            InitializeComponent();
        } // Tähän muutetaan salasana, jos se on erilainen sinun tietokannassasi.
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;password=Ruutti");
        MySqlCommand command;
        private void frmPalvelut_Load(object sender, EventArgs e)
        { // Formin lautuessa datagrideihin haetaan tietokannasta tiedot
            populateDGV();
            populateDGV2();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        { // Lisää napin funktio -- Lisätään tiedot tietokantaan
            int palveluID = int.Parse(textBox1.Text);
            int alueID = int.Parse(textBox2.Text);
            int tyyppi = int.Parse(textBox4.Text);
            double hinta = double.Parse(textBox6.Text);
            double alv = double.Parse(textBox7.Text);

            string insertQuery = "INSERT INTO palvelu(palvelu_id, alue_id, nimi, tyyppi, kuvaus, hinta, alv)values(" + palveluID + "," + alueID + ",'" + textBox3.Text + "'," + tyyppi + ",'" + textBox5.Text + "'," + hinta + "," + alv + ")";
            ExecuteMyQuery(insertQuery);
            populateDGV();
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        { // Päivitetään halutut tiedot tietokantaan
            int palveluID = int.Parse(textBox1.Text);
            int alueID = int.Parse(textBox2.Text);
            int tyyppi = int.Parse(textBox4.Text);
            double hinta = double.Parse(textBox6.Text);
            double alv = double.Parse(textBox7.Text);

            string updateQuery = "UPDATE palvelu SET palvelu_id=" + palveluID + ", alue_id=" + alueID + ",nimi='" + textBox3.Text + "',tyyppi=" + tyyppi + ",kuvaus='" + textBox5.Text + "',hinta=" + hinta + ",alv=" + alv + " WHERE palvelu_id=" + int.Parse(textBox1.Text);
            ExecuteMyQuery(updateQuery);
            populateDGV();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        { // Poistetaan halutut tiedot tietokannasta
            string deleteQuery = "DELETE FROM palvelu WHERE palvelu_id = " + int.Parse(textBox1.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV();
        }

        private void btnLisaa2_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO alue(nimi)values('" + textBox9.Text + "')";
            ExecuteMyQuery(insertQuery);
            populateDGV2();
        }

        private void btnPaivita2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE alue SET nimi='" + textBox9.Text + "' WHERE alue_id=" + int.Parse(textBox8.Text);
            ExecuteMyQuery(updateQuery);
            populateDGV2();
        }

        private void btnPoista2_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM alue WHERE alue_id = " + int.Parse(textBox8.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV2();
        }
        private void populateDGV()
        { // Haetaan tiedot tietokannasta, ja lisätään ne datagridiin
            try
            {
                string query = "SELECT * FROM palvelu";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateDGV2()
        { // Haetaan tiedot tietokannasta, ja lisätään ne datagridiin
            try
            {
                string query = "SELECT * FROM alue";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExecuteMyQuery(string query)
        { // Tässä funktiossa suoritetaan SQL-komennot
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

        public void OpenConnection()
        { // Avataan yhteys
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        { // Suljetaan yhteys
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        { // Lisätään tiedot tekstikenttiin klikkaamalla haluttua riviä
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        { // Lisätään tiedot tekstikenttiin klikkaamalla haluttua riviä
            textBox8.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
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
