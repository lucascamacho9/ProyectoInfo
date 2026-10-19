using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulari
{
    public partial class NouFlightPlan : Form
    {
        private int MAX_FLIGHT_PLANS = 2;
        private FlightPlanList listaprincipal;
        public NouFlightPlan(FlightPlanList listaqueentra)
        {
            InitializeComponent();
            this.listaprincipal = listaqueentra;
        }
        private int countFP = 0;
        private void afegirButton_Click(object sender, EventArgs e)
        {

            if (countFP==2)
            {
                MessageBox.Show("No pots afegir mes de dos flight plans");
                return;
            }

            if (IDBox.Text== null || pXiBox.Text == null || pYiBox.Text == null || string.IsNullOrWhiteSpace(pXfBox.Text) || string.IsNullOrWhiteSpace(pYfBox.Text) || string.IsNullOrWhiteSpace(velocityBox.Text))
            {
                MessageBox.Show("Has d'omplir tots els camps abans d'afegir.");
                return;
            }

            for (int i = 0; i < listaprincipal.GetNumber(); i++)
            {
                if (listaprincipal.GetFlightPlan(i).GetID() == IDBox.Text)
                {
                    MessageBox.Show("Ja existeix un flight plan amb aquest ID");
                    return;
                }
            }

            try
            {
                FlightPlan p = new FlightPlan(IDBox.Text, Convert.ToDouble(pXiBox.Text), Convert.ToDouble(pYiBox.Text), Convert.ToDouble(pXfBox.Text), Convert.ToDouble(pYfBox.Text), Convert.ToDouble(velocityBox.Text));
                listaprincipal.AddFlightPlan(p);
                MessageBox.Show("s'ha afegit correctament");
                MAX_FLIGHT_PLANS++;
                countFP++;

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

        private void buttonTancar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFP1_Click(object sender, EventArgs e)
        {
            IDBox.Text = "FP1";
            pXiBox.Text = "1";
            pYiBox.Text = "1";
            pXfBox.Text = "100";
            pYfBox.Text = "100";
            velocityBox.Text = "50";
        }

        private void buttonFP2_Click(object sender, EventArgs e)
        {
            IDBox.Text = "FP2";
            pXiBox.Text = "1";
            pYiBox.Text = "100";
            pXfBox.Text = "100";
            pYfBox.Text = "1";
            velocityBox.Text = "50";
        }
    }
}