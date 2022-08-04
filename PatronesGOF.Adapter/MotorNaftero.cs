using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Adapter
{
    public class MotorNaftero : Motor
    {
        // Métodos
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor naftero...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor naftero...");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustrible al motor naftero...");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor naftero...");
        }
    }
}
