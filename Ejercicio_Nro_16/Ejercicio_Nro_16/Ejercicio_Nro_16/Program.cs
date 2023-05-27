/*
 *  Ejercicio Nro 16.	
 *  
 *  Crear la clase Alumno de acuerdo al siguiente diagrama:
 *  
 *       -------------------------------------------------------  
 *      |   Alumno                                              |
 *      |     Fields                                            |
 *      |       (private) nota1 : byte                          |
 *      |       (private) nota2 : byte                          |
 *      |       (private) notafinal : float                     |
 *      |       apellido : string                               |
 *      |       legajo : int                                    |
 *      |       nombre : string                                 |
 *      |     Methods                                           |
 *      |       CalcularFinal() : void                          |
 *      |       Estudiar(byte notaUno, byte notaDos) : void     |
 *      |       Mostrar() : string                              |
 *      |_______________________________________________________|    
 *  
 *      a.	Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle nombre, apellido y legajo a cada uno de ellos.
 *      b.	Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
 *      c.	El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4, caso contrario la inicializará con -1. 
 *          Para darle un valor a la nota final utiliceel método de instancia Next de la clase Random.
 *      d.	El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se mostrará sólo si es distinto de -1, 
 *          caso contrario se mostrará la leyenda "Alumno desaprobado".
 *      
 */

using Biblioteca_Nro_16;

namespace Ejercicio_Nro_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno alumno1 = new Alumno("Gonzalo", "Ezequiel", 20220301);
            Alumno alumno2 = new Alumno("Florencia", "Agustina", 20220302);
            Alumno alumno3 = new Alumno("Alumno", "Ficticio", 20220305);

            alumno1.Estudiar(10, 8);

            alumno2.Estudiar(4, 9);

            alumno3.Estudiar(3, 7);

            Console.WriteLine("  Nombre     Apellido       Legajo       1°Parcial       2°Parcial        Final  ");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}