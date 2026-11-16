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
    public partial class datagrid : Form
    {
        FlightPlanList milista = new FlightPlanList();
        List<double> velocitatsinicials = new List<double>();

        public datagrid()
        {
            InitializeComponent();
        }

        public void TomaInfo(FlightLib.FlightPlanList llista, List<double> velocitatsinicials)
        {
            this.milista = llista;
            this.velocitatsinicials = velocitatsinicials;
        }
        private void datagrid_Load_1(object sender, EventArgs e)
        {
            int numero = milista.GetNumber();
            if (numero == 0)
            {
                MessageBox.Show("No hi ha conflictes per resoldre");
            }
            else
            {
                // Definimos filas y las 4 columnas de texto
                dataGridView1.RowCount = numero;
                dataGridView1.ColumnCount = 4;

                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Companyia";
                dataGridView1.Columns[2].HeaderText = "Velocitat Inicial";
                dataGridView1.Columns[3].HeaderText = "Velocitat Proposada";

                // Añadimos la columna 4 de tipo CheckBox para poder marcar/desmarcar
                DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
                colCheck.HeaderText = "Aplicar";
                dataGridView1.Columns.Add(colCheck);


                for (int i = 0; i < numero; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = milista.GetFlightPlan(i).GetID();
                    dataGridView1.Rows[i].Cells[1].Value = milista.GetFlightPlan(i).GetCompany();
                    dataGridView1.Rows[i].Cells[2].Value = velocitatsinicials[i].ToString("F2");
                    dataGridView1.Rows[i].Cells[3].Value = milista.GetFlightPlan(i).GetVelocidad().ToString("F2");
                    dataGridView1.Rows[i].Cells[4].Value = true;
                }
            }
        }

        private void aceptar_btn_Click(object sender, EventArgs e)
        {
            // Recorremos las filas para ver cuáles ha desmarcado el usuario
            for (int i = 0; i < milista.GetNumber(); i++)
            {
                bool aplicar = Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value);

                // Si NO está marcado, le devolvemos su velocidad inicial
                if (!aplicar)
                {
                    milista.GetFlightPlan(i).SetVelocidad(velocitatsinicials[i]);
                }
            }
            Close();
        }
    }
}
