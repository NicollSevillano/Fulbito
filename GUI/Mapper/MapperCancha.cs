using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperCancha : IABMC<BeCancha>
    {
        Dao dao = new Dao();
        ArrayList arraylist;

        public void Alta(BeCancha pObject)
        {
            string spAltaCancha = "sp_Alta_Cancha";
            arraylist = new ArrayList();

            arraylist.Add(new SqlParameter("@TipoCancha", pObject.Nombre));
            arraylist.Add(new SqlParameter("@Precio", pObject.Precio));
            arraylist.Add(new SqlParameter("@Capacidad", pObject.Capacidad));
            arraylist.Add(new SqlParameter("@Estado", pObject.Estado));
            arraylist.Add(new SqlParameter("@Observaciones", pObject.Observaciones));

            dao.Escribir(spAltaCancha, arraylist);
        }

        public void Baja(int pId)
        {
            string spBajaCancha = "sp_Baja_Cancha";
            arraylist = new ArrayList();
            arraylist.Add(new SqlParameter("@IdCancha", pId));
            dao.Escribir(spBajaCancha, arraylist);
        }

        public List<BeCancha> Consulta()
        {
            string listarCancha = "sp_Listar_Cancha";
            DataTable dt = dao.Leer(listarCancha);
            List<BeCancha> lCancha = new List<BeCancha>();
            foreach (DataRow dr in dt.Rows)
            {
                BeCancha aux = new BeCancha(dr.ItemArray);
                lCancha.Add(aux);
            }
            return lCancha;
        }

        public void Modificacion(BeCancha pObject)
        {
            string spModificarCancha = "sp_Cancha_Modificar";
            arraylist = new ArrayList();
            arraylist.Add(new SqlParameter("@CodigoCancha", int.Parse(pObject.id)));
            arraylist.Add(new SqlParameter("@TipoCancha", pObject.Nombre));
            arraylist.Add(new SqlParameter("@Precio", pObject.Precio));
            arraylist.Add(new SqlParameter("@Capacidad", pObject.Capacidad));
            dao.Escribir(spModificarCancha, arraylist);
        }

        public void CambiarEstado(int idCancha, string nuevoEstado)
        {
            string sp = "sp_Cambiar_Estado_Cancha";
            var al = new ArrayList();
            al.Add(new SqlParameter("@CodigoCancha", idCancha));
            al.Add(new SqlParameter("@Estado", nuevoEstado));
            dao.Escribir(sp, al);
        }

        public void CambiarObservaciones(int idCancha, string nuevasObs)
        {
            string sp = "sp_Cambiar_Observaciones_Cancha";
            var al = new ArrayList();
            al.Add(new SqlParameter("@CodigoCancha", idCancha));
            al.Add(new SqlParameter("@Observaciones", nuevasObs));
            dao.Escribir(sp, al);
        }

        public List<BeCancha> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }
    }
}
