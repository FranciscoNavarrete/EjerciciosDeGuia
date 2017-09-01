using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int a;
            int espacios;
            int nivel=0;
            Console.WriteLine("Ingrese la altura de la piramide");
            nivel = int.Parse(Console.ReadLine());

            Console.Clear();
                for (int i = 1; i <= nivel; i++)
                {
                    StringBuilder final = new StringBuilder();

                    espacios = nivel - i;
                    a = i + (i - 1);
                    for (int i1 = 0; i1 < espacios; i1++)
                        final.Append(" ");

                    for (int i2 = 0; i2 < a; i2++)
                        final.Append("*");

                    Console.WriteLine(final.ToString());
                }
                
                Console.WriteLine("\nLa altura es de: {0}", nivel);
            
            Console.ReadKey();

        }
    }
}
