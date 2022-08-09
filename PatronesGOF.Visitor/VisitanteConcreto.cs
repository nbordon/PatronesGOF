using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Visitor
{
    public class VisitanteConcreto : IVisitor
    {
        // Métodos
        public void Visitar(string serie)
        {
            Console.WriteLine($"S/N {serie}");
        }
    }
    
    public class VisitanteConcreto2 : IVisitor
    {
        // Métodos
        public void Visitar(string serie)
        {
            Console.WriteLine($"El numero de serie es {serie}");
        }
    }
}
