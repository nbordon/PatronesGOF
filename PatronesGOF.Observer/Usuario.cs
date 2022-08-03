using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Observer
{
    public class Usuario : IObserverUsuario
    {
        // Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructores
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        // Métodos
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public void Actualizar(Producto producto)
        {
            Console.WriteLine($"El usuario {this} recibio la notificación del producto {producto}");
        }
    }
}
