using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class Etiqueta : IEntity
    {
        public Etiqueta(Idioma pIdioma, string pControl, string pTexto)
        {
            id = pIdioma.id;
            ControlT = pControl;
            Texto = pTexto;
        }
        public Etiqueta(object[] array)
        {
            id = array[0].ToString();
            ControlT = array[1].ToString();
            Texto = array[2].ToString();
        }
        public string id { get; set; }
        public string ControlT { get; set; }
        public string Texto { get; set; }
    }
}
