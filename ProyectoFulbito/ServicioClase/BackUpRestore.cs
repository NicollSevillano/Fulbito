using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioClase
{
    public class BackUpRestore
    {
        public bool VerificarRutaBackUp(string pRuta)
        {
            return Directory.Exists(Path.GetDirectoryName(pRuta));
        }
        public bool VerificarRutaRestore(string pRutaArchivo)
        {
            return File.Exists(pRutaArchivo) && Path.GetExtension(pRutaArchivo).Equals(".bak", StringComparison.OrdinalIgnoreCase);
        }
    }
}
