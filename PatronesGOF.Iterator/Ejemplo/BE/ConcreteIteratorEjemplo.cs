using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Iterator.Ejemplo.BE
{
    public class ConcreteIteratorEjemplo : IteratorEjemplo
    {
        // Atributos
        private Collection _aggregate = new ConcreteCollection();
        private Item _item;

        // Constructores
        public ConcreteIteratorEjemplo(Collection _agregado)
        {
            _aggregate = _agregado;
        }

        // Métodos
        public override Item CurrentItem()
        {
            return _item;
        }

        public override void First()
        {
            _item = _aggregate.Index(0);
        }

        public override bool IsDone()
        {
            return _aggregate.Count() == _aggregate.Posicion() + 1;
        }

        public override void Siguiente()
        {
            _item = _aggregate.Index(_aggregate.Posicion() + 1);
        }
    }
}
