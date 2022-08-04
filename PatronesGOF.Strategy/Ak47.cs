using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Strategy
{
    public class Ak47 : Arma
    {
        public override string Disparar()
        {
            return "Disparando con una AK 47";
        }
    }
}
