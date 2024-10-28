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
        public BeInsumo(DateTime pFechaHora, string pNombre, int pCantidad, int pCantidadActual, string pProveedor, string pEstado, string pObservaciones)
        {
            fechaHora = pFechaHora; Nombre = pNombre; Cantidad = pCantidad; cantidadActual = pCantidadActual;
            Proveedor = pProveedor; Estado = pEstado; Observaciones = pObservaciones;
        }
        public BeInsumo(object[] array)
        {
            id = array[0].ToString();
            fechaHora = DateTime.Parse(array[1].ToString());
            Nombre = array[2].ToString();
            Cantidad = int.Parse(array[3].ToString());
            cantidadActual = int.Parse(array[4].ToString());
            Proveedor = array[5].ToString();
            Estado = array[6].ToString();
            Observaciones = array[7].ToString();
        }

        public string id { get; set; }
        public DateTime fechaHora { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int cantidadActual { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
