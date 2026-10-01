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
        FlightPlan p;
        public NouFlightPlan()
        {
            InitializeComponent();
        }

        private void afegirButton_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            try
            {
                
                    p = new FlightPlan(IDBox.Text, Convert.ToDouble(pXiBox.Text), Convert.ToDouble(pYiBox.Text), Convert.ToDouble(pXfBox.Text), Convert.ToDouble(pYfBox.Text), Convert.ToDouble(velocityBox.Text));
                    MessageBox.Show("s'ha afegit correctament");
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

        public FlightPlan GetFlightPlan()
        {
            return this.p;
        }
    }
}
