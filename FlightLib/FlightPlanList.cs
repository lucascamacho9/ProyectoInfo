using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightLib
{
    public class FlightPlanList
    {
        List <FlightPlan> vector = new List<FlightPlan>();
        int number = 0;

        public int AddFlightPlan(FlightPlan p)
        {
            vector.Add(p);
            number++;
            return 0;
        }
        public FlightPlan GetFlightPlan(int i)
        {
            if (i < 0 || i >= number)
            {
                return null;
            }
            else
            {
                return vector[i];
            }

        }
        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(tiempo);
                i++;
            }
        }
        
        public void EscribeConsola()
        {
            int i = 0;
            while (i < number)
            {
                vector[i].EscribeConsola();
                i++;

            }
        }

        public void MesNudos(double v)
        {
            int i = 0;
            while (i < number)
            {
                vector[i].SumarNudos(v);
                i++;
            }
        }


        public int GetNumber()
        {
            return this.number;
        }

        public List<FlightPlan> leerFichero (string nom_flitxer)
        {
            List<FlightPlan> nova = new List<FlightPlan>();
            
            StreamReader R = null;
            try
            {
                R = new StreamReader(nom_flitxer);
                string linia = R.ReadLine();
                int numLinia = 0;
                while (linia != null)
                {
                    string[] parts = linia.Split(' ');
                    if (parts.Length != 7)
                    {
                        Console.WriteLine("Línia " + numLinia + ": s'esperaven 7 camps i n'hi ha " + parts.Length +
                "\nContingut: [" + linia + "]" +
                "\nFitxer: " + Path.GetFullPath(nom_flitxer));
                        return null;
                    }
                    string id = parts[0];
                    string company = parts[1];
                    double cpx = Convert.ToDouble(parts[2]);
                    double cpy = Convert.ToDouble(parts[3]);
                    double fpx = Convert.ToDouble(parts[4]);
                    double fpy = Convert.ToDouble(parts[5]);
                    double velocidad = Convert.ToDouble(parts[6]);
                    FlightPlan flightPlan = new FlightPlan(id, company, cpx, cpy, fpx, fpy, velocidad);
                    nova.Add(flightPlan);
                    numLinia = numLinia + 1;
                    linia = R.ReadLine();
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No s'ha trobat el fitxer");
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("El fitxer no té el format correcte");
                return null;
            }

            return nova;
                
            }

        public int escrivirListaFichero(string nom_fitxer)
        {
            StreamWriter W = new StreamWriter(nom_fitxer);
            int i = 0;
            try
            {
                while (i < number)
                {
                    FlightPlan f = vector[i];
                    W.WriteLine(f.GetID() + " " + f.GetCompany() + " " + f.GetCurrentPosition().GetX() + " " + f.GetCurrentPosition().GetY() + " " + f.GetFinalPosition().GetX() + " " + f.GetFinalPosition().GetY() + " " + f.GetVelocidad());
                    i++;
                }
                W.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No existeix cap fitxer amb aquest nom.");
                return -1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el format del fitxer");
                return -2;
            }

            return 0;
        }

    }
}