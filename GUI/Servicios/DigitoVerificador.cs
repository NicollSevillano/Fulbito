using Dal;
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

        public List<string> VerificarTabla(string tabla)
        {
            List<string> errores = new List<string>();

            string sp = $"sp_ListarDVH_{tabla}";
            DataTable dt = dao.Leer(sp);

            StringBuilder todosLosDVH = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                string dvhBD = row["DVH"].ToString();
                string dvhCalculado = CalcularDVH(row, tabla);

                todosLosDVH.Append(dvhBD);

                if (string.IsNullOrWhiteSpace(dvhBD))
                {
                    errores.Add($"Tabla: {tabla}, Registro ID: {id} tiene DVH vacío.");
                }
                else if (dvhBD != dvhCalculado)
                {
                    errores.Add($"Tabla: {tabla}, Registro ID: {id} tiene DVH incorrecto.");
                }
            }

            string nuevoDVV = GetSHA256Base64(todosLosDVH.ToString());

            var parametros = new ArrayList
            {
                new SqlParameter("@Tabla", tabla)
            };
            DataTable dvvTabla = dao.Leer("sp_Obtener_DVV", parametros);

            if (dvvTabla.Rows.Count == 0)
            {
                errores.Add($"No existe DVV para la tabla {tabla}.");
            }
            else
            {
                string dvvBD = dvvTabla.Rows[0]["DVV"].ToString();
                if (dvvBD != nuevoDVV)
                {
                    errores.Add($"DVV de la tabla {tabla} es inválido.");
                }
            }

            return errores;
        }

        public void RecalcularDVV(string tabla)
        {
            string sp = $"sp_ListarDVH_{tabla}";
            DataTable dt = dao.Leer(sp);

            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                if (row["DVH"] != DBNull.Value)
                    sb.Append(row["DVH"].ToString());
            }

            string nuevoDVV = GetSHA256Base64(sb.ToString());

            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@Tabla", tabla),
                new SqlParameter("@DVV", nuevoDVV)
            };

            dao.Escribir("sp_InsertarOVerwrite_DVV", parametros);
        }

        public void RecalcularDVH(string tabla)
        {
            string sp = $"sp_ListarDVH_{tabla}";
            DataTable dt = dao.Leer(sp);

            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                string dvh = CalcularDVH(row, tabla);

                ArrayList parametros = new ArrayList
                {
                    new SqlParameter("@Tabla", tabla),
                    new SqlParameter("@Id", int.Parse(id)),
                    new SqlParameter("@DVH", dvh)
                };

                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
        }

        private string CalcularDVH(DataRow row, string tabla)
        {
            switch (tabla)
            {
                case "Cliente":
                    return CalcularHash($"{row["Id"]}{row["DNI"]}{row["Nombre"]}{row["Telefono"]}{row["Direccion"]}");

                case "Cancha":
                    return CalcularHash($"{row["Id"]}{row["TipoCancha"]}{row["Precio"]}{row["Capacidad"]}{row["Estado"]}{row["Observaciones"]}");

                case "Reserva":
                    string cancelada = row["Cancelada"] == DBNull.Value ? "false" : row["Cancelada"].ToString();
                    return CalcularHash($"{row["Id"]}{row["CodigoClient"]}{row["CodigoCancha"]}{Convert.ToDateTime(row["Fecha"]).ToString("yyyy-MM-dd HH:mm")}{cancelada}");

                default:
                    return "";
            }
        }

        private string CalcularHash(string texto)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                return Convert.ToBase64String(hash);
            }
        }

        private string GetSHA256Base64(string input)
        {
            return CalcularHash(input);
        }
    }
}
