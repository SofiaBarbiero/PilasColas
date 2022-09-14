using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionAppForm
{
    class Pila : ICollection
    {
        Stack<string> pilas = new Stack<string>();

        public bool estaVacia()
        {
            bool ok = true;
            if (pilas == null)
            {
                ok = false;
            }
            return ok;
        }

        public string extraer()
        {
            string primero = string.Empty;
            if (pilas != null)
            {
                primero = pilas.Pop();
            }
            return primero;
        }

        public string primero()
        {
            string primero = string.Empty;
            if (pilas != null)
            {
                primero = pilas.First();
            }
            return primero;
        }

        public bool añadir(string elemento)
        {
            bool ok = true;
            elemento = txtElemento.Text;
            if (pilas == null)
            {
                pilas.Push(elemento);
            }
            return ok;
        }
    }
}
