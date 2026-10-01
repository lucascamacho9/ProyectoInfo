using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Formulari
{
    public partial class Principal : Form
    {
        FlightPlanList milista = new FlightPlanList();

        public Principal()
        {
            InitializeComponent();
        }

        private void fORMULARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouFlightPlan form = new NouFlightPlan();
            form.ShowDialog();
            FlightPlan p = form.GetFlightPlan();
            milista.AddFlightPlan(p);
            
        }
    }
}
