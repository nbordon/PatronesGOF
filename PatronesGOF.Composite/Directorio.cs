using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Composite
{
    public class Directorio : Componente
    {
        // Atributos
        private List<Componente> _hijos;

        // Constructores
        public Directorio(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }

        // Propiedades
        public override int ObtenerTamanio
        {
            get
            {
                int t = 0;

                foreach (var item in _hijos)
                    t += item.ObtenerTamanio;

                return t;
            }
        }

        // Métodos
        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }
    }
}
