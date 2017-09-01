using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region Atributos
        private byte _nota1= 0;
        private byte _nota2= 0;
        private float _notaFinal = 0;
        public string apellido;
        public int legajo;
        public string nombre;
        
        #endregion
        #region Constructor
        public Alumno(string ape, string nombre, int leg) 
        {
            this.apellido = ape;
            this.nombre = nombre;
            this.legajo = leg;
        }
        #endregion
        #region Estudiar
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
        #endregion
        #region CalcularFinal
        public void CalcularFinal() 
        {
            Random nota = new Random();
            if (_nota1 >= 4 && _nota2 >= 4)
            {
                this._notaFinal = nota.Next(10);
            }
            else {
                _notaFinal = -1;
            }
            
        }
#endregion
       public void Mostrar() 
       {
           Console.WriteLine("DATOS ALUMNO");
           Console.WriteLine("Nombre: "+nombre + " Apellido: "+apellido);
           Console.WriteLine("Legajo: {0}",legajo);
           Console.WriteLine("Nota 1: "+_nota1+ " Nota 2: " +_nota2);
           if (!(_notaFinal == -1))
           {
               Console.WriteLine("Nota Final: {0}", _notaFinal);
           }
       }
    }
}
