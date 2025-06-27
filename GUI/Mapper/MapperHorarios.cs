using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperHorarios : IABMC<BeHorarios>
    {
        ArrayList arrayList;
        Dao dao = new Dao();
        public void Alta(BeHorarios pObject)
        {
            throw new NotImplementedException();
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeHorarios> Consulta()
        {
            string listarCancha = "sp_Listar_Horarios";
            DataTable dt = dao.Leer(listarCancha);
            List<BeHorarios> lHorarios = new List<BeHorarios>();
            foreach (DataRow dr in dt.Rows)
            {
                BeHorarios aux = new BeHorarios(dr.ItemArray);
                lHorarios.Add(aux);
            }
            return lHorarios;
        }

        public List<BeHorarios> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeHorarios pObject)
        {
            throw new NotImplementedException();
        }
    }
}
