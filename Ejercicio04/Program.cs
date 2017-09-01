using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int []p = new int[11];
            int b=0;
            int a ;
            String cad="";
            for (int i = 2; i < 702; i++)
            {
             a = 0;
                for (int j = 1; j < (i + 2); j++)
                {
                 if (i % j == 0)
                    {
                         a = a + j;
                        if ((a - i) == i)
                        {
                            p[b] = i;
                            b++;
                        }
                    }
                }
             }
            for (int x = 0; x < b; x++)
            {
                cad = cad + " " + p[x] + " Es un numero perfecto\n";
            }
         Console.WriteLine(cad);
         Console.ReadLine();
        }
        
    }
}
