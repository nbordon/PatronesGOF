using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public class PizzaLightBuilder : PizzaBuilder
    {
        // Constructores
        public PizzaLightBuilder()
        {
            _descripcion = "Pizza Light";
        }

        // Métodos
        public override Agregado BuildAgregado()
        {
            return new Berenjenas();
        }

        public override Masa BuildMasa()
        {
            return new Integral();
        }

        public override Salsa BuildSalsa()
        {
            return new Light();
        }
    }
}
