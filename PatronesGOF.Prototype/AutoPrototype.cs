using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Prototype
{
    public abstract class AutoPrototype
    {
        // Atributos
        protected string _color;
        protected string _modelo;

        // Propiedades
        public string Color { set => _color = value; }
        public string Modelo { set => _modelo = value; }

        // Métodos
        public abstract AutoPrototype Clonar();
        public abstract string VerAuto();
    }
}
