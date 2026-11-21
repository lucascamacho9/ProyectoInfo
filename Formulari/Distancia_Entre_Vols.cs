using FlightLib;
using System;
using System.Collections;
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
        FlightPlan seleccionat;
        FlightPlanList miLista;
        public Distancia_Entre_Vols()
        {
            InitializeComponent();
        }

        public void setFlightPlans(FlightPlan a, FlightPlanList llista)
        {
            this.seleccionat = a;
            this.miLista = llista;
        }

        private void buttonTancar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Distancia_Entre_Vols_Load(object sender, EventArgs e)
        {
            int numero = miLista.GetNumber();
            if (numero == 0)
            {
                MessageBox.Show("la llista està buida");
            }
            else
            {
                distanciaGridView.RowCount = miLista.GetNumber();
                distanciaGridView.ColumnCount = 2;
                distanciaGridView.Columns[0].HeaderText = "ID";
                distanciaGridView.Columns[1].HeaderText = "distància";
                for (int i = 0; i < miLista.GetNumber(); i++)
                {   FlightPlan altre = miLista.GetFlightPlan(i);
                    distanciaGridView.Rows[i].Cells[0].Value = altre.GetID();
                    distanciaGridView.Rows[i].Cells[1].Value = seleccionat.Distance(altre).ToString("F2"); ;
                }
            }
        }
    }
}
