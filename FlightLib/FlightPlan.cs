using System;
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
            if (currentPosition == finalPosition)
                resultado = true;
            return resultado;
        }

        public bool Conflicto(FlightPlan b, double distanciaSeguridad)

        {
            bool conflicto = true;
            if (this.currentPosition.Distancia(b.currentPosition) < (distanciaSeguridad))
                conflicto = true;
            return conflicto;
        }

        public void SumarNudos(double v)
        {
            this.velocidad = velocidad + v;
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
