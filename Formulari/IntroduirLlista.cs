using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Formulari
{
    public partial class IntroduirLlista : Form
    {
        FlightPlanList milista;
        public IntroduirLlista(FlightPlanList milista)
        {
            InitializeComponent();
            this.milista = milista;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcceptar_Click(object sender, EventArgs e)
        {
            List<FlightPlan> nova = milista.leerFichero(textBoxNomFitxer.Text);
            if (nova==null)
            {
                MessageBox.Show("Error al leer el fichero");
            }
            else
            {
                int k = 0;
                while (k < nova.Count)
                {
                    milista.AddFlightPlan(nova[k]);
                    k++;
                }
                MessageBox.Show("Se han añadido " + k + " planes de vuelo a la lista");
                Close();
            }
        }
    }
}
