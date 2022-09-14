using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAppForm
{
    internal class Cola : ICollection
    {
        Queue<string> colas = new Queue<string>();

        public bool estaVacia()
        {
            bool ok = true;
            if (colas == null)
            {
                ok = false;
            }
            return ok;
        }

        public string extraer()
        {
            string primero = colas.First();
            if (colas != null)
            {
                primero = colas.Dequeue();
            }
            return primero;

        }

        public string primero()
        {
            string primero = string.Empty;

            if (colas != null)
            {
                primero = colas.First();

            }
            return primero;
        }


        public bool añadir()
        {
            bool ok = true;

            colas.Enqueue("perro");
            if (colas != null)
            {
                colas.Enqueue("perro");
                return ok;
            }
            else
                return false;
        }
    }
}
