using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Servicios
{
    public class DigitoVerificador
    {
        private Dao dao = new Dao();

        public DataTable VerificarIntegridadGlobal()
        {
            return dao.Leer("Verificar_Integridad_Global");
        }

        public List<string> VerificarTabla(string tableName)
        {
            List<string> errores = new List<string>();
            DataTable dt = dao.Leer($"SELECT * FROM {tableName}");

            StringBuilder sbDVH = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string concat = "";
                int dvhIndex = row.Table.Columns["DVH"].Ordinal;
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    if (i == dvhIndex) continue;
                    concat += row[i]?.ToString() ?? "";
                }

                string dvhCalculado = GetSHA256Hex(concat);
                string dvhBD = row["DVH"].ToString();

                if (dvhCalculado != dvhBD)
                    errores.Add($"Registro ID: {row[0]} tiene DVH inválido.");

                sbDVH.Append(dvhBD);
            }

            string dvvCalculado = GetSHA256Hex(sbDVH.ToString());
            var parametros = new ArrayList();
            parametros.Add(new SqlParameter("@Tabla", tableName));
            DataTable dtDVV = dao.Leer("SELECT DVV FROM IntegrityControl WHERE Tabla = @Tabla", parametros);

            if (dtDVV.Rows.Count > 0)
            {
                string dvvBD = dtDVV.Rows[0]["DVV"].ToString();
                if (dvvBD != dvvCalculado)
                    errores.Add($"DVV de la tabla {tableName} es inválido.");
            }
            else
            {
                errores.Add($"No existe registro en IntegrityControl para la tabla {tableName}.");
            }

            return errores;
        }

        public void RecalcularTablas(string tableName)
        {
            DataTable dt = dao.Leer($"SELECT * FROM {tableName}");

            foreach (DataRow row in dt.Rows)
            {
                string concat = "";
                int dvhIndex = row.Table.Columns["DVH"].Ordinal;
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    if (i == dvhIndex) continue;
                    concat += row[i]?.ToString() ?? "";
                }

                string dvh = GetSHA256Hex(concat);

                var parametros = new ArrayList();
                string idCampo = tableName == "Cliente" ? "CodigoCliente" :
                                 tableName == "Cancha" ? "CodigoCancha" : "CodigoReserva";
                parametros.Add(new SqlParameter("@Id", row[idCampo]));
                parametros.Add(new SqlParameter("@DVH", dvh));

                dao.Escribir($"UPDATE {tableName} SET DVH = @DVH WHERE {idCampo} = @Id", parametros);
            }
            RecalcularTablaVertical(tableName);
        }
        public void RecalcularTablaVertical(string tableName)
        {
            string idCampo = tableName == "Cliente" ? "CodigoCliente" :
                             tableName == "Cancha" ? "CodigoCancha" :
                             tableName == "Reserva" ? "CodigoReserva" : null;

            if (idCampo == null)
                throw new Exception("No se reconoce el campo clave primaria para la tabla " + tableName);

            DataTable dt = dao.Leer($"SELECT DVH FROM {tableName} ORDER BY {idCampo}");

            StringBuilder sbDVH = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                if (row["DVH"] != DBNull.Value)
                    sbDVH.Append(row["DVH"].ToString());
            }

            string dvv = GetSHA256Hex(sbDVH.ToString());

            var checkParams = new ArrayList();
            checkParams.Add(new SqlParameter("@Tabla", tableName));
            DataTable dtCheck = dao.Leer("SELECT COUNT(*) as C FROM IntegrityControl WHERE Tabla = @Tabla", checkParams);

            var parametros = new ArrayList();
            parametros.Add(new SqlParameter("@Tabla", tableName));
            parametros.Add(new SqlParameter("@DVV", dvv));

            if (dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0]["C"]) > 0)
            {
                dao.Escribir("sp_ActualizarDVV", parametros);
            }
            else
            {
                dao.Escribir("sp_InsertarDVV", parametros);
            }
        }

        public string GetSHA256Hex(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = sha256.ComputeHash(encoding.GetBytes(input));
                var sb = new StringBuilder();
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }
        }
    }
}
