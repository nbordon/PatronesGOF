using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.TemplateMethod
{
    public class CreditoHipotecario : Credito
    {
        // Cosntructores
        public CreditoHipotecario(Cliente cliente) : base(cliente) { }

        // Métodos
        protected override string VerificarAcciones()
        {
            return "Verificando acciones para asignar un crédito hipotecario";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balance bancario para asignar un crédito hipotecario";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando otros créditos para asignar un crédito hipotecario";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos para asignar un crédito hipotecario";
        }
    }
}
