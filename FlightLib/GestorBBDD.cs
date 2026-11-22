using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;

namespace FlightLib
{
    public class GestorBBDD
    {
        SQLiteConnection cnx;
        public void Iniciar()
        {
            string dataSource = "Data Source=miBD.db";
            this.cnx = new SQLiteConnection(dataSource);
            cnx.Open();
        }

        public void Cerrar()
        {
            this.cnx.Close();
        }

        public DataTable GetClientes()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM entrada";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, this.cnx);
            adp.Fill(dt);
            return dt;
        }

        public int InsertarCliente(string nom, int edat, string contrassenya)
        {
            string sql = "INSERT INTO entrada (CONTRASSENYA, nom, edat) VALUES (@contrassenya, @nom, @edat)";
            SQLiteCommand cmd = new SQLiteCommand(sql, this.cnx);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@edat", edat);
            cmd.Parameters.AddWithValue("@contrassenya", contrassenya);
            int filesAfectades = cmd.ExecuteNonQuery();
            return filesAfectades;
        }

        public bool ClienteRegistrado(string nom, int edat, string contrassenya)
        {
            DataTable dt = GetClientes();
            int i = 0;
            bool encontrado = false;
            while (i < dt.Rows.Count && !encontrado)
            {
                if (dt.Rows[i]["nom"].ToString() == nom && Convert.ToInt32(dt.Rows[i]["edat"]) == edat && dt.Rows[i]["contrassenya"].ToString() == contrassenya)
                {
                    encontrado = true;
                }
                i++;
            }
            return encontrado;
        }

               
    }
}
