using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Observer
{
    public interface IObserverUsuario
    {
        // Métodos
        void Actualizar(Producto producto);
    }
}
