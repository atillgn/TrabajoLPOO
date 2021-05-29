using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarTipoDepartamento
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }
        public static DataTable list_tipoDpto() 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarTipoDpto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void insert_tipoDpto(TipoDepartamento tipoDpto) 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaTipoDpto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@descripcion", tipoDpto.tipoD_Descripcion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void edit_tipoDpto(TipoDepartamento tipoDpto)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdateTipoDpto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", tipoDpto.tipoD_Codigo);
            cmd.Parameters.AddWithValue("@descripcion", tipoDpto.tipoD_Descripcion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void delete_tipoDpto(int codigo)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeleteTipoDpto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
