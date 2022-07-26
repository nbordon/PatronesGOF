using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Prototype
{
    public class FiatPrototype : AutoPrototype
    {
        // Métodos
        public override AutoPrototype Clonar()
        {
            // MemberwiseClone de .NET devuelve una copia superficial del objeto
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat {_modelo} color {_color}";
        }
    }
}
