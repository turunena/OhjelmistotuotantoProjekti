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
using System.Configuration;
using System.Web.Configuration;
using Microsoft.Build.Framework.XamlTypes;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ohjelmistotuotanto_Projekti
{
    public partial class frmMokit : Form
    {

        public frmMokit()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=Ruutti");
        MySqlCommand command;


        private void Form1_Load(object sender, EventArgs e)
        {
            populateDGV();

            //postinumeron ja alueid haku comboboxiin
            OpenConnection();


            MySqlDataReader reader;
            string query1 = "SELECT * FROM posti";
            command = new MySqlCommand(query1, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbPostinro.Items.Add(reader["postinro"]);
            }
            MySqlConnection connection2 = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=Ruutti");

            connection2.Open();
            MySqlCommand command2;
            MySqlDataReader reader2;
            string query2 = "SELECT * FROM alue";
            command2 = new MySqlCommand(query2, connection2);
            reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                cbAlue_ID.Items.Add(reader2["alue_id"]);
            }

            CloseConnection();
        }

        //Täydennetään datagridviewi
        public void populateDGV()
        {
            string query = "SELECT * FROM mokki";
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvYkkonen.DataSource = table;
        }

        //Kopiointi datagridiä klikatessa
        private void dgvYkkonen_Click(object sender, EventArgs e)
        {
            tbMokkiID.Text = dgvYkkonen.CurrentRow.Cells[0].Value.ToString();
            cbAlue_ID.Text = dgvYkkonen.CurrentRow.Cells[1].Value.ToString();
            cbPostinro.Text = dgvYkkonen.CurrentRow.Cells[2].Value.ToString();
            tbMokkinimi.Text = dgvYkkonen.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvYkkonen.CurrentRow.Cells[4].Value.ToString();
            tbHinta.Text = dgvYkkonen.CurrentRow.Cells[5].Value.ToString();
            tbKuvaus.Text = dgvYkkonen.CurrentRow.Cells[6].Value.ToString();
            tbHenkilomaara.Text = dgvYkkonen.CurrentRow.Cells[7].Value.ToString();
            tbVarustelu.Text = dgvYkkonen.CurrentRow.Cells[8].Value.ToString();
        }


        //tietojen lisäys dgw
        private void btnLisaa_Click(object sender, EventArgs e)
        {

            if (cbAlue_ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            if (tbMokkiID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna mökki ID");
                return;
            }
            if (tbHinta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna hinta");
                return;
            }
            if (tbHenkilomaara.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna henkilömäärä");
                return;
            }

            int alueid = int.Parse(cbAlue_ID.Text);
            int mokkiid = int.Parse(tbMokkiID.Text);
            string insertQuery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES(" + mokkiid + "," + alueid + ",'" + cbPostinro.Text + "','" + tbMokkinimi.Text + "','" + tbKatuosoite.Text + "','" + tbHinta.Text + "','" + tbKuvaus.Text + "','" + tbHenkilomaara.Text + "','" + tbVarustelu.Text + "')";
            ExecuteMyQuery(insertQuery);
            populateDGV();
        }

        //yhteyden avaus
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //yhteyden sulku
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //Toimintojen käyttö
        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Toiminto Suoritettu");
                }
                else
                {
                    MessageBox.Show("Toimintoa ei suoritettu");
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

        //Tietojen poisto dgw
        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            if (cbAlue_ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            if (tbMokkiID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna mökki ID");
                return;
            }

            string deleteQuery = "DELETE FROM mokki WHERE mokki_id = " + int.Parse(tbMokkiID.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV();
        }

        //tietojen päivitys dgw
        private void btnPaivita2_Click(object sender, EventArgs e)
        {
            if (cbAlue_ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            if (tbMokkiID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna mökki ID");
                return;
            }

            int alueid = int.Parse(cbAlue_ID.Text);
            int mokkiid = int.Parse(tbMokkiID.Text);
            string updateQuery2 = "UPDATE mokki SET mokki_id='" + mokkiid + "',alue_id='" + alueid + "',postinro='" + cbPostinro.Text + "',mokkinimi='" + tbMokkinimi.Text + "',katuosoite='" + tbKatuosoite.Text + "',hinta='" + tbHinta.Text + "',kuvaus='" + tbKuvaus.Text + "',henkilomaara='" + tbHenkilomaara.Text + "',varustelu='" + tbVarustelu.Text + "'WHERE mokki_id =" + mokkiid;
            ExecuteMyQuery(updateQuery2);
            populateDGV();

        }

        //takaisin päävalikkoon
        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

        private void tbToiminta_AlueNimi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


 

