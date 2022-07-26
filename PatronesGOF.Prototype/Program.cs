using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo 3 instancias prototípicas
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoDS = new DSPrototype();
            AutoPrototype prototipoAlfa = new AlfaRomeoPrototype();

            // Instancio los objetos desde el prototipo y asigno el estado
            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "Blanco";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "Negro";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype ds3 = prototipoDS.Clonar();
            ds3.Modelo = "3 Chic";
            ds3.Color = "Blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype ds4 = prototipoDS.Clonar();
            ds4.Modelo = "4 Sport";
            ds4.Color = "Negro";
            Console.WriteLine(ds4.VerAuto());

            AutoPrototype alfa145 = prototipoAlfa.Clonar();
            alfa145.Modelo = "145";
            alfa145.Color = "Blanco";
            Console.WriteLine(alfa145.VerAuto());

            AutoPrototype alfa146 = prototipoAlfa.Clonar();
            alfa146.Modelo = "146";
            alfa146.Color = "Negro";
            Console.WriteLine(alfa146.VerAuto());

            Console.ReadKey();
        }
    }
}
