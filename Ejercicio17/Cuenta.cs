using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    

    class Cuenta
    {
        public enum ETipoInteres
        {
            Tin,
            Tae,
            Tir
        }
        #region Atributos
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;
        #endregion

        public string getNombre() 
        {
            return _nombre;
        }
        public long getNroCuenta() 
        {
            return _nroCuenta;
        }
        public double getSaldo() 
        {
            return _saldo;
        }
        public ETipoInteres getTipoInteres() 
        {
            return _tipoInteres;
        }

        public void setNombre(string nombre) 
        {
            this._nombre = nombre;
        }
        public void setNroDeCuenta(long nroCuenta) 
        {
            this._nroCuenta = nroCuenta;
        }
        public void setSaldo(double saldo) 
        {
            this._saldo = saldo;
        }
        public void setTipoInteres(ETipoInteres tipoInteres) 
        {
            this._tipoInteres = tipoInteres;
        }



    }
}
