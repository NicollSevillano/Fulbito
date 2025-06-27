using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class PermisoSimple : Permiso
    {
        public PermisoSimple(string pNombre)
        {
            Nombre = pNombre;
        }
        public PermisoSimple(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
        }
    }
}
