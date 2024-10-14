using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeCliente : IEntity
    {
        public BeCliente(string pDni, string pNombre, string pTelefono)
        {
            DNI = pDni; Nombre = pNombre; Telefono = pTelefono;
        }
        public BeCliente(object[] array)
        {
            id = array[0].ToString();
            DNI = array[1].ToString();
            Nombre = array[2].ToString();
            Telefono = array[3].ToString();
        }

        public BeCliente()
        {
        }

        public string id { get ; set ; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
