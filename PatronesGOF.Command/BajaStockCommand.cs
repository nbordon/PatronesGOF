using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Command
{
    public class BajaStockCommand : OrdenCommand
    {

        // Constructores
        public BajaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad) { }

        // Métodos
        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
