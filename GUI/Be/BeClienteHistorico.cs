﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be
{
    public class BeClienteHistorico
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Mes { get; set; }
        public decimal Total { get; set; }
        public int Frecuencia { get; set; }
    }
}
