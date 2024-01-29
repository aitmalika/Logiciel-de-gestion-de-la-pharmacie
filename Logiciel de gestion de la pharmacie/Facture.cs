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
            TextTauxTva.Text = "";
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
            conn.Open();
            string Req = "select * From Facture";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridFacture.AutoGenerateColumns = false;
            DataGridFacture.DataSource = dt;
            conn.Close();
        }
        private void AjouterFacture_Click(object sender, EventArgs e)
        {
            if (TextNumClient.SelectedIndex == -1 || TextDateFacture.Text == "" || TextMedNum.SelectedIndex == -1 || TextDesginationMed.Text == "" || TextQuantite.Text == "" || TextHT.Text == "" || TextTva.Text == "" || TextTTC.Text == "" || TextPU.Text == "" || TextTauxTva.Text == "")
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

                    Req = "insert into Facture(NumClient, DateFacture, MedNum, DesginationMed,Quantite, HT, Tva, TTC, PU, TauxTVA) values(" + TextNumClient.SelectedValue + ",'" + TextDateFacture.Value.Date + "'," + TextMedNum.SelectedValue + ",'" + TextDesginationMed.Text + "'," + TextQuantite.Text + "," + TextHT.Text + "," + TextTva.Text + "," + TextTTC.Text + "," + TextPU.Text + "," + TextTauxTva.Text + ")";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.Parameters.AddWithValue("@NumClient", TextNumClient.SelectedValue);
                    cmd.Parameters.AddWithValue("@DateFacture", TextDateFacture.Value.Date);
                    cmd.Parameters.AddWithValue("@MedNum", TextMedNum.SelectedValue);
                    cmd.Parameters.AddWithValue("@DesginationMed", TextDesginationMed.Text);
                    cmd.Parameters.AddWithValue("@Quantite", TextQuantite.Text);
                    cmd.Parameters.AddWithValue("@HT", TextHT.Text);
                    cmd.Parameters.AddWithValue("@Tva", TextTva.Text);
                    cmd.Parameters.AddWithValue("@TTC", TextTTC.Text); // On garde la valeur précédente, peut-être la recalculer ici ?
                    cmd.Parameters.AddWithValue("@PU", TextPU.Text);
                    cmd.Parameters.AddWithValue("@TauxTVA", TextTauxTva.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Facture Ajouté avec Succes");
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

        private void ModifierFacture_Click(object sender, EventArgs e)
        {
            if (TextNumClient.SelectedIndex == -1 || TextDateFacture.Text == "" || TextMedNum.SelectedIndex == -1 || TextDesginationMed.Text == "" || TextQuantite.Text == "" || TextHT.Text == "" || TextTva.Text == "" || TextTTC.Text == "" || TextPU.Text == "" || TextTauxTva.Text == "")
            //if (TextNumClient.SelectedIndex == -1 ||
            //    !decimal.TryParse(TextQuantite.Text, out decimal Quantite) ||
            //    !decimal.TryParse(TextPU.Text, out decimal PU) ||
            //    !decimal.TryParse(TextHT.Text, out decimal HT) ||
            //    !decimal.TryParse(TextTva.Text, out decimal Tva) ||
            //    !decimal.TryParse(TextTauxTva.Text, out decimal TauxTva))
            {
                MessageBox.Show("Information Manquante");
                return;
            }
            //else
            try
            {
                conn.Open();
                //string Req = "UPDATE Facture SET NumClient=@Nom, DateFacture=@DateFacture, MedNum=@Numero, DesginationMed=@Designation,Quantite=@Quantite,HT=@HT,Tva=@Tva,TTC=@TTC,PU=@PU,TauxTVA=@Taux WHERE NumFacture=@Cle;";
                string Req = "UPDATE Facture SET NumClient=@NumClient, DateFacture=@DateFacture, MedNum=@MedNum, DesginationMed=@DesginationMed, Quantite=@Quantite, HT=@HT, Tva=@Tva, TTC=@TTC, PU=@PU, TauxTVA=@TauxTVA WHERE NumFacture=@Cle;";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@NumClient", TextNumClient.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DateFacture", TextDateFacture.Value.Date);
                cmd.Parameters.AddWithValue("@MedNum", TextMedNum.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DesginationMed", TextDesginationMed.Text);
                cmd.Parameters.AddWithValue("@Quantite", TextQuantite.Text);
                cmd.Parameters.AddWithValue("@HT", TextHT.Text);
                cmd.Parameters.AddWithValue("@Tva", TextTva.Text);
                cmd.Parameters.AddWithValue("@TTC", TextTTC.Text); // On garde la valeur précédente, peut-être la recalculer ici ?
                cmd.Parameters.AddWithValue("@PU", TextPU.Text);
                cmd.Parameters.AddWithValue("@TauxTVA", TextTauxTva.Text);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Facture Modifié Avec Succes");
                conn.Close();
                Afficher();
                Reinitialiser();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification de la facture : " + ex.Message);
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
                conn.Close();
                Afficher();
                Reinitialiser();
                

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
                    MessageBox.Show("La date n'est pas valide.", "Erreur de conversion de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TextMedNum.SelectedValue = DataGridFacture.SelectedRows[0].Cells[1].Value?.ToString();
                TextDesginationMed.Text = DataGridFacture.SelectedRows[0].Cells[4].Value?.ToString();
                TextQuantite.Text = DataGridFacture.SelectedRows[0].Cells[5].Value?.ToString();
                TextHT.Text = DataGridFacture.SelectedRows[0].Cells[6].Value?.ToString();
                TextTva.Text = DataGridFacture.SelectedRows[0].Cells[7].Value?.ToString();
                TextTTC.Text = DataGridFacture.SelectedRows[0].Cells[8].Value?.ToString();
                TextPU.Text = DataGridFacture.SelectedRows[0].Cells[9].Value?.ToString();
                TextTauxTva.Text = DataGridFacture.SelectedRows[0].Cells[10].Value?.ToString();


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

        private void TextQuantite_TextChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }

        private void TextPU_TextChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }

        private void TextHT_TextChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }

        private void TextTva_TextChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }

        private void TextTTC_TextChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }

        private void TextTauxTva_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculerTotal();
        }
        private void CalculerTotal()
        {
            try
  
            {
                if (decimal.TryParse(TextQuantite.Text, out decimal Quantite) &&
                    decimal.TryParse(TextPU.Text, out decimal PU) &&
                    decimal.TryParse(TextHT.Text, out decimal HT) &&
                    decimal.TryParse(TextTva.Text, out decimal Tva) &&
                    decimal.TryParse(TextTauxTva.Text, out decimal TauxTva))
                {
                    // Calculs
                    decimal ttc = Quantite * PU;
                    decimal htCalcule = ttc / (1 + TauxTva / 100);
                    decimal tvaCalcule = ttc - htCalcule;

                    // Mise à jour des champs
                    TextHT.Text = htCalcule.ToString("0.00");
                    TextTva.Text = tvaCalcule.ToString("0.00");
                    TextTTC.Text = ttc.ToString("0.00");
                }
               
            }
            catch (FormatException)
            {
                // Gérer le cas où la conversion échoue
            }
        }
    }
}

