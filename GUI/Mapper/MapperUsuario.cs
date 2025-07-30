using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Be;
using Dal;
using Interface;
using Servicios;

namespace Mapper
{
    public class MapperUsuario : IABMC<BelUsuario>
    {
        ArrayList arrayList;
        Dao dao = new Dao();

        public void Alta(BelUsuario pObject)
        {
            string storeAlta = "sp_Usuario_Alta";
            arrayList = new ArrayList();

            arrayList.Add(new SqlParameter("@DNI", pObject.DNI) { SqlDbType = SqlDbType.NVarChar });
            arrayList.Add(new SqlParameter("@Nombre", pObject.Nombre) { SqlDbType = SqlDbType.NVarChar });
            arrayList.Add(new SqlParameter("@Apellido", pObject.Apellido) { SqlDbType = SqlDbType.NVarChar });
            arrayList.Add(new SqlParameter("@Email", pObject.Email) { SqlDbType = SqlDbType.NVarChar });
            arrayList.Add(new SqlParameter("@Rol", pObject.Perfil.id) { SqlDbType = SqlDbType.Int });
            arrayList.Add(new SqlParameter("@Usuario", pObject.Usuario) { SqlDbType = SqlDbType.VarChar });
            arrayList.Add(new SqlParameter("@Contraseña", pObject.Contraseña) { SqlDbType = SqlDbType.VarChar });
            arrayList.Add(new SqlParameter("@IdiomaId", pObject.IdiomaId.id) { SqlDbType = SqlDbType.Int });

            dao.Escribir(storeAlta, arrayList);
        }

        public void Baja(int pId)
        {
            string storeBaja = "sp_Usuario_Borrar";
            arrayList = new ArrayList
            {
                new SqlParameter("@CodigoUsuario", pId) { SqlDbType = SqlDbType.Int }
            };

            dao.Escribir(storeBaja, arrayList);
        }

        public void Modificacion(BelUsuario pObject)
        {
            string storeModificar = "sp_Usuario_Modificar";
            arrayList = new ArrayList
            {
                new SqlParameter("@CodigoUsuario", pObject.id) { SqlDbType = SqlDbType.Int },
                new SqlParameter("@DNI", pObject.DNI) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Nombre", pObject.Nombre) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Apellido", pObject.Apellido) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Email", pObject.Email) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Rol", pObject.Perfil.id) { SqlDbType = SqlDbType.Int },
                new SqlParameter("@Usuario", pObject.Usuario) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Contraseña", pObject.Contraseña) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("@Bloqueado", pObject.Bloqueado) { SqlDbType = SqlDbType.Bit },
                new SqlParameter("@Activo", pObject.Activo) { SqlDbType = SqlDbType.Bit },
                new SqlParameter("@Intentos", pObject.Intentos) { SqlDbType = SqlDbType.Int },
                new SqlParameter("@IdiomaId", pObject.IdiomaId.id) { SqlDbType = SqlDbType.Int }
            };

            dao.Escribir(storeModificar, arrayList);
        }

        public void Desbloquear(BelUsuario pCU)
        {
            string storeDesbloquear = "sp_Desbloquear_Usuario";
            arrayList = new ArrayList
            {
                new SqlParameter("@CodigoUsuario", pCU.id) { SqlDbType = SqlDbType.Int }
            };

            dao.Escribir(storeDesbloquear, arrayList);
        }

        public List<BelUsuario> Consulta()
        {
            string storedProcedure = "sp_Usuario_Listar";
            DataTable dt = dao.Leer(storedProcedure);
            List<BelUsuario> lUsuario = new List<BelUsuario>();
            PerfilManager.IniciarPerfilManager();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray.Length > 5 && dr["Rol"] != null)
                {
                    BelUsuario aux = new BelUsuario(dr.ItemArray);

                    aux.Perfil = PerfilManager.lPerfil?.Find(x => x.id == dr["Rol"].ToString());

                    string idiomaId = dr["IdiomaId"].ToString();
                    aux.IdiomaId = LanguageManager.lIdioma.Find(x => x.id == idiomaId);

                    lUsuario.Add(aux);
                }
            }

            return lUsuario;
        }

        public List<BelUsuario> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }
    }
}
