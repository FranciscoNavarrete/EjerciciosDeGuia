using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        
        
        /// <summary>
        ///calcula el area del cuadrado, recibe un double por parametro 
        /// </summary>
        /// <param name="areaCuad"></param>
        /// <returns></returns>
        public static double CalcularCuadrado(double areaCuad) 
        {
            double areaCuadrado = Math.Pow(2, areaCuad);
            return areaCuadrado;
        }
        /// <summary>
        /// calcula el area del triagulo, recibe dos double por parametro
        /// </summary>
        /// <param name="bas"></param>
        /// <param name="alt"></param>
        /// <returns></returns>
        public static double CalcularTriangulo(double bas, double alt)
        {
            double areaTriangulo = bas * alt;
            return areaTriangulo;
        }
        /// <summary>
        /// calcula el area del un circulo, recibe un double por parametro
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns>
        public static double CalcularCirculo(double radio)
        {
            double areaCirculo = radio * 3.14;
            return areaCirculo;
        }
    }
}
