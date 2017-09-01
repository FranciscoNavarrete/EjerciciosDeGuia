using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {   char continuar;
            do
            {

                float  primero;    
                float  segundo;     
                string operacion;   

                Console.Title = "Ejercicio 15"; 
                Console.Clear();

                Console.WriteLine ("Introduzca el primer  número");
                primero = float.Parse(Console.ReadLine());
               
                Console.WriteLine ("Introduzca la operación a realizar (+,-,*,/)");
                operacion = Console.ReadLine();
               
                Console.WriteLine ("Introduzca el segundo número");
                segundo = float.Parse(Console.ReadLine());
               
                Console.WriteLine ("El resultado es");
                Console.WriteLine (Calculadora.Calcular(primero,segundo,operacion));


                Console.ReadKey ();

                Console.WriteLine("Presione s para continuar");
                continuar = Console.ReadKey().KeyChar;
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
