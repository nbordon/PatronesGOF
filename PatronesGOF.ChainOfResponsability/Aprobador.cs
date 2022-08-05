using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.ChainOfResponsability
{
    public abstract class Aprobador
    {
        // Atributos
        protected Aprobador _siguiente;

        // Constructores
        public void AgregarSiguiente(Aprobador aprobador)
        {
            _siguiente = aprobador;
        }

        // Métodos
        public abstract void Procesar(Compra c);
    }
}
