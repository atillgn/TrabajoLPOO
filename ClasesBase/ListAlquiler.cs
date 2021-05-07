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
            cmd.CommandText += @"SELECT
                Alq_Codigo AS 'Codigo',
                Edificio.Edif_Direccion AS 'Direccion departamento',
                Departamento.Dpto_Numero AS 'Numero departamento',
                Departamento.Dpto_Piso AS 'Piso departamento',
                Inquilino.Inq_Apellido AS 'Apellido',
                Inquilino.Inq_Nombre AS 'Nombre',
                Alq_Fecha AS 'Fecha de registro',
                Alq_FechaDesde AS 'Fecha desde',
                Alq_FechaHasta AS 'Fecha hasta',
                Alq_Precio AS 'Precio de alquiler'
                FROM Alquiler 
                INNER JOIN Departamento ON Alquiler.Dpto_Codigo = Departamento.Dpto_Codigo
                INNER JOIN Inquilino ON Alquiler.Inq_Codigo = Inquilino.Inq_Codigo
                INNER JOIN Edificio ON Departamento.Edif_Codigo = Edificio.Edif_Codigo 
                ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
