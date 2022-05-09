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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=ruutti");
        MySqlCommand command;


        private void Form1_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        public void populateDGV()
        {
            string query = "SELECT * FROM mokki";
            string query2 = "SELECT * FROM alue";
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvYkkonen.DataSource = table;
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvKakkonen.DataSource = table2;
        }


        private void dgvYkkonen_Click(object sender, EventArgs e)
        {
            tbMokkiID.Text = dgvYkkonen.CurrentRow.Cells[0].Value.ToString();
            tbToiminta_AlueID.Text = dgvYkkonen.CurrentRow.Cells[1].Value.ToString();
            tbPostinumero.Text = dgvYkkonen.CurrentRow.Cells[2].Value.ToString();
            tbMokkinimi.Text = dgvYkkonen.CurrentRow.Cells[3].Value.ToString();
            tbKatuosoite.Text = dgvYkkonen.CurrentRow.Cells[4].Value.ToString();
            tbHinta.Text = dgvYkkonen.CurrentRow.Cells[5].Value.ToString();
            tbKuvaus.Text = dgvYkkonen.CurrentRow.Cells[6].Value.ToString();
            tbHenkilomaara.Text = dgvYkkonen.CurrentRow.Cells[7].Value.ToString();
            tbVarustelu.Text = dgvYkkonen.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgvKakkonen_Click(object sender, EventArgs e)
        {
            tbToiminta_AlueID2.Text = dgvKakkonen.CurrentRow.Cells[0].Value.ToString();
            tbToiminta_AlueNimi.Text = dgvKakkonen.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            int alueid = int.Parse(tbToiminta_AlueID.Text);
            int mokkiid = int.Parse(tbMokkiID.Text);
            string insertQuery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES("+mokkiid+","+alueid+",'"+tbPostinumero.Text +"','" +tbMokkinimi.Text+ "','" + tbKatuosoite.Text + "','" + tbHinta.Text + "','" + tbKuvaus.Text + "','" + tbHenkilomaara.Text + "','" + tbVarustelu.Text + "')";
            ExecuteMyQuery(insertQuery);
            populateDGV();
        }

        private void btnLisaa2_Click(object sender, EventArgs e)
        {
            int alueid2 = int.Parse(tbToiminta_AlueID2.Text);
            string insertQuery = "INSERT INTO alue(alue_id, nimi) VALUES(" + alueid2 + ",'" + tbToiminta_AlueNimi.Text + "')";
            ExecuteMyQuery(insertQuery);
            populateDGV();
        }


        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

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

        private void btnPoistaAlue_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM alue WHERE alue_id = " + int.Parse(tbToiminta_AlueID2.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV();
        }

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM mokki WHERE mokki_id = " + int.Parse(tbMokkiID.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV();
        }

        private void tbToiminta_AlueNimi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 

