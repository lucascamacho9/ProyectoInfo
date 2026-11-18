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
    public partial class Entrada : Form
    {
        GestorBBDD miGestor = new GestorBBDD();

        public Entrada()
        {
            InitializeComponent();
            miGestor.Iniciar();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
        }

        private void buttonRegistre_Click(object sender, EventArgs e)
        {
            if (nomBox.Text==null || EDATBox.Text==null || ContrassenyaBox1.Text == null || ContrassenyaBox1.Text==null || ContrassenyaBox2.Text == null)
            {
                MessageBox.Show("Has d'omplir tots els camps abans de registrar-te.");
                return;
            }

            else if (ContrassenyaBox1.Text != ContrassenyaBox2.Text)
            {
                MessageBox.Show("Les contrassenyes no coincideixen.");
                return;
            }

            else
            {
                string nom = nomBox.Text;
                int edat = Convert.ToInt32(EDATBox.Text);
                string contrassenya1 = ContrassenyaBox1.Text;
                string contrassenya2 = ContrassenyaBox2.Text;
                int resultat = miGestor.InsertarCliente(nom, edat, contrassenya1);
                if (resultat != 0)
                {
                    MessageBox.Show("Client registrat correctament.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el client.");
                }
            }                   
        }

        private void buttonAccedir_Click(object sender, EventArgs e)
        {
            if (nomBox.Text == null || EDATBox.Text == null || ContrassenyaBox1.Text == null || ContrassenyaBox1.Text == null || ContrassenyaBox2.Text == null)
            {
                MessageBox.Show("Has d'omplir tots els camps abans de registrar-te.");
                return;
            }

            else if (ContrassenyaBox1.Text != ContrassenyaBox2.Text)
            {
                MessageBox.Show("Les contrassenyes no coincideixen.");
                return;
            }

            else
            {
                if (miGestor.ClienteRegistrado(nomBox.Text, Convert.ToInt32(EDATBox.Text), ContrassenyaBox1.Text))
                {
                    MessageBox.Show("Accés correcte.");
                    Form Princiapl = new Principal();
                    Princiapl.Show();
                }

                else
                {
                    MessageBox.Show("Accés incorrecte.");
                }
            }
        }
    }
}
