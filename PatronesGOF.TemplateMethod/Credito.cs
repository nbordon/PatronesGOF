using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.TemplateMethod
{
    public abstract class Credito : Verificaciones
    {
        // Constructores
        public Credito(Cliente c)
        {
            _cliente = c;
        }

        // Métodos
        protected abstract override string VerificarAcciones();
        protected abstract override string VerificarBalance();
        protected abstract override string VerificarIngresos();
        protected abstract override string VerificarCreditos();
    }
}
