using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class CafeSolo : BebidaComponent
    {
        // Propiedades
        public override double Costo => 10;
        public override string Descripcion => "Café solo";
    }
}
