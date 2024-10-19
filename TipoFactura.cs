using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorRemisiones
{
    class TipoFactura
    {
        public string ClaveDocumento { get; set; }
        public string Tipo { get; set; }

        public TipoFactura(string cd, string tipo)
        {
            ClaveDocumento = cd;
            Tipo = tipo;
        }
    }
}
