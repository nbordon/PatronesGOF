using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitante = new VisitanteConcreto();
            IVisitor visitante2 = new VisitanteConcreto2();

            Componente dr = new DiscoRigido("4658162165-DR");
            Componente pb = new PlacaBase("16516SAD498-PB");
            Componente pr = new Procesador("494898491979-PR");

            dr.Aceptar(visitante);
            pb.Aceptar(visitante);
            pr.Aceptar(visitante);

            dr.Aceptar(visitante2);
            pb.Aceptar(visitante2);
            pr.Aceptar(visitante2);

            Console.ReadKey();
        }
    }
}
