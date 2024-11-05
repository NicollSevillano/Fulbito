using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeAlquiler : IEntity
    {
        public BeAlquiler(BeCliente pCliente, BeInsumo pInsumo, DateTime pFechaHora, int pCantidad)
        {
            Cliente = pCliente; Insumo = pInsumo; fechaHora = pFechaHora; Cantidad = pCantidad;
        }
        public BeAlquiler(object[] array)
        {
            id = array[0].ToString();
            fechaHora = DateTime.Parse(array[3].ToString());
            Cantidad = int.Parse(array[4].ToString());
        }
        public string id { get; set; }
        public BeCliente Cliente { get; set; }
        public BeInsumo Insumo { get; set; }
        public DateTime fechaHora { get; set; }
        public int Cantidad { get; set; }
    }
}
