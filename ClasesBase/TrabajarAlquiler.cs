using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAlquiler
    {
        private static SqlConnection connect()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.datosConnectionString);
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
            foreach (DataRow row in dt.Rows)
            {
                row[1] += " - " + row[2].ToString();
            }
            return dt;
        }

        public static DataTable list_tipoDepartamento()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarTipoDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_departamentos(int Edif_Codigo)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarDepartamentos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@edif_codigo", Edif_Codigo);

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable newDt = newDt = new DataTable();
            newDt.Columns.Add(new DataColumn("Dpto_Codigo", typeof(Int32)));
            newDt.Columns.Add(new DataColumn("Info", typeof(string)));
            foreach (DataRow row in dt.Rows)
            {
                DataRow dr = newDt.NewRow();
                dr["Dpto_Codigo"] = row[0];
                dr["Info"] = "Piso: " + row[4].ToString() + " - Número: " + row[3].ToString() + " - Ambientes: " + row[5].ToString() + " - $" + row[9] + "/mes";
                newDt.Rows.Add(dr);
            }
            return newDt;
        }
        public static DataTable list_inquilinos()
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarInquilinos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Mandar al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                row[1] = row[1].ToString() + ", " + row[2].ToString();
            }
            return dt;
        }
        public static Departamento get_departamento(int Dpto_Codigo)
        {
            SqlConnection con = connect();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ObtenerDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Dpto_Codigo", Dpto_Codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Departamento dpto = new Departamento();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                dpto.Dpto_Codigo = (int)row[0];
                dpto.Edif_Codigo = (int)row[1];
                dpto.Dpto_Tipo = (int)row[2];
                dpto.Dpto_Numero = (int)row[3];
                dpto.Dpto_Piso = (int)row[4];
                dpto.Dpto_Ambientes = (int)row[5];
                dpto.Dpto_Dormitorios = (int)row[6];
                dpto.Dpto_Baños = (int)row[7];
                dpto.Dpto_Disposicion = (int)row[8];
                dpto.Dpto_Precio = Decimal.ToDouble((decimal)row[9]);

            }
            return dpto;
        }
        public static void insert_alquiler(Alquiler alq)
        {
            SqlConnection con = connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AltaAlquiler";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            alq.Alq_Fecha = DateTime.Now;
            cmd.Parameters.AddWithValue("@fecha", alq.Alq_Fecha);
            cmd.Parameters.AddWithValue("@dpto_codigo", alq.Dpto_Codigo);
            cmd.Parameters.AddWithValue("@inq_codigo", alq.Inq_Codigo);
            cmd.Parameters.AddWithValue("@fechadesde", alq.Alq_FechaDesde);
            cmd.Parameters.AddWithValue("@fechahasta", alq.Alq_FechaHasta);
            cmd.Parameters.AddWithValue("@precio", alq.Alq_Precio);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable valid_fechas(DateTime fechai, DateTime fechaf, int id) 
        {
            SqlConnection con = connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "VerificarFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@fechai", fechai);
            cmd.Parameters.AddWithValue("@fechaf", fechaf);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}