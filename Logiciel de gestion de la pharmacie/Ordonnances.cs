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
    public partial class Ordonnances : Form
    {
        public Ordonnances()
        {
            InitializeComponent();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            TextNCNSS.Text = "";
            TextNomdupatient.Text = "";
            TextNommedecin.Text = "";
            TextDateOrd.Text = "";
            Cle = 0;

        }
        public void Afficher()
        {
            conn.Open();
            string Req = "select * From Ordonnances";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            SqlCommandBuilder builler = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridOrdonnances.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void AjouterOrdonnance_Click(object sender, EventArgs e)
        {
            if (TextNCNSS.Text == "" || TextNomdupatient.Text == "" || TextNommedecin.Text == "" || TextDateOrd.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "insert into Ordonnances values (" + TextNCNSS.Text + ",'" + TextNomdupatient.Text + "','" + TextNommedecin.Text + "','" + TextDateOrd.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ordonnances Ajouté avec Succes");
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

        private void ModifierOrdonnance_Click(object sender, EventArgs e)
        {
            if (TextNCNSS.Text == "" || TextNomdupatient.Text == "" || TextNommedecin.Text == "" || TextDateOrd.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();

                string Req = "UPDATE Ordonnances SET NCNSS=@NumeroCNSS, Nomdupatient=@Nomdupatient,  Nommedecin=@Nomdumedecin, DateOrd=@DateOrd WHERE NumOrd=@Cle;";

                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@NumeroCNSS", TextNCNSS.Text);
                cmd.Parameters.AddWithValue("@Nomdupatient", TextNomdupatient.Text);
                cmd.Parameters.AddWithValue("@Nomdumedecin", TextNommedecin.Text);
                cmd.Parameters.AddWithValue("@DateOrd", TextDateOrd.Value.Date);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ordonnances Modifié Avec Succes");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void SupprimerOrdonnance_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez le Ordonnances a effacer");
            }
            else
            {
                conn.Open();
                string req = "DELETE FROM Ordonnances WHERE NumOrd = @Cle";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ordonnances Supprimé avec Succès");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void ReinitialiserOrdonnance_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }
        int Cle = 0;
        private void DataGridOrdonnances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridOrdonnances.SelectedRows.Count > 0)
            {
                TextNCNSS.Text = DataGridOrdonnances.SelectedRows[0].Cells[1].Value?.ToString();
                TextNomdupatient.Text = DataGridOrdonnances.SelectedRows[0].Cells[2].Value?.ToString();
                TextNommedecin.Text = DataGridOrdonnances.SelectedRows[0].Cells[3].Value?.ToString();
                if (DateTime.TryParse(DataGridOrdonnances.SelectedRows[0].Cells[4].Value?.ToString(), out DateTime dateOrd))
                {
                    TextDateOrd.Value = dateOrd;
                }
                else
                {
                    // Gérer le cas où la valeur n'est pas une date valide (peut-être afficher un message d'erreur)
                }
                if (TextNCNSS.Text == "")
                    Cle = 0;
                else
                    Cle = Convert.ToInt32(DataGridOrdonnances.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void TextNomdupatient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
