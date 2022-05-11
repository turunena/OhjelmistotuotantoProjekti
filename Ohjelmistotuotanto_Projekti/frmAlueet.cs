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
    public partial class frmAlueet : Form
    {
        public frmAlueet()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=Ruutti");
        MySqlCommand command;


        //dgw haku
        private void frmAlueet_Load(object sender, EventArgs e)
        {
            populateDGV2();
        }

        //tietojen haku Dgw:hen
        public void populateDGV2()
        {
            string query2 = "SELECT * FROM alue";
            DataTable table2 = new DataTable();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvKakkonen.DataSource = table2;

            string query3 = "SELECT * FROM posti";
            DataTable table3 = new DataTable();

            MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, connection);
            adapter3.Fill(table3);
            dgvPosti.DataSource = table3;

        }

        
        //tietojen kopiointi
        private void dgvKakkonen_Click_1(object sender, EventArgs e)
        {
            tbToiminta_AlueID2.Text = dgvKakkonen.CurrentRow.Cells[0].Value.ToString();
            tbToiminta_AlueNimi.Text = dgvKakkonen.CurrentRow.Cells[1].Value.ToString();
        }


        private void dgvPosti_Click(object sender, EventArgs e)
        {
            tbPostinro.Text = dgvPosti.CurrentRow.Cells[0].Value.ToString();
            tbtoimipaikka.Text = dgvPosti.CurrentRow.Cells[1].Value.ToString();
        }




        //yhteyden avaus tietokantaan
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

        //toimintojen käyttö
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

        //takaisin päävalikkoon
        private void btnTakaisin2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }


        //tietojen lisäys dgw
        private void btnLisaa2_Click_1(object sender, EventArgs e)
        {
            if (tbToiminta_AlueID2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }


            int alueid2 = int.Parse(tbToiminta_AlueID2.Text);
            string insertQuery = "INSERT INTO alue(alue_id, nimi) VALUES(" + alueid2 + ",'" + tbToiminta_AlueNimi.Text + "')";
            ExecuteMyQuery(insertQuery);
            populateDGV2();
        }

        private void btnLisaaPosti_Click(object sender, EventArgs e)
        {
            if (tbPostinro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna postinumero");
                return;
            }

            int postinro = int.Parse(tbPostinro.Text);
            string insertQuery2 = "INSERT INTO posti(postinro, toimipaikka) VALUES(" + tbPostinro.Text + ",'" + label123.Text + "')";
            ExecuteMyQuery(insertQuery2);
            populateDGV2();
        }



        //tietojen poisto dgw
        private void btnPoistaAlue_Click_1(object sender, EventArgs e)
        {
            if (tbToiminta_AlueID2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            string deleteQuery = "DELETE FROM alue WHERE alue_id = " + int.Parse(tbToiminta_AlueID2.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV2();
        }

        private void btnPoistaPosti_Click(object sender, EventArgs e)
        {
            string deleteQuery2 = "DELETE FROM posti WHERE postinro = " + tbPostinro.Text;
            ExecuteMyQuery(deleteQuery2);
            populateDGV2();
        }



        //tietojen päivitys dgw
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            if (tbToiminta_AlueID2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            int alueid2 = int.Parse(tbToiminta_AlueID2.Text);
            string updateQuery = "UPDATE alue SET alue_id='" + alueid2 + "',nimi='" + tbToiminta_AlueNimi.Text + "' WHERE alue_id =" + alueid2;
            ExecuteMyQuery(updateQuery);
            populateDGV2();
        }

        private void btnPaivitaPosti_Click(object sender, EventArgs e)
        {

            if (tbPostinro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna postinumero");
                return;
            }

            int postinro = int.Parse(tbPostinro.Text);
            string updateQuery2 = "UPDATE posti SET postinro='" + tbPostinro.Text + "',toimipaikka='" + tbtoimipaikka.Text + "' WHERE postinro =" + tbPostinro.Text;
            ExecuteMyQuery(updateQuery2);
            populateDGV2();


        }
    }






}
