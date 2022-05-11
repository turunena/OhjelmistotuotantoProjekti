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
    public partial class frmLaskut : Form
    {
        public frmLaskut()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3307; Database=vn; Uid=root; Pwd=Ruutti");
        MySqlCommand command;

        private void frmLaskut_Load(object sender, EventArgs e)
        {
            populateDGV();

            OpenConnection();
            MySqlDataReader reader;
            string query1 = "SELECT * FROM varaus";
            command = new MySqlCommand(query1, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cbVarausID.Items.Add(reader["varaus_id"]);
            }
            CloseConnection();

        }

        public void populateDGV()
        {
            string query2 = "SELECT * FROM lasku";
            DataTable table2 = new DataTable();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, connection);
            adapter2.Fill(table2);
            dgvLaskut.DataSource = table2;

        }

        private void dgvLaskut_Click(object sender, EventArgs e)
        {
            tbLaskuID.Text = dgvLaskut.CurrentRow.Cells[0].Value.ToString();
            cbVarausID.Text = dgvLaskut.CurrentRow.Cells[1].Value.ToString();
            tbSumma.Text = dgvLaskut.CurrentRow.Cells[2].Value.ToString();
            tbAlv.Text = dgvLaskut.CurrentRow.Cells[3].Value.ToString();

        }

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

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValikko valikko = new frmValikko();
            valikko.ShowDialog();
            this.Close();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            if (tbLaskuID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna lasku ID");
                return;
            }

            if (cbVarausID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna varaus ID");
                return;
            }

            int laskuid = int.Parse(tbLaskuID.Text);
            int varausid = int.Parse(cbVarausID.Text);
            string insertQuery = "INSERT INTO lasku(lasku_id, varaus_id, summa, alv) VALUES(" + varausid + "," + laskuid + ",'" + tbSumma.Text + "','" + tbAlv.Text +"')";
            ExecuteMyQuery(insertQuery);
            populateDGV();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (tbLaskuID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna lasku ID");
                return;
            }

            if (cbVarausID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna varaus ID");
                return;
            }


            string deleteQuery = "DELETE FROM lasku WHERE lasku_id = " + int.Parse(tbLaskuID.Text);
            ExecuteMyQuery(deleteQuery);
            populateDGV();
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            if (tbLaskuID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna lasku ID");
                return;
            }

            if (cbVarausID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna varaus ID");
                return;
            }


            int laskuid = int.Parse(tbLaskuID.Text);
            int varausid = int.Parse(cbVarausID.Text);
            string updateQuery2 = "UPDATE lasku SET lasku_id='" + laskuid + "',varaus_id='" + varausid + "',summa='" + tbSumma.Text + "',alv='" + tbAlv.Text;
            ExecuteMyQuery(updateQuery2);
            populateDGV();

        }

        private void btnHae_Click(object sender, EventArgs e)
        {

            if (tbLaskuID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Anna lasku ID");
                return;
            }

            MySqlDataReader mdr;
            string select = "SELECT * FROM lasku WHERE lasku_id = " + tbLaskuID.Text;
            command = new MySqlCommand(select, connection);
            OpenConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                cbVarausID.Text = mdr.GetInt32("varaus_id").ToString();
                tbSumma.Text = mdr.GetInt32("summa").ToString();
                tbAlv.Text = mdr.GetInt32("alv").ToString();
            }
            else
            {
                MessageBox.Show("Etsintä epäonnistui");
            }

            CloseConnection();
        }




    }
}
