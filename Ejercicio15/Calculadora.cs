using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static string Calcular(float primero, float segundo, string operacion)
        {
            float temp;
            switch (operacion) // Estructura con switch
            {
                case "+":
                    temp = primero + segundo;
                    return temp.ToString();
                case "-":
                    temp = primero - segundo;
                    return temp.ToString();
                case "*":
                    temp = primero * segundo;
                    return temp.ToString();
                case "/":
                    temp = primero / segundo;
                    return temp.ToString();
            }
            return "-1";
        }

        //public static void Mostrar(float resultado) 
        //{
        //    Console.WriteLine("El resultado es", resultado);
        //}
    }
}
