using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_Nro_64
{
    internal class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes { get => this.filaClientes; }

        public void AtenderCliente()
        {
            foreach(var cliente in filaClientes)
            {
                Console.WriteLine($"Cliente: {cliente} | ID Task: {Task.CurrentId}");
                Thread.Sleep(2000);
            }
        }
    }
}
