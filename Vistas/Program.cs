using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FrmLogin oFrmLogin;
       // public static FrmUsuario oFrmUsuario;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(oFrmLogin= new FrmLogin());
            //Application.Run(oFrmUsuario = new FrmUsuario());
        }
    }
}
