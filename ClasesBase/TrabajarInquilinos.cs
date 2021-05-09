using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarInquilinos
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }

        public static DataTable list_inquilinos(String sPattern = "")
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            sPattern = sPattern.Replace(' ', '%');
            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.CommandText = "SELECT Inq_Codigo AS 'Codigo',Inq_Apellido AS 'Apellido',Inq_Nombre AS 'Nombre',Inq_Telefono AS 'Telefono'FROM Inquilino WHERE Inq_Nombre+' '+Inq_Apellido LIKE @pattern OR Inq_Apellido+' '+Inq_Nombre LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable list_inquilinosord()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Inq_Codigo AS 'Codigo',Inq_Apellido AS 'Apellido',Inq_Nombre AS 'Nombre',Inq_Telefono AS 'Telefono'FROM Inquilino ORDER BY Inq_Apellido";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_inquilino(Inquilino inquilino)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Inquilino(Inq_Apellido, Inq_Nombre, Inq_Telefono) VALUES(@apellido, @nombre, @telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@apellido", inquilino.Inq_Apellido);
            cmd.Parameters.AddWithValue("@nombre", inquilino.Inq_Nombre);
            cmd.Parameters.AddWithValue("@telefono", inquilino.Inq_Telefono);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void edit_inquilino(Inquilino inquilino)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Inquilino SET Inq_Apellido = @apellido, Inq_Nombre = @nombre, Inq_Telefono = @telefono WHERE Inq_Codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@apellido", inquilino.Inq_Apellido);
            cmd.Parameters.AddWithValue("@nombre", inquilino.Inq_Nombre);
            cmd.Parameters.AddWithValue("@telefono", inquilino.Inq_Telefono);
            cmd.Parameters.AddWithValue("@codigo", inquilino.Inq_Codigo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void delete_inquilino(int codigo)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Inquilino WHERE Inq_Codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
