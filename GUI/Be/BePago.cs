using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BePago : IEntity
    {
        public string id { get ; set ; }
        public BeReserva Reserva { get; set; }
        public string TipoPago { get; set; }
    }
}
