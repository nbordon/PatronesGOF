using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.State
{
    public class Program
    {
        static void Main(string[] args)
        {
            Switch _sw = new Switch();

            _sw.Presionar();
            _sw.Presionar();
            _sw.Presionar();
            _sw.Presionar();
            _sw.Presionar();
            _sw.Presionar();

            Console.ReadKey();
        }
    }
}
