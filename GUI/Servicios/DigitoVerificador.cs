using Dal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Servicios
{
    public class DigitoVerificador
    {
        private Dao dao = new Dao();

        public List<string> VerificarTabla(string tableName)
        {
            List<string> errores = new List<string>();

            string spListarDVH = $"sp_ListarDVH_{tableName}";
            DataTable dtDVH = dao.Leer(spListarDVH);

            StringBuilder sbDVH = new StringBuilder();
            foreach (DataRow row in dtDVH.Rows)
            {
                string dvhActual = row["DVH"]?.ToString() ?? "";
                sbDVH.Append(dvhActual);

                if (string.IsNullOrWhiteSpace(dvhActual))
                {
                    errores.Add($"Registro ID: {row[0]} tiene DVH vacío.");
                }
            }

            string nuevoDVV = GetSHA256Base64(sbDVH.ToString());

            var parametros = new ArrayList { new SqlParameter("@Tabla", tableName) };
            DataTable dtDVV = dao.Leer("sp_Obtener_DVV", parametros);

            if (dtDVV.Rows.Count == 0)
            {
                errores.Add($"No existe DVV para la tabla {tableName}.");
            }
            else
            {
                string dvvBD = dtDVV.Rows[0]["DVV"].ToString();
                if (dvvBD != nuevoDVV)
                {
                    errores.Add($"DVV de la tabla {tableName} es inválido.");
                }
            }

            return errores;
        }

        public void RecalcularDVV(string tableName)
        {
            string spListarDVH = $"sp_ListarDVH_{tableName}";
            DataTable dtDVH = dao.Leer(spListarDVH);

            StringBuilder sbDVH = new StringBuilder();
            foreach (DataRow row in dtDVH.Rows)
            {
                if (row["DVH"] != DBNull.Value)
                    sbDVH.Append(row["DVH"].ToString());
            }

            string nuevoDVV = GetSHA256Base64(sbDVH.ToString());

            var parametros = new ArrayList
        {
            new SqlParameter("@Tabla", tableName),
            new SqlParameter("@DVV", nuevoDVV)
        };

            dao.Escribir("sp_InsertarOVerwrite_DVV", parametros);
        }

        private string GetSHA256Base64(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }

}
