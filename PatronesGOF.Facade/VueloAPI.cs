using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Facade
{
    public class VueloAPI
    {
        // Métodos
        public void BuscarVuelos(string fechaEntrada, string fechaSalida, string origen, string destino)
        {
            Console.WriteLine($"Vuelos encontrados para {destino} desde {origen}");
            Console.WriteLine($"Fecha de ida: {fechaEntrada} - Fecha de vuelta: {fechaSalida}");
            Console.WriteLine("Vuelo 1");
            Console.WriteLine("Vuelo 2");
            Console.WriteLine("Vuelo 3");
            Console.WriteLine("==================================================");
        }
    }
}
