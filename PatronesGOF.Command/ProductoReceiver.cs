using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Command
{
    public class ProductoReceiver
    {
        // Atributos
        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        // Métodos
        public void RestarStock(double cantidad)
        {
            Cantidad -= cantidad;
            Console.WriteLine($"Quitando {cantidad} unidades");
        }

        public void SumarStock(double cantidad)
        {
            Cantidad += cantidad;
            Console.WriteLine($"Agregando {cantidad} unidades");
        }
    }
}
