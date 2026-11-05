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
        FlightPlanList listaOriginal;
        int temps_cicle;
        double distancia_seguretat;

        // Picture boxes per representar els avions
        PictureBox[] vuelos;
        bool mostrarLinies = false;
        bool mostrarElipses = false;
        bool MoureAutomatic = false;
        Timer timerAutomatic;

        public Simular()
        {
            InitializeComponent();
            panelSimular.ClientSize = new Size(600, 600);
            timerAutomatic = new Timer();
            timerAutomatic.Interval = 250; // 250 ms entre movimientos
            timerAutomatic.Tick += timerAutomatic_Tick;
        }

        private void MoureAvions()
        {
            miLista.Mover(temps_cicle);
            int i = 0;
            while (i < miLista.GetNumber())
            {
                FlightPlan f = miLista.GetFlightPlan(i);
                Position pos = f.GetCurrentPosition();
                ColocarAvio(vuelos[i], pos);
                i = i + 1;
            }

            VerificarConflictosActuales();

            panelSimular.Invalidate();
        }

        private void VerificarConflictosActuales()
        {
            bool alerta = false;

            for (int i = 0; i < miLista.GetNumber(); i++)
            {
                for (int j = i + 1; j < miLista.GetNumber(); j++)
                {
                    Position posA = miLista.GetFlightPlan(i).GetCurrentPosition();
                    Position posB = miLista.GetFlightPlan(j).GetCurrentPosition();

                    // Distancia
                    double difX = posA.GetX() - posB.GetX();
                    double difY = posA.GetY() - posB.GetY();
                    double distancia = Math.Sqrt((difX * difX) + (difY * difY));

                    if (distancia < 2*distancia_seguretat)
                    {
                        alerta = true;
                    }
                }
            }

            // Acción visual
            if (alerta)
            {
                panelSimular.BackColor = Color.LightCoral;
                lblAlerta.Text = "¡Peligro! Distancia de seguridad infringida.";
                lblAlerta.ForeColor = Color.Red;
            }

            else
            {
                panelSimular.BackColor = Color.FromArgb(255, 255, 128);
                lblAlerta.Text = "Separación segura.";
                lblAlerta.ForeColor = Color.Green;
            }


        }
        private void timerAutomatic_Tick(object sender, EventArgs e)
        {
            MoureAvions();
        }
        public void SetData(FlightPlanList f, int c, double d)
        {
            listaOriginal = f;
            miLista = CrearCopia(listaOriginal);
            temps_cicle = c;
            distancia_seguretat = d;

        }

        /// Treballarem amb una còpia del Flight Plan original així podem reinicial la simulació amb les dades originals
        private FlightPlanList CrearCopia(FlightPlanList original)
        {
            FlightPlanList copia = new FlightPlanList();
            for (int i = 0; i < original.GetNumber(); i++)
            {
                FlightPlan f = original.GetFlightPlan(i);
                FlightPlan nuevo = new FlightPlan(f.GetID(), f.GetCompany(), f.GetCurrentPosition().GetX(), f.GetCurrentPosition().GetY(), f.GetFinalPosition().GetX(), f.GetFinalPosition().GetY(), f.GetVelocidad());
                copia.AddFlightPlan(nuevo);
            }
            return copia;
        }
        double escala = 6;
        private float ToPixels(double coord)
        {
            return (float)(coord * escala);
        }

        private void ColocarAvio(PictureBox p, Position pos)
        {
            p.Location = new Point((int)Math.Round(ToPixels(pos.GetX())) - p.Width / 2,
                          (int)Math.Round(ToPixels(pos.GetY())) - p.Height / 2);
        }

        private void ComprovarConflicteInicial()
        {
            int n = miLista.GetNumber();
            string llistaconflictes = "";
            int numConflictes = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    FlightPlan a = miLista.GetFlightPlan(i);
                    FlightPlan b = miLista.GetFlightPlan(j);
                    if (a.PreverConflictos(b, distancia_seguretat))
                    {
                        numConflictes++;
                    }
                }
            }
            
    
            {
                DialogResult resposta = MessageBox.Show ("es preveuen " + numConflictes + " conflictes" + "\n"+
                    "Vols resoldre'ls canviant la seva velocitat?", "Conflictes", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            FlightPlan a = miLista.GetFlightPlan(i);
                            FlightPlan b = miLista.GetFlightPlan(j);
                            if (a.PreverConflictos(b, distancia_seguretat))
                            {
                                double velocidadinicial1 = a.GetVelocidad();
                                double velocidadinicial2 = b.GetVelocidad();
                                a.ResoldreConflicte(b, distancia_seguretat);
                                double velocidadfinal1 = a.GetVelocidad();
                                double velocidadfinal2 = b.GetVelocidad();
                                if (velocidadinicial1 != velocidadfinal1)
                                {
                                    MessageBox.Show("S'ha canviat la velocitat del vol " + a.GetID() + " de " + velocidadinicial1 + " a " + velocidadfinal1);
                                }
                                if (velocidadinicial2 != velocidadfinal2)
                                {
                                    MessageBox.Show("S'ha canviat la velocitat del vol " + b.GetID() + " de " + velocidadinicial2 + " a " + velocidadfinal2);
                                }
                            }
                        }
                    }
                }   
            }
        }

        private void Simular_Load(object sender, EventArgs e)
        {
            panelSimular.Size = new Size(600, 600);

            ComprovarConflicteInicial();

            //final primera part fase 11

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
                ///p.ClientSize = new Size(10, 10);

                // Ubicació
                Position pos = f.GetCurrentPosition();

                // Ubicar el PictureBox  (es resta 10 (que es el tamany) i dividit entre 2 perquè quedi centrat)
                ColocarAvio(p, pos);

                // Ajustar el tamany de la imatge a 10x10
                /// p.SizeMode = PictureBoxSizeMode.StretchImage;

                p.Size = new Size(10, 10);
                p.BackColor = Color.Red;

                // Afegir la imatge de l'avió HA DE ESTAR A LA CARPETA DE LA SOLUCIÓ
                ///Bitmap imatge = new Bitmap("avio2.png");
                ///p.Image = (Image)imatge;

                p.Tag = i;
                p.Click += new System.EventHandler(this.ShowFlightInfo);

                panelSimular.Controls.Add(p);
                vuelos[i] = p;

                i = i + 1;
            }
        }


        //final segona part fase 11
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
            MoureAvions();
        }

        private void buttonLinia_Click(object sender, EventArgs e)
        {
            mostrarLinies = !mostrarLinies;
            panelSimular.Invalidate();
        }

        private void buttonElipse_Click(object sender, EventArgs e)
        {
            mostrarElipses = !mostrarElipses;
            panelSimular.Invalidate();
        }

        private void buttonAutomatic_Click(object sender, EventArgs e)
        {
            MoureAutomatic = !MoureAutomatic;
            timerAutomatic.Enabled = MoureAutomatic;
        }


        private void panelSimular_Paint(object sender, PaintEventArgs e)
        {
            if (miLista == null)
            {
                return;
            }
            using (Pen penLinia = new Pen(Color.Red, 2))
            using (Pen penElipse = new Pen(Color.Blue, 1))
            using (Font fontID = new Font("Arial", 8, FontStyle.Bold))
            using (Brush brushID = new SolidBrush(Color.Black))
            {
                float r = ToPixels(distancia_seguretat);
                int i = 0;
                while (i < miLista.GetNumber())
                {
                    FlightPlan f = miLista.GetFlightPlan(i);
                    Position pos = f.GetCurrentPosition();
                    float px = ToPixels(pos.GetX());
                    float py = ToPixels(pos.GetY());

                    if (mostrarLinies)
                    {
                        Position fin = f.GetFinalPosition();
                        // Dibuixar la línia de trajectòria
                        // Pen penLinia = new Pen(Color.Red, 2);
                        e.Graphics.DrawLine(penLinia, px, py, ToPixels(fin.GetX()), ToPixels(fin.GetY()));
                    }
                    if (mostrarElipses)
                    {
                        //Pen penElipse = new Pen(Color.Blue, 1);
                        e.Graphics.DrawEllipse(penElipse, px - r, py - r, 2 * r, 2 * r);
                    }
                    Position posID = f.GetCurrentPosition();
                    e.Graphics.DrawString(f.GetID(), fontID, brushID, px + 8, py - 18);
                    i++;
                }
            }
        }

        private void buttonDades_Click(object sender, EventArgs e)
        {
            Dades form = new Dades();
            form.TomaLista(miLista);
            form.ShowDialog();
        }

        private void PredecirButton_Click(object sender, EventArgs e)
        {
            int numAviones = miLista.GetNumber();
            if (numAviones < 2) return;

            // Creamos una simulacion "fantasma" de todos los aviones para predecir conflictos futuros
            FlightPlan[] copia = new FlightPlan[numAviones];
            for (int i = 0; i < numAviones; i++)
            {
                FlightPlan original = miLista.GetFlightPlan(i);

                // Creamos un clon en su posición actual
                copia[i] = new FlightPlan(
                    original.GetID(),
                    original.GetCompany(),
                    original.GetCurrentPosition().GetX(),
                    original.GetCurrentPosition().GetY(),
                    original.GetFinalPosition().GetX(),
                    original.GetFinalPosition().GetY(),
                    original.GetVelocidad()
                );
            }

            bool conflictoEncontrado = false;
            int maxIteraciones = 5000;
            int iteracion = 0;

            // Iniciamos la simulacion fantasma
            while (AlgunAvionEnRuta(copia) && !conflictoEncontrado && iteracion < maxIteraciones)
            {
                for (int i = 0; i < numAviones; i++)
                {
                    if (!copia[i].HasArrived())
                    {
                        copia[i].Mover(temps_cicle);
                    }
                }

                // Comprobamos conflictos solo entre aviones que siguen volando
                for (int i = 0; i < numAviones; i++)
                {
                    if (copia[i].HasArrived()) continue;

                    for (int j = i + 1; j < numAviones; j++)
                    {
                        if (copia[j].HasArrived()) continue;

                        if (copia[i].Conflicto(copia[j], distancia_seguretat))
                        {
                            conflictoEncontrado = true;
                        }
                    }
                }
                iteracion++;
            }

            if (conflictoEncontrado)
            {
                MessageBox.Show("¡ALERTA! Se prevé un conflicto en las trayectorias", "Predicción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Rutas limpias. No se predicen conflictos.", "Predicción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool AlgunAvionEnRuta(FlightPlan[] copia)
        {
            foreach (FlightPlan f in copia)
            {
                if (!f.HasArrived()) return true; // Si al menos uno no ha llegado, seguimos
            }
            return false; // Todos han llegado
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            ///para el mode automàtic si estava iniciat
            MoureAutomatic = false;
            timerAutomatic.Enabled = false;

            ///recol·locar els picturebox a la posició inicial
            for (int i = 0; i < miLista.GetNumber(); i++)
            {
                FlightPlan f = miLista.GetFlightPlan(i);
                f.Reestart();
                Position pos = f.GetCurrentPosition();
                ColocarAvio(vuelos[i], pos);
            }
            VerificarConflictosActuales();
            panelSimular.Invalidate();
        }
        
    }
}
  

