using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Composite
{
    public abstract class Componente
    {
        // Atributos
        public string Nombre { get; set; }
        
        // Constructores
        public Componente(string nombre)
        {
            Nombre = nombre;
        }

        // Métodos
        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerTamanio { get; }
    }
}
