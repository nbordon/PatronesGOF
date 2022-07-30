using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Memento
{
    public class Persona
    {
        // Atributos
        public string Nombre { get; set; }

        // Métodos
        public Memento SaveToMemento()
        {
            Console.WriteLine($"Originator: Guardando memento para {Nombre}");
            return new Memento(Nombre);
        }

        public void RestoreToMemnto(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine($"Originator: Recuperando memento {Nombre}");
        }
    }
}
