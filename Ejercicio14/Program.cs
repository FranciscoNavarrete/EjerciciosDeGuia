using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            #region Cuadrado
            Console.WriteLine("Ingrese el lado del cuadrado");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA DEL CUADRADO");
            Console.WriteLine(CalculoDeArea.CalcularCuadrado(lado));
            #endregion

            #region Triangulo
            Console.WriteLine("Ingrese base");
            double bass = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura");
            double altu = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA DEL TRIANGULO");
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(bass, altu));
            #endregion

            #region Circulo
            Console.WriteLine("Ingrese el radio del Circulo");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA DEL CIRCULO");
            Console.WriteLine(CalculoDeArea.CalcularCirculo(radio));
            #endregion

            Console.ReadKey();
        }
    }
}
