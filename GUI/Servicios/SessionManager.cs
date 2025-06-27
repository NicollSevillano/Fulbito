using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be;

namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager sessionManager;
        public BelUsuario usuario { get; set; }
        public DateTime fechaInicio { get; set; }
        public static object _lock = new object();

        public static SessionManager getInstance
        {
            get
            {
                return sessionManager;
            }
        }
        public static void LogIn(BelUsuario pUsuario)
        {
            lock (_lock)
            {
                if (sessionManager == null)
                {
                    sessionManager = new SessionManager();
                    sessionManager.usuario = pUsuario;
                    sessionManager.fechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión iniciada");
                }
            }
        }
        public static void LogOut()
        {
            lock (_lock)
            {
                if (sessionManager != null)
                {
                    sessionManager = null;                    
                }
            }
        }
        private SessionManager()
        {

        }
    }
}
