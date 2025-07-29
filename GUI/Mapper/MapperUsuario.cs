using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            arrayList.Add(new SqlParameter("@DNI", pObject.DNI));
            arrayList.Add(new SqlParameter("@Nombre", pObject.Nombre));
            arrayList.Add(new SqlParameter("@Apellido", pObject.Apellido));
            arrayList.Add(new SqlParameter("@Email", pObject.Email));
            arrayList.Add(new SqlParameter("@Rol", pObject.Perfil.id));
            arrayList.Add(new SqlParameter("@Usuario", pObject.Usuario));
            arrayList.Add(new SqlParameter("@Contraseña", pObject.Contraseña));
            arrayList.Add(new SqlParameter("@IdiomaId", pObject.IdiomaId)); 

            dao.Escribir(storeAlta, arrayList);
        }

        public void Baja(int pId)
        {
            string storeBaja = "sp_Usuario_Borrar";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoUsuario";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            dao.Escribir(storeBaja, arrayList);
        }


        public List<BelUsuario> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BelUsuario pObject)
        {
            string storeModificar = "sp_Usuario_Modificar";
            arrayList = new ArrayList();

            arrayList.Add(new SqlParameter("@CodigoUsuario", pObject.id));
            arrayList.Add(new SqlParameter("@DNI", pObject.DNI));
            arrayList.Add(new SqlParameter("@Nombre", pObject.Nombre));
            arrayList.Add(new SqlParameter("@Apellido", pObject.Apellido));
            arrayList.Add(new SqlParameter("@Email", pObject.Email));
            arrayList.Add(new SqlParameter("@Rol", pObject.Perfil.id));
            arrayList.Add(new SqlParameter("@Usuario", pObject.Usuario));
            arrayList.Add(new SqlParameter("@Contraseña", pObject.Contraseña));
            arrayList.Add(new SqlParameter("@Bloqueado", pObject.Bloqueado));
            arrayList.Add(new SqlParameter("@Activo", pObject.Activo));

            var pIntentos = new SqlParameter("@Intentos", SqlDbType.Int); 
            pIntentos.Value = pObject.Intentos;
            arrayList.Add(pIntentos);

            var pIdioma = new SqlParameter("@IdiomaId", SqlDbType.Int); 
            pIdioma.Value = pObject.IdiomaId;
            arrayList.Add(pIdioma);

            dao.Escribir(storeModificar, arrayList);
        }

        public void Desbloquear(BelUsuario pCU)
        {
            string storeDesbloquear = "sp_Desbloquear_Usuario";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoUsuario";
            p1.Value = pCU.id;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

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
                    lUsuario.Add(aux);
                }
            }
            return lUsuario;
        }
    }
}
