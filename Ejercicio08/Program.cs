using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            float acum = 0;
            do
            {
                float valHs = 0;
                string nombre = "";
                float antiguedad = 0;
                float cantHs = 0;
                

                Console.WriteLine("Ingrese Nombre del Empleado");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese Valor de su hora");
                valHs = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Antiguedad");
                antiguedad = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                cantHs = float.Parse(Console.ReadLine());

                float impACobrar = valHs * cantHs;
                impACobrar = impACobrar + (antiguedad * 150);
                float CobraConDescuento = impACobrar + (impACobrar * 100)/13;

                acum = acum + CobraConDescuento;

                Console.WriteLine("Nombre: {0}",nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor hora: {0}", valHs);
                Console.WriteLine("Sueldo bruto: {0}", impACobrar);
                Console.WriteLine("Sueldo con descuento: {0}", CobraConDescuento);
                Console.WriteLine();
                Console.WriteLine("Acumulacion de Sueldos: {0}",acum);

                Console.WriteLine("Presione s para continuar");
                continuar = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
