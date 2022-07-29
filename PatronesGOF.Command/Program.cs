using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();
            var producto = new ProductoReceiver();

            producto.Cantidad = 100;

            var ordenAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenAlta);

            var ordenBaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenBaja);

            var ordenBaja2 = new BajaStockCommand(producto, 5);
            empresa.TomarOrden(ordenBaja2);
            var ordenBaja3 = new BajaStockCommand(producto, 15);
            empresa.TomarOrden(ordenBaja3);

            var ordenAlta2 = new AltaStockCommand(producto, 100);
            empresa.TomarOrden(ordenAlta2);
            var ordenAlta3 = new AltaStockCommand(producto, 100);
            empresa.TomarOrden(ordenAlta3);

            empresa.ProcesarOrdenes();

            Console.WriteLine($"Total de stock es {producto.Cantidad}");

            Console.ReadKey();
        }
    }
}
