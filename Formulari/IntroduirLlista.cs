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
            string nomFitxer = textBoxNomFitxer.Text;
            FlightPlanList nova = new FlightPlanList();
            StreamReader R = new StreamReader(nomFitxer);
            int i = 0;
            try
            {
                string linia = R.ReadLine();
                while (linia != null)
                {
                    string[] parts = linia.Split(' ');
                    string id = parts[0];
                    string company = parts[1];
                    double cpx = Convert.ToDouble(parts[2]);
                    double cpy = Convert.ToDouble(parts[3]);
                    double fpx = Convert.ToDouble(parts[4]);
                    double fpy = Convert.ToDouble(parts[5]);
                    double velocidad = Convert.ToDouble(parts[6]);
                    FlightPlan flightPlan = new FlightPlan (id, company, cpx, cpy, fpx, fpy, velocidad);
                    nova.AddFlightPlan(flightPlan);
                    i = i + 1;
                    linia = R.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No s'ha trobat el fitxer");
            }
            catch (FormatException)
            {
                MessageBox.Show("El fitxer no té el format correcte");
            }
    
            R.Close();
        }
    }
}
