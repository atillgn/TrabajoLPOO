using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Edificio
    {
        private int edif_Codigo;

        public int Edif_Codigo
        {
            get { return edif_Codigo; }
            set { edif_Codigo = value; }
        }
        private string edif_Nombre;

        public string Edif_Nombre
        {
            get { return edif_Nombre; }
            set { edif_Nombre = value; }
        }
        private string edif_Direccion;

        public string Edif_Direccion
        {
            get { return edif_Direccion; }
            set { edif_Direccion = value; }
        }

        private string edif_Admnistrador;

        public string Edif_Admnistrador
        {
            get { return edif_Admnistrador; }
            set { edif_Admnistrador = value; }
        }
        private string edif_Telefono;

        public string Edif_Telefono
        {
            get { return edif_Telefono; }
            set { edif_Telefono = value; }
        }
    }
}
