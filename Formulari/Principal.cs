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
        double distancia_seguretat;
        int temps_cicle;

        public Principal()
        {
            InitializeComponent();
        }

        private void fORMULARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouFlightPlan form = new NouFlightPlan(milista);
            form.ShowDialog();          
            NouFlightPlan form = new NouFlightPlan(milista);
            form.ShowDialog();
            
            
        }
        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D_Seguretat_T_Cicle form = new D_Seguretat_T_Cicle();
            form.ShowDialog();
            distancia_seguretat = form.GetDistanciaSeguretat();
            temps_cicle = form.GetTempsCicle();
            MessageBox.Show("Distancia de seguretat:" + distancia_seguretat);
            MessageBox.Show("Temps de cicle:" + temps_cicle);
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simular form = new Simular();
            form.SetData(milista, temps_cicle, distancia_seguretat);
            form.ShowDialog();
        }
    }
}
