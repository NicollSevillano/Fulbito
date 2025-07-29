using Be;
using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Mapper
{
    public class MapperAlquiler : IABMC<BeAlquiler>
    {
        Dao dao = new Dao();

        public void Alta(BeAlquiler pObject)
        {
            if (pObject.Cliente == null || !int.TryParse(pObject.Cliente.id, out int clienteId))
                throw new ArgumentException("ID de cliente inválido");

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SistemaF;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_Alta_AlquilerCompleto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CodigoCliente", clienteId);
                    cmd.Parameters.AddWithValue("@Horas", pObject.Horas);
                    cmd.Parameters.AddWithValue("@Total", pObject.Total);
                    cmd.Parameters.AddWithValue("@Fecha", pObject.Fecha);

                    DataTable detalleTable = new DataTable();
                    detalleTable.Columns.Add("CodigoInsumo", typeof(int));
                    detalleTable.Columns.Add("Cantidad", typeof(int));

                    foreach (var detalle in pObject.Detalle)
                    {
                        detalleTable.Rows.Add(detalle.CodigoInsumo, detalle.Cantidad);
                    }

                    SqlParameter tvp = new SqlParameter("@InsumosDetalle", SqlDbType.Structured)
                    {
                        TypeName = "dbo.T_InsumoDetalle",
                        Value = detalleTable
                    };
                    cmd.Parameters.Add(tvp);

                    SqlParameter outputId = new SqlParameter("@NuevoID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cmd.ExecuteNonQuery();

                    if (outputId.Value != DBNull.Value)
                        pObject.id = outputId.Value.ToString();
                }
            }
        }
        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }
        public BeCliente ObtenerPorId(int id)
        {
            var parametros = new ArrayList
            {
                new SqlParameter("@id", id)
            };

            DataTable tabla = dao.Leer("sp_ObtenerClientePorId", parametros);

            if (tabla.Rows.Count == 0) return null;

            DataRow fila = tabla.Rows[0];
            return new BeCliente
            {
                id = fila["id"].ToString(),
                DNI = fila["DNI"].ToString(),
                Nombre = fila["Nombre"].ToString(),
                Telefono = fila["Telefono"].ToString(),
                Direccion = fila["Direccion"].ToString()
            };
        }


        public List<BeAlquiler> Consulta()
        {
            List<BeAlquiler> lista = new List<BeAlquiler>();

            DataTable tabla = dao.Leer("sp_Listar_Alquileres");

            foreach (DataRow fila in tabla.Rows)
            {
                BeAlquiler alquiler = new BeAlquiler
                {
                    id = fila["CodigoAlquiler"].ToString(),
                    Horas = Convert.ToInt32(fila["Horas"]),
                    Total = Convert.ToDecimal(fila["Total"]),
                    Fecha = Convert.ToDateTime(fila["Fecha"]),
                    Cliente = new BeCliente
                    {
                        id = fila["CodigoCliente"].ToString(),
                        Nombre = fila["Nombre"].ToString()
                    }
                };

                lista.Add(alquiler);
            }

            return lista;
        }

        public List<BeAlquiler> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeAlquiler pObject)
        {
            throw new NotImplementedException();
        }
    }
}
