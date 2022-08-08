using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Iterator.Ejemplo.BE
{
    public class ConcreteCollection : Collection
    {
        // Atributos
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion;

        // Métodos
        public override IteratorEjemplo CrearIterator()
        {
            return new ConcreteIteratorEjemplo(this);
        }

        public override void Agregar(Item _item)
        {
            _listaItems.Add(_item);
        }

        public override Item Index(int _index)
        {
            _item = _listaItems[_index];
            _posicion = _index;
            return _item;
        }

        public override int Count()
        {
            return _listaItems.Count;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}
