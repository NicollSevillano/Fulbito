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
    public class BllUsuario : IABMC<BelUsuario>
    {
        MapperUsuario mpUsuario = new MapperUsuario();
        public void Alta(BelUsuario pObject)
        {
            mpUsuario.Alta(pObject);
        }

        public void Baja(int pId)
        {
            mpUsuario.Baja(pId);
        }

        public List<BelUsuario> Consulta()
        {
            return mpUsuario.Consulta();
        }

        public List<BelUsuario> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Desbloquear(BelUsuario pUsuario)
        {
            
        }

        public void Modificacion(BelUsuario pObjeto)
        {
            mpUsuario.Modificacion(pObjeto);
        }
    }
}
