using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Adapter
{
    public class MotorDiesel : Motor
    {
        // Métodos
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor diesel...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor diesel...");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustrible al motor diesel...");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor diesel...");
        }
    }
}
