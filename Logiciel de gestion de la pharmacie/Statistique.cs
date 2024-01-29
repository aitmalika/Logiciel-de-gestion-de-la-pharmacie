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
using System.Windows.Forms.DataVisualization.Charting;


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

        private void label1_Click(object sender, EventArgs e)
        {
        }
       

        private DataTable GetDonneesDeStatistiques()
        {
            // Remplacez cette méthode par une logique pour récupérer les données de votre base de données
            DataTable table = new DataTable();
            table.Columns.Add("Medicament", typeof(string));
            table.Columns.Add("TotalStocks", typeof(int));
            table.Columns.Add("MoyenneVente", typeof(double));
            table.Columns.Add("TotalVente", typeof(int));
            table.Columns.Add("TotalMedicament", typeof(int));

            // Exemple de données
            table.Rows.Add("MedicamentA", 100, 25.5, 150, 50);
            table.Rows.Add("MedicamentB", 80, 20.0, 100, 30);
            // Ajoutez vos données ici

            return table;
        }
        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
