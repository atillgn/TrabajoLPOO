using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class VerificarLogin
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
        }
        public static DataTable search_user(string u, string p) 
        {
            SqlConnection con = connect();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText += "Login";
            cmd.Parameters.AddWithValue("user", u);
            cmd.Parameters.AddWithValue("pas", p);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }

    }
}
