using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.FactoryMethod
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen)
        {
            _descripcion = "Pizza napolitana";
            _origen = origen;
        }
    }
}
