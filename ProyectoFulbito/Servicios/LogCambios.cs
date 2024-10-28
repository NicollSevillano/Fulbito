using Be;
using Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class LogCambios
    {
        static Dao dao = new Dao();
        static ArrayList arrayList;

        public static void AgregarCambio(BeInsumo pInsumo, BelUsuario pUsuario)
        {
            string sp_Agregar_Cambio = "sp_Alta_Cambio";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoInsumo";
            p1.Value = pInsumo.id;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@fechaHora";
            p2.Value = DateTime.Now;
            p2.SqlDbType = SqlDbType.DateTime;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Nombre";
            p3.Value = pInsumo.Nombre;
            p3.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Existe";
            p4.Value = pInsumo.cantidadActual;
            p4.SqlDbType = SqlDbType.Int;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Descripcion";
            p5.Value = pInsumo.Observaciones;
            p5.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@Usuario";
            p6.Value = pUsuario.Nombre;
            p6.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p6);

            dao.Escribir(sp_Agregar_Cambio, arrayList);
        }
        public static void ActivarCambio(string pId, bool pActivo)
        {
            string sp_Activar_Cambio = "sp_Activar_Cambio";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCambio";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Activo";
            p2.Value = pActivo;
            p2.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p2);

            dao.Escribir(sp_Activar_Cambio, arrayList);
        }
        public static DataTable ConsultaCambio()
        {
            string listarBitacoraC = "sp_Listar_Cambio";
            DataTable dt = dao.Leer(listarBitacoraC);
            return dt;
        }
    }
}
