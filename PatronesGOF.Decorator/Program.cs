using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafe = new CafeSolo();
            //cafe = new Leche(cafe);
            cafe = new Crema(cafe);
            cafe = new Azucar(cafe);
            cafe = new Azucar(cafe);

            Console.WriteLine($"Producto: {cafe.Descripcion} tiene un costo de ${cafe.Costo}");

            Console.ReadKey();
        }
    }
}
