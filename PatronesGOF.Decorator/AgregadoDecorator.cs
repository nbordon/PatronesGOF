using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public abstract class AgregadoDecorator : BebidaComponent
    {
        // Atribútos
        protected BebidaComponent _bebida;

        // Constructores
        public AgregadoDecorator(BebidaComponent bebida)
        {
            _bebida = bebida;
        }
    }
}
