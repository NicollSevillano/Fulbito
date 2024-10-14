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

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@DNI";
            p1.Value = pObject.DNI;
            p1.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Nombre";
            p2.Value = pObject.Nombre;
            p2.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Apellido";
            p3.Value = pObject.Apellido;
            p3.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Email";
            p4.Value = pObject.Email;
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Rol";
            p5.Value = pObject.Perfil.id;
            p5.SqlDbType = SqlDbType.Int;
            arrayList.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@Usuario";
            p6.Value = pObject.Usuario;
            p6.SqlDbType = SqlDbType.VarChar;
            arrayList.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@Contraseña";
            p7.Value = pObject.Contraseña;
            p7.SqlDbType = SqlDbType.VarChar;
            arrayList.Add(p7);

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

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoUsuario";
            p1.Value = pObject.id;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@DNI";
            p2.Value = pObject.DNI;
            p2.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Nombre";
            p3.Value = pObject.Nombre;
            p3.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Apellido";
            p4.Value = pObject.Apellido;
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Email";
            p5.Value = pObject.Email;
            p5.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p5);

            SqlParameter p6 = new SqlParameter();
            p6.ParameterName = "@Rol";
            p6.Value = pObject.Perfil.id;
            p6.SqlDbType = SqlDbType.Int;
            arrayList.Add(p6);

            SqlParameter p7 = new SqlParameter();
            p7.ParameterName = "@Usuario";
            p7.Value = pObject.Usuario;
            p7.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p7);

            SqlParameter p8 = new SqlParameter();
            p8.ParameterName = "@Contraseña";
            p8.Value = pObject.Contraseña;
            p8.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p8);

            SqlParameter p9 = new SqlParameter();
            p9.ParameterName = "@Bloqueado";
            p9.Value = pObject.Bloqueado;
            p9.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p9);

            SqlParameter p10 = new SqlParameter();
            p10.ParameterName = "@Activo";
            p10.Value = pObject.Activo;
            p10.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p10); 
            
            SqlParameter p11 = new SqlParameter();
            p11.ParameterName = "@Intentos";
            p11.Value = pObject.Intentos;
            p11.SqlDbType = SqlDbType.Bit;
            arrayList.Add(p11);

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
