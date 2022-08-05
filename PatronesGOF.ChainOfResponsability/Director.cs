using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.ChainOfResponsability
{
    public class Director : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
        }
    }
}
