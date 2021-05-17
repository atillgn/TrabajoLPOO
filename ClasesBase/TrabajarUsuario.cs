using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }

        public static DataTable list_roles()
        {
            SqlConnection con = connect();
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "ListarRoles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_usuario(Usuario user)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@usuario", user.Usr_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", user.Usr_Contrasenia);
            cmd.Parameters.AddWithValue("@apellidonombre", user.Usr_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_codigo", user.Rol_id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void edit_usuario(Usuario user) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdateUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", user.Usr_Id);
            cmd.Parameters.AddWithValue("@usuario", user.Usr_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", user.Usr_Contrasenia);
            cmd.Parameters.AddWithValue("@apellidonombre", user.Usr_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_codigo", user.Rol_id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void delete_usuario(int id) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeleteUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable list_usuarios(String sPattern = "")
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarUsuarios";
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
