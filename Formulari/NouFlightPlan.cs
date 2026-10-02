using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulari
{
    public partial class NouFlightPlan : Form
    {
        private FlightPlanList listaprincipal;
        public NouFlightPlan(FlightPlanList listaqueentra)
        {
            InitializeComponent();
            this.listaprincipal = listaqueentra;
        }

        private int contadorFP = 0;
        private void afegirButton_Click(object sender, EventArgs e)
        {

            if (contadorFP == 2)
            {
                MessageBox.Show("No pots afegir mes de dos flight plans");
                return;
            }

            if (string.IsNullOrWhiteSpace(IDBox.Text) || string.IsNullOrWhiteSpace(pXiBox.Text) || string.IsNullOrWhiteSpace(pYiBox.Text) || string.IsNullOrWhiteSpace(pXfBox.Text) || string.IsNullOrWhiteSpace(pYfBox.Text) || string.IsNullOrWhiteSpace(velocityBox.Text))
            {
                MessageBox.Show("Has d'omplir tots els camps abans d'afegir.");
                return;
            }

            try
            {
                FlightPlan p = new FlightPlan(IDBox.Text, Convert.ToDouble(pXiBox.Text), Convert.ToDouble(pYiBox.Text), Convert.ToDouble(pXfBox.Text), Convert.ToDouble(pYfBox.Text), Convert.ToDouble(velocityBox.Text));
                listaprincipal.AddFlightPlan(p);
                MessageBox.Show("s'ha afegit correctament");
                contadorFP++;

                IDBox.Clear();
                pXiBox.Clear();
                pYiBox.Clear();
                pXfBox.Clear();
                pYfBox.Clear();
                velocityBox.Clear();

            }
            catch (FormatException)
            {
                MessageBox.Show("escriu bé");
            }
        }
    }
}
