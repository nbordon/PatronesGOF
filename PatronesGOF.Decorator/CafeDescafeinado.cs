using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class CafeDescafeinado : BebidaComponent
    {
        // Propiedades
        public override double Costo => 15;
        public override string Descripcion => "Café descafeinado";
    }
}
