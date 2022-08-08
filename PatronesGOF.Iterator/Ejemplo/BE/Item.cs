using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Iterator.Ejemplo.BE
{
    public class Item
    {
        // Atributos
        public string Nombre { get; set; }

        // Constructores
        public Item(string _nombre)
        {
            Nombre = _nombre;
        }

        // Métodos
        public override string ToString()
        {
            return Nombre;
        }
    }
}
