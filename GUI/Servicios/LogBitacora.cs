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
    public class LogBitacora
    {
        static Dao dao = new Dao();
        static ArrayList arrayList;

        public static void AgregarEvento(string pLog, int pCriticidad, BelUsuario pUsuario, string pModulo)
        {
            string altaBitacora = "sp_Alta_Bitacora";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Fecha";
            p1.Value = DateTime.Now;
            p1.SqlDbType = SqlDbType.DateTime;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Texto";
            p2.Value = pLog;
            p2.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Criticidad";
            p3.Value = pCriticidad;
            p3.SqlDbType = SqlDbType.Int;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Usuario";
            p4.Value = pUsuario.Usuario;
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Modulo";
            p5.Value = pModulo;
            p5.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p5);

            dao.Escribir(altaBitacora, arrayList);
        }
        public static DataTable ConsultaBitacora()
        {
            string listarBitacoraE = "sp_Listar_Bitacora";
            DataTable dt = dao.Leer(listarBitacoraE);
            return dt;
        }
    }
}
