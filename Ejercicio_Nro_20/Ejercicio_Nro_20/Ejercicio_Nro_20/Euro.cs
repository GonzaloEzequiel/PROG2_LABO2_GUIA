using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.09765;
        }

        public Euro(double cantidad) : this(cantidad, 1.09765)
        {

        }

        public Euro(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = cotizacion;
        }

        // METODOS

        /// <summary>
        /// Construye explicitamente un objeto Dolar, dado un objeto Euro
        /// </summary>
        /// <param name="e">objeto Euro dado</param>
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }

        /// <summary>
        /// Construye explicitamente un objeto Pesos, dado un objeto Euro
        /// </summary>
        /// <param name="e">objeto Euro dado</param>
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos((e.cantidad * Euro.GetCotizacion()) / (1 / Pesos.GetCotizacion()));
        }


        /// <summary>
        /// Muestra la cantidad de este objeto Euro
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
            return Euro.cotizRespectoDolar;
        }



        /// <summary>
        /// Construye implicitamente un objeto Euro, dado un valor double
        /// </summary>
        /// <param name="d">la cantidad correspondiente</param>
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }


        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).GetCantidad());
        }


        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).GetCantidad());
        }



        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }
        
    }
}
