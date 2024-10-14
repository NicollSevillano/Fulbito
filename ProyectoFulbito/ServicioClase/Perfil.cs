using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace ServicioClase
{
    public class Perfil : IEntity
    {
        //public Perfil(string pNombre2)
        //{
        //    Nombre = pNombre2;
        //}
        public Perfil(string pNombre, Permiso pPermiso)
        {
            Nombre = pNombre; Permiso = pPermiso;
        }
        public Perfil(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
        }
        public string id { get ; set ; }
        public string Nombre { get; set; }
        public Permiso Permiso { get; set; }
    }
}
