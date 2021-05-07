using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Inquilino
    {
        private int inq_Codigo;

        public int Inq_Codigo
        {
            get { return inq_Codigo; }
            set { inq_Codigo = value; }
        }
        private string inq_Apellido;

        public string Inq_Apellido
        {
            get { return inq_Apellido; }
            set { inq_Apellido = value; }
        }
        private string inq_Nombre;

        public string Inq_Nombre
        {
            get { return inq_Nombre; }
            set { inq_Nombre = value; }
        }
        private string inq_Telefono;

        public string Inq_Telefono
        {
            get { return inq_Telefono; }
            set { inq_Telefono = value; }
        }

       
    }
}
