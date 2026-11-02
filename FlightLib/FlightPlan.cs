using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos
        string id; // identificador
        Position initialPosition;
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        // Metodos

        public string GetID()
        {
            return this.id;
        }

        public Position GetInitialPosition()
        {
            return this.initialPosition;
        }
        public Position GetCurrentPosition()
        {
            return this.currentPosition;
        }

        public Position GetFinalPosition()
        {
            return this.finalPosition;
        }

        public double GetVelocidad()
        {
            return this.velocidad;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void SetInitialPosition(Position initialPosition)
        {
            this.initialPosition = initialPosition;
        }

        public void SetCurrentPosition(Position currentPosition)
        {
            this.currentPosition = currentPosition;
        }

        public void SetFinalPosition(Position finalPosition)
        {
            this.finalPosition = finalPosition;
        }

        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad; }

        public Boolean HasArrived()
        {
            if (currentPosition.Distancia(finalPosition) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            bool ha_llegado = false;
            if (HasArrived())
            {
                ha_llegado = true;
            }

            else
            {
                //Calculamos la distancia recorrida en el tiempo dado
                double distancia = tiempo * this.velocidad / 60;

                //Calculamos las razones trigonométricas
                double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
                double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
                double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

                //Caculamos la nueva posición del vuelo
                double x = currentPosition.GetX() + distancia * coseno;
                double y = currentPosition.GetY() + distancia * seno;

                Position nextPosition = new Position(x, y);
                if (currentPosition.Distancia(nextPosition) < hipotenusa)
                    currentPosition = nextPosition;
                else
                    currentPosition = finalPosition;
            }

        }

        public void Reestart()
        {
            currentPosition = new Position(initialPosition.GetX(), initialPosition.GetY());
        }

        public double Distance(FlightPlan plan)
        {
            return this.currentPosition.Distancia(plan.currentPosition);
        }

        public bool EstaEnDestino()
        {
            bool resultado = false;
            if (currentPosition.Distancia(finalPosition) == 0)
                resultado = true;
            return resultado;
        }

        public bool Conflicto(FlightPlan b, double distanciaSeguridad)

        {
            bool conflicto = false; 
            if (this.currentPosition.Distancia(b.currentPosition) < (2*distanciaSeguridad))
                conflicto = true;
            return conflicto;
        }

        public void SumarNudos(double v)
        {
            this.velocidad = velocidad + v;
        }

        public bool PreverConflictos(FlightPlan b, double distanciaSeguridad)
        {
            bool conflicto = false;
            double D1 = this.initialPosition.Distancia(this.finalPosition);
            double vx1 = (this.finalPosition.GetX() - this.initialPosition.GetX()) / D1 * this.velocidad;
            double vy1 = (this.finalPosition.GetY() - this.initialPosition.GetY()) / D1 * this.velocidad;
            double D2 = b.initialPosition.Distancia(b.finalPosition);
            double vx2 = (b.finalPosition.GetX() - b.initialPosition.GetX()) / D2 * b.velocidad;
            double vy2 = (b.finalPosition.GetY() - b.initialPosition.GetY()) / D2 * b.velocidad;
            double dX = this.initialPosition.GetX() - b.initialPosition.GetX();
            double dY = this.initialPosition.GetY() - b.initialPosition.GetY();
            double dVx = vx1 - vx2;
            double dVy = vy1 - vy2;
            double tmin = -(dX * dVx + dY * dVy) / (dVx * dVx + dVy * dVy);
            double xmin = dX + dVx * tmin;
            double ymin = dY + dVy * tmin;
            double Dmin = Math.Sqrt(xmin * xmin + ymin * ymin);
            if (Dmin < 2*distanciaSeguridad)
                conflicto = true;
            return conflicto;
        }

        // Fase 11: busca una velocitat nova per a un dels vols perquè no hi hagi conflicte
        public void ResoldreConflicte(FlightPlan b, double distanciaSeguridad)
        {
            double velocitat1 = this.velocidad;
            double velocitat2 = b.GetVelocidad();
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
                    b.SetVelocidad(novaVelocitat);
                    if (!PreverConflictos(b, distanciaSeguridad))
                    {
                        trobada = true;
                        volCanviat = 2;
                    }
                }
                if (!trobada)
                {
                    novaVelocitat = velocitat2 + velocitat2 * 0.05 * i;
                    b.SetVelocidad(novaVelocitat);
                    if (!PreverConflictos(b, distanciaSeguridad))
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
                    this.SetVelocidad(novaVelocitat);
                    if (!PreverConflictos(b, distanciaSeguridad))
                    {
                        trobada = true;
                        volCanviat = 1;
                        
                    }
                }
                if (!trobada)
                {
                    novaVelocitat = velocitat1 + velocitat1 * 0.05 * i;
                    this.SetVelocidad(novaVelocitat);
                    if (!PreverConflictos(b, distanciaSeguridad))
                    {
                        trobada = true;
                        volCanviat = 1;
                        
                    }
                }
                i = i + 1;
            }
        }

        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:f2}", velocidad);
            Console.WriteLine("Posición actual: ({0:f2},{1:f2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.EstaEnDestino())
            {
                Console.WriteLine("Ha llegado al destino");
            }
            Console.WriteLine("******************************");
        }
    }
   
}
