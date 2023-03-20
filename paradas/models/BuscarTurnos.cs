using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class BuscarTurnos
    {
        public List<Turnos> getTurnos()
        {

            List<Turnos> lista = new List<Turnos>();

            Connection coneccion = new Connection();
            String query = "select t.turno ,t.hora_inicial ,t.hora_final from turnos t  where t.activo = 'S'";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Turnos turnos = new Turnos(leer[0].ToString(), leer[1].ToString(), leer[2].ToString());
                    lista.Add(turnos);

                }
                coneccion.cerrarConeccion();
            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return lista;
        }

        public double calculoHoras(String hora_inicio, String hora_fin)
        {
            double horasTotales1;
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(hora_inicio);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(hora_fin);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
            horasTotales1 = Math.Abs(diferenciaHoras.TotalHours);

            return horasTotales1;
        }
    }
}
