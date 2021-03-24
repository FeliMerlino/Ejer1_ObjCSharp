using System;
using System.Collections.Generic;
using System.Text;


namespace Ejer1_ObjCSharp.Ejercicio1
{
    class Cliente 
    {
        private String _nombre { get; set; }

        private String _apellido { get; set;}

        private String _dni { get; set; }

        private String _fDeNac { get; set; }

        private List<Cuenta> _cuentasBancarias;


        public Cliente(String nombre, String apellido, String dni, String fDeNac)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _fDeNac = fDeNac;
            _cuentasBancarias = new List<Cuenta>();
          
        }

        public void  AsignarCuenta(Cuenta cuenta)
        {
            cuenta._cliente = this;
            _cuentasBancarias.Add(cuenta);
        }
       
    }


 
}
