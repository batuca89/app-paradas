using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    public class ReporteParadas
    {
        String fecha;
        String tipoParada;
        String problema;
        String InicioParada;
        String finParada;
        decimal horasParadas;
        String sector;
        String turno;
        String obervaciones;

        public ReporteParadas(string fecha, string tipoParada, string problema, string inicioParada, string finParada, decimal horasParadas, string sector, string turno, string obervaciones)
        {
            this.fecha = fecha;
            this.tipoParada = tipoParada;
            this.problema = problema;
            InicioParada = inicioParada;
            this.finParada = finParada;
            this.horasParadas = horasParadas;
            this.sector = sector;
            this.turno = turno;
            this.obervaciones = obervaciones;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string TipoParada { get => tipoParada; set => tipoParada = value; }
        public string Problema { get => problema; set => problema = value; }
        public string InicioParada1 { get => InicioParada; set => InicioParada = value; }
        public string FinParada { get => finParada; set => finParada = value; }
        public decimal HorasParadas { get => horasParadas; set => horasParadas = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Obervaciones { get => obervaciones; set => obervaciones = value; }
    }
}
