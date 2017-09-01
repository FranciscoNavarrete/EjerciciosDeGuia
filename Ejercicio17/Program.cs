using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta();
            Cuenta cuenta2 = new Cuenta();
            Cuenta cuenta3 = new Cuenta();

            Console.WriteLine(cuenta1.getTipoInteres());

            cuenta1.setNombre("Francisco");
            Console.WriteLine(cuenta1.getNombre());


            Console.ReadKey();
        }
    }
}
