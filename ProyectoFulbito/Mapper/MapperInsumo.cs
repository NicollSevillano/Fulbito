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
    public class MapperInsumo : IABMC<BeInsumo>
    {
        Dao dao = new Dao();
        ArrayList arraylist;
        public void Alta(BeInsumo pObject)
        {
            throw new NotImplementedException();
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeInsumo> Consulta()
        {
            throw new NotImplementedException();
        }

        public List<BeInsumo> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeInsumo pObject)
        {
            throw new NotImplementedException();
        }
    }
}
