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
        public BeAlquiler() { }
        public BeAlquiler(BeCliente cliente, int horas, decimal total, DateTime fecha)
        {
            Cliente = cliente;
            Horas = horas;
            Total = total;
            Fecha = fecha;
        }

        public BeAlquiler(object[] array)
        {
            id = array[0].ToString();

            Cliente = new BeCliente
            {
                id = array[1].ToString(),
                Nombre = array[2].ToString()
            };

            Horas = int.Parse(array[3].ToString());
            Total = decimal.Parse(array[4].ToString());
            Fecha = DateTime.Parse(array[5].ToString());
        }
        public string id { get; set; }
        public BeCliente Cliente { get; set; }
        public int Horas { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public List<AlquilerInsumoDetalle> Detalle { get; set; } = new List<AlquilerInsumoDetalle>();
    }
}
