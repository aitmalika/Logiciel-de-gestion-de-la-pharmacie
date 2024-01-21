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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C172PTE;Initial Catalog=Gestion_pharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
          

        }
        private void Affichierstocks_Click(object sender, EventArgs e)
        {
           
        }

        private void Reinitialiserstocks_Click(object sender, EventArgs e)
        {
            
        }
        
        private void DataGridStatistique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Statistique_Load(object sender, EventArgs e)
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
