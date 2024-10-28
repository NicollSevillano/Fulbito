using Be;
using Interface;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllInsumo : IABMC<BeInsumo>
    {
        MapperInsumo mInsumo = new MapperInsumo();
        public void Alta(BeInsumo pObject)
        {
            mInsumo.Alta(pObject);
        }

        public void Baja(int pId)
        {
            mInsumo.Baja(pId);
        }

        public List<BeInsumo> Consulta()
        {
            return mInsumo.Consulta();
        }
        public void CambiarEstado(BeInsumo pObject)
        {
            mInsumo.CambiarEstado(pObject);
        }
        public List<BeInsumo> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeInsumo pObject)
        {
            mInsumo.Modificacion(pObject);
        }
    }
}
