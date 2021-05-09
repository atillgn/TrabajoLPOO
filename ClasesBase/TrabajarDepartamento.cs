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
    }
}
