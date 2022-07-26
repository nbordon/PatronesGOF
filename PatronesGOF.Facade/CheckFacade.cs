using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Facade
{
    public class CheckFacade
    {
        // Atributos
        private HotelAPI hotelAPI;
        private VueloAPI vueloAPI;

        // Constructores
        public CheckFacade()
        {
            hotelAPI = new HotelAPI();
            vueloAPI = new VueloAPI();
        }

        // Métodos
        public void Buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            hotelAPI.BuscarHoteles(fechaIda, fechaVuelta, origen, destino);
            vueloAPI.BuscarVuelos(fechaIda, fechaVuelta, origen, destino);
        }
    }
}
