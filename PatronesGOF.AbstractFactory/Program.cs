using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            Pizza pizza;
            Empanada empanada;

            pizzeria = new PizzeriaArgentina();
            pizza = pizzeria.CrearPizza();
            Console.WriteLine($"Pizza: {pizza.Descripcion}");
            empanada = pizzeria.CrearEmpanada();
            Console.WriteLine(empanada.Descripcion);

            pizzeria = new PizzeriaItaliana();
            pizza = pizzeria.CrearPizza();
            Console.WriteLine($"Pizza: {pizza.Descripcion}");
            empanada = pizzeria.CrearEmpanada();
            Console.WriteLine(empanada.Descripcion);

            pizzeria = new PizzeriaChina();
            pizza = pizzeria.CrearPizza();
            Console.WriteLine($"Pizza: {pizza.Descripcion}");
            empanada = pizzeria.CrearEmpanada();
            Console.WriteLine(empanada.Descripcion);

            Console.ReadKey();
        }
    }
}
