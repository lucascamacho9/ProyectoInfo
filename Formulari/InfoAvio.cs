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
    public partial class InfoAvio : Form
    {
        FlightPlan myFlight;
        public InfoAvio()
        {
            InitializeComponent();
        }

        public void setFlightPlan(FlightPlan f)
        {
            this.myFlight = f;
        }

        private void InfoAvio_Load(object sender, EventArgs e)
        {
            XBox.Text = Convert.ToString(myFlight.GetCurrentPosition().GetX());
            YBox.Text = Convert.ToString(myFlight.GetCurrentPosition().GetY());
            speedBox.Text = Convert.ToString(myFlight.GetVelocidad());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
