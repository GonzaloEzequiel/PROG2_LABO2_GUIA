using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;

        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;



        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(Math.Abs(vertice1.GetX()), Math.Abs(vertice3.GetY()));
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(Math.Abs(vertice3.GetX()), Math.Abs(vertice1.GetY()));
        }

        public Punto Vertice1 { get => vertice1; }
        public Punto Vertice2 { get => vertice2; }
        public Punto Vertice3 { get => vertice3; }
        public Punto Vertice4 { get => vertice4; }

        /// <summary>
        /// calcula (si es la primera vez) y devuelve el area del rectángulo
        /// </summary>
        /// <returns></returns>
        public float Area()
        {
            if (this.area == 0)
                this.area = (this.vertice2.GetY() - this.vertice1.GetY()) * (this.vertice4.GetX() - this.vertice1.GetX());
            
            return this.area;
        }

        /// <summary>
        /// calcula (si es la primera vez) y devuelve el perimetro del rectángulo
        /// </summary>
        /// <returns></returns>
        public float Perimetro()
        {
            if (this.perimetro == 0)
                this.perimetro = 2 * (this.vertice2.GetY() - this.vertice1.GetY()) + (this.vertice4.GetX() - this.vertice1.GetX());

            return this.perimetro;
        }
    }
}
