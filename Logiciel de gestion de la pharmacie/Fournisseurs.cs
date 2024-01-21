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
    public partial class Fournisseurs : Form
    {
        public Fournisseurs()
        {
            InitializeComponent();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        public void Afficher()
        {
            conn.Open();
            string Req = "select * From Fournisseurs";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            SqlCommandBuilder builler = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridFournisseurs.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void Reinitialiser()
        {
            ComboboxNomFRs.Text = "";
            ComboboxTeleFRs.Text = "";
            ComboboxIFFRs.Text = "";
            ComboboxICEFRs.Text = "";
            ComboboxAdresseFRs.Text = "";
            Cle = 0;

        }
        private void AjouterFRs_Click(object sender, EventArgs e)
        {
            if (ComboboxNomFRs.Text == "" || ComboboxTeleFRs.Text == "" || ComboboxIFFRs.Text == "" || ComboboxICEFRs.Text == "" || ComboboxAdresseFRs.Text == "")
            {
                MessageBox.Show("compltez les informations s'il vous plait");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "insert into Fournisseurs values ('" + ComboboxNomFRs.Text + "','" + ComboboxTeleFRs.Text + "'," + ComboboxIFFRs.Text + "," + ComboboxICEFRs.Text + ",'" + ComboboxAdresseFRs.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fournisseurs Ajouté avec Succes");
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

        private void ModifierFRs_Click(object sender, EventArgs e)
        {
            if (ComboboxNomFRs.Text == "" || ComboboxTeleFRs.Text == "" || ComboboxIFFRs.Text == "" || ComboboxICEFRs.Text == "" || ComboboxAdresseFRs.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();
                string Req = "UPDATE Fournisseurs SET NomFRs=@Nom, TeleFRs=@Telephone, IFFRs=@IF, ICEFRs=@ICE,AdresseFRs=@Adresse WHERE NumFRs=@Cle;";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@Nom", ComboboxNomFRs.Text);
                cmd.Parameters.AddWithValue("@Telephone", ComboboxTeleFRs.Text);
                cmd.Parameters.AddWithValue("@IF", ComboboxIFFRs.Text);
                cmd.Parameters.AddWithValue("@ICE", ComboboxICEFRs.Text);
                cmd.Parameters.AddWithValue("@Adresse", ComboboxAdresseFRs.Text);
                cmd.Parameters.AddWithValue("@cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseurs Modifié Avec Succes");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void SupprimerFRs_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez le fournisseurs a effacer");
            }
            else
            {
                conn.Open();
                string req = "DELETE FROM Fournisseurs WHERE NumFRs = @Cle";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseurs Supprimé avec Succès");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void ReinitialiserFRs_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }
        int Cle = 0;
        private void DataGridFournisseurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboboxNomFRs.Text = DataGridFournisseurs.SelectedRows[0].Cells[1].Value.ToString();
            ComboboxTeleFRs.Text = DataGridFournisseurs.SelectedRows[0].Cells[2].Value.ToString();
            ComboboxIFFRs.Text = DataGridFournisseurs.SelectedRows[0].Cells[3].Value.ToString();
            ComboboxICEFRs.Text = DataGridFournisseurs.SelectedRows[0].Cells[4].Value.ToString();
            ComboboxAdresseFRs.Text = DataGridFournisseurs.SelectedRows[0].Cells[5].Value.ToString();
            if (ComboboxNomFRs.Text == "")
                Cle = 0;
            else
                Cle = Convert.ToInt32(DataGridFournisseurs.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Fournisseurs_Load(object sender, EventArgs e)
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
