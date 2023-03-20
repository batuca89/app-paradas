using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Informes
    {
        public List<InformeTurno> getInformeTurnos(String horaInicio, String horaFin)
        {

            String query;
            List<InformeTurno> list = new List<InformeTurno>();  

            query = "sp_reporte_turnos";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_fecha_ini", horaInicio);
                cmd.Parameters.AddWithValue("@as_fecha_fin", horaFin);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    InformeTurno lectura = new InformeTurno(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3] is DBNull ? 0 : Convert.ToInt32(leer[3]),
                       leer[4] is DBNull ? 0 : Convert.ToInt32(leer[4]), leer[5] is DBNull ? 0 : Convert.ToDecimal(leer[5]), leer[6].ToString(), leer[7].ToString());
                    list.Add(lectura);
                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return list;
        }

        public List<ReporteParadas> getInformeParadas(String horaInicio, String horaFin)
        {

            String query;
            List<ReporteParadas> list = new List<ReporteParadas>();

            query = "sp_reporte_paradas";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_fecha_ini", horaInicio);
                cmd.Parameters.AddWithValue("@as_fecha_fin", horaFin);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {

                    ReporteParadas lectura = new ReporteParadas(leer[0].ToString(), leer[1].ToString(), leer[2].ToString(), leer[3].ToString(), leer[4].ToString(), leer[5] is DBNull ? 0 : Convert.ToDecimal(leer[5]), leer[6].ToString(), leer[7].ToString(), leer[8].ToString());
                    list.Add(lectura);
                }
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }

            return list;
        }
    }
}
