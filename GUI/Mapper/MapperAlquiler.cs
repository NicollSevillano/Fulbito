using Be;
using Dal;
using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            using (SqlCommand cmd = new SqlCommand("sp_Alta_Alquiler", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoCliente", clienteId);
                cmd.Parameters.AddWithValue("@Horas", pObject.Horas);
                cmd.Parameters.AddWithValue("@Total", pObject.Total);

                SqlParameter outputId = new SqlParameter("@NuevoID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                conn.Open();
                cmd.ExecuteNonQuery();

                if (outputId.Value == DBNull.Value || outputId.Value == null)
                    throw new Exception("No se pudo obtener el ID del nuevo alquiler");

                pObject.id = outputId.Value.ToString();
            }
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeAlquiler> Consulta()
        {
            List<BeAlquiler> lista = new List<BeAlquiler>();

            DataTable tabla = dao.Leer("sp_Listar_Alquileres");

            foreach (DataRow fila in tabla.Rows)
            {
                BeAlquiler alquiler = new BeAlquiler
                {
                    id = fila["0"].ToString(),
                    Horas = Convert.ToInt32(fila["2"]),
                    Total = Convert.ToDecimal(fila["3"]),
                    Cliente = new BeCliente
                    {
                        Nombre = fila["1"].ToString()
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
