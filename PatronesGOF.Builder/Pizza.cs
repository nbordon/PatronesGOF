using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Builder
{
    public class Pizza
    {
        // Atributos
        private Masa _masa;
        private Salsa _salsa;
        private Agregado _agregado;
        private string _tipo;

        // Constructores
        public Pizza(Masa masa, Salsa salsa, Agregado agregado, string tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _tipo = tipo;
        }

        // Métodos
        public override string ToString()
        {
            return $"{_tipo}, Masa: {_masa.Descripcion}, salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }
    }
}
