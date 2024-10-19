using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorRemisiones
{
    class Moneda
    {
        public string NmMoneda { get; set; }
        public int TpMoneda { get; set; }

        public Moneda(int tipo, string nombre)
        {
            NmMoneda = nombre;
            TpMoneda = tipo;
        }

    }
}
