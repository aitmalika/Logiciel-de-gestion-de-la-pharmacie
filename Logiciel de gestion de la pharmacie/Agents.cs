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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            NomAgent.Text = "";
            DateNaissanceAgent.Text = "";
            TelephoneAgent.Text = "";
            GenreAgent.SelectedIndex = -1;
            MotDePasseAgent.Text = "";
            Cle = 0;

        }
        public void Afficher()
        {
            //conn.Open();
          
            string Req = "select * From AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AgentDgv.AutoGenerateColumns = false;
            AgentDgv.DataSource = dt;
            //conn.Close();
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void AjouterAgents_Click(object sender, EventArgs e)
        {
            if (NomAgent.Text == "" || DateNaissanceAgent.Text == "" || TelephoneAgent.Text == "" || GenreAgent.SelectedIndex == -1 || MotDePasseAgent.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                
                try
                {
                    conn.Open();
                    string req = "INSERT INTO AgentTbl (AgNom, AgADN, AgTel, AgSex, AgPass) VALUES (@NomAgent, @DateNaissanceAgent, @TelephoneAgent, @GenreAgent, @MotDePasseAgent)";
                    SqlCommand cmd = new SqlCommand(req, conn);
                    cmd.Parameters.AddWithValue("@NomAgent", NomAgent.Text);
                    cmd.Parameters.AddWithValue("@DateNaissanceAgent", DateNaissanceAgent.Value.Date);
                    cmd.Parameters.AddWithValue("@TelephoneAgent", TelephoneAgent.Text);
                    cmd.Parameters.AddWithValue("@GenreAgent", GenreAgent.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MotDePasseAgent", MotDePasseAgent.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Ajouté avec Succes");
                    Afficher();
                    Reinitialiser();
                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Cle = 0;
        private void AgentDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AgentDgv.SelectedRows.Count > 0)
            {
                NomAgent.Text = AgentDgv.SelectedRows[0].Cells[1].Value.ToString();
                if (DateTime.TryParse(AgentDgv.SelectedRows[0].Cells[2].Value?.ToString(), out DateTime datenaissance))
                {
                    DateNaissanceAgent.Value = datenaissance;
                }
                else
                {
                    // Gérer le cas où la valeur n'est pas une date valide (peut-être afficher un message d'erreur)
                }
                TelephoneAgent.Text = AgentDgv.SelectedRows[0].Cells[3].Value.ToString();
                GenreAgent.SelectedItem = AgentDgv.SelectedRows[0].Cells[4].Value.ToString();
                MotDePasseAgent.Text = AgentDgv.SelectedRows[0].Cells[5].Value.ToString();
                if (NomAgent.Text == "")
                    Cle = 0;
                else
                    Cle = Convert.ToInt32(AgentDgv.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {

            }

        }

        private void ReinitialiserAgents_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        private void SupprimerAgents_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez l'agent a Supprimer");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "delete From AgentTbl where AgNum=" + Cle + "";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Supprimé avec Succes");
                    Afficher();
                    Reinitialiser();
                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ModifierAgents_Click(object sender, EventArgs e)
        {
            if (NomAgent.Text == "" || DateNaissanceAgent.Text == "" || GenreAgent.SelectedIndex == -1 || TelephoneAgent.Text == "" || MotDePasseAgent.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "update AgentTbl Set AgNom='" + NomAgent.Text + "',AgADN='" + DateNaissanceAgent.Value.Date + "',AgTel='" + TelephoneAgent.Text + "',AgSex='" + GenreAgent.SelectedItem.ToString() + "',AgPass='" + MotDePasseAgent.Text + "'where AgNum=" + Cle + ";";

                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Modifié Avec Succes");
                    Afficher();
                    Reinitialiser();
                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void MotDePasseAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agents_Load(object sender, EventArgs e)
        {

        }
    }
}
