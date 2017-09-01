using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int min, int may, int num) 
        {
            if (num > min && num < may)
                return true;
            else
                return false;
        }
    }
}
