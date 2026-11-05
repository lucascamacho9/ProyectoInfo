using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}