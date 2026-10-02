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
    public partial class D_Seguretat_T_Cicle : Form
    {
        double distancia_seguretat;
        int temps_cicle;
        public D_Seguretat_T_Cicle()
        {
            InitializeComponent();
        }

        private void afegir_seg_tem_button_Click(object sender, EventArgs e)
        {
            try
            {
                distancia_seguretat = Convert.ToDouble(seguretatBox.Text);
                temps_cicle = Convert.ToInt32(cicleBox.Text);
                MessageBox.Show("distància de seguretat i temps de cicle correctes");
            }
            catch (FormatException)
            {
                MessageBox.Show("escriu bé");
            }
            Close();
        }

        public double GetDistanciaSeguretat()
        {
            return this.distancia_seguretat;
        }

        public int GetTempsCicle()
        {
            return this.temps_cicle;
        }
    }
}
