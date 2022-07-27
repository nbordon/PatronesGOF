using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class Crema : AgregadoDecorator
    {
        // Constructores
        public Crema(BebidaComponent bebida) : base(bebida) { }

        // Propiedades
        public override double Costo => _bebida.Costo + 4;

        public override string Descripcion => $"{_bebida.Descripcion}, Crema";
    }
}
