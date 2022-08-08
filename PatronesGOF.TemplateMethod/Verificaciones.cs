using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.TemplateMethod
{
    public abstract class Verificaciones
    {
        // Atributos
        protected Cliente _cliente;

        // Métodos
        public string[] Verificar()
        {
            var msg = new List<string>();
            msg.Add($"Verificando crédito para: {_cliente.Nombre}");
            msg.Add(VerificarAcciones());
            msg.Add(VerificarBalance());
            msg.Add(VerificarCreditos());
            msg.Add(VerificarIngresos());

            return msg.ToArray();
        }

        protected abstract string VerificarAcciones();
        protected abstract string VerificarBalance();
        protected abstract string VerificarIngresos();
        protected abstract string VerificarCreditos();
    }
}
