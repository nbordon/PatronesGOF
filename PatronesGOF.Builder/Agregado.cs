using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public abstract class Agregado
    {
        // Atributos
        protected string _descripcion;

        // Propiedades
        public string Descripcion { get { return _descripcion; } }
    }

    public class Oregano : Agregado
    {
        // Constructores
        public Oregano()
        {
            _descripcion = "Orégano fresco";
        }
    }

    public class Anchoas : Agregado
    {
        // Constructores
        public Anchoas()
        {
            _descripcion = "Anchoas en aceite";
        }
    }

    public class Berenjenas : Agregado
    {
        // Constructores
        public Berenjenas()
        {
            _descripcion = "Berenjenas sin calorías";
        }
    }
}
