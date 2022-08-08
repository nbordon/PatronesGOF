using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Mediator
{
    public abstract class Usuario
    {
        // Atributos
        private List<Mensaje> _mensaje;
        private string _nombre;
        public Chat Chat { get; set; }

        // Constructores
        public Usuario(string nombre)
        {
            _nombre = nombre;
            _mensaje = new List<Mensaje>();
        }

        // Atributos
        public Mensaje[] Mensajes
        {
            get
            {
                return _mensaje.ToArray();
            }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        // Métodos
        public override string ToString()
        {
            return _nombre;
        }

        public void Enviar(string _mensaje, Usuario _para)
        {
            Chat.Enviar(_mensaje, _para, this);
        }

        public void Recibir(Mensaje msg)
        {
            _mensaje.Add(msg);
        }
    }
}
