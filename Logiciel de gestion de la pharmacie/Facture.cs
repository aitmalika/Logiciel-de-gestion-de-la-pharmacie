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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
            RemplirFacture();
            RemplirFA();
            Afficher();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void RemplirFA()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select MedNum From MedicamentTbl", conn);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MedNum", typeof(int));
            dt.Load(Rdr);
            TextMedNum.ValueMember = "MedNum";
            TextMedNum.DataSource = dt;
            conn.Close();
        }
        private void Reinitialiser()
        {
            TextNumClient.SelectedValue.ToString();
            TextDateFacture.Text = "";
            TextMedNum.SelectedValue.ToString();
            TextDesginationMed.Text = "";
            TextQuantite.Text = "";
            TextHT.Text = "";
            TextTva.Text = "";
            TextTTC.Text = "";
            TextPU.Text = "";
            TextTauxTVA.Text = "";
            Cle = 0;

        }
        private void RemplirFacture()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select NumClient From Clients", conn);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumClient", typeof(int));
            dt.Load(Rdr);
            TextNumClient.ValueMember = "NumClient";
            TextNumClient.DataSource = dt;
            conn.Close();
        }
        public void Afficher()
        {
            //conn.Open();
            string Req = "select * From Facture";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridFacture.AutoGenerateColumns = false;
            DataGridFacture.DataSource = dt;
            //conn.Close();
        }
        private void AjouterFacture_Click(object sender, EventArgs e)
        {
            if (TextNumClient.SelectedIndex == -1 || TextDateFacture.Text == "" || TextMedNum.SelectedIndex == -1 || TextDesginationMed.Text == "" || TextQuantite.Text == "" || TextHT.Text == "" || TextTva.Text == "" || TextTTC.Text == "" || TextPU.Text == "" || TextTauxTVA.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                string Req = "";
                try
                {
                    conn.Open();

                    Req = "insert into Facture(NumClient, DateFacture, MedNum, DesginationMed,Quantite, HT, Tva, TTC, PU, TauxTVA) values(" + TextNumClient.SelectedValue + ",'" + TextDateFacture.Value.Date + "'," + TextMedNum.SelectedValue + ",'" + TextDesginationMed.Text + "'," + TextQuantite.Text + "," + TextHT.Text + "," + TextTva.Text + "," + TextTTC.Text + "," + TextPU.Text + "," + TextTauxTVA.Text + ")";

                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Facture Ajouté avec Succes");
                    Afficher();
                    Reinitialiser();
                    conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, Req);
                }
            }
        }

        private void ModifierFacture_Click(object sender, EventArgs e)
        {
            if (TextNumClient.SelectedIndex == -1 || TextDateFacture.Text == "" || TextMedNum.SelectedIndex == -1 || TextDesginationMed.Text == "" || TextQuantite.Text == "" || TextHT.Text == "" || TextTva.Text == "" || TextTTC.Text == "" || TextPU.Text == "" || TextTauxTVA.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();
                string Req = "UPDATE Facture SET NumClient=@Nom, DateFacture=@DateFacture, MedNum=@Numero, DesginationMed=@Designation,Quantite=@Quantite,HT=@HT,Tva=@Tva,TTC=@TTC,PU=@PU,TauxTVA=@Taux WHERE NumFacture=@Cle;";

                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@Nom", TextNumClient.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DateFacture", TextDateFacture.Text);
                cmd.Parameters.AddWithValue("@Numero", TextMedNum.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Designation", TextDesginationMed.Text);
                cmd.Parameters.AddWithValue("@Quantite", TextQuantite.Text);
                cmd.Parameters.AddWithValue("@HT", TextHT.Text);
                cmd.Parameters.AddWithValue("@Tva", TextTva.Text);
                cmd.Parameters.AddWithValue("@TTC", TextTTC.Text);
                cmd.Parameters.AddWithValue("@PU", TextPU.Text);
                cmd.Parameters.AddWithValue("@Taux", TextTauxTVA.Text);
                cmd.Parameters.AddWithValue("@cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Facture Modifié Avec Succes");
                Afficher();
                Reinitialiser();
                conn.Close();
            }
        }

        private void TauxTVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupprimerFacture_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez la Facture a effacer");
            }
            else
            {
                conn.Open();
                string Req = "delete From Facture where NumFacture=" + Cle + "";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Facture Supprimé avec Succes");
                Afficher();
                Reinitialiser();
                conn.Close();

            }
        }

        private void ReinitialiserFacture_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }
        int Cle = 0;
        private void DataGridFacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridFacture.SelectedRows.Count > 0)
            {

                TextNumClient.SelectedValue = DataGridFacture.SelectedRows[0].Cells[2].Value?.ToString();
                if (DateTime.TryParse(DataGridFacture.SelectedRows[0].Cells[3].Value?.ToString(), out DateTime dateFacture))
                {
                    TextDateFacture.Value = dateFacture;
                }
                else
                {
                    // Gérer le cas où la valeur n'est pas une date valide (peut-être afficher un message d'erreur)
                }
                TextMedNum.SelectedValue = DataGridFacture.SelectedRows[0].Cells[1].Value?.ToString();
                TextDesginationMed.Text = DataGridFacture.SelectedRows[0].Cells[4].Value?.ToString();
                TextQuantite.Text = DataGridFacture.SelectedRows[0].Cells[5].Value?.ToString();
                TextHT.Text = DataGridFacture.SelectedRows[0].Cells[6].Value?.ToString();
                TextTva.Text = DataGridFacture.SelectedRows[0].Cells[7].Value?.ToString();
                TextTTC.Text = DataGridFacture.SelectedRows[0].Cells[8].Value?.ToString();
                TextPU.Text = DataGridFacture.SelectedRows[0].Cells[9].Value?.ToString();
                TextTauxTVA.Text = DataGridFacture.SelectedRows[0].Cells[10].Value?.ToString();


                if (TextNumClient.Text == "")
                    Cle = 0;
                else
                    Cle = Convert.ToInt32(DataGridFacture.SelectedRows[0].Cells[0].Value.ToString());


            }
            else
            {

            }
        }

        private void DateFacture_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Facture_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void TextMedNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
