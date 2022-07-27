using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class TeTradicional : BebidaComponent
    {
        // Propiedades
        public override double Costo => 8;
        public override string Descripcion => "Té tradicional";
    }
}
