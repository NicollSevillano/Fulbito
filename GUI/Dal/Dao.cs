using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class Dao
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=SistemaF;Integrated Security=True");
        private SqlTransaction transaction;
        private SqlCommand cmd;

        public DataTable Leer(string storeProcedure, ArrayList pParametros = null)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter;
            cmd = new SqlCommand(storeProcedure, conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                if (pParametros != null)
                {
                    foreach (SqlParameter parameter in pParametros)
                    {
                        cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public int Escribir(string storeProcedure, ArrayList pParametros = null)
        {
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();
                cmd = new SqlCommand(storeProcedure, conexion, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                if (pParametros != null)
                {
                    foreach (SqlParameter parameter in pParametros)
                    {
                        cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                    }
                }
                int respuesta = cmd.ExecuteNonQuery();
                transaction.Commit();
                return respuesta;
            }
            catch (SqlException)
            {
                transaction.Rollback();
                return -1;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return -1;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
