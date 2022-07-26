using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Prototype
{
    public class DSPrototype : AutoPrototype
    {
        // Métodos
        public override AutoPrototype Clonar()
        {
            return (DSPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"DS {_modelo} color {_color}";
        }
    }
}
