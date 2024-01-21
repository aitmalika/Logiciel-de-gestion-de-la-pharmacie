using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class SituationStocks : Form
    {
        public SituationStocks()
        {
            InitializeComponent();
            RemplirStocks();
            

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");

        private void Reinitialiser()
        {
            TextMedNume.SelectedValue.ToString();
            textQuantiteStock.Text = "";
            TextDateEntre.Text = "";
            Cle = 0;

        }
        private void Mednumero_Click(object sender, EventArgs e)
        {

        }

        private void Affichierstocks_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Req = "select * From Stocks";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            SqlCommandBuilder builler = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridStocks.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void Reinitialiserstocks_Click(object sender, EventArgs e)
        {
            Reinitialiser();

        }
        private void RemplirStocks()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select MedNum From MedicamentTbl", conn);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MedNum", typeof(int));
            dt.Load(Rdr);
            TextMedNume.ValueMember = "MedNum";
            TextMedNume.DataSource = dt;
            conn.Close();
        }
        int Cle = 0;
        private void DataGridStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridStocks.SelectedRows.Count > 0)
            {
                TextMedNume.SelectedValue = DataGridStocks.SelectedRows[0].Cells[1].Value.ToString();
                textQuantiteStock.Text = DataGridStocks.SelectedRows[0].Cells[2].Value.ToString();
                if (DateTime.TryParse(DataGridStocks.SelectedRows[0].Cells[3].Value?.ToString(), out DateTime dateentre))
                {
                    TextDateEntre.Value = dateentre;
                }
                else
                {
                    // Gérer le cas où la valeur n'est pas une date valide (peut-être afficher un message d'erreur)
                }
                if (TextMedNume.Text == "")
                    Cle = 0;
                else
                    Cle = Convert.ToInt32(DataGridStocks.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void SituationStocks_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
