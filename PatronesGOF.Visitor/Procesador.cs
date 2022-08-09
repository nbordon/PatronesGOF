using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Visitor
{
    public class Procesador : Componente
    {
        // Construcores
        public Procesador(string serial) : base(serial) { }
    }
}
