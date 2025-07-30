using Be;
using Interface;
using Mapper;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllCliente : IABMC<BeCliente>
    {
        MapperCliente mCliente = new MapperCliente();

        public void Alta(BeCliente pObject)
        {
            mCliente.Alta(pObject); 
            new DigitoVerificador().RecalcularDVV("Cliente");
        }

        public void Baja(int pId)
        {
            mCliente.Baja(pId);
            new DigitoVerificador().RecalcularDVV("Cliente");
        }

        public List<BeCliente> Consulta()
        {
            return mCliente.Consulta();
        }

        public List<BeCliente> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeCliente pObject)
        {
            mCliente.Modificacion(pObject);
            new DigitoVerificador().RecalcularDVV("Cliente");
        }
    }
}
