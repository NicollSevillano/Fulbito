using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DigitoVerificador
    {
        private Dao dao = new Dao();

        public DataTable VerificarIntegridadGlobal()
        {
            return dao.Leer("Verificar_Integridad_Global");
        }
        public List<String> VerificarTabla(string tableName)
        {
            List<String> errores = new List<string>();
            DataTable dt = dao.Leer($"SELECT * FROM {tableName}");

            StringBuilder sbDVH = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string concat = string.Empty;

                if (tableName == "Cliente")
                    concat = $"{row["CodigoCliente"]}|{row["DNI"]}|{row["Nombre"]}|{row["Telefono"]}|{row["Direccion"]}";
                else if (tableName == "Cancha")
                    concat = $"{row["CodigoCancha"]}|{row["TipoCancha"]}|{row["Precio"]}|{row["Capacidad"]}|{row["Estado"]}|{row["Observaciones"]}";
                else if (tableName == "Reserva")
                    concat = $"{row["CodigoReserva"]}|{row["CodigoCancha"]}|{row["CodigoClient"]}|{row["Fecha"]}|{row["Hora"]}|{row["Pagado"]}";

                string dvhCalculado = SHA256Base64(concat);
                string dvhBD = row["DVH"].ToString();

                if (dvhCalculado != dvhBD)
                    errores.Add($"Registro ID: {row[0]} tiene DVH inválido.");

                sbDVH.Append(dvhBD);
            }

            string dvvCalculado = SHA256Base64(sbDVH.ToString());
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
                string concat = string.Empty;

                if (tableName == "Cliente")
                    concat = $"{row["CodigoCliente"]}|{row["DNI"]}|{row["Nombre"]}|{row["Telefono"]}|{row["Direccion"]}";
                else if (tableName == "Cancha")
                    concat = $"{row["CodigoCancha"]}|{row["TipoCancha"]}|{row["Precio"]}|{row["Capacidad"]}|{row["Estado"]}|{row["Observaciones"]}";
                else if (tableName == "Reserva")
                    concat = $"{row["CodigoReserva"]}|{row["CodigoCancha"]}|{row["CodigoClient"]}|{row["Fecha"]}|{row["Hora"]}|{row["Pagado"]}";

                string dvh = SHA256Base64(concat);

                var parametros = new System.Collections.ArrayList();
                string idCampo = tableName == "Cliente" ? "CodigoCliente" :
                                 tableName == "Cancha" ? "CodigoCancha" : "CodigoReserva";
                parametros.Add(new System.Data.SqlClient.SqlParameter("@Id", row[idCampo]));
                parametros.Add(new System.Data.SqlClient.SqlParameter("@DVH", dvh));

                dao.Escribir($"UPDATE {tableName} SET DVH = @DVH WHERE {idCampo} = @Id", parametros);
            }
        }
        public void RecalcularTablaVertical(string tableName)
        {
            DataTable dt = dao.Leer($"SELECT DVH FROM {tableName} ORDER BY 1"); 
            StringBuilder sbDVH = new StringBuilder();

            foreach (DataRow row in dt.Rows)
                sbDVH.Append(row["DVH"].ToString());

            string dvv = SHA256Base64(sbDVH.ToString());

            var parametros = new System.Collections.ArrayList();
            parametros.Add(new System.Data.SqlClient.SqlParameter("@DVV", dvv));
            parametros.Add(new System.Data.SqlClient.SqlParameter("@Tabla", tableName));

            dao.Escribir("UPDATE IntegrityControl SET DVV = @DVV, FechaActualización = GETDATE() WHERE Tabla = @Tabla", parametros);
        }

        public string SHA256Base64(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
