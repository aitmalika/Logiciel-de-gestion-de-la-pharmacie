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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void button_inscription_Click(object sender, EventArgs e)
        {
            if (textnomutilisateur.Text == "" || textNomComplet.Text == "" || textMotdepasse.Text == "" || confirmermotdepasse.Text == "")
            {
                MessageBox.Show("Entrer un Nom d'Utilisateur et Mot de Passe");
            }
            else
            {
                try
                {
                    conn.Open();
                    string Req = "insert into Utilisateur values ('" + textnomutilisateur.Text + "','" + textNomComplet.Text + "','" + textMotdepasse.Text + "','" + confirmermotdepasse.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("utilisateur Ajouté avec Succes");
                    //conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                conn.Close();
                connexion connexion = new connexion();
                connexion.Show();
                this.Hide();
            }
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void textMotdepasse_TextChanged(object sender, EventArgs e)
        {
            // Assurez-vous que le contrôle est de type TextBox
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.PasswordChar = '*';
            }
        }

        private void confirmermotdepasse_TextChanged(object sender, EventArgs e)
        {
            // Assurez-vous que le contrôle est de type TextBox
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.PasswordChar = '*';
            }
        }
    }
}
