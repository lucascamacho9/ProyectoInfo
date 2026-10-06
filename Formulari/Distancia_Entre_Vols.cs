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
    public partial class Distancia_Entre_Vols : Form
    {
        
        public Distancia_Entre_Vols()
        {
            InitializeComponent();

        }

        public void setFlightPlans(FlightPlan a, FlightPlan b)
        {
            distanciaBox.Text = a.Distance(b).ToString("F2");
        }

        private void buttonTancar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
