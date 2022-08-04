using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        // Atributos
        MotorElectrico motorElectrico = new MotorElectrico();

        // Métodos
        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }

        public override void CargarCombustible()
        {
            motorElectrico.Enchufar();
        }

        public override void Detener()
        {
            motorElectrico.Desactivar();
            motorElectrico.Parar();
        }
    }
}
