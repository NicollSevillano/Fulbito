using Be;
using Interface;
using Mapper;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllReserva : IABMC<BeReserva>
    {
        MapperReserva mReserva = new MapperReserva();
        public void Alta(BeReserva pObject)
        {
            mReserva.Alta(pObject);
            new DigitoVerificador().RecalcularDVV("Reserva");
        }

        public void Baja(int pId)
        {
            mReserva.Baja(pId);
            new DigitoVerificador().RecalcularDVV("Reserva");
        }

        public List<BeReserva> Consulta()
        {
            return mReserva.Consulta();
        }

        public List<BeReserva> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeReserva pObject)
        {
            throw new NotImplementedException();
        }
        public void Cancelar(int idReserva)
        {
            mReserva.CancelarReserva(idReserva);
            new DigitoVerificador().RecalcularDVV("Reserva");
        }
    }
}
