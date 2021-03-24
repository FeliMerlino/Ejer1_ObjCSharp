using System;
using System.Collections.Generic;
using System.Text;


namespace Ejer1_ObjCSharp.Ejercicio1
{
    class Cuenta
    {

        private int _numCuenta { get; set; }

        private Sucursal _sucursal { get; set; }

        public Cliente _cliente { get; set; }

        private Moneda _moneda { get; set; }

        private decimal _balance { get; set; }
       

        public Cuenta()
        {
            Random r = new Random();
            _numCuenta = r.Next(0, 99999999);
            _balance = 0M;

        }

        public Cuenta(Sucursal sucursal, Cliente cliente, Moneda moneda)
          : this()
        {
            _sucursal = sucursal;
            _cliente = cliente;
            _moneda = moneda;

        }
        public void Depositar(decimal monto) => _balance += monto;

        public void Extraer(decimal monto)
        {
            if (_balance < monto)
            {
                Console.WriteLine("La caja de ahorro no admite descubierto");
            }
            _balance -= monto;
        }
        public String MostrarBalance() => $"El balance es de {_moneda}{_balance}";

    }

  
}
