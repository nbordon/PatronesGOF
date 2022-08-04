using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public class PizzaMuzzaBuilder : PizzaBuilder
    {
        // Constructores
        public PizzaMuzzaBuilder()
        {
            _descripcion = "Pizza de muzzarella";
        }

        // Métodos
        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
