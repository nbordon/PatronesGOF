using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.ChainOfResponsability
{
    public class Gerente : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe <= 1000)
                Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
            else
                _siguiente.Procesar(c);
        }
    }
}
