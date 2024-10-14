using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using ServicioClase;

namespace Be
{
    public class BelUsuario : IEntity
    {
        public BelUsuario()
        {

        }
        public BelUsuario(string pDNi, string pNombre, string pApellido, string pEmail, Perfil pPerfil, 
            string pUsuario, string pContraseña)
        {
            DNI = pDNi;
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Perfil = pPerfil;
            Usuario = pUsuario;
            Contraseña = pContraseña;
            Bloqueado = false;
            Activo = true;
            Intentos = 3;
        }

        public BelUsuario(object[] array)
        {
            id = array[0].ToString();
            DNI = array[1].ToString();
            Nombre = array[2].ToString();
            Apellido = array[3].ToString();
            Email = array[4].ToString();
            Usuario = array[6].ToString();
            Contraseña = array[7].ToString();
            Bloqueado = bool.Parse(array[8].ToString());
            Activo = bool.Parse(array[9].ToString());
            Intentos = int.Parse(array[10].ToString());
        }

        public string id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public Perfil Perfil { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Bloqueado { get; set; }
        public bool Activo { get; set; }
        public int Intentos { get; set; }
    }
}
