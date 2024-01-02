/*
 *  Ejercicio Nro 20
 * 
 *  Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dólar.
 *  
 *  a.	Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, 
 *      teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
 *      
 *  b.	El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
 *  
 *  c.	Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
 *  
 *  d.	Colocar dentro del Main el código necesario para probar todos los métodos.
 *  
 *  e.	Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.
 *  
 *  f.	Los comparadores == compararan cantidades.
 *  
 *  g.	Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido. 
 *      Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
 *      
 *  h.	Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
 *  
 *   ___________________________________________________     ___________________________________________________     ___________________________________________________
 *  |   DOLAR                                           |   |   EURO                                            |   |   PESOS                                           |
 *  |     Atributos:                                    |   |     Atributos:                                    |   |     Atributos:                                    |         
 *  |       (private) cantidad : double                 |   |       (private) cantidad : double                 |   |       (private) cantidad : double                 |
 *  |       (private) cotizRespectoDolar : double       |   |       (private) cotizRespectoDolar : double       |   |       (private) cotizRespectoDolar : double       |
 *  |     Métodos:                                      |   |     Métodos:                                      |   |     Métodos:                                      |
 *  |       (static) Dolar()                            |   |       (static) Euro()                             |   |       (static) Pesos()                            |
 *  |       Dolar(double cantidad)                      |   |       Euro(double cantidad)                       |   |       Pesos(double cantidad)                      |
 *  |       explicit operator Euro(Dolar d) : Euro      |   |       Euro(double cantidad, double cotizacion)    |   |       Pesos(double cantidad, double cotizacion)   |
 *  |       explicit operator Pesos(Dolar d) : Pesos    |   |       explicit operator Dolar(Euro e) : Dolar     |   |       explicit operator Dolar(Pesos p) : Dolar    |   
 *  |       GetCantidad() : double                      |   |       explicit operator Pesos(Euro e) : Pesos     |   |       explicit operator Euro(Pesos p) : Euro      |
 *  |       GetCotizacion() : double                    |   |       GetCantidad() : double                      |   |       GetCantidad() : double                      |                 
 *  |       implicit operator Dolar(double d) : Dolar   |   |       GetCotizacion() : double                    |   |       GetCotizacion() : double                    |     
 *  |       operator !=(Dolar d, Euro e) : bool         |   |       implicit operator Euro(double d) : Euro     |   |       implicit operator Pesos(double d) : Pesos   |    
 *  |       operator !=(Dolar d, Pesos p) : bool        |   |       operator !=(Euro e, Dolar d) : bool         |   |       operator !=(Pesos p, Dolar d) : bool        |
 *  |       operator !=(Dolar d1, Dolar d2) : bool      |   |       operator !=(Euro e, Pesos p) : bool         |   |       operator !=(Pesos p, Euro e) : bool         |
 *  |       operator -(Dolar d, Euro e) : Dolar         |   |       operator !=(Euro e1, Euro e2) : bool        |   |       operator !=(Pesos p1, Pesos p2) : bool      |
 *  |       operator -(Dolar d, Pesos p) : Dolar        |   |       operator -(Euro e, Dolar d) : Euro          |   |       operator -(Pesos p, Dolar d) : Pesos        |  
 *  |       operator +(Dolar d, Euro e) : Dolar         |   |       operator -(Euro e, Pesos p) : Euro          |   |       operator -(Pesos p, Euro e) : Pesos         |
 *  |       operator +(Dolar d, Pesos p) : Dolar        |   |       operator +(Euro e, Dolar d) : Euro          |   |       operator +(Pesos p, Dolar d) : Pesos        |    
 *  |       operator ==(Dolar d, Euro e) : bool         |   |       operator +(Euro e, Pesos p) : Euro          |   |       operator +(Pesos p, Euro e) : Pesos         |      
 *  |       operator ==(Dolar d, Pesos p) : bool        |   |       operator ==(Euro e, Dolar d) : bool         |   |       operator ==(Pesos p, Dolar d) : bool        |           
 *  |       operator ==(Dolar d1, Dolar d2) : bool      |   |       operator ==(Euro e, Pesos p) : bool         |   |       operator ==(Pesos p, Euro e) : bool         |  
 *  |___________________________________________________|   |___________________________________________________|   |___________________________________________________|
 * 
 */


using Billetes;
using System.Text;

namespace Ejercicio_Nro_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTORES
            //se instancian 3 Dolar
            Dolar dolar1 = new Dolar(1);
            Dolar dolar2 = new Dolar(100);
            Dolar dolar3 = new Dolar(125);
            //se instancian 3 Euro
            Euro euro1 = new Euro(1);
            Euro euro2 = new Euro(100);
            Euro euro3 = new Euro(125);
            //se instancian 3 Peso
            Pesos pesos1 = new Pesos(1);
            Pesos pesos2 = new Pesos(100);
            Pesos pesos3 = new Pesos(125);

            //IMPLICITOS
            Dolar nuevoDolar = 200;
            Euro nuevoEuro = 200;
            Pesos nuevoPesos = 200;

            //EXPLCITOS
            Euro nuevoDolarAEuro = (Euro)nuevoDolar;
            Pesos nuevoDolarAPesos = (Pesos)nuevoDolar;
            Dolar nuevoEuroADolar = (Dolar)nuevoEuro;
            Pesos nuevoEuroAPesos = (Pesos)nuevoEuro;
            Dolar nuevoPesoADolar = (Dolar)nuevoPesos;
            Euro nuevoPesoAEuro = (Euro)nuevoPesos;

            //SUMAS
            //DOLAR + EURO
            Dolar dolarSumarEuro = dolar2 + euro2;
            //DOLAR + PESOS
            Dolar dolarSumarPesos = dolar2 + pesos2;
            //EURO + DOLAR
            Euro euroSumaDolar = euro3 + dolar3;
            //EURO + PESOS
            Euro euroSumaPesos = euro1 + pesos2;
            //PESOS + DOLAR
            Pesos pesosSumaDolar = pesos3 + dolar1;
            //PESOS + EURO
            Pesos pesosSumaEuro = pesos3 + euro1;

            //RESTAS
            //DOLAR - EURO
            Dolar dolarRestaEuro = dolar2 - euro2;
            //DOLAR - PESO
            Dolar dolarRestaPesos = dolar2 - pesos2;
            //EURO - DOLAR
            Euro euroRestaDolar = euro2 - dolar2;
            //EURO - PESOS
            Euro euroRestaPesos = euro2 - pesos2;
            //PESOS - DOLAR
            Pesos pesosRestaDolar = pesos2 - dolar1;
            //PESOS - EURO
            Pesos pesosRestaEuro = pesos2 - euro1;

            //COMPARACIONES
            //DOLAR IGUAL DOLAR
            bool dolarIgualDolar = dolar1 == dolar2;
            //DOLAR IGUAL EURO
            bool dolarIgualEuro = dolar1 == euro1;
            //DOLAR IGUAL PESOS
            bool dolarIgualPesos = dolar1 == pesos2;
            //EURO IGUAL EURO
            bool euroIgualEuro = euro1 == euro2;
            //EURO IGUAL DOLAR
            bool euroIgualDolar = euro1 == dolar2;
            //EURO IGUAL PESOS
            bool euroIgualPesos = euro2 == pesos3;
            //PESOS IGUAL PESOS
            bool pesosIgualPesos = pesos2 == pesos3;
            //PESOS IGUAL DOLAR
            bool pesosIgualDolar = pesos2 == dolar2;
            //PESOS IGUAL EURO
            bool pesosIgualEuro = pesos2 == euro1;

            //DOLAR DISTINTO DOLAR
            bool dolarDistintoDolar = dolar2 != nuevoEuroADolar;
            //DOLAR DISTINTO EURO
            bool dolarDistintoEuro = dolar2 != nuevoDolarAEuro;
            //DOLAR DISTINTO PESOS
            bool dolarDistintoPesos = dolar2 != nuevoDolarAPesos;
            //EURO DISTINTO EURO
            bool euroDistintoEuro = euro2 != nuevoDolarAEuro;
            //EURO DISTINTO DOLAR
            bool euroDistintoDolar = euro2 != nuevoEuroADolar;
            //EURO DISTINTO PESOS
            bool euroDistintoPesos = euro2 != nuevoEuroAPesos;
            //PESOS DISTINTO PESOS
            bool pesosDistintoPesos = pesos2 != nuevoDolarAPesos;
            //PESOS DISTINTO DOLAR
            bool pesosDistintoDolar = pesos2 != nuevoPesoADolar;
            //PESOS DISTINTO EURO
            bool pesosDistintoEuro = pesos2 != nuevoPesoAEuro;

            //presentacion en pantalla
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dolar 1: {dolar1.GetCantidad()}");
            sb.AppendLine($"Dolar 2: {dolar2.GetCantidad()}");
            sb.AppendLine($"Dolar 3: {dolar3.GetCantidad()}");
            sb.AppendLine($"Euro 1: {euro1.GetCantidad()}");
            sb.AppendLine($"Euro 2: {euro2.GetCantidad()}");
            sb.AppendLine($"Euro 3: {euro3.GetCantidad()}");
            sb.AppendLine($"Pesos 1: {pesos1.GetCantidad()}");
            sb.AppendLine($"Pesos 2: {pesos2.GetCantidad()}");
            sb.AppendLine($"Pesos 3: {pesos3.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Dolar: {nuevoDolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Euro: {nuevoEuro.GetCantidad()}");
            sb.AppendLine($"Nuevo Pesos: {nuevoPesos.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Dolar a Euro: {nuevoDolarAEuro.GetCantidad()}");
            sb.AppendLine($"Nuevo Dolar a Pesos: {nuevoDolarAPesos.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Euro a Dolar: {nuevoEuroADolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Euro a Pesos: {nuevoEuroAPesos.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Pesos a Dolar: {nuevoPesoADolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Pesos a Euro: {nuevoPesoAEuro.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Dolar 1 = Dolar 2?: {dolarIgualDolar}");
            sb.AppendLine($"¿Dolar 1 = Euro 1?: {dolarIgualEuro}");
            sb.AppendLine($"¿Dolar 1 = Peso 2?: {dolarIgualPesos}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Euro 1 = Euro 2?: {euroIgualEuro}");
            sb.AppendLine($"¿Euro 1 = Dolar 2?: {euroIgualDolar}");
            sb.AppendLine($"¿Euro 2 = Pesos 3?: {euroIgualPesos}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Pesos 2 = Pesos 3?: {pesosIgualPesos}");
            sb.AppendLine($"¿Pesos 2 = Dolar 2?: {pesosIgualDolar}");
            sb.AppendLine($"¿Pesos 2 = Euro 1?: {pesosIgualEuro}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Dolar 2 != Nuevo Euro a Dolar?: {dolarDistintoDolar}");
            sb.AppendLine($"¿Dolar 2 != Nuevo Dolar a Euro?: {dolarDistintoEuro}");
            sb.AppendLine($"¿Dolar 2 != Nuevo Dolar a Pesos?: {dolarDistintoPesos}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Euro 2 != Nuevo Dolar a Euro?: {euroDistintoEuro}");
            sb.AppendLine($"¿Euro 2 != Nuevo Euro a Dolar?: {euroDistintoDolar}");
            sb.AppendLine($"¿Euro 2 != Nuevo Euro a Pesos?: {euroDistintoPesos}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"¿Pesos 2 != Nuevo Dolar a Pesos?: {pesosDistintoPesos}");
            sb.AppendLine($"¿Pesos 2 != Nuevo Peso a Dolar?: {dolarDistintoDolar}");
            sb.AppendLine($"¿Pesos 2 != Nuevo Peso a Euro?: {pesosDistintoEuro}");

            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}