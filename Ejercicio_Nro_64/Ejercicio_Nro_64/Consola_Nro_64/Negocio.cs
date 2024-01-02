using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_Nro_64
{
    internal class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public Caja Caja1 { get => this.caja1; }
        public Caja Caja2 { get => this.caja2; }
        public List<string> Clientes { get => this.clientes; }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");

            foreach (var cliente in this.clientes)
            {
                if (this.caja1.FilaClientes.Count <= this.caja2.FilaClientes.Count)
                {
                    this.caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    this.caja2.FilaClientes.Add(cliente);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
