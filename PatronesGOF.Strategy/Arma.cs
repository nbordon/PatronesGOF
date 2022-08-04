using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Strategy
{
    public abstract class Arma
    {
        // Métodos
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public abstract string Disparar();
    }
}
