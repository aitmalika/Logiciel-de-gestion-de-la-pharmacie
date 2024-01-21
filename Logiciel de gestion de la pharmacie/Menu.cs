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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Paramétrage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fournisseurs Fournisseurs = new Fournisseurs();
            Fournisseurs.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Agents Agents = new Agents();
            Agents.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FABRICANTS fabricants = new FABRICANTS();
            fabricants.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SituationStocks stocks = new SituationStocks();
            stocks.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistique Statistique = new Statistique();
            Statistique.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Ordonnances Ordonnances = new Ordonnances();
            Ordonnances.Show();
            this.Hide();
        }
    }
}