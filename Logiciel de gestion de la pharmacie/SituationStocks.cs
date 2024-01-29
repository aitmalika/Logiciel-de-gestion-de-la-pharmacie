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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class SituationStocks : Form
    {
        public SituationStocks()
        {
            InitializeComponent();
            RemplirStocks();
            Afficher();


        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");

        private void Reinitialiser()
        {
            TextMedNume.SelectedValue.ToString();
            textQuantitedepart.Text = "";
            TextDateEntre.Text = "";
            textquantiteachat.Text = "";
            textquantiteVente.Text = "";
            textstocksfinal.Text = "";
            Cle = 0;

        }
        private void Mednumero_Click(object sender, EventArgs e)
        {

        }

        private void Affichierstocks_Click(object sender, EventArgs e)
        {
            try
            {
                // Assurez-vous qu'une ligne est sélectionnée
                if (DataGridStocks.SelectedRows.Count > 0)
                {
                    // Obtenez les valeurs de la ligne sélectionnée
                    int medNum = Convert.ToInt32(DataGridStocks.SelectedRows[0].Cells[6].Value);
                    DateTime dateEntre = Convert.ToDateTime(DataGridStocks.SelectedRows[0].Cells[5].Value);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True"))
                    {
                        conn.Open();

                        string query = "SELECT QuantiteDepart, QuantiteAchat, QuantiteVente, StocksFinal FROM Stocks WHERE MedNume = @MedNum AND DateEntre = @DateEntre";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@MedNum", MedNume);
                            command.Parameters.AddWithValue("@DateEntre", dateEntre);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Afficher les valeurs dans les TextBox
                                    textQuantitedepart.Text = reader["QuantiteDepart"].ToString();
                                    textquantiteachat.Text = reader["QuantiteAchat"].ToString();
                                    textquantiteVente.Text = reader["QuantiteVente"].ToString();
                                    textstocksfinal.Text = reader["StockFinal"].ToString();
                                }
                                else
                                {
                                    // Aucune entrée correspondante trouvée
                                    MessageBox.Show("Aucune entrée trouvée pour le médicament et la date spécifiés.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne pour afficher les quantités.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des quantités : " + ex.Message);
            }



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
        public void Afficher()
        {
            conn.Open();
            string Req = "select * From Stocks";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridStocks.AutoGenerateColumns = false;
            DataGridStocks.DataSource = dt;
            conn.Close();
        }
        int Cle = 0;
        private void DataGridStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridStocks.SelectedRows.Count > 0)
            {
                TextMedNume.SelectedValue = DataGridStocks.SelectedRows[0].Cells[6].Value.ToString();
                textQuantitedepart.Text = DataGridStocks.SelectedRows[0].Cells[1].Value.ToString();
                textquantiteachat.Text = DataGridStocks.SelectedRows[0].Cells[2].Value.ToString();
                textquantiteVente.Text = DataGridStocks.SelectedRows[0].Cells[3].Value.ToString();
                textstocksfinal.Text = DataGridStocks.SelectedRows[0].Cells[4].Value.ToString();
                if (DateTime.TryParse(DataGridStocks.SelectedRows[0].Cells[5].Value?.ToString(), out DateTime dateentre))
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextMedNume_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjouterFacture_Click(object sender, EventArgs e)
        {
            if (textQuantitedepart.Text == "" || textquantiteachat.Text == "" || textquantiteVente.Text == "" || textstocksfinal.Text == "" || TextDateEntre.Text == "" || TextMedNume.SelectedIndex == -1)
            {
                MessageBox.Show("compltez les informations s'il vous plait");
                return;
            }
            else
            {
                string Req = "";
                try
                {
                    conn.Open();

                    Req = "insert into Stocks(QuantiteDepart, DateEntre, MedNume, QuantiteAchat,QuantiteVente, StockFinal) values(" + textQuantitedepart.Text + ",'" + TextDateEntre.Value.Date+ "'," + TextMedNume.SelectedValue +"," + textquantiteachat.Text + "," + textquantiteVente.Text+"," + textstocksfinal.Text+")";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.Parameters.AddWithValue("@QuantiteDepart", textQuantitedepart.Text);
                    cmd.Parameters.AddWithValue("@DateEntre", TextDateEntre.Value.Date);
                    cmd.Parameters.AddWithValue("@MedNume", TextMedNume.SelectedValue);
                    cmd.Parameters.AddWithValue("@QuantiteAchat", textquantiteachat.Text);
                    cmd.Parameters.AddWithValue("@QuantiteVente", textquantiteVente.Text);
                    cmd.Parameters.AddWithValue("StockFinal", textstocksfinal.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stocks Ajouté avec Succes");
                    conn.Close();
                    Afficher();
                    Reinitialiser();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, Req);
                }
            }
        }
    }
}
