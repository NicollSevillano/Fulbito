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

        public List<string> VerificarTabla(string tableName)
        {
            List<string> errores = new List<string>();
            DataTable dt = dao.Leer(GetListarSP(tableName));
            StringBuilder sbDVH = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string concat = ConcatenarCampos(tableName, row);
                string dvhCalculado = GetSHA256Hex(concat);
                string dvhBD = row["DVH"].ToString();

                if (dvhCalculado != dvhBD)
                    errores.Add($"Registro ID: {GetIdCampo(tableName, row)} tiene DVH inválido.");

                sbDVH.Append(dvhBD);
            }

            string dvvCalculado = GetSHA256Hex(sbDVH.ToString());
            var parametros = new ArrayList();
            parametros.Add(new SqlParameter("@Tabla", tableName));
            DataTable dtDVV = dao.Leer("sp_Obtener_DVV", parametros);

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
            DataTable dt = dao.Leer(GetListarSP(tableName));
            foreach (DataRow row in dt.Rows)
            {
                string concat = ConcatenarCampos(tableName, row);
                string dvh = GetSHA256Hex(concat);

                var parametros = new ArrayList();
                string idCampo = GetIdCampoNombre(tableName);
                parametros.Add(new SqlParameter("@Id", row[idCampo]));
                parametros.Add(new SqlParameter("@DVH", dvh));
                parametros.Add(new SqlParameter("@Tabla", tableName));
                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
            RecalcularTablaVertical(tableName);
        }

        public void RecalcularTablaVertical(string tableName)
        {
            string sp = GetListarDVHSP(tableName);
            DataTable dt = dao.Leer(sp);
            StringBuilder sbDVH = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                if (row["DVH"] != DBNull.Value)
                    sbDVH.Append(row["DVH"].ToString());
            }
            string dvv = GetSHA256Hex(sbDVH.ToString());

            var parametros = new ArrayList();
            parametros.Add(new SqlParameter("@Tabla", tableName));
            parametros.Add(new SqlParameter("@DVV", dvv));
            dao.Escribir("sp_InsertarDVV", parametros);
        }

        private string GetListarSP(string tableName)
        {
            switch (tableName)
            {
                case "Cliente": return "sp_Cliente_Listar";
                case "Cancha": return "sp_Listar_Cancha";
                case "Reserva": return "sp_Listar_Reserva";
                default: throw new Exception("Tabla no reconocida");
            }
        }

        private string GetListarDVHSP(string tableName)
        {
            switch (tableName)
            {
                case "Cliente": return "sp_ListarDVH_Cliente";
                case "Cancha": return "sp_ListarDVH_Cancha";
                case "Reserva": return "sp_ListarDVH_Reserva";
                default: throw new Exception("Tabla no reconocida");
            }
        }

        private string GetIdCampoNombre(string tableName)
        {
            switch (tableName)
            {
                case "Cliente": return "CodigoCliente";
                case "Cancha": return "CodigoCancha";
                case "Reserva": return "CodigoReserva";
                default: throw new Exception("Tabla no reconocida");
            }
        }
        private object GetIdCampo(string tableName, DataRow row)
        {
            return row[GetIdCampoNombre(tableName)];
        }

        private string ConcatenarCampos(string tableName, DataRow row)
        {
            switch (tableName)
            {
                case "Cliente":
                    return $"{row["CodigoCliente"].ToString().Trim()}{row["DNI"].ToString().Trim()}{row["Nombre"].ToString().Trim()}{row["Telefono"].ToString().Trim()}{row["Direccion"].ToString().Trim()}";

                case "Cancha":
                    return $"{row["CodigoCancha"].ToString().Trim()}{row["TipoCancha"].ToString().Trim()}{row["Precio"].ToString().Trim()}{row["Capacidad"].ToString().Trim()}{row["Estado"].ToString().Trim()}{row["Observaciones"].ToString().Trim()}";

                case "Reserva":
                    return $"{row["CodigoReserva"].ToString().Trim()}{row["Fecha"].ToString().Trim()}{row["Hora"].ToString().Trim()}{row["CodigoClient"].ToString().Trim()}{row["CodigoCancha"].ToString().Trim()}{row["Pagado"].ToString().Trim()}{row["Cancelada"].ToString().Trim()}";

                default: throw new Exception("Tabla no reconocida");
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
