using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.FactoryMethod
{
    public class Pizza
    {
        protected string _descripcion;
        protected string _origen;

        public void Render()
        {
            Console.WriteLine($"Pizza de {_descripcion} hecha en {_origen}");
        }
    }
}
