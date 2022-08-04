using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Strategy
{
    public class AireComprimido : Arma
    {
        public override string Disparar()
        {
            return "Disparando con un rifle de aire comprimido";
        }
    }
}
