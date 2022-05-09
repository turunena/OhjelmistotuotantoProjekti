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
    public partial class frmMajoitusRaportti : Form
    {
        public frmMajoitusRaportti()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=ruutti;Allow User Variables=True");
        MySqlCommand command;

        private void frmMajoitusRaportti_Load(object sender, EventArgs e)
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

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog=vn;username=root;password=ruutti");
            using (command = new MySqlCommand("SELECT m.mokkinimi, m.mokki_id, m.alue_id, m.kuvaus" +
                " FROM mokki m INNER JOIN alue a ON m.alue_id = a.alue_id AND a.nimi = @Vali" +
                " INNER JOIN varaus v ON m.mokki_id = v.mokki_mokki_id AND" +
                " v.varattu_alkupvm <= @Loppu AND v.varattu_loppupvm >= @Alku", conn))
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
                        dgvRaportti.DataSource = dt;
                        CloseConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Haku epäonnistui");
                    }
                    if (dgvRaportti.Rows.Count == 1)
                    {
                        MessageBox.Show("Ei mökkejä varattuna alueella " + cbAlue.Text + "\n" + dtpMista.Text + " - " + dtpMihin.Text + " aikana");
                    }
                }
            }
        }
    }
}
