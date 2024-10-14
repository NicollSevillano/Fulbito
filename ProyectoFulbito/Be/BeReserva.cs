using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeReserva : IEntity
    {
        public BeReserva(BeCancha pCancha, BeCliente pCliente, DateTime pFecha, TimeSpan pHora)
        {
            //id = pId;
            Cancha = pCancha; 
            Cliente = pCliente;
            Fecha = pFecha; 
            Hora = pHora;
        }
        public BeReserva() { }
        public BeReserva(object[] array)
        {
            id = array[0].ToString();
            Fecha = DateTime.Parse(array[3].ToString());
            Hora = TimeSpan.Parse(array[4].ToString());
        }
        public string id { get ; set ; }
        public BeCancha Cancha { get; set; }
        public BeCliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
