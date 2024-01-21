using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class FABRICANTS : Form
    {
        public FABRICANTS()
        {
            InitializeComponent();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            Nomfabriant.Text = "";
            AdresseFabicant.Text = "";
            DescriptionFabicant.Text = "";
            TelephoneFabricant.Text = "";
            Cle = 0;

        }
        public void Afficher()
        {
            conn.Open();
            string Req = "select * From FabricantTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            SqlCommandBuilder builler = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListeDesFabricants.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void FABRICANTS_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Nomfabriant.Text == "" || AdresseFabicant.Text == "" || DescriptionFabicant.Text == "" || TelephoneFabricant.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "insert into FabricantTbl values ('" + Nomfabriant.Text + "','" + AdresseFabicant.Text + "','" + DescriptionFabicant.Text + "','" + TelephoneFabricant.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Ajouté avec Succes");
                    conn.Close();
                    Afficher();
                    Reinitialiser();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ReinitialiserFabricant_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }
        int Cle = 0;
        private void ListeDesFabricants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nomfabriant.Text = ListeDesFabricants.SelectedRows[0].Cells[1].Value.ToString();
            AdresseFabicant.Text = ListeDesFabricants.SelectedRows[0].Cells[2].Value.ToString();
            DescriptionFabicant.Text = ListeDesFabricants.SelectedRows[0].Cells[3].Value.ToString();
            TelephoneFabricant.Text = ListeDesFabricants.SelectedRows[0].Cells[4].Value.ToString();
            if (Nomfabriant.Text == "")
                Cle = 0;
            else
                Cle = Convert.ToInt32(ListeDesFabricants.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void SupprimerFabricant_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez le fabricant a effacer");
            }
            else
            {
                conn.Open();
                string req = "DELETE FROM FabricantTbl WHERE FabNum = @Cle";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fabricant Supprimé avec Succès");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void ModifierFabricant_Click(object sender, EventArgs e)
        {
            if (Nomfabriant.Text == "" || AdresseFabicant.Text == "" || DescriptionFabicant.Text == "" || TelephoneFabricant.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();
                string Req = "UPDATE FabricantTbl SET FabNom=@Nom, FabAdres=@Adresse, FabDescription=@Description, FabTel=@Telephone WHERE FabNum=@Cle;";

                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@Nom", Nomfabriant.Text);
                cmd.Parameters.AddWithValue("@Adresse", AdresseFabicant.Text);
                cmd.Parameters.AddWithValue("@Description", DescriptionFabicant.Text);
                cmd.Parameters.AddWithValue("@Telephone", TelephoneFabricant.Text);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fabricant Modifié Avec Succes");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void TextMedicamant_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomfabriant_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNomFabicant_Click(object sender, EventArgs e)
        {

        }

        private void TextAdresseFabicant_Click(object sender, EventArgs e)
        {

        }

        private void AdresseFabicant_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextDescriptionFabricant_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void TextFacture_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
            this.Hide();
        }

        private void TextTableauDeBord_Click(object sender, EventArgs e)
        {
            Statistique statistique = new Statistique();
            statistique.Show();
            this.Hide();
        }
    }
}
