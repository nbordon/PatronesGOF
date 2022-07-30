using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Memento
{
    public class CareTaker
    {
        // Atributos
        private List<Memento> _mementos = new List<Memento>();

        // Métodos
        public void Add(Memento m)
        {
            _mementos.Add(m);
        }

        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
