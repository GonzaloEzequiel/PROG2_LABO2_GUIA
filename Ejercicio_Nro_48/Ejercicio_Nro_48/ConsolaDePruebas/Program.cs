using BibliotecaDeClases;
namespace ConsolaDePruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Factura item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Recibo item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }

            Console.WriteLine("Bye World!");
        }
    }
}