using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Problemas
    {
        String indice;
        String errores;

        public Problemas(String indice, string errores)
        {
            this.indice = indice;
            this.errores = errores;
        }

        public String Indice { get => indice; set => indice = value; }
        public string Errores { get => errores; set => errores = value; }
    }
}
