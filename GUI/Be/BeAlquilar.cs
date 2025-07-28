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
        public string id { get; set; }
        public BeCliente Cliente { get; set; }
        public int Horas { get; set; }
        public decimal Total { get; set; }
    }
}
