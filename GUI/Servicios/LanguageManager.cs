using ServicioClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Dal;
using System.Xml.Schema;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace Servicios
{
    public static class LanguageManager 
    {
        static Dao dao = new Dao();
        static List<ITraducible> lTraducible;
        public static List<Idioma> lIdioma;
        public static int CodIdiomaActual { get; set; }
        public static void Iniciarlizar()
        {
            lTraducible = new List<ITraducible>();
            ConsultaIdioma();
        }
        public static void Suscribir(ITraducible objeto)
        {
            if(lTraducible == null) { lTraducible = new List<ITraducible>(); }
            lTraducible.Add(objeto);
        }
        public static void AltaEtiqueta(Idioma pIdioma, string pTag)
        {
            string altaEtiqueta = "sp_Alta_Etiqueta";
            ArrayList al = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoIdioma";
            p1.Value = pIdioma.id;
            p1.SqlDbType = System.Data.SqlDbType.Int;
            al.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Tag";
            p2.Value = pTag;
            p2.SqlDbType = SqlDbType.NVarChar;
            al.Add(p2);

            dao.Escribir(altaEtiqueta, al);
        }
        public static void ConsultaIdioma()
        {
            string consultaIdioma = "sp_Listar_Idioma";
            DataTable dt = dao.Leer(consultaIdioma);
            lIdioma = new List<Idioma>();
            ArrayList al = new ArrayList();
            //Crea idiomas
            foreach (DataRow dr in dt.Rows)
            {
                Idioma idioma = new Idioma(dr.ItemArray);
                lIdioma.Add(idioma);
                string codIdioma = dr.ItemArray[0].ToString();
                string conIdiomaEtiqueta = "sp_Consulta_Idioma_Etiqueta";
                SqlParameter p1 = new SqlParameter();
                p1.ParameterName = "@Idioma";
                p1.Value = codIdioma;
                p1.SqlDbType = SqlDbType.Int;
                al.Add(p1);
                DataTable dt2 = dao.Leer(conIdiomaEtiqueta, al);
                al.Clear();
                //cada etiqueta se agrega al idioma
                foreach (DataRow dr2 in dt2.Rows)
                {
                    Etiqueta etiqueta = new Etiqueta(dr2.ItemArray);
                    idioma.lEtiqueta.Add(etiqueta);
                }
            }
        }
        public static void Actualizar(int pIdioma)
        {
            CodIdiomaActual = pIdioma;
            foreach (ITraducible l in lTraducible)
            {
                l.Actualizar(pIdioma.ToString());
            }
        }
        public static Idioma idioma(int pIdioma)
        {
            return lIdioma.Find(x => x.id == pIdioma.ToString());
        }
    }
}
