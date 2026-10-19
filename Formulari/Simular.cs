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
        bool mostrarLinies = false;
        bool mostrarElipses = false;
        bool MoureAutomatic = false;
        Timer timerAutomatic;

        public Simular()
        {
            InitializeComponent();
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
                vuelos[i].Location = new Point((int)pos.GetX()-10/2, (int)pos.GetY()-10/2);
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

                    if (distancia < distancia_seguretat)
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
            miLista = f;
            temps_cicle = c;
            distancia_seguretat = d;

        }
        private void Simular_Load(object sender, EventArgs e)
        {

            // Fase 11: abans de simular comprovem si els vols entraran en conflicte
            if (miLista.GetNumber() == 2)
            {
                FlightPlan vol1 = miLista.GetFlightPlan(0);
                FlightPlan vol2 = miLista.GetFlightPlan(1);
                if (PreveureConflicte(vol1.GetVelocidad(), vol2.GetVelocidad()))
                {
                    DialogResult resposta = MessageBox.Show("Els vols entraran en conflicte (les el·lipses de seguretat es tocaran). Vols resoldre el conflicte?", "Conflicte", MessageBoxButtons.YesNo);
                    if (resposta == DialogResult.Yes)
                    {
                        ResoldreConflicte();
                    }
                }
            }
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
                p.Location = new Point((int)pos.GetX()-10/2, (int)pos.GetY()-10/2);

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
        // Fase 11: simula amb còpies dels vols (els de veritat no es mouen)
        // i retorna true si les el·lipses de seguretat es tocaran en algun moment
        private bool PreveureConflicte(double velocitat1, double velocitat2)
        {
            FlightPlan a = miLista.GetFlightPlan(0);
            FlightPlan b = miLista.GetFlightPlan(1);

            // Fem còpies dels vols amb les velocitats que volem provar
            FlightPlan copiaA = new FlightPlan(a.GetID(), a.GetCurrentPosition().GetX(), a.GetCurrentPosition().GetY(), a.GetFinalPosition().GetX(), a.GetFinalPosition().GetY(), velocitat1);
            FlightPlan copiaB = new FlightPlan(b.GetID(), b.GetCurrentPosition().GetX(), b.GetCurrentPosition().GetY(), b.GetFinalPosition().GetX(), b.GetFinalPosition().GetY(), velocitat2);

            // Cada avió té una el·lipse de radi distancia_seguretat,
            // per tant perquè no es toquin els avions han d'estar a 2 * distancia_seguretat com a mínim
            double distanciaMinima = 2 * distancia_seguretat;

            // Dividim cada cicle en 100 passos petits per no saltar-nos
            // el moment en què els avions estan més a prop (entre dos cicles)
            double tempsPas = temps_cicle / 100.0;

            bool conflicte = false;
            int passos = 0;
            // Movem fins que hi hagi conflicte o els dos hagin arribat (màxim 1000000 passos per si la velocitat és 0)
            while (!conflicte && (!copiaA.HasArrived() || !copiaB.HasArrived()) && passos < 1000000)
            {
                if (copiaA.Conflicto(copiaB, distanciaMinima))
                {
                    conflicte = true;
                }
                copiaA.Mover(tempsPas);
                copiaB.Mover(tempsPas);
                passos = passos + 1;
            }

            // Comprovem també la posició final (quan els dos ja han arribat)
            if (copiaA.Conflicto(copiaB, distanciaMinima))
            {
                conflicte = true;
            }
            return conflicte;
        }

        // Fase 11: busca una velocitat nova per a un dels vols perquè no hi hagi conflicte
        private void ResoldreConflicte()
        {
            FlightPlan vol1 = miLista.GetFlightPlan(0);
            FlightPlan vol2 = miLista.GetFlightPlan(1);
            double velocitat1 = vol1.GetVelocidad();
            double velocitat2 = vol2.GetVelocidad();
            double novaVelocitat = 0;
            bool trobada = false;
            int volCanviat = 0;

            // Primer provem canviant la velocitat del vol 2, de 5% en 5% (primer més lent i després més ràpid)
            int i = 1;
            while (i <= 40 && !trobada)
            {
                if (i < 20)
                {
                    novaVelocitat = velocitat2 - velocitat2 * 0.05 * i;
                    if (!PreveureConflicte(velocitat1, novaVelocitat))
                    {
                        trobada = true;
                        volCanviat = 2;
                    }
                }
                if (!trobada)
                {
                    novaVelocitat = velocitat2 + velocitat2 * 0.05 * i;
                    if (!PreveureConflicte(velocitat1, novaVelocitat))
                    {
                        trobada = true;
                        volCanviat = 2;
                    }
                }
                i = i + 1;
            }

            // Si no s'ha trobat, provem el mateix canviant la velocitat del vol 1
            i = 1;
            while (i <= 40 && !trobada)
            {
                if (i < 20)
                {
                    novaVelocitat = velocitat1 - velocitat1 * 0.05 * i;
                    if (!PreveureConflicte(novaVelocitat, velocitat2))
                    {
                        trobada = true;
                        volCanviat = 1;
                    }
                }
                if (!trobada)
                {
                    novaVelocitat = velocitat1 + velocitat1 * 0.05 * i;
                    if (!PreveureConflicte(novaVelocitat, velocitat2))
                    {
                        trobada = true;
                        volCanviat = 1;
                    }
                }
                i = i + 1;
            }

            if (trobada)
            {
                if (volCanviat == 1)
                {
                    vol1.SetVelocidad(novaVelocitat);
                    MessageBox.Show("Conflicte resolt. Nova velocitat del vol " + vol1.GetID() + ": " + novaVelocitat.ToString("F2"));
                }
                else
                {
                    vol2.SetVelocidad(novaVelocitat);
                    MessageBox.Show("Conflicte resolt. Nova velocitat del vol " + vol2.GetID() + ": " + novaVelocitat.ToString("F2"));
                }
            }
            else
            {
                MessageBox.Show("No s'ha pogut resoldre el conflicte canviant la velocitat d'un dels vols");
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
            {
                int i = 0;
                while (i < miLista.GetNumber())
                {
                    FlightPlan f = miLista.GetFlightPlan(i);

                    if (mostrarLinies)
                    {
                        Position pos = f.GetCurrentPosition();
                        Position fin = f.GetFinalPosition();
                        // Dibuixar la línia de trajectòria
                        // Pen penLinia = new Pen(Color.Red, 2);
                        e.Graphics.DrawLine(penLinia, (int)pos.GetX(), (int)pos.GetY(), (int)fin.GetX(), (int)fin.GetY());
                    }
                    if (mostrarElipses)
                    {
                        Position pos = f.GetCurrentPosition();
                        float r = (float)distancia_seguretat;
                        //Pen penElipse = new Pen(Color.Blue, 1);
                        e.Graphics.DrawEllipse(penElipse, (int)pos.GetX() - (int)r, (int)pos.GetY() - (int)r, 2 * (int)r, 2 * (int)r);
                    }
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
            FlightPlan[] fantasmas = new FlightPlan[numAviones];
            for (int i = 0; i < numAviones; i++)
            {
                FlightPlan original = miLista.GetFlightPlan(i);

                // Creamos un clon en su posición actual
                fantasmas[i] = new FlightPlan(
                    original.GetID(),
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
            while (AlgunAvionEnRuta(fantasmas) && !conflictoEncontrado && iteracion < maxIteraciones)
            {
                for (int i = 0; i < numAviones; i++)
                {
                    if (!fantasmas[i].HasArrived())
                    {
                        fantasmas[i].Mover(temps_cicle);
                    }
                }

                // Comprobamos conflictos solo entre aviones que siguen volando
                for (int i = 0; i < numAviones; i++)
                {
                    if (fantasmas[i].HasArrived()) continue;

                    for (int j = i + 1; j < numAviones; j++)
                    {
                        if (fantasmas[j].HasArrived()) continue;

                        if (fantasmas[i].Conflicto(fantasmas[j], distancia_seguretat))
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

        private bool AlgunAvionEnRuta(FlightPlan[] listaFantasmas)
        {
            foreach (FlightPlan f in listaFantasmas)
            {
                if (!f.HasArrived()) return true; // Si al menos uno no ha llegado, seguimos
            }
            return false; // Todos han llegado
        }
    }
}
