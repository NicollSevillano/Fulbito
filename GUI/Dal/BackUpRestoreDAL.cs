using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BackUpRestoreDAL
    {
        private string Conexion = "Data Source=.;Initial Catalog=SistemaF;Integrated Security=True";
        public void RealizarBackUp(string BackUpPath)
        {
            string nombreArchivo = $"SistemaF.BCK_{DateTime.Now:ddMMyy_HHmm}.bak";
            string rutaCompleta = System.IO.Path.Combine(BackUpPath, nombreArchivo);
            string comandoBackup = $"BACKUP DATABASE SistemaF TO DISK = '{rutaCompleta}'";

            using (SqlConnection con = new SqlConnection(Conexion))
            {
                SqlCommand cmd = new SqlCommand(comandoBackup, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void RealizarRestore(string backupFilePath)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion))
                {
                    conn.Open();
                    using (SqlCommand setMaster = new SqlCommand("USE master;", conn))
                    {
                        setMaster.ExecuteNonQuery();
                    }
                    using(SqlCommand setSigleUser = new SqlCommand("ALTER DATABASE SistemaF SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", conn))
                    {
                        setSigleUser.ExecuteNonQuery();
                    }
                    string query = $"RESTORE DATABASE SistemaF FROM DISK ='{backupFilePath}' WITH REPLACE;";
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    //using(SqlCommand setMultiUser = new SqlCommand("ALTER DATABASE SistemaF SET MULTI_USER;", conn))
                    //{
                    //    setMultiUser.ExecuteNonQuery();
                    //}
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al restaurar la BD: {ex.Message}");
            }
        }
    }
}
