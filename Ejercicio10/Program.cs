using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            int tamanio = 0;
            char continuar;

            do
            {
                Console.Clear();
                Console.Write("Ingrese el tamaño de la pirámide: ");
                if (int.TryParse(Console.ReadLine(), out tamanio))
                {
                    tamanio = tamanio * 2;
                    Console.WriteLine("===========EJERCICIO 09===========");
                    for (int i = tamanio; i >= 0; i--)
                    {
                        if (((tamanio - i) % 2) != 0)
                        {
                            // Recorro el ancho del piso de la pirámide
                            for (int j = 0; j < tamanio - i; j++)
                            {
                                Console.Write("*");
                            }
                            // Salto de línea
                            Console.WriteLine();
                        }
                    }
                }
                else
                    Console.WriteLine("Valor ingresado inválido!");

                Console.WriteLine("Presione s para continuar");
                continuar = Console.ReadKey().KeyChar;
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
