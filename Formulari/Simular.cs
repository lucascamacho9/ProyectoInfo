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
    public partial class Simular : Form
    {
        FlightPlanList miLista;
        int temps_cicle;
        double distancia_seguretat;
        
        // Picture boxes per representar els avions
        PictureBox[] vuelos;
        
        public Simular()
        {
            InitializeComponent();
        }
        public void SetData(FlightPlanList f, int c, double d)
        {
            miLista = f;
            temps_cicle = c;
            distancia_seguretat = d;

        }
        private void Simular_Load(object sender, EventArgs e)
        {
            vuelos = new PictureBox[miLista.GetNumber()];
            int i = 0;
            while (i < miLista.GetNumber())
            {
                // Per represetnar el vol a la posició i
                PictureBox p = new PictureBox();
                FlightPlan f = miLista.GetFlightPlan(i);

                // Configurar el picture box
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);

                // Ubicació
                Position pos = f.GetCurrentPosition();

                // Ubicar el PictureBox
                p.Location = new Point((int)pos.GetX(), (int)pos.GetY());

                // Ajustar el temany de la imatge a 10x10
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                // Afegir la imatge de l'avió HA DE ESTAR A LA CARPETA DE LA SOLUCIÓ
                Bitmap imatge = new Bitmap("avio2.png");
                p.Image = (Image)imatge;

                p.Tag = i;
                p.Click += new System.EventHandler(this.ShowFlightInfo);

                panelSimular.Controls.Add(p);
                vuelos[i] = p;
                i = i + 1;
            }
        }

        private void ShowFlightInfo(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            InfoAvio f = new InfoAvio();
            f.setFlightPlan(miLista.GetFlightPlan(i));
            f.ShowDialog();
        }

        private void buttonMoure_Click(object sender, EventArgs e)
        {
            miLista.Mover(temps_cicle);
            int i = 0;
            while (i < miLista.GetNumber())
            {
                // Per represetnar el vol a la posició i/
                FlightPlan f = miLista.GetFlightPlan(i);

                // Ubicació
                Position pos = f.GetCurrentPosition();

                // Ubicar el PictureBox
                vuelos[i].Location = new Point((int)pos.GetX(), (int)pos.GetY());
                i = i + 1;
            }
        }
    }
}
