using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.State
{
    public class Switch
    {
        // Atributos
        private Estado _estado;

        // Constructores
        public Switch()
        {
            _estado = new Encendido();
        }

        // Métodos
        public void DefinirEstado(Estado estado)
        {
            _estado = estado;
        }

        public void Presionar()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Describir());
        }
    }
}
