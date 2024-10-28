using Be;
using Dal;
using Interface;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MapperInsumo : IABMC<BeInsumo>
    {
        Dao dao = new Dao();
        ArrayList arraylist;
        public void Alta(BeInsumo pObject)
        {
            string sp_Alta_Insumo = "sp_Alta_Insumo";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@fechaHora";
            p1.Value = pObject.fechaHora;
            p1.SqlDbType = SqlDbType.DateTime;
            arraylist.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Nombre";
            p2.Value = pObject.Nombre;
            p2.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@cantidad";
            p3.Value = pObject.Cantidad;
            p3.SqlDbType = SqlDbType.Int;
            arraylist.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@cantidadActual";
            p4.Value = pObject.cantidadActual;
            p4.SqlDbType = SqlDbType.Int;
            arraylist.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Proveedor";
            p5.Value = pObject.Proveedor;
            p5.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@Estado";
            p6.Value = pObject.Estado;
            p6.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@Observaciones";
            p7.Value = pObject.Observaciones;
            p7.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p7);

            dao.Escribir(sp_Alta_Insumo, arraylist);
        }

        public void Baja(int pId)
        {
            string sp_BajaInsumo = "sp_Baja_Insumo";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoInsumo";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arraylist.Add(p1);

            dao.Escribir(sp_BajaInsumo, arraylist);
        }

        public List<BeInsumo> Consulta()
        {
            string sp_Listar_Insumo = "sp_Listar_Insumo";
            DataTable dt = dao.Leer(sp_Listar_Insumo);
            List<BeInsumo> lInsumo = new List<BeInsumo>();
            foreach (DataRow dr in dt.Rows)
            {
                BeInsumo aux = new BeInsumo(dr.ItemArray);
                lInsumo.Add(aux);
            }
            return lInsumo;
        }
        public void CambiarEstado(BeInsumo pObject)
        {
            string sp_CE_insumo = "sp_Cambiar_Estado_Insumo";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoInsumo";
            p1.Value = pObject.id;
            p1.SqlDbType = SqlDbType.Int;
            arraylist.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Estado";
            p2.Value = pObject.Estado;
            p2.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p2);

            dao.Escribir(sp_CE_insumo, arraylist);
        }
        public List<BeInsumo> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeInsumo pObject)
        {
            string spModificarInsumo = "sp_Insumo_Modificar";
            arraylist = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoInsumo";
            p1.Value = pObject.id;
            p1.SqlDbType = SqlDbType.Int;
            arraylist.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@fechaHora";
            p2.Value = pObject.fechaHora;
            p2.SqlDbType = SqlDbType.DateTime;
            arraylist.Add(p2);


            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Nombre";
            p3.Value = pObject.Nombre;
            p3.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@cantidadActual";
            p4.Value = pObject.cantidadActual;
            p4.SqlDbType = SqlDbType.Int;
            arraylist.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Proveedor";
            p5.Value = pObject.Proveedor;
            p5.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@Observaciones";
            p6.Value = pObject.Observaciones;
            p6.SqlDbType = SqlDbType.NVarChar;
            arraylist.Add(p6);

            dao.Escribir(spModificarInsumo, arraylist);
        }
    }
}
