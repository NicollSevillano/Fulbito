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
            new DigitoVerificador().RecalcularDVV("Cancha");
        }

        public void Baja(int pId)
        {
            mCancha.Baja(pId);
            new DigitoVerificador().RecalcularDVV("Cancha");
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
            new DigitoVerificador().RecalcularDVV("Cancha");
        }

        public void CambiarEstado(int pId, string pEstado)
        {
            mCancha.CambiarEstado(pId, pEstado);
            new DigitoVerificador().RecalcularDVV("Cancha");
        }

        public void CambiarObservaciones(int pId, string pObs)
        {
            mCancha.CambiarObservaciones(pId, pObs);
            new DigitoVerificador().RecalcularDVV("Cancha");
        }
    }
}
