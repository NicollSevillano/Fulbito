using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeInsumo : IEntity
    {
        public BeInsumo() { }
        public BeInsumo(string pNombre, int pCantidad, int pCantidadActual, string pProveedor, string pEstado, string pObservaciones)
        {
            Nombre = pNombre; Cantidad = pCantidad; cantidadActual = pCantidadActual;
            Proveedor = pProveedor; Estado = pEstado; Observaciones = pObservaciones;
        }
        public BeInsumo(object[] array)
        {
            id = array[0].ToString();
            Nombre = array[1].ToString();
            Cantidad = int.Parse(array[2].ToString());
            cantidadActual = int.Parse(array[3].ToString());
            Proveedor = array[4].ToString();
            Estado = array[5].ToString();
            Observaciones = array[6].ToString();
        }

        public string id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int cantidadActual { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
