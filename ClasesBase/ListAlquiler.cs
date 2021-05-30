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
        
        public static DataTable list_alquileresP(String edificio,DateTime fecha_inicio, DateTime fecha_final,String tipo_departamento,bool a,bool b,bool c) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarAlquileresPar";
            cmd.Parameters.AddWithValue("@aux", DateTime.Parse("01/01/1800"));
            if (a) cmd.Parameters.AddWithValue("@edificio" ,edificio);
            else cmd.Parameters.AddWithValue("@edificio", "%");
            if (b) 
            { 
                cmd.Parameters.AddWithValue("@fecha_i", fecha_inicio);
                cmd.Parameters.AddWithValue("@fecha_f", fecha_final);
            }
            else
            {
                cmd.Parameters.AddWithValue("@fecha_i", DateTime.Parse("01/01/1800"));
                cmd.Parameters.AddWithValue("@fecha_f", DateTime.Parse("01/01/1800"));
            }
            if (c) cmd.Parameters.AddWithValue("@tipo_dpto",tipo_departamento);
            else cmd.Parameters.AddWithValue("@tipo_dpto", "%");
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_dptoParaAlquilar(DateTime fecha_inicio, DateTime fecha_final, String tipo_dpto, int ambiente, int precio, String disposicion, int banios) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarDepartamentosAlquilar";
            cmd.Parameters.AddWithValue("@fecha_i", fecha_inicio);
            cmd.Parameters.AddWithValue("@fecha_f", fecha_final);
            cmd.Parameters.AddWithValue("@tipo_dpto", tipo_dpto);
            cmd.Parameters.AddWithValue("@ambiente", ambiente);
            cmd.Parameters.AddWithValue("@precio",precio);
            cmd.Parameters.AddWithValue("@disposicion", disposicion);
            cmd.Parameters.AddWithValue("@banios", banios);

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
