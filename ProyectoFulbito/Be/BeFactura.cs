using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeFactura : IEntity
    {
        public string id { get ; set ; }
        public BeReserva Reserva { get; set; }
        public string TipoPago { get; set; }
        public decimal Total { get; set; }
    }
}
