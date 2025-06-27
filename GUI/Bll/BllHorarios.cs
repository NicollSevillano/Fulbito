using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be;
using Interface;
using Mapper;

namespace Bll
{
    public class BllHorarios : IABMC<BeHorarios>
    {
        MapperHorarios mHoras = new MapperHorarios();
        public void Alta(BeHorarios pObject)
        {
            throw new NotImplementedException();
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeHorarios> Consulta()
        {
            return mHoras.Consulta();
        }

        public List<BeHorarios> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeHorarios pObject)
        {
            throw new NotImplementedException();
        }
    }
}
