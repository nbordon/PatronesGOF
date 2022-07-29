using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Command
{
    public abstract class OrdenCommand
    {
        // Atributos
        protected ProductoReceiver _producto;
        protected double _cantidad;

        // Constructores
        public OrdenCommand(ProductoReceiver producto, double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }

        // Métodos
        public abstract void Ejecutar();
    }
}
