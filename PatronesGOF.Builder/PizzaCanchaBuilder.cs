using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public class PizzaCanchaBuilder : PizzaBuilder
    {
        // Constructores
        public PizzaCanchaBuilder()
        {
            _descripcion = "Pizza de cancha";
        }

        // Métodos
        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new Integral();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }
    }
}
