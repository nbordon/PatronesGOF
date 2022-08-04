using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Strategy
{
    public class Pistola : Arma
    {
        // Métodos
        public override string Disparar()
        {
            return "Disparando con la pistola";
        }
    }
}
