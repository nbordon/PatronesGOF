using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public abstract class Salsa
    {
        // Atributos
        protected string _descripcion;

        // Propiedades
        public string Descripcion { get { return _descripcion; } }
    }

    public class Tomate : Salsa
    {
        // Constructores
        public Tomate()
        {
            _descripcion = "Salsa de tomate clásica";
        }
    }

    public class Oliva : Salsa
    {
        // Constructores
        public Oliva()
        {
            _descripcion = "Salsa de tomate a la oliva";
        }
    }

    public class Light : Salsa
    {
        // Constructores
        public Light()
        {
            _descripcion = "Salsa sin condimentos ni sal";
        }
    }
}
