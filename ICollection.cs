using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAppForm
{
    internal interface ICollection
    {
        bool estaVacia();
        string extraer();
        string primero();
        bool añadir();
    }
}
