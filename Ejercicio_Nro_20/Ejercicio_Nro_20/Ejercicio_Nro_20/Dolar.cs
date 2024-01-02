using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this(cantidad, 1)
        {

        }

        public Dolar(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        // METODOS

        /// <summary>
        /// Construye explicitamente un objeto Euro, dado un objeto Dolar
        /// </summary>
        /// <param name="d">objeto Dolar dado</param>
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * 1 / Euro.GetCotizacion());
        }

        /// <summary>
        /// Construye explicitamente un objeto Pesos, dado un objeto Dolar
        /// </summary>
        /// <param name="d">objeto Dolar dado</param>
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        /// <summary>
        /// Muestra la cantidad de este objeto Dolar
        /// </summary>
        /// <returns>el atributo cantidad</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Muestra la cotizacion de este objeto respect al Dolar
        /// </summary>
        /// <returns>el atributo estático cotizacion</returns>
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        /// <summary>
        /// Construye implicitamente un objeto Dolar, dado un valor double
        /// </summary>
        /// <param name="d">la cantidad a construir</param>
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }


        /// <summary>
        /// Compara si dos objetos Dolar son distintos segun su cantidad
        /// </summary>
        /// <param name="d1">Primer objeto Dolar a comparar</param>
        /// <param name="d2">Segundo objeto Dolar a comparar</param>
        /// <returns>true si son distintos, false si son iguales</returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Euro son distintos segun su cantidad equivalente
        /// </summary>
        /// <param name="d">Objeto Dolar a comparar</param>
        /// <param name="e">Objeto Euro a comparar</param>
        /// <returns>true si son distintos, false si son iguales</returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Pesos son distintos segun su cantidad equivalente
        /// </summary>
        /// <param name="d">Objeto Dolar a comparar</param>
        /// <param name="p">Objeto Pesos a comparar</param>
        /// <returns>true si son distintos, false si son iguales</returns>
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }


        /// <summary>
        /// Resta el equivalente en Dolar a la cantidad correspondiente de Pesos
        /// </summary>
        /// <param name="d">objeto Dolar del cual restar</param>
        /// <param name="p">objeto Peso a restar</param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).GetCantidad());
        }
        /// <summary>
        /// Resta el equivalente en Dolar a la cantidad correspondiente de Euro
        /// </summary>
        /// <param name="d">objeto Dolar del cual restar</param>
        /// <param name="e">objeto Euro a restar</param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }


        /// <summary>
        /// Suma el equivalente en Dolar a la cantidad correspondiente de Pesos
        /// </summary>
        /// <param name="d">objeto Dolar del cual sumar</param>
        /// <param name="p">objeto Pesos a srumar</param>
        /// <returns></returns>
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }
        /// <summary>
        /// Suma el equivalente en Dolar a la cantidad correspondiente de Euro
        /// </summary>
        /// <param name="d">objeto Dolar del cual sumar</param>
        /// <param name="e">objeto Euro a sumar</param>
        /// <returns></returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }


        /// <summary>
        /// Compara si dos objetos Dolar son iguales segun su cantidad
        /// </summary>
        /// <param name="d1">Primer objeto Dolar a comparar</param>
        /// <param name="d2">Segundo objeto Dolar a comparar</param>
        /// <returns>true si son iguales, false si son distintos</returns>
        public static bool operator==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Euro son iguales segun su cantidad equivalente
        /// </summary>
        /// <param name="d">Objeto Dolar a comparar</param>
        /// <param name="e">Objeto Euro a comparar</param>
        /// <returns>true si son iguales, false si son distintos</returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }
        /// <summary>
        /// Compara si un objeto Dolar y un objeto Pesos son iguales segun su cantidad equivalente
        /// </summary>
        /// <param name="d">Objeto Dolar a comparar</param>
        /// <param name="p">Objeto Pesos a comparar</param>
        /// <returns>true si son iguales, false si son distintos</returns>
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }
       
    }
}
