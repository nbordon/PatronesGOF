using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Visitor
{
    public abstract class Componente
    {
        // Atributos
        private string _serial;

        // Constructores
        public Componente(string serial)
        {
            _serial = serial;
        }

        // Propiedades
        public string Serial
        {
            get { return _serial; }
        }

        // Métodos
        public void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(_serial);
        }
    }
}
