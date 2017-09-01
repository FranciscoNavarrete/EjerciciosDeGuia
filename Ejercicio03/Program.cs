using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            Console.WriteLine("Ingrese un numero");
            double num = double.Parse(Console.ReadLine());
            while (num == 0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            
            int cont = 0; 
            for (int i = 2; i <= num; i++)
            {  
                for (int j = 1; j <= i; j++)
                {   
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }     
                cont = 0;             
            }
            Console.ReadKey();
        }
    }
}
