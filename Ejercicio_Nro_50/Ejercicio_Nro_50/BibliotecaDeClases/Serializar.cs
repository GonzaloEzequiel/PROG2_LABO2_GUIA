using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Serializar<S,V> : IGuardar<S,V>
    {


        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string aux = "Objeto Leído";
            return (V)Convert.ChangeType(aux, typeof(V));
        }
    }
}
