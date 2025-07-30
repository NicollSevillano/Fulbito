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
        public BeReserva(BeCancha pCancha, BeCliente pCliente, DateTime pFecha, TimeSpan pHora, bool pPagado)
        {
            //id = pId;
            Cancha = pCancha; 
            Cliente = pCliente;
            Fecha = pFecha; 
            Hora = pHora;
            Pagado = pPagado;

        }
        public BeReserva() { }
        public BeReserva(object[] array)
        {
            id = array[0].ToString();
            Fecha = DateTime.Parse(array[3].ToString());
            Hora = TimeSpan.Parse(array[4].ToString());
            Pagado = bool.Parse(array[5].ToString());
            DVH = array[6].ToString();
            if (array[7] == DBNull.Value)
                this.Cancelada = false; 
            else
                this.Cancelada = Convert.ToBoolean(array[7]);
        }
        public string id { get ; set ; }
        public BeCancha Cancha { get; set; }
        public BeCliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public bool Pagado { get; set; }
        public bool Cancelada { get; set; }
        public string DVH { get; set; }
    }
}
