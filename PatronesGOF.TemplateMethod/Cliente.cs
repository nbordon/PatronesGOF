using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.TemplateMethod
{
    public class Cliente
    {
        // Atributos
        public string Nombre { get; set; }

        // Métodos
        public override string ToString()
        {
            return Nombre;
        }
    }
}
