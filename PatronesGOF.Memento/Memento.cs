using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Memento
{
    public class Memento
    {
        // Atributos
        private string _estado;

        // Constructores
        public Memento()
        {

        }

        public Memento(string estado)
        {
            this._estado = estado;
        }

        // Propiedades
        public string Estado { get => _estado;}
    }
}
