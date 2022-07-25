using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.AbstractFactory
{
    public class PizzeriaChina : Pizzeria
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaDeCeviche();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaSushi();
        }
    }
}
