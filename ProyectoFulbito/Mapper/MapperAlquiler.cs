using Be;
using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MapperAlquiler : IABMC<BeAlquiler>
    {
        Dao dao = new Dao();
        ArrayList arrayList;
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
