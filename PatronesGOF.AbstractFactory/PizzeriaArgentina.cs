using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.AbstractFactory
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaDeCarne();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaCancha();
        }
    }
}
