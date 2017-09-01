using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";
            int a;
            Console.WriteLine("Ingresa año");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
            {
                Console.WriteLine("El año " + a + " Si es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año " + a + " No es bisiesto ");
            }
            Console.ReadLine();
        }
    }
}
