using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class InformeTurno
    {
        String fecha;
        String turnoInicia;
        String turnoFin;
        int cantidadBins;
        int CantidadPersonas;
        decimal horasTurnos;
        String turno;
        String sector;

        public InformeTurno(string fecha, string turnoInicia, string turnoFin, int cantidadBins, int cantidadPersonas, decimal horasTurnos, string turno, string sector)
        {
            this.fecha = fecha;
            this.turnoInicia = turnoInicia;
            this.turnoFin = turnoFin;
            this.cantidadBins = cantidadBins;
            CantidadPersonas = cantidadPersonas;
            this.horasTurnos = horasTurnos;
            this.turno = turno;
            this.sector = sector;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string TurnoInicia { get => turnoInicia; set => turnoInicia = value; }
        public string TurnoFin { get => turnoFin; set => turnoFin = value; }
        public int CantidadBins { get => cantidadBins; set => cantidadBins = value; }
        public int CantidadPersonas1 { get => CantidadPersonas; set => CantidadPersonas = value; }
        public decimal HorasTurnos { get => horasTurnos; set => horasTurnos = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Sector { get => sector; set => sector = value; }
    }
}
