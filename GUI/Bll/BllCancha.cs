using System;
using System.Collections.Generic;
using Be;
using Interface;
using Mapper;
using Servicios;

namespace Bll
{
    public class BllCancha : IABMC<BeCancha>
    {
        MapperCancha mCancha = new MapperCancha();

        public void Alta(BeCancha pObject)
        {
            mCancha.Alta(pObject);
        }

        public void Baja(int pId)
        {
            mCancha.Baja(pId);
        }

        public List<BeCancha> Consulta()
        {
            return mCancha.Consulta();
        }

        public List<BeCancha> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeCancha pObject)
        {
            mCancha.Modificacion(pObject);
        }

        public void CambiarEstado(int pId, string pEstado)
        {
            mCancha.CambiarEstado(pId, pEstado);
        }

        public void CambiarObservaciones(int pId, string pObs)
        {
            mCancha.CambiarObservaciones(pId, pObs);
        }
    }
}
