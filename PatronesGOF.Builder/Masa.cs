using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public abstract class Masa
    {
        // Atributos
        protected string _descripcion;

        // Propiedades
        public string Descripcion { get { return _descripcion; }}
    }

    public class AlMolde : Masa
    {
        // Constructores
        public AlMolde()
        {
            _descripcion = "Masa al molde";
        }
    }

    public class ALaPiedra : Masa
    {
        // Constructores
        public ALaPiedra()
        {
            _descripcion = "Masa a la piedra de horno de leña";
        }
    }

    public class Integral : Masa
    {
        // Constructores
        public Integral()
        {
            _descripcion = "Masa de harina integral";
        }
    }
}
