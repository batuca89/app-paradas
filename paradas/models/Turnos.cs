using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Turnos
    {
        String turno;
        String hora_inicio;
        String hora_fin;

        public Turnos(string turno, string hora_inicio, string hora_fin)
        {
            this.turno = turno;
            this.hora_inicio = hora_inicio;
            this.hora_fin = hora_fin;
        }

        public string Turno { get => turno; set => turno = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_fin { get => hora_fin; set => hora_fin = value; }
    }
}
