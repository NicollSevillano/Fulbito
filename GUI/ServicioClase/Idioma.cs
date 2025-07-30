using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class Idioma : IEntity
    {
        public Idioma() { }

        public string id { get; set; }

        public Idioma(string pCodigo, string pNombre)
        {
            id = pCodigo;
            Nombre = pNombre;
            lEtiqueta = new List<Etiqueta>();
        }
        public Idioma(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
            lEtiqueta = new List<Etiqueta>();
        }
        public string Nombre { get; set; }
        public List<Etiqueta> lEtiqueta { get; set; }
    }
}
