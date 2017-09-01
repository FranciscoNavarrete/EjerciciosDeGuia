using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligrafo
{
    class Boligrafo
    {
        ConsoleColor _color;
        int _tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }
        public ConsoleColor getColor() 
        {
            return _color;
        }

        public int getTinta() 
        {
            return _tinta;
        }

        public bool Pintar(int gasto) 
        {
            if (gasto >= 0)
            {
                return true;
            }
            else { return false; }
        }

        public void Recargar() 
        {

        }
    }
}
