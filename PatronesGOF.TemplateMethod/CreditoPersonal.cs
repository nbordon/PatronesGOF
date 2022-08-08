using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.TemplateMethod
{
    public class CreditoPersonal : Credito
    {
        // Cosntructores
        public CreditoPersonal(Cliente cliente) : base(cliente) { }

        // Métodos
        protected override string VerificarAcciones()
        {
            return "No es requerido verificar acciones para asignar un prestamo personal";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balance bancario para asignar un prestamo personal";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando otros créditos para asignar un prestamo personal";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos para asignar un prestamos personal";
        }
    }
}
