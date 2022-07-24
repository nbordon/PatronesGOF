using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.FactoryMethod
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza(string tipo);
    }
}
