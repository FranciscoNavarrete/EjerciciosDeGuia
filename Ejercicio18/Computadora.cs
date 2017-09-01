using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Computadora
    {
        public enum EMarca 
        {
            Asus,
            Apple,
            Samsung,
            Toshiba,
            IBM
        }

        public enum EProcesador 
        {
            Intel_Core_i7,
            ADM_Phenom_II,
            ADM_Athlon_II,
            Intel_Celeron_430,
            ADM_Sempron_145
        }


        #region Atributos
        private bool _estaEncendida = false;
        private EMarca _marca;
        private float _peso;
        private EProcesador _procesador;
        #endregion

        public Computadora(bool estado, EMarca marca, float peso, EProcesador procesador) 
        {
            this._estaEncendida = estado;
            this._marca = marca;
            this._peso = peso;
            this._procesador = procesador;
        }

        public bool getEstaEncendida()
        {
            return this._estaEncendida;
        }
        public EMarca getMarca() 
        {
            return this._marca;
        }
        public float getPeso() 
        {
            return this._peso;
        }
        public EProcesador getProcesador()
        {
            return this._procesador;
        }


        public void setEstaEncendida(bool encender) 
        {
            this._estaEncendida = encender;
        }
        public void setMarca(EMarca marca) 
        {
            this._marca = marca;
        }
        public void setPeso(float peso)
        {
            this._peso = peso;
        }
        public void setProcesador(EProcesador procesador) 
        {
            this._procesador = procesador;
        }


        public void InformarEstado() 
        {
            Console.WriteLine("Marca: {0}", _marca);
            Console.WriteLine("Estado: {0}",_estaEncendida);
            Console.WriteLine("Procesador: {0}",_procesador);
        }
        public bool Encender() 
        {
            return true;
        }
        public bool Apagar() 
        {
            return false;
        }
    }
}
