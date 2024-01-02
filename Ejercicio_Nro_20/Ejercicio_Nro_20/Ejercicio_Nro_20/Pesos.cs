using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 1000;
        }

        public Pesos(double cantidad) : this(cantidad, 1000)
        {

        }

        public Pesos(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            Pesos.cotizRespectoDolar = cotizacion;
        }

        // METODOS

        /// <summary>
        /// Construye explicitamente un objeto Dolar, dado un objeto Pesos
        /// </summary>
        /// <param name="p">objeto Pesos dado</param>
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        /// <summary>
        /// Construye explicitamente un objeto Euro, dado un objeto Pesos
        /// </summary>
        /// <param name="p">objeto Pesos dado</param>
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Pesos.GetCotizacion() / Euro.GetCotizacion());
        }

        /// <summary>
        /// Muestra la cantidad de este objeto Pesos
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Muestra la cantidad de este objeto respect al Dolar
        /// </summary>
        /// <returns></returns>
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }



        /// <summary>
        /// Construye implicitamente un objeto Dolar, dado un valor double
        /// </summary>
        /// <param name="d">la cantidad correspondiente</param>
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }


        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }



        public static Pesos operator - (Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }



        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }




        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }

    }
}
