/*
 *  Ejercicio Nro 18
 *  
 *  Escribir una aplicación con estos dos espacios de nombres (namespaces): Geometría y PruebaGeometria.
 *  Dentro del espacio de nombres Geometría se deberán escribir dos clases: Punto y Rectángulo.
 *  
 *   -------------------------------         -------------------------------------------------------
 *  |   Punto                       |       |   Rectangulo                                          |
 *  |     Fields                    |       |     Fields                                            |
 *  |       (private) x : int       |       |       (private) area : float                          |
 *  |       (private) y : int       |       |       (private) perimetro : float                     |
 *  |     Methods                   |       |       (private) vertice1 : Punto                      |
 *  |       GetX() : int            |       |       (private) vertice2 : Punto                      |
 *  |       GetY() : int            |       |       (private) vertice3 : Punto                      |
 *  |       Punto(int x, int y)     |       |       (private) vertice4 : Punto                      |
 *  |_______________________________|       |     Methods                                           |
 *                                          |       Area() : float                                  |
 *                                          |       Perimetro() : float                             |
 *                                          |       Rectangulo(Punto vertice1, Punto vertice3)      |
 *                                          |_______________________________________________________|
 *                                          
 *  a.	La clase Punto ha de tener dos atributos privados con acceso de sólo lectura (sólo con getters), que serán las coordenadas del punto. 
 *      También un constructor que reciba los parámetros x e y.
 *      
 *  b.	La clase Rectángulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
 *  
 *  c.	La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe tener un constructor para construir 
 *      el rectángulo por medio de los vértices 1 y 3 (utilizar el método Abs de la clase Math, dicho método retorna el valor absoluto de un número, 
 *      para obtener la distancia entre puntos).
 *  
 *  d.	Realizar los métodos getters para los atributos privados área y perímetro.
 *  
 *  e.	Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo una vez, al llamar por primera vez a su 
 *      correspondiente método getter (Area y Perimetro de la clase Rectángulo creados en el punto anterior). 
 *      Luego, cada vez que se invoque a los métodos Área y Perímetro, se deberá retornar siempre el valor calculado anteriormente.
 *      
 *  En el espacio de nombres PruebaGeometria es donde se escribirá una clase con el método Main.
 *  
 *  f.	Probar las funcionalidades de las clases Punto y Rectángulo.
 *      i.	Generar un nuevo Rectángulo.
 *      ii.	Imprimir por pantalla los valores de área y perímetro.
 *      
 *  g.	Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como parámetro.  
 * 
 */

using Geometria;
using System.Drawing;
using System.Text;

namespace PruebaGeometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto esquina1 = new Punto(0, 15);
            Punto esquina3 = new Punto(60, 40);
            Rectangulo rectangulo1 = new Rectangulo(esquina1, esquina3);

            Program.MostrarDatos(rectangulo1);
        }

        /// <summary>
        /// Imprime en pantalla todos los datos de un rectángulo
        /// </summary>
        /// <param name="rectangulo">el rectangulo a mostrar</param>
        private static void MostrarDatos(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Vértice 1: ({rectangulo.Vertice1.GetX()}; {rectangulo.Vertice1.GetY()})");
            sb.AppendLine($"Vértice 2: ({rectangulo.Vertice2.GetX()}; {rectangulo.Vertice2.GetY()})");
            sb.AppendLine($"Vértice 3: ({rectangulo.Vertice3.GetX()}; {rectangulo.Vertice3.GetY()})");
            sb.AppendLine($"Vértice 4: ({rectangulo.Vertice4.GetX()}; {rectangulo.Vertice4.GetY()})");
            sb.AppendLine($"Área: {rectangulo.Area()}");
            sb.AppendLine($"Perímetro: {rectangulo.Perimetro()}");

            Console.WriteLine(sb);
        }
    }
}