using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Strategy
{
    public class Jugador
    {
        // Atributos
        private Arma _estrategia;
        public string Nombre { get; set; }

        // Métodos
        public void CambiarEstrategia(Arma estrategia)
        {
            this._estrategia = estrategia;
        }

        public string Disparar()
        {
            if (_estrategia == null) return "Arma no disponible";
            return _estrategia.Disparar();
        }
    }
}
