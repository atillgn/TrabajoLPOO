using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        private int alq_Codigo;

        public int Alq_Codigo
        {
            get { return alq_Codigo; }
            set { alq_Codigo = value; }
        }
        private DateTime alq_Fecha;

        public DateTime Alq_Fecha
        {
            get { return alq_Fecha; }
            set { alq_Fecha = value; }
        }
        private int dpto_Codigo;

        public int Dpto_Codigo
        {
            get { return dpto_Codigo; }
            set { dpto_Codigo = value; }
        }
        private int inq_Codigo;

        public int Inq_Codigo
        {
            get { return inq_Codigo; }
            set { inq_Codigo = value; }
        }
        private DateTime alq_FechaDesde;

        public DateTime Alq_FechaDesde
        {
            get { return alq_FechaDesde; }
            set { alq_FechaDesde = value; }
        }
        private DateTime alq_FechaHasta;

        public DateTime Alq_FechaHasta
        {
            get { return alq_FechaHasta; }
            set { alq_FechaHasta = value; }
        }
        private double alq_Precio;

        public double Alq_Precio
        {
            get { return alq_Precio; }
            set { alq_Precio = value; }
        }
    }
}
