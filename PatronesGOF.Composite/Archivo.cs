using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Composite
{
    public class Archivo : Componente
    {
        // Atributos
        private int _tamanio;

        // Constructores
        public Archivo(string nombre, int tamanio):base(nombre)
        {
            _tamanio = tamanio;
        }

        // Propiedades
        public override int ObtenerTamanio => _tamanio;

        // Métodos
        public override void AgregarHijo(Componente c)
        {
            
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }
    }
}
