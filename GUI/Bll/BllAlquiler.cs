using Be;
using Interface;
using Mapper;
using System;
using System.Collections.Generic;

namespace Bll
{
    public class BllAlquiler : IABMC<BeAlquiler>
    {
        private MapperAlquiler mapperAlquiler = new MapperAlquiler();

        public void Alta(BeAlquiler alquiler)
        {
            mapperAlquiler.Alta(alquiler);
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeAlquiler> Consulta()
        {
            return mapperAlquiler.Consulta();
        }

        public List<BeAlquiler> ConsultaCondicional(string condicion, string condicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeAlquiler alquiler)
        {
            throw new NotImplementedException();
        }
    }
}
