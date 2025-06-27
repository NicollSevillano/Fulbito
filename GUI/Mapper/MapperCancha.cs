using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@TipoCancha";
            p1.Value = pObject.Nombre;
            p1.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Precio";
            p2.Value = pObject.Precio;
            p2.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Capacidad";
            p3.Value = pObject.Capacidad;
            p3.SqlDbType = SqlDbType.Int;
            arraylist.Add(p3);

            dao.Escribir(spAltaCancha, arraylist);
        }

        public void Baja(int pId)
        {
            string spBajaCancha = "sp_Baja_Cancha";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@IdCancha";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arraylist.Add(p1);

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

        public List<BeCancha> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeCancha pObject)
        {
            string spModificarCancha = "sp_Cancha_Modificar";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCancha";
            p1.Value = pObject.id;
            p1.SqlDbType = SqlDbType.Int;
            arraylist.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@TipoCancha";
            p2.Value = pObject.Nombre;
            p2.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Precio";
            p3.Value = pObject.Precio;
            p3.SqlDbType = SqlDbType.Decimal;
            arraylist.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Estado";
            p4.Value = pObject.Estado;
            p4.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Observaciones";
            p5.Value = pObject.Observaciones;
            p5.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p5);

            dao.Escribir(spModificarCancha, arraylist);
        }
    }
}
