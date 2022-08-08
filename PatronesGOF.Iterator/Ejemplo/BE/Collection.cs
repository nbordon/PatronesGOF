using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Iterator.Ejemplo.BE
{
    public abstract class Collection
    {
        // Métodos
        public abstract IteratorEjemplo CrearIterator();
        public abstract void Agregar(Item _item);
        public abstract Item Index(int _index);
        public abstract int Count();
        public abstract int Posicion();
    }
}
