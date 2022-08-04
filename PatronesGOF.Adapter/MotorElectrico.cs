using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Adapter
{
    public class MotorElectrico
    {
        // Atributos
        private bool _conectado;
        private bool _activo;
        private bool _moviendo;

        // Métodos
        public void Conectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Imposible conectar un motor ya conectado!");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("Motor conectado!");
            }
        }

        public void Activar()
        {
            if (!_conectado)
                Console.WriteLine("Imposible activar un motor no conectado!");
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado!");
            }
        }

        public void Mover()
        {
            if(_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehículo con motor electrico...");
            }
            else
            {
                Console.WriteLine("El motor deberá estar conectado y activo!");
            }
        }

        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehículo con motor eléctrico...");
            }
            else
            {
                Console.WriteLine("Imposible para un motor que no esté en movimiento!");
            }
        }

        public void Desconectar()
        {
            if (_conectado)
            {
                _conectado = false;
                Console.WriteLine("Motor desconectado...");
            }
            else
            {
                Console.WriteLine("El motor ya se encuentra desconectado!");
            }
        }

        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Desactivando motor eléctrico...");
            }
            else
            {
                Console.WriteLine("Imposible desactivar un motor que no está activo!");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando las baterías...");
            }
            else
            {
                Console.WriteLine("Imposible enchufar un motor activo!");
            }
        }
    }
}
