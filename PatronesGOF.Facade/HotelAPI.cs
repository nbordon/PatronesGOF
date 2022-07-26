using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Facade
{
    public class HotelAPI
    {
        // Métodos
        public void BuscarHoteles(string fechaEntrada, string fechaSalida, string origen, string destino)
        {
            Console.WriteLine("Hoteles encontrados:");
            Console.WriteLine($"Entrada: {fechaEntrada} - Salida: {fechaSalida}");
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("==================================================");
        }
    }
}
