using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Command
{
    public class AltaStockCommand : OrdenCommand
    {
        // Constructores
        public AltaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad) { }

        // Métodos
        public override void Ejecutar()
        {
            _producto.SumarStock(_cantidad);
        }
    }
}
