using Controles;
using Microsoft.VisualBasic.Logging;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LanguageManager.Iniciarlizar();
            LanguageManager.CodIdiomaActual = 1; 
            LanguageManager.Actualizar(1);
            Application.Run(new InicioSesionForm());
        }
    }
}
