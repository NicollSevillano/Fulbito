using ServicioClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public static class Traductor
    {
        public static string ObtenerTexto(string tag)
        {
            string idiomaId = LanguageManager.CodIdiomaActual.ToString();
            Idioma idioma = LanguageManager.lIdioma.Find(x => x.id == idiomaId);

            if (idioma == null)
                return tag;

            var etiqueta = idioma.lEtiqueta.FirstOrDefault(e => e.ControlT == tag);
            return etiqueta != null ? etiqueta.Texto : tag;
        }
    }
}
