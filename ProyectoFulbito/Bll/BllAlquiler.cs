using Be;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllAlquiler : IABMC<BeAlquiler>
    {
        public void Alta(BeAlquiler pObject)
        {
            throw new NotImplementedException();
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeAlquiler> Consulta()
        {
            throw new NotImplementedException();
        }

        public List<BeAlquiler> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeAlquiler pObject)
        {
            throw new NotImplementedException();
        }
    }
}
