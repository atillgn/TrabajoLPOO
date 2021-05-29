using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TipoDepartamento
    {
        private int tipod_Codigo;

        public int tipoD_Codigo {
            get { return tipod_Codigo; }
            set { tipod_Codigo = value; }
        }
        private string tipod_Descripcion;

        public string tipoD_Descripcion {
            get { return tipod_Descripcion; }
            set { tipod_Descripcion = value; }
        }
    }
}
