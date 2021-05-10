using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ListAlquiler
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }

        public static DataTable list_alquileres()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarAlquileres";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public static DataTable list_alquileresP(String edificio,DateTime fecha_inicio, DateTime fecha_final,String tipo_departamento) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarAlquileresPar";
            cmd.Parameters.AddWithValue("@fecha_i", fecha_inicio);
            cmd.Parameters.AddWithValue("@fecha_f", fecha_final);
            cmd.Parameters.AddWithValue("@edificio" ,edificio);
            cmd.Parameters.AddWithValue("@tipo_dpto",tipo_departamento);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_edificios()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarEdificios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
