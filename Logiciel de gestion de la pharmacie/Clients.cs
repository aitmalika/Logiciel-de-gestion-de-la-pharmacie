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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            Afficher();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            TextNomClient.Text = "";
            TextTeleClient.Text = "";
            TextIFClient.Text = "";
            TextICEClient.Text = "";
            TextAdresseClient.Text = "";
            Cle = 0;

        }
        public void Afficher()
        {
            conn.Open();
            string Req = "select * From Clients";
            SqlDataAdapter sda = new SqlDataAdapter(Req, conn);
            SqlCommandBuilder builler = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridClient.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void AdresseClients_Click(object sender, EventArgs e)
        {

        }

        private void AjouterClient_Click(object sender, EventArgs e)
        {
            if (TextNomClient.Text == "" || TextTeleClient.Text == "" || TextIFClient.Text == "" || TextICEClient.Text == "" || TextAdresseClient.Text == "")
            {
                MessageBox.Show("compltez le client s'il vous plait");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "insert into Clients values (@Nom, @Telephone, @IF, @ICE, @Adresse)";
                    //string Req = "insert into Clients values ('" + TextNomClient.Text + "','" + TextTeleClient.Text + "'," + TextIFClient.Text + "," + TextICEClient.Text + ",'" + TextAdresseClient.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.Parameters.AddWithValue("@Nom", TextNomClient.Text);
                    cmd.Parameters.AddWithValue("@Telephone", TextTeleClient.Text);
                    cmd.Parameters.AddWithValue("@IF", TextIFClient.Text);
                    cmd.Parameters.AddWithValue("@ICE", TextICEClient.Text);
                    cmd.Parameters.AddWithValue("@Adresse", TextAdresseClient.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clients Ajouté avec Succes");
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

        private void ModifierClient_Click(object sender, EventArgs e)
        {
            if (TextNomClient.Text == "" || TextTeleClient.Text == "" || TextIFClient.Text == "" || TextICEClient.Text == "" || TextAdresseClient.Text == "")
            {
                MessageBox.Show("Information Manquante");
            }
            else
            {
                conn.Open();
                string Req = "UPDATE Clients SET NomClient=@Nom, TeleClient=@Telephone, IFClient=@IF, ICEClient=@ICE,AdresseClient=@Adresse WHERE NumClient=@Cle;";
                SqlCommand cmd = new SqlCommand(Req, conn);
                cmd.Parameters.AddWithValue("@Nom", TextNomClient.Text);
                cmd.Parameters.AddWithValue("@Telephone", TextTeleClient.Text);
                cmd.Parameters.AddWithValue("@IF", TextIFClient.Text);
                cmd.Parameters.AddWithValue("@ICE", TextICEClient.Text);
                cmd.Parameters.AddWithValue("@Adresse", TextAdresseClient.Text);
                cmd.Parameters.AddWithValue("@cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clients Modifié Avec Succes");
                conn.Close();
                Afficher();
                Reinitialiser();
                
            }
        }

        private void SupprimerClient_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Selectionnez le Client a effacer");
            }
            else
            {
                conn.Open();
                string req = "DELETE FROM Clients WHERE NumClient = @Cle";
                SqlCommand cmd = new SqlCommand(req, conn);
                cmd.Parameters.AddWithValue("@Cle", Cle);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clients Supprimé avec Succès");
                conn.Close();
                Afficher();
                Reinitialiser();
            }
        }

        private void ReinitialiserClient_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }
        int Cle = 0;
        private void DataGridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextNomClient.Text = DataGridClient.SelectedRows[0].Cells[1].Value.ToString();
            TextTeleClient.Text = DataGridClient.SelectedRows[0].Cells[2].Value.ToString();
            TextIFClient.Text = DataGridClient.SelectedRows[0].Cells[3].Value.ToString();
            TextICEClient.Text = DataGridClient.SelectedRows[0].Cells[4].Value.ToString();
            TextAdresseClient.Text = DataGridClient.SelectedRows[0].Cells[5].Value.ToString();
            if (TextNomClient.Text == "")
                Cle = 0;
            else
                Cle = Convert.ToInt32(DataGridClient.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void TextAdresseClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
