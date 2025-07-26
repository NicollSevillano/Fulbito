using Be;
using Dal;
using Interface;
using Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

            arraylist.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = pObject.Nombre });
            arraylist.Add(new SqlParameter("@cantidad", SqlDbType.Int) { Value = pObject.Cantidad });
            arraylist.Add(new SqlParameter("@cantidadActual", SqlDbType.Int) { Value = pObject.cantidadActual });
            arraylist.Add(new SqlParameter("@Proveedor", SqlDbType.NVarChar) { Value = pObject.Proveedor });
            arraylist.Add(new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = pObject.Estado });
            arraylist.Add(new SqlParameter("@Observaciones", SqlDbType.NVarChar) { Value = pObject.Observaciones });

            string usuario = SessionManager.getInstance?.usuario?.Usuario ?? "Desconocido";
            arraylist.Add(new SqlParameter("@Usuario", SqlDbType.NVarChar) { Value = usuario });

            dao.Escribir(sp_Alta_Insumo, arraylist);
        }

        public void Baja(int pId)
        {
            string sp_BajaInsumo = "sp_Baja_Insumo";
            arraylist = new ArrayList();

            arraylist.Add(new SqlParameter("@CodigoInsumo", SqlDbType.Int) { Value = pId });

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

            arraylist.Add(new SqlParameter("@CodigoInsumo", SqlDbType.Int) { Value = pObject.id });
            arraylist.Add(new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = pObject.Estado });

            dao.Escribir(sp_CE_insumo, arraylist);
        }

        public List<BeInsumo> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeInsumo pObject)
        {
            string spModificarInsumo = "sp_Modificar_Insumo";
            arraylist = new ArrayList();

            arraylist.Add(new SqlParameter("@CodigoInsumo", SqlDbType.Int) { Value = int.Parse(pObject.id) });
            arraylist.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = pObject.Nombre });
            arraylist.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = pObject.Cantidad });
            arraylist.Add(new SqlParameter("@CantidadActual", SqlDbType.Int) { Value = pObject.cantidadActual });
            arraylist.Add(new SqlParameter("@Proveedor", SqlDbType.NVarChar) { Value = pObject.Proveedor });
            arraylist.Add(new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = pObject.Estado });
            arraylist.Add(new SqlParameter("@Observaciones", SqlDbType.NVarChar) { Value = pObject.Observaciones });

            string usuario = SessionManager.getInstance?.usuario?.Usuario ?? "Desconocido";
            arraylist.Add(new SqlParameter("@Usuario", SqlDbType.NVarChar) { Value = usuario });

            dao.Escribir(spModificarInsumo, arraylist);
        }
    }
}
