using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarEdificios
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }
        public static DataTable list_admin() 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarUsuarios";
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
            cmd.CommandText = "MostrarEdificios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_edificio(Edificio edificio) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@nombre", edificio.Edif_Nombre);
            cmd.Parameters.AddWithValue("@direccion", edificio.Edif_Direccion);
            cmd.Parameters.AddWithValue("@telefono", edificio.Edif_Telefono);
            cmd.Parameters.AddWithValue("@admin", edificio.Edif_Admnistrador);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void edit_edificio(Edificio edificio)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdateEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", edificio.Edif_Codigo);
            cmd.Parameters.AddWithValue("@nombre", edificio.Edif_Nombre);
            cmd.Parameters.AddWithValue("@direccion", edificio.Edif_Direccion);
            cmd.Parameters.AddWithValue("@telefono", edificio.Edif_Telefono);
            cmd.Parameters.AddWithValue("@admin", edificio.Edif_Admnistrador);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void delete_edificio(int codigo)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeleteEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
