using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DigitoVerificador
    {
        private string EncriptarEntidad(IEntity e)
        {
            var properties = e.GetType().GetProperties();
            string encriptado = "";
            foreach(var propiedad in properties)
            {
                if(propiedad.GetValue(e) != null)
                {
                    if (propiedad.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                    {
                        DateTime dt = (DateTime)propiedad.GetValue(e);
                        encriptado += dt.ToString("yyyymmddhhmmss");
                    }
                    else
                    {
                        encriptado += propiedad.GetValue(e).ToString();
                    }
                }
            }
            return Encriptar.Encrypt(encriptado);
        }
        private string EncriptarLista(List<IEntity> lista)
        {
            string encriptado = "";
            foreach(IEntity e in lista)
            {
                encriptado += EncriptarEntidad(e);
            }
            return Encriptar.Encrypt(encriptado);
        }

        private bool CompararDVHTotal(List<IEntity> lista)
        {
            //Conseguir DV de Id 0 en la tabla de BD
        }
    }
}
