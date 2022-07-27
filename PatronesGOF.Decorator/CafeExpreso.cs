using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class CafeExpreso : BebidaComponent
    {
        // Propiedades
        public override double Costo => 12;
        public override string Descripcion => "Café expreso";
    }
}
