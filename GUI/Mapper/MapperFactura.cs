using Be;
using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MapperFactura : IABMC<BeFactura>
    {
        ArrayList arrayList;
        Dao dao = new Dao();
        MapperReserva mreserva = new MapperReserva();
        public void Alta(BeFactura pObject)
        {
            string spAltaFactura = "sp_Alta_Factura";
            arrayList = new ArrayList();
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@codigoFactura";
            p1.Value = pObject.id;
            p1.SqlDbType = System.Data.SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@CodigoReserva";
            p2.Value = pObject.Reserva.id;
            p2.SqlDbType = System.Data.SqlDbType.Int;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@tipoPago";
            p3.Value = pObject.TipoPago;
            p3.SqlDbType = System.Data.SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Total";
            p4.Value = pObject.Total;
            p4.SqlDbType = System.Data.SqlDbType.Decimal;
            arrayList.Add(p4);

            dao.Escribir(spAltaFactura, arrayList);
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeFactura> Consulta()
        {
            throw new NotImplementedException();
        }

        public List<BeFactura> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeFactura pObject)
        {
            throw new NotImplementedException();
        }
    }
}
