using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public abstract class BebidaComponent
    {
        // Propiedades
        public abstract double Costo { get; }
        public abstract string Descripcion { get; }
    }
}
