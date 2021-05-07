using System;
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
            cmd.CommandText += "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
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

            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario, Usu_Contrasenia, Usu_ApellidoNombre, Rol_Codigo) VALUES(@usuario, @contrasenia, @apellidonombre, @rol_codigo)";
            cmd.CommandType = CommandType.Text;
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

            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @usuario, Usu_Contrasenia = @contrasenia, Usu_ApellidoNombre = @apellidonombre, Rol_Codigo = @rol_codigo WHERE Usu_ID = @id";
            cmd.CommandType = CommandType.Text;
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

            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_ID = @id";
            cmd.CommandType = CommandType.Text;
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
            cmd.CommandText = @"SELECT
                Usu_ID AS 'ID',
                Usu_NombreUsuario AS 'Nombre de usuario',
                Usu_Contrasenia AS 'Contraseña',
                Usu_ApellidoNombre AS 'Apellido y Nombre',
                Roles.Rol_Descripcion AS 'Rol',
                Roles.Rol_Codigo AS 'ID Rol'
                FROM Usuario INNER JOIN Roles ON Usuario.Rol_Codigo=Roles.Rol_Codigo
                WHERE Usu_NombreUsuario LIKE @pattern OR Usu_ApellidoNombre LIKE @pattern
                ";
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
