using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Cargar
    {
        public void setTablaParadas(int turno, DateTime turno_inico, DateTime turno_fin, decimal horas_turno, String tipo_errores,
            String obervaciones, decimal horas_comida, decimal horas_parada, DateTime parada_inicio, DateTime parada_fin,
            String sector, String usuario, DateTime comida_inicio, DateTime comida_fin
            )
        {

            String query;


            query = "sp_cargar_tabla_errores_parada";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_turno", turno);
                cmd.Parameters.AddWithValue("@as_turno_inicio", turno_inico);
                cmd.Parameters.AddWithValue("@as_turno_fin", turno_fin);
                cmd.Parameters.AddWithValue("@as_horas_turnos", horas_turno);
                cmd.Parameters.AddWithValue("@as_tipo_errores", tipo_errores);
                cmd.Parameters.AddWithValue("@as_observaciones", obervaciones);
                cmd.Parameters.AddWithValue("@as_horas_comida", horas_comida);
                cmd.Parameters.AddWithValue("@as_horas_parada", horas_parada);
                cmd.Parameters.AddWithValue("@as_parada_inicio", parada_inicio);
                cmd.Parameters.AddWithValue("@as_parada_fin", parada_fin);
                cmd.Parameters.AddWithValue("@as_sector", sector);
                cmd.Parameters.AddWithValue("@as_usuario", usuario);
                cmd.Parameters.AddWithValue("@as_comida_inicio", comida_inicio);
                cmd.Parameters.AddWithValue("@as_comida_fin", comida_fin);
                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


        }

        public void setTablaParadasTurnos(String horaini, String horafin, String fecha,int cantiad_personas, int cantidad_bins, String turno, String sector)
        {

            String query;


            query = "sp_cargar_turnos_paradas";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_turno_inicia", horaini);
                cmd.Parameters.AddWithValue("@as_turno_fin", horafin);
                cmd.Parameters.AddWithValue("@as_fecha_carga", fecha);
                cmd.Parameters.AddWithValue("@as_cantidad_personas", cantiad_personas);
                cmd.Parameters.AddWithValue("@as_cantidad_bins", cantidad_bins);
                cmd.Parameters.AddWithValue("@as_turno", turno);
                cmd.Parameters.AddWithValue("@as_sector", sector);
                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


        }
        public void setTablaRegistrosParadas(String tipoParada,String problema,String horaInicio, String horaFin, String sector, String usuario, String observaciones,String turno,String fecha)
        {

            String query;


            query = "sp_cargar_registros_paradas";



            Connection coneccion = new Connection();
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@as_tipo_parada", tipoParada);
                cmd.Parameters.AddWithValue("@as_problema", problema);
                cmd.Parameters.AddWithValue("@as_inicio_parada", horaInicio);
                cmd.Parameters.AddWithValue("@as_fin_parada", horaFin);
                cmd.Parameters.AddWithValue("@as_sector", sector);
                cmd.Parameters.AddWithValue("@as_usuario", usuario);
                cmd.Parameters.AddWithValue("@as_observaciones", observaciones);
                cmd.Parameters.AddWithValue("@as_turno", turno);
                cmd.Parameters.AddWithValue("@as_fecha", fecha);
                cmd.ExecuteNonQuery();
                coneccion.cerrarConeccion();

            }
            catch (Exception e)
            {
                coneccion.cerrarConeccion();
                System.Windows.Forms.MessageBox.Show("Error al ejecutar la transacción : " + e.Message);
            }


        }
    }
}
