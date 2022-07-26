using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckFacade checkFacade = new CheckFacade();

            checkFacade.Buscar("10/01/2023", "25/01/2023", "Buenos Aires", "Findlandia");

            Console.ReadKey();
        }
    }
}
