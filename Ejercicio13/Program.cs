using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            Console.WriteLine("Ingrese un número decimal positivo");
            double numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número binario");
            string binario = Console.ReadLine();

            Console.WriteLine("el binario {0} en decimal es {1}", binario, Conversor.BinarioDecimal(binario));
            Console.WriteLine("el Decimal {0} en binario es {1}", numero, Conversor.DecimalBinario(numero));
            Console.ReadKey();
            
        }
    }
}
