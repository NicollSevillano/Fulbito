using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Be
{
    public class BeHorarios : IEntity
    {
        public BeHorarios(string pId, TimeSpan pHE, TimeSpan pHS)
        {
            id = pId;
            HoraEntrada = pHE;
            HoraSalida = pHS;
        }
        public BeHorarios(object[] _object)
        {
            id = _object[0].ToString();
            HoraEntrada = TimeSpan.Parse(_object[1].ToString());
            HoraSalida = TimeSpan.Parse(_object[2].ToString());
        }
        public string id { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
    }

}
