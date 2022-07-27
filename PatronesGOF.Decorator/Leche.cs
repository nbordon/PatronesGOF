using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class Leche : AgregadoDecorator
    {
        // Constructores
        public Leche(BebidaComponent bebida) : base(bebida) { }

        // Propiedades
        public override double Costo => _bebida.Costo + 2;

        public override string Descripcion => $"{_bebida.Descripcion}, Leche";
    }
}
