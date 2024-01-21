using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_gestion_de_la_pharmacie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int pointdepar = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pointdepar += 1;
            BardeProgression.Value = pointdepar;
            Pourcentage.Text = pointdepar + "%";
            if (BardeProgression.Value == 100)
            {
                BardeProgression.Value = 0;
                timer1.Stop();
                Form1 conc = new Form1();
                conc.Show();
                this.Hide();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BardeProgression_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pourecentage_Click(object sender, EventArgs e)
        {

        }
    }
}
