using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int[] num = new int[3];
            float prom = 0;
            float aux = 0;
            int max = 0;
            int min = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese un numero");
                num[i] = int.Parse(Console.ReadLine());
                if (Validacion.Validar(-100, 100, num[i]) == true)
                {
                    Console.WriteLine("El numero es valido");
                }
                else
                {
                    Console.WriteLine("El numero no es valido");
                    Console.WriteLine("Ingrese un numero");
                    num[i] = int.Parse(Console.ReadLine());
                }
                    //Console.Clear();

                if (max < num[i] || max == 0)
                    max = num[i];

                //Minimo
                if (min > num[i] || min == 0)
                    min = num[i];

                //Promedio

                aux = aux + num[i];
                prom = aux / 3;
            }
            Console.Clear();
            Console.WriteLine("Mayor numero: {0}", max);
            Console.WriteLine("Menor numero: {0}", min);
            Console.WriteLine("Promedio: {0}", prom);
           
           
            

            

            Console.ReadKey();
        }
    }
}
