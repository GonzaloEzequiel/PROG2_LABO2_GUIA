namespace BibliotecaDeClases
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {


        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            string aux = "Texto Leído";
            return (V)Convert.ChangeType(aux, typeof(V));
        }
    }
}