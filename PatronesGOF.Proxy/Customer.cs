using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Proxy
{
    public class Customer
    {
        // Atributos
        public string Name { get; set; }

        // Constructores
        public Customer(string name)
        {
            Name = name;
        }
    }
}
