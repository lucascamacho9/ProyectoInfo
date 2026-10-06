using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Formulari
{
    public partial class Dades : Form
    {
        FlightPlanList miLista = new FlightPlanList();

        public Dades()
        {
            InitializeComponent();
        }

        public void TomaLista(FlightPlanList llista)
        {
            this.miLista = llista;
        }
        private void Dades_Load(object sender, EventArgs e)
        {
            int numero = miLista.GetNumber();
            if (numero == 0)
            {
                MessageBox.Show("la llista està buida");
            }
            else
            {
                avionsView.RowCount = miLista.GetNumber();
                avionsView.ColumnCount = 4;
                avionsView.Columns[0].HeaderText = "ID";
                avionsView.Columns[1].HeaderText = "Current Position X";
                avionsView.Columns[2].HeaderText = "Current Position Y";
                avionsView.Columns[3].HeaderText = "Velocidad";

                for (int i = 0; i < miLista.GetNumber(); i++)
                {
                    avionsView.Rows[i].Cells[0].Value = miLista.GetFlightPlan(i).GetID();
                    avionsView.Rows[i].Cells[1].Value = miLista.GetFlightPlan(i).GetCurrentPosition().GetX().ToString("F2");
                    avionsView.Rows[i].Cells[2].Value = miLista.GetFlightPlan(i).GetCurrentPosition().GetY().ToString("F2");
                    avionsView.Rows[i].Cells[3].Value = miLista.GetFlightPlan(i).GetVelocidad().ToString("F2");
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void avionsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FlightPlan seleccionat = miLista.GetFlightPlan(e.RowIndex);
            if (seleccionat == null)
            {
                MessageBox.Show("No s'ha seleccionat cap vol correctament");
                return;
            }
            else
            {
                FlightPlan altre = miLista.GetFlightPlan(1 - e.RowIndex);
                Distancia_Entre_Vols form = new Distancia_Entre_Vols();
                //// FALTA ALGO PERQUÈ FUNCIONI
                form.ShowDialog();
            }
        }
    }
}
