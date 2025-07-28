using Dal;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Servicios; 

namespace Servicios
{
    public class LogCambios
    {
        static Dao dao = new Dao();

        public static DataTable ConsultaCambio()
        {
            return dao.Leer("sp_Listar_Cambio");
        }

        public static DataTable ConsultaCambioPorFecha(DateTime desde, DateTime hasta)
        {
            ArrayList parametros = new ArrayList();

            SqlParameter p1 = new SqlParameter("@FechaInicio", SqlDbType.DateTime);
            p1.Value = desde;
            parametros.Add(p1);

            SqlParameter p2 = new SqlParameter("@FechaFin", SqlDbType.DateTime);
            p2.Value = hasta;
            parametros.Add(p2);

            return dao.Leer("sp_Listar_Cambio_Fecha", parametros);
        }

        public static void ActivarCambio(int idCambio, int codigoInsumo)
        {
            ArrayList parametros = new ArrayList();

            SqlParameter p1 = new SqlParameter("@CodigoCambio", SqlDbType.Int);
            p1.Value = idCambio;
            parametros.Add(p1);

            SqlParameter p2 = new SqlParameter("@CodigoInsumo", SqlDbType.Int);
            p2.Value = codigoInsumo;
            parametros.Add(p2);

            dao.Escribir("sp_Activar_Cambio", parametros);
        }
    }
}
