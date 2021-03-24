using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer1_ObjCSharp.Ejercicio1
{
    class Banco 
    {
        private String _nombre { get; set; }

        private List<Sucursal> _sucursales;

        private Sucursal _casaMatriz;

        public void EsCasaMatriz(Sucursal sucursal, bool esCasaMatriz)
        {
            _sucursales.Add(sucursal);

            if (esCasaMatriz)
                _casaMatriz = sucursal;
        }

    }
}
