using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alm1 = new Alumno("Navarrete", "Francisco", 112);
            Alumno alm2 = new Alumno("Perez", "Facundo ", 205);
            Alumno alm3 = new Alumno("Gomez", "Hernan", 381);
            alm1.Estudiar(4, 7);
            alm1.CalcularFinal();
            alm1.Mostrar();

            alm2.Estudiar(8, 7);
            alm2.CalcularFinal();
            alm2.Mostrar();

            Console.ReadKey();

        }
    }
}
