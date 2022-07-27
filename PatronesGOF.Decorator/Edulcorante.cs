using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class Edulcorante : AgregadoDecorator
    {
        // Constructores
        public Edulcorante(BebidaComponent bebida) : base(bebida) { }

        // Propiedades
        public override double Costo => _bebida.Costo + 1;

        public override string Descripcion => $"{_bebida.Descripcion}, Edulcorante";
    }
}
