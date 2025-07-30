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
        public BeCliente(string pDni, string pNombre, string pTelefono, string direccion)
        {
            DNI = pDni;
            Nombre = pNombre;
            Telefono = pTelefono;
            Direccion = direccion;
        }

        public BeCliente(object[] array)
        {
            id = array[0].ToString();
            DNI = array[1].ToString();
            Nombre = array[2].ToString();
            Telefono = array[3].ToString();
            Direccion = array[4].ToString();
            DVH = array[5].ToString();
        }

        public BeCliente() { }

        public string id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string DVH { get; set; }
    }
}
