using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            Console.WriteLine("Ingrese un numero");
            double num = double.Parse(Console.ReadLine());
            while (num == 0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("El numero es: {0}", num);
            Console.WriteLine("El cuadrado del Numero es: {0}",Math.Pow(2,num));
            Console.WriteLine("El cubo del Numero es: {0}", Math.Pow(3, num));

            Console.ReadKey();
        }
    }
}
