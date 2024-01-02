/*
 *  Ejercicio Nro 64
 *  
 *  Crear un proyecto de tipo consola para simular la atención paralela de clientes en 2 cajas de un negocio.
 *  Para ello se pide crear las siguientes clases:
 *  
 *           ___________________________________________                     _______________________________________________
 *          |   Negocio                                 |                   |   Caja                                        |
 *          |     Fields                                |                   |     Fields                                    |
 *          |       (private) caja1 : Caja              |                   |       (private) filaClientes : List<string>   |
 *          |       (private) caja2 : Caja              |                   |     Properties                                |
 *          |       (private) clientes : List<string>   |                   |       FilaClientes { get; } : List<string>    |
 *          |     Properties                            |                   |     Methods                                   |
 *          |       Caja1 { get; } : Caja               |                   |       AtenderClientes() : void                |
 *          |       Caja2 { get; } : Caja               |                   |       Caja()                                  |
 *          |       Clientes { get; } : List<string>    |                   |_______________________________________________|
 *          |     Methods                               |
 *          |       AsignarCaja() : void                |
 *          |       Negocio(Caja c1, Caja c2)           |
 *          |___________________________________________|  
 *  
 *  
 *      Caja:
 *          a.	Tendrá como único atributo una lista de tipo String "filaClientes".
 *          b.	El constructor de la clase Caja deberá inicializar dicha lista.
 *          c.	El método AtenderClientes deberá recorrer la fila de clientes e ir imprimiendo el nombre 
 *              del cliente que se está atendiendo junto con el ID del Task de la caja (Task.CurrentId)
 *          d.	Por cada cliente que se atiende en cada caja se tardará 2 segundos.
 *          
 *      Negocio
 *          a.	Tendrá como atributos una lista de tipo String “clientes” y dos atributos de tipo Caja.
 *          b.	Crear propiedades de lectura para todos sus atributos.
 *          c.	El constructor recibirá por parámetro las dos cajas e inicializará la lista de clientes.
 *          d.	El método AsignarCaja deberá imprimir el mensaje "Asignando cajas..." cuando sea invocado, 
 *              recorrer la lista de clientes y asignar a cada cliente en la fila de la caja que menos clientes tenga en ese momento.
 *          e.	La asignación de cada cliente a una caja tardará 1 segundo.
 *     
 *      Main
 *          a.	Se deberá instanciar un negocio con 2 cajas y agregarle algunos clientes.
 *          b.	Crear un task para asignar las cajas a los clientes, uno para atender los clientes de la caja1 
 *              y otro para atender los clientes de la caja2.
 *          c.	Se deberán iniciar los 3 tasks uno a continuación del otro.
 *          d.	Utilizar el método Wait del objeto de la clase Task para asegurar que se hayan asignado 
 *              todos los clientes a alguna caja antes de comenzar a atender.
 *              
 */

namespace Ejericio_Nro_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio pagoFacil = new Negocio(new Caja(), new Caja());

            Task tareaDeAsignacion;
            Task caja1Atendiendo;
            Task caja2Atendiendo;

            Console.WriteLine("entran los clientes");
            //agregro los clientes a la lista del negocio
            pagoFacil.Clientes.Add("Pepe");
            pagoFacil.Clientes.Add("Gonza");
            pagoFacil.Clientes.Add("Lomito");
            pagoFacil.Clientes.Add("Racing");
            pagoFacil.Clientes.Add("Salmuera");
            pagoFacil.Clientes.Add("Ricardo");
            pagoFacil.Clientes.Add("Aldana");
            pagoFacil.Clientes.Add("Raul");
            pagoFacil.Clientes.Add("Flor");
            pagoFacil.Clientes.Add("Menta");
            pagoFacil.Clientes.Add("Tuki");
            pagoFacil.Clientes.Add("Meli");
            //asigno los clientes a cada una de las cajas, y espero a que esta acción finalize
            tareaDeAsignacion = Task.Run( () => pagoFacil.AsignarCaja() );
            tareaDeAsignacion.Wait();
            //abro la atencion de las cajas al mismo tiempo
            caja1Atendiendo = Task.Run( () => pagoFacil.Caja1.AtenderCliente() );   
            caja2Atendiendo = Task.Run( () => pagoFacil.Caja2.AtenderCliente() );
            //declaro esperar a que cada una de las cajas finalice
            caja1Atendiendo.Wait();
            caja2Atendiendo.Wait();

        }
    }
}