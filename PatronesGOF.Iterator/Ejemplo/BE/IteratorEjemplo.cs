using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Iterator.Ejemplo.BE
{
    public abstract class IteratorEjemplo
    {
        // Métodos
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}
