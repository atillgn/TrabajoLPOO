using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usr_Id;
        private string usr_NombreUsuario;

        public Usuario() { }

        public string Usr_NombreUsuario
        {
            get { return usr_NombreUsuario; }
            set { usr_NombreUsuario = value; }
        }
        private string usr_Contrasenia;

        public string Usr_Contrasenia
        {
            get { return usr_Contrasenia; }
            set { usr_Contrasenia = value; }
        }
        private string usr_ApellidoNombre;

        public string Usr_ApellidoNombre
        {
            get { return usr_ApellidoNombre; }
            set { usr_ApellidoNombre = value; }
        }

        

        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        private int rol_id;

        public int Rol_id
        {
            get { return rol_id; }
            set { rol_id = value; }
        }

        public Usuario(int id, string nombreusuario, string contrasenia, string nombreyApellido, int rolId )
        {
            Usr_NombreUsuario = nombreusuario;
            Usr_Contrasenia = contrasenia;
            Usr_ApellidoNombre = nombreyApellido;
            Usr_Id = id;
            Rol_id = rolId;
        }

        
    }
}
