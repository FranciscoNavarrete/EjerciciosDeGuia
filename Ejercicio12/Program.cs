using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";

            int num = 0;
            int acumNum = 0;

            
            do
            {
                Console.WriteLine("Ingrese un numero a Sumar: ");
                num = int.Parse(Console.ReadLine());
                acumNum = acumNum + num;
                
                Console.WriteLine("La suma es: {0}", acumNum);
                
                
                Console.WriteLine("Presione S para continuar o N para cerrar");
                char continuar = Console.ReadKey().KeyChar;
                if (continuar == 'n')
                {
                    break;
                }
                Console.Clear();
                if(!(continuar == 's' || continuar == 'S'))
                {
                    Console.WriteLine("ERROR. Reingresar número!!!");
                    Console.WriteLine("Presione bien la S para continuar o N para cerrar");
                    continuar = Console.ReadKey().KeyChar;
                    if (continuar == 'n') 
                    {
                        break;
                    }
                    Console.Clear();
                }
                
            } while (ValidarRespuesta.ValidaS_N() == true);
            Console.ReadKey();
        }
    }
}
