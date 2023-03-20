using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Errores
    {
        public List<Problemas> getErrores()
        {

            List<Problemas> lista = new List<Problemas>();
           // lista.Add(" ");
            Connection coneccion = new Connection();
            String query = "SELECT id,tipo_errores FROM tipo_errores";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Problemas problemas = new Problemas(leer.GetString(0), leer.GetString(1));
                   
                    lista.Add(problemas);

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

        public List<String> getComidas()
        {

            List<String> lista = new List<String>();
            lista.Add(" ");

            Connection coneccion = new Connection();
            String query = "SELECT coalesce(tipo_comidas) FROM tipo_errores where tipo_comidas is not null;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, coneccion.establecerConeccion());
                cmd.CommandType = System.Data.CommandType.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    String turno = leer.GetString(0);
                    lista.Add(turno);

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
    }

    

}
