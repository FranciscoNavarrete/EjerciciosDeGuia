using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora cp = new Computadora(true, Computadora.EMarca.Asus, 6, Computadora.EProcesador.ADM_Sempron_145);
            cp.InformarEstado();
            Console.ReadKey();
        }
    }
}
