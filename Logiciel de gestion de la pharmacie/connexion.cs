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
using System.Diagnostics.Eventing.Reader;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            if (textnomutilisateur.Text == "" || textmotdepasse.Text == "")
            {
                MessageBox.Show("Entrer un Nom d'Utilisateur et Mot de Passe");
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Utilisateur Where userName='" + textnomutilisateur.Text + "' And mot_De_Passe ='" + textmotdepasse.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Console.WriteLine(dt.Rows[0][0].ToString());
                if (dt.Rows.Count > 0)
                {

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Mot de Pass Incorrect");
                }
                conn.Close();

            }


            //    string NomUtilisateur, user_MotDePasse;
            //    NomUtilisateur = textnomutilisateur.Text;
            //    user_MotDePasse = textmotdepasse.Text;
            //    try
            //    {
            //        string query = "select * from Utilisateur Where userName='" + textnomutilisateur.Text + "' And mot_De_Passe ='" + textmotdepasse.Text + "'";
            //        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //        DataTable dtable = new DataTable();
            //        sda.Fill(dtable);

            //        if (dtable.Rows.Count > 0)
            //        {
            //            NomUtilisateur = textnomutilisateur.Text;
            //            user_MotDePasse = textmotdepasse.Text;
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Nom d'utilisateur incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            textnomutilisateur.Clear();
            //            textmotdepasse.Clear();
            //            //to focus username
            //            textnomutilisateur.Focus();
            //        }

            //    }
            //    catch
            //    {
            //        MessageBox.Show("Erreur");
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
        }
        private void textmotdepasse_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textmotdepasse_TextChanged_1(object sender, EventArgs e)
        {
            // Assurez-vous que le contrôle est de type TextBox
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.PasswordChar = '*';
            }
        }

        private void textnomutilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
