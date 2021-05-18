using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDepartamento
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }

        public static DataTable ConsultarDisposicion(){

            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarDepartamentoDisposicion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ConsultarAmbiente()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarDepartamentoAmbiente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_dpto() 
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MostrarDepartamentos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insert_depto(Departamento d)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaDepto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@numero", d.Dpto_Numero);
            cmd.Parameters.AddWithValue("@piso", d.Dpto_Piso);
            cmd.Parameters.AddWithValue("@ambientes", d.Dpto_Ambientes);
            cmd.Parameters.AddWithValue("@dormitorios", d.Dpto_Dormitorios);
            cmd.Parameters.AddWithValue("@banios", d.Dpto_Baños);
            cmd.Parameters.AddWithValue("@precio", d.Dpto_Precio);
            cmd.Parameters.AddWithValue("@ed_codigo", d.Edif_Codigo);
            cmd.Parameters.AddWithValue("@tipo", d.Dpto_Tipo);
            cmd.Parameters.AddWithValue("@disposicion", d.Dpto_Disposicion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void edit_depto(Departamento d)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdateDepto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", d.Dpto_Codigo);
            cmd.Parameters.AddWithValue("@numero", d.Dpto_Numero);
            cmd.Parameters.AddWithValue("@piso", d.Dpto_Piso);
            cmd.Parameters.AddWithValue("@ambientes", d.Dpto_Ambientes);
            cmd.Parameters.AddWithValue("@dormitorios", d.Dpto_Dormitorios);
            cmd.Parameters.AddWithValue("@banios", d.Dpto_Baños);
            cmd.Parameters.AddWithValue("@precio", d.Dpto_Precio);
            cmd.Parameters.AddWithValue("@ed_codigo", d.Edif_Codigo);
            cmd.Parameters.AddWithValue("@tipo", d.Dpto_Tipo);
            cmd.Parameters.AddWithValue("@disposicion", d.Dpto_Disposicion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void delete_depto(int cod)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeleteDepto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@codigo", cod);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable list_tipo_departamento()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarTipoDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //cmd.Parameters.AddWithValue("@codigo", cod);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
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
