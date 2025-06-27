using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using ServicioClase;

namespace Servicios
{
    public static class PerfilManager
    {
        static Dao dao = new Dao();
        static ArrayList arrayList;
        public static List<Perfil> lPerfil;
        public static PermisoCompuesto pCompuestoRaiz;
        public static void IniciarPerfilManager()
        {
            pCompuestoRaiz = ConsultaPermiso()[0] as PermisoCompuesto;
            lPerfil = ConsultaPerfil();
        }
        //Perfiles
        private static void ActualizarPerfil()
        {
            lPerfil = ConsultaPerfil();
        }
        public static Perfil Perfil(string pId)
        {
            return lPerfil.Find(x => x.id == pId);
        }
        public static void ActualizaListaPerfil()
        {
            lPerfil = ConsultaPerfil();
        }
        public static void ModificarPerfil(Perfil pPerfil)
        {
            string spModificarPerfil = "sp_Modificar_Permiso_Perfil";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoPerfil";
            p1.Value = pPerfil.id;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Permiso";
            p2.Value = pPerfil.Permiso.id;
            p2.SqlDbType = SqlDbType.Int;
            arrayList.Add(p2);

            dao.Escribir(spModificarPerfil, arrayList);
            ActualizaListaPerfil();
        }
        public static void AltaNombrePerfil(Perfil pObject)
        {
            string spnombrePerfil = "sp_Alta_Nombre_Perfil";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Nombre";
            p1.Value = pObject.Nombre;
            p1.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p1);

            dao.Escribir(spnombrePerfil, arrayList);
            ActualizaListaPerfil();
        }
        public static void BajaPerfil(int pId)
        {
            string storeBajaPerfil = "sp_Eliminar_Perfil";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoPerfil";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);
            dao.Escribir(storeBajaPerfil, arrayList);

            ActualizarPerfil();
        }
        public static List<Perfil> ConsultaPerfil()
        {
            string storedProcedure = "sp_Listar_Perfil";
            DataTable dt = dao.Leer(storedProcedure);
            List<Perfil> lPerfil = new List<Perfil>();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray.Length > 2 && dr[2] != null)
                {
                    Perfil aux = new Perfil(dr.ItemArray);
                    aux.Permiso = pCompuestoRaiz?.BuscarPermisoId(dr[2].ToString(), pCompuestoRaiz);
                    lPerfil.Add(aux);
                }
            }
            return lPerfil;
        }
        //Permisos
        private static void ActualizarPermisos()
        {
            pCompuestoRaiz = ConsultaPermiso()[0] as PermisoCompuesto;
        }
        public static List<Permiso> ConsultaPermiso()
        {
            //Conseguir la lista de permisos 
            arrayList = new ArrayList();
            string storeConsulta = "sp_Listar_Permiso";
            DataTable dt = dao.Leer(storeConsulta);
            List<Permiso> listaPermiso = new List<Permiso>();
            List<Permiso> arbol = new List<Permiso>();

            foreach (DataRow dRow in dt.Rows)
            {
                if (bool.Parse(dRow[2].ToString()) == false)
                {
                    PermisoSimple pSimple = new PermisoSimple(dRow.ItemArray);
                    listaPermiso.Add(pSimple);
                }
                else
                {
                    PermisoCompuesto pCompuesto = new PermisoCompuesto(dRow.ItemArray);
                    listaPermiso.Add(pCompuesto);
                }
            }
            //armo las relaciones entre los permisos
            string storeCRelaciones = "sp_Listar_Relaciones";
            DataTable dT = dao.Leer(storeCRelaciones);
            PermisoCompuesto pCompuestoRelacion = new PermisoCompuesto("nRaiz");
            foreach (Permiso p in listaPermiso)
            {
                if (p is PermisoCompuesto)
                {
                    RelacionPermiso(p as PermisoCompuesto, dT, listaPermiso);
                    pCompuestoRelacion.AgregarPermiso(p);
                }
                else
                {
                    pCompuestoRelacion.AgregarPermiso(p);
                }
            }
            arbol.Add(pCompuestoRelacion);
            return arbol;
        }
        public static void RelacionPermiso(PermisoCompuesto pPermiso, DataTable pRelaciones, List<Permiso> pLista)
        {
            foreach (DataRow dRow in pRelaciones.Rows)
            {
                if (dRow[0].ToString() == (pPermiso.id).ToString())
                {
                    pPermiso.AgregarPermiso(pLista.Find(x => x.id == dRow[1].ToString()));
                }
            }
        }
        public static void AltaPermisoR(Permiso pObject, Permiso pPadre = null)
        {
            string storeAlta = "sp_Alta_Permiso";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.Value = pObject.Nombre;
            p1.ParameterName = "@Nombre";
            p1.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Bool";
            p2.SqlDbType = SqlDbType.Bit;
            if (pObject is PermisoSimple)
            {
                p2.Value = 0;
            }
            else
            {
                p2.Value = 1;
            }
            arrayList.Add(p2);

            dao.Escribir(storeAlta, arrayList);

            //Relación con padre
            if (pPadre != null)
            {
                arrayList.Clear();
                string storeRelacion = "sp_Relacion_Permiso";
                arrayList = new ArrayList();
                SqlParameter p3 = new SqlParameter();
                p2.ParameterName = "@Compuesto";
                p3.Value = pPadre.id;
                p3.SqlDbType = SqlDbType.Int;
                arrayList.Add(p3);

                SqlParameter p4 = new SqlParameter();
                p4.ParameterName = "@Simple";
                p4.Value = UltimoIdPermiso();
                p4.SqlValue = SqlDbType.Int;
                arrayList.Add(p4);

                dao.Escribir(storeRelacion, arrayList);
            }
            ActualizarPermisos();
        }
        private static string UltimoIdPermiso()
        {
            string storeUltimo = "sp_ListarUltimo_Permiso";
            DataTable dt = dao.Leer(storeUltimo);
            string id = dt.Rows[0].ItemArray[0].ToString();
            return id;
        }
        public static void BajaPermiso(string pId)
        {
            //Eliminar permiso
            string storeBaja = "sp_Eliminar_Permiso";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.Value = pId;
            p1.ParameterName = "@CodigoUsuario";
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);
            dao.Escribir(storeBaja, arrayList);

            //Eliminar relación permiso
            storeBaja = "sp_EliminarRelacion_Permiso";
            dao.Escribir(storeBaja, arrayList);

            ActualizarPermisos();
        }
    }
}
