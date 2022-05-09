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
    public partial class frmMokit : Form
    {

        public frmMokit()
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
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvYkkonen.DataSource = table;


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



        private void btnLisaa_Click(object sender, EventArgs e)
        {

            if (tbToiminta_AlueID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            if (tbMokkiID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna mökki ID");
                return;
            }

            int alueid = int.Parse(tbToiminta_AlueID.Text);
            int mokkiid = int.Parse(tbMokkiID.Text);
            string insertQuery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES(" + mokkiid + "," + alueid + ",'" + tbPostinumero.Text + "','" + tbMokkinimi.Text + "','" + tbKatuosoite.Text + "','" + tbHinta.Text + "','" + tbKuvaus.Text + "','" + tbHenkilomaara.Text + "','" + tbVarustelu.Text + "')";
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

        private void btnPoistaMokki_Click(object sender, EventArgs e)
        {
            if (tbToiminta_AlueID.Text.Trim() == string.Empty)
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

        private void btnPaivita2_Click(object sender, EventArgs e)
        {
            if (tbToiminta_AlueID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna toiminta-alue ID");
                return;
            }

            if (tbMokkiID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna mökki ID");
                return;
            }

            int alueid = int.Parse(tbToiminta_AlueID.Text);
            int mokkiid = int.Parse(tbMokkiID.Text);
            string updateQuery2 = "UPDATE mokki SET mokki_id='" + mokkiid + "',alue_id='" + alueid + "',postinro='" + tbPostinumero.Text + "',mokkinimi='" + tbMokkinimi.Text + "',katuosoite='" + tbKatuosoite.Text + "',hinta='" + tbHinta.Text + "',kuvaus='" + tbKuvaus.Text + "',henkilomaara='" + tbHenkilomaara.Text + "',varustelu='" + tbVarustelu.Text + "'WHERE mokki_id =" + mokkiid;
            ExecuteMyQuery(updateQuery2);
            populateDGV();

        }

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


 

