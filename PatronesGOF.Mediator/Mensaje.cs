using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Mediator
{
    public class Mensaje
    {
        // Atributos
        private DateTime _fecha;
        public Usuario De { get; set; }
        public Usuario Para { get; set; }
        public string Texto { get; set; }

        // Constructores
        public Mensaje()
        {
            _fecha = DateTime.Now;
        }

        // Atributos
        public DateTime Fecha { get { return _fecha; } }

        // Métodos
        public override string ToString()
        {
            return $"Mensaje a las {Fecha.ToShortTimeString()} de {De} para {Para} ---> {Texto}";
        }
    }
}
