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

        private void frmAlueet_Load(object sender, EventArgs e)
        {
            populateDGV2();
        }


        public void populateDGV2()
        {
            string query2 = "SELECT * FROM alue";
            DataTable table2 = new DataTable();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvKakkonen.DataSource = table2;

        }

        private void dgvKakkonen_Click_1(object sender, EventArgs e)
        {
            tbToiminta_AlueID2.Text = dgvKakkonen.CurrentRow.Cells[0].Value.ToString();
            tbToiminta_AlueNimi.Text = dgvKakkonen.CurrentRow.Cells[1].Value.ToString();
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

        private void btnTakaisin2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

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

    }






}
