using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Observer
{
    public class Producto : ISujetoProducto
    {
        // Atributos
        private List<IObserverUsuario> _usuarios;
        public string Nombre { get; set; }
        private double _precio;

        // Propiedades
        public double Precio
        {
            get { return _precio; }
            set
            {
                _precio = value;
                this.Notificar();
            }
        }
        
        // Constructores
        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            _precio = precio;
            Nombre = nombre;
        }

        // Métodos
        public override string ToString()
        {
            return $"{Nombre} (${_precio})";
        }
        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripcion para {((Usuario)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach(var usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }

            if(_usuarios.Count == 0)
            {
                Console.WriteLine("No hay suscripciones");
            }

            Console.WriteLine("------------------------------------------------------");
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripcion para {((Usuario)usuario)}");
            }
        }
    }
}
