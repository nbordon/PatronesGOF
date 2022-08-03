using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos los productos
            Producto pa = new Producto("Producto a", 120);
            Producto pb = new Producto("Producto b", 95);
            Producto pc = new Producto("Producto c", 230);

            Console.WriteLine("Estado original de los productos");
            Console.WriteLine(pa);
            Console.WriteLine(pb);
            Console.WriteLine(pc);

            // Instancio a los usuarios
            Usuario u1 = new Usuario("Pepe", "Garcia");
            Usuario u2 = new Usuario("Juan", "Perez");
            Usuario u3 = new Usuario("Marcos", "Alonso");

            // Suscribo 2 usuarios al producto a y 2 al producto b
            Console.WriteLine($"Suscriobo a {u1.Nombre} al producto {pa.Nombre}");
            pa.Agregar(u1);
            Console.WriteLine($"Suscriobo a {u2.Nombre} al producto {pa.Nombre}");
            pa.Agregar(u2);
            Console.WriteLine($"Suscriobo a {u3.Nombre} al producto {pb.Nombre}");
            pb.Agregar(u3);

            // Cambio el precio de los productos
            Console.WriteLine($"Cambio el precio a {pa.Nombre} de {pa.Precio} a $200");
            pa.Precio = 200;

            Console.WriteLine($"Cambio el precio a {pb.Nombre} de {pb.Precio} a $60");
            pb.Precio = 60;

            Console.WriteLine($"Cambio el precio a {pc.Nombre} de {pc.Precio} a $115");
            pc.Precio = 115;

            // Elimino una suscripcion a un producto y cambio su precio
            Console.WriteLine($"Desuscribo a {u1.Nombre} del producto {pa.Nombre}");
            pa.Quitar(u1);
            Console.WriteLine($"Cambio el precio a {pa.Nombre} de {pa.Precio} a $185");
            pa.Precio = 185;

            Console.ReadKey();
        }
    }
}
