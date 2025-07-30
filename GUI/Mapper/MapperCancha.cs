using Be;
using Dal;
using Interface;
using Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Mapper
{
    public class MapperCancha : IABMC<BeCancha>
    {
        Dao dao = new Dao();
        ArrayList arraylist;

        public void Alta(BeCancha pObject)
        {
            string spAltaCancha = "sp_Alta_Cancha";
            arraylist = new ArrayList
            {
                new SqlParameter("@TipoCancha", pObject.Nombre),
                new SqlParameter("@Precio", pObject.Precio),
                new SqlParameter("@Capacidad", pObject.Capacidad),
                new SqlParameter("@Estado", pObject.Estado),
                new SqlParameter("@Observaciones", pObject.Observaciones)
            };

            dao.Escribir(spAltaCancha, arraylist);

            var canchaInsertada = Consulta().LastOrDefault(c =>
                c.Nombre == pObject.Nombre &&
                c.Precio == pObject.Precio &&
                c.Capacidad == pObject.Capacidad &&
                c.Estado == pObject.Estado &&
                c.Observaciones == pObject.Observaciones);

            if (canchaInsertada != null)
            {
                pObject.id = canchaInsertada.id;

                string concatenado = $"{pObject.id}|{pObject.Nombre}|{pObject.Precio}|{pObject.Capacidad}|{pObject.Estado}|{pObject.Observaciones}";
                string dvh = HashingHelper.CalcularHash(concatenado);

                ArrayList parametros = new ArrayList
                {
                    new SqlParameter("@Tabla", "Cancha"),
                    new SqlParameter("@Id", int.Parse(pObject.id)),
                    new SqlParameter("@DVH", dvh)
                };

                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
        }

        public void Baja(int pId)
        {
            string spBajaCancha = "sp_Baja_Cancha";
            arraylist = new ArrayList { new SqlParameter("@IdCancha", pId) };
            dao.Escribir(spBajaCancha, arraylist);
        }

        public List<BeCancha> Consulta()
        {
            string listarCancha = "sp_Listar_Cancha";
            DataTable dt = dao.Leer(listarCancha);
            List<BeCancha> lCancha = new List<BeCancha>();
            foreach (DataRow dr in dt.Rows)
            {
                BeCancha aux = new BeCancha(dr.ItemArray);
                lCancha.Add(aux);
            }
            return lCancha;
        }

        public void Modificacion(BeCancha pObject)
        {
            string spModificarCancha = "sp_Cancha_Modificar";
            arraylist = new ArrayList
            {
                new SqlParameter("@CodigoCancha", int.Parse(pObject.id)),
                new SqlParameter("@TipoCancha", pObject.Nombre),
                new SqlParameter("@Precio", pObject.Precio),
                new SqlParameter("@Capacidad", pObject.Capacidad)
            };
            dao.Escribir(spModificarCancha, arraylist);

            string concatenado = $"{pObject.id}|{pObject.Nombre}|{pObject.Precio}|{pObject.Capacidad}|{pObject.Estado}|{pObject.Observaciones}";
            string dvh = HashingHelper.CalcularHash(concatenado);

            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@Tabla", "Cancha"),
                new SqlParameter("@Id", int.Parse(pObject.id)),
                new SqlParameter("@DVH", dvh)
            };

            dao.Escribir("sp_Actualizar_DVH", parametros);
        }

        public void CambiarEstado(int idCancha, string nuevoEstado)
        {
            string sp = "sp_Cambiar_Estado_Cancha";
            var al = new ArrayList
            {
                new SqlParameter("@CodigoCancha", idCancha),
                new SqlParameter("@Estado", nuevoEstado)
            };
            dao.Escribir(sp, al);
        }

        public void CambiarObservaciones(int idCancha, string nuevasObs)
        {
            string sp = "sp_Cambiar_Observaciones_Cancha";
            var al = new ArrayList
            {
                new SqlParameter("@CodigoCancha", idCancha),
                new SqlParameter("@Observaciones", nuevasObs)
            };
            dao.Escribir(sp, al);
        }

        public List<BeCancha> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }
        public void ActualizarDVH(BeCancha c)
        {
            string datos = $"{c.id}|{c.Nombre}|{c.Precio}|{c.Capacidad}|{c.Estado}|{c.Observaciones}";
            string dvh = HashingHelper.CalcularHash(datos);

            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@Tabla", "Cancha"),
                new SqlParameter("@Id", int.Parse(c.id)),
                new SqlParameter("@DVH", dvh)
            };

            dao.Escribir("sp_Actualizar_DVH", parametros);
        }
    }
}
