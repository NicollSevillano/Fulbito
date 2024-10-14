using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace ServicioClase
{
    public abstract class Permiso : IEntity
    {
        public string id { get ; set ; }
        public string Nombre { get; set; }
    }
}
