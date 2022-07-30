using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Memento
{
    public class Program
    {
        // Atributos
        static CareTaker careTaker = new CareTaker();

        // Métodos
        static void Main(string[] args)
        {
            var p = new Persona();
            p.Nombre = "Pepe";
            careTaker.Add(p.SaveToMemento());
            p.Nombre = "Pepe1";
            careTaker.Add(p.SaveToMemento());
            p.Nombre = "Pepe2";
            careTaker.Add(p.SaveToMemento());

            Memento m1 = careTaker.GetMemento(0);
            Console.WriteLine($"Viendo memento 1: {m1.Estado}");
            Console.WriteLine($"Viendo memento 2: {careTaker.GetMemento(1).Estado}");
            Console.WriteLine($"Viendo memento 3: {careTaker.GetMemento(2).Estado}");

            p.RestoreToMemnto(m1);

            Console.ReadKey();
        }
    }
}
