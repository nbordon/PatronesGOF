using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Mediator
{
    public abstract class Chat
    {
        // Atributos
        protected List<Mensaje> _mensajes;

        // Constructores
        public Chat()
        {
            _mensajes = new List<Mensaje>();
        }

        // Propiedades
        public Mensaje[] Mensajes
        {
            get { return _mensajes.ToArray(); }
        }

        // Métodos
        public abstract void Enviar(string _mensaje, Usuario _para, Usuario _de);
        public abstract void Registrar(Usuario _usuario);
    }
}
