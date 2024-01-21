using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class Medicaments : Form
    {
        public Medicaments()
        {
            InitializeComponent();
            RemplirFab();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void RemplirFab()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select FabNum From FabricantTbl", conn);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FabNum", typeof(int));
            dt.Load(Rdr);
            FabricantMedicament.ValueMember = "FabNum";
            FabricantMedicament.DataSource = dt;
            conn.Close();
        }
        private void Reinitialiser()
        {
            NomMedicament.Text = "";
            PrixAchatMedicament.Text = "";
            QuantiteDisponibleMedicament.Text = "";
            QuantiteMinimaleMedicament.Text = "";
            DateExpirationMedicament.Text = "";
            DesignationMedicament.Text = "";
            UtilisationsMedicament.Text = "";
            ContreIndicationMedicament.Text = "";
            EffetsSecondairesMedicament.Text = "";
            TauxDePriseEnChargeMedicament.Text = "";
            CodeABarresMedicament.Text = "";
            FabricantMedicament.SelectedValue.ToString();
            MedPrixV.Text = "";
            MedPhoto.Text = "";
            Cle = 0;

        }
        public void Afficher()
        {
            //conn.Open();
            string Req = "select * From MedicamentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DgvMedicament.AutoGenerateColumns = false;
            DgvMedicament.DataSource = dt;
            //conn.Close();
        }
        private void Medicaments_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FABRICANTS fabricants = new FABRICANTS();
            fabricants.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Statistique statistique = new Statistique();
            statistique.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ModifierMedicamaent_Click(object sender, EventArgs e)
        {
            if (NomMedicament.Text == "" || PrixAchatMedicament.Text == "" || QuantiteDisponibleMedicament.Text == "" || FabricantMedicament.SelectedIndex == -1 || QuantiteMinimaleMedicament.Text == "" || DateExpirationMedicament.Text == "" || DesignationMedicament.Text == "" || UtilisationsMedicament.Text == "" || ContreIndicationMedicament.Text == "" || EffetsSecondairesMedicament.Text == "" || TauxDePriseEnChargeMedicament.Text == "" || CodeABarresMedicament.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();
                string Req = "UPDATE MedicamentTbl SET MedNom=@Nom, MedPrixA=@PrixAchat, MedQteM=@QuantiteMinimale, MedExp=@DateExpiration, MedDesig=@Designation, MedQteD=@QuantiteDisponible, MedUtili=@Utilisations, MedContInd=@ContreIndication, MedEffet=@EffetsSecondaires, MedTpc=@TauxDePriseEnCharge, MedCodBa=@CodeABarres, IdFabrican=@Fabricant WHERE MedNum=@Cle";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@Nom", NomMedicament.Text);
                cmd.Parameters.AddWithValue("@PrixAchat", PrixAchatMedicament.Text);
                cmd.Parameters.AddWithValue("@QuantiteMinimale", QuantiteMinimaleMedicament.Text);
                cmd.Parameters.AddWithValue("@DateExpiration", DateExpirationMedicament.Value.Date);
                cmd.Parameters.AddWithValue("@Designation", DesignationMedicament.Text);
                cmd.Parameters.AddWithValue("@QuantiteDisponible", QuantiteDisponibleMedicament.Text);
                cmd.Parameters.AddWithValue("@Utilisations", UtilisationsMedicament.Text);
                cmd.Parameters.AddWithValue("@ContreIndication", ContreIndicationMedicament.Text);
                cmd.Parameters.AddWithValue("@EffetsSecondaires", EffetsSecondairesMedicament.Text);
                cmd.Parameters.AddWithValue("@TauxDePriseEnCharge", TauxDePriseEnChargeMedicament.Text);
                cmd.Parameters.AddWithValue("@CodeABarres", CodeABarresMedicament.Text);
                cmd.Parameters.AddWithValue("@Fabricant", FabricantMedicament.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicament Modifié Avec Succes");
                Afficher();
                Reinitialiser();
                conn.Close();
                //try
                //{


                //}
                //catch (Exception Ex)
                //{
                //    MessageBox.Show(Ex.Message);
                //}
                //finally
                //{
                //    conn.Close();
                //}
            }
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez le Medicament a effacer");
            }
            else
            {
                conn.Open();
                string Req = "delete From MedicamentTbl where MedNum=" + Cle + "";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicament Supprimé avec Succes");
                Afficher();
                Reinitialiser();
                conn.Close();

                //try
                //{

                //}
                //catch (Exception Ex)
                //{
                //    MessageBox.Show(Ex.Message);
                //}
            }
        }




        private void AjouterMedicament_Click(object sender, EventArgs e)
        {
            if (NomMedicament.Text == "" || PrixAchatMedicament.Text == "" || QuantiteDisponibleMedicament.Text == "" || FabricantMedicament.SelectedIndex == -1 || QuantiteMinimaleMedicament.Text == "" || DateExpirationMedicament.Text == "" || DesignationMedicament.Text == "" || UtilisationsMedicament.Text == "" || ContreIndicationMedicament.Text == "" || EffetsSecondairesMedicament.Text == "" || TauxDePriseEnChargeMedicament.Text == "" || CodeABarresMedicament.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                string Req = "";
                try
                {
                    conn.Open();

                    Req = "insert into MedicamentTbl(MedNom, MedPrixA, MedQteM, MedExp,MedDesig, MedQteD, MedUtili, MedContInd, MedEffet, MedTpc, MedCodBa, IdFabrican) values('" + NomMedicament.Text + "'," + PrixAchatMedicament.Text + "," + QuantiteMinimaleMedicament.Text + ",'" + DateExpirationMedicament.Value.Date + "','" + DesignationMedicament.Text + "'," + QuantiteDisponibleMedicament.Text + ",'" + UtilisationsMedicament.Text + "','" + ContreIndicationMedicament.Text + "','" + EffetsSecondairesMedicament.Text + "'," + TauxDePriseEnChargeMedicament.Text + "," + CodeABarresMedicament.Text + "," + FabricantMedicament.SelectedValue + ")";

                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicament Ajouté avec Succes");
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

        private void FabricantMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int Cle = 0;

        private void DgvMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMedicament.SelectedRows.Count > 0)
            {

                NomMedicament.Text = DgvMedicament.SelectedRows[0].Cells[1].Value?.ToString();
                PrixAchatMedicament.Text = DgvMedicament.SelectedRows[0].Cells[2].Value?.ToString();
                QuantiteMinimaleMedicament.Text = DgvMedicament.SelectedRows[0].Cells[3].Value?.ToString();

                if (DateTime.TryParse(DgvMedicament.SelectedRows[0].Cells[4].Value?.ToString(), out DateTime dateExpiration))
                {
                    DateExpirationMedicament.Value = dateExpiration;
                }
                else
                {
                    // Gérer le cas où la valeur n'est pas une date valide (peut-être afficher un message d'erreur)
                }
                DesignationMedicament.Text = DgvMedicament.SelectedRows[0].Cells[5].Value?.ToString();
                QuantiteDisponibleMedicament.Text = DgvMedicament.SelectedRows[0].Cells[6].Value?.ToString();
                UtilisationsMedicament.Text = DgvMedicament.SelectedRows[0].Cells[7].Value?.ToString();
                ContreIndicationMedicament.Text = DgvMedicament.SelectedRows[0].Cells[8].Value?.ToString();
                EffetsSecondairesMedicament.Text = DgvMedicament.SelectedRows[0].Cells[9].Value?.ToString();
                TauxDePriseEnChargeMedicament.Text = DgvMedicament.SelectedRows[0].Cells[10].Value?.ToString();
                CodeABarresMedicament.Text = DgvMedicament.SelectedRows[0].Cells[11].Value?.ToString();
                FabricantMedicament.SelectedValue = DgvMedicament.SelectedRows[0].Cells[12].Value?.ToString();
                //MedPrixV.Text = DgvMedicament.SelectedRows[0].Cells[13].Value.ToString();
                //MedPhoto.Text = DgvMedicament.SelectedRows[0].Cells[15].Value.ToString();

                if (NomMedicament.Text == "")
                    Cle = 0;
                else
                    Cle = Convert.ToInt32(DgvMedicament.SelectedRows[0].Cells[0].Value.ToString());


            }
            else
            {

            }

        }

        private void NomMedicament_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateExpirationMedicament_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PrixAchatMedicament_TextChanged(object sender, EventArgs e)
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
