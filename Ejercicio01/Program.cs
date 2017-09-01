using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int[] val = new int[5];
            int max = 0;
            int min = 0;
            float prom = 0;
            float aux = 0;
            
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Ingrese un numero {0}º",i+1);
                val[i] = int.Parse(Console.ReadLine());
            //Maximo
                if (max < val[i] || max == 0)
                    max = val[i];

            //Minimo
                if (min > val[i] || min == 0)
                    min = val[i];

               //Promedio
                
                aux = aux + val[i];
                prom = aux / 5;

            }
            Console.Clear();
            Console.WriteLine("Mayor numero: {0}",max);
            Console.WriteLine("Menor numero: {0}", min);
            Console.WriteLine("Promedio: {0}", prom);
            
            Console.ReadKey();


            
        }
    }
}
