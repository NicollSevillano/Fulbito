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

namespace Mapper
{
    public class MapperReserva : IABMC<BeReserva>
    {
        Dao dao = new Dao();

        public void Alta(BeReserva pObject)
        {
            string storeAltaRerva = "sp_Alta_Reserva";
            ArrayList al = new ArrayList
            {
                new SqlParameter("@CodigoCancha", pObject.Cancha.id),
                new SqlParameter("@CodigoClient", pObject.Cliente.id),
                new SqlParameter("@Fecha", pObject.Fecha),
                new SqlParameter("@Hora", pObject.Hora),
                new SqlParameter("@Pagado", pObject.Pagado)
            };

            dao.Escribir(storeAltaRerva, al);

            var reservaInsertada = Consulta().LastOrDefault(r =>
                r.Cancha.id == pObject.Cancha.id &&
                r.Cliente.id == pObject.Cliente.id &&
                r.Fecha == pObject.Fecha &&
                r.Hora == pObject.Hora);

            if (reservaInsertada != null)
            {
                pObject.id = reservaInsertada.id;

                string datos = $"{pObject.id}|{pObject.Cancha.id}|{pObject.Cliente.id}|{pObject.Fecha:yyyy-MM-ddTHH:mm:ss}|{pObject.Hora:hh\\:mm\\:ss}|{pObject.Pagado}|{pObject.Cancelada}";
                string dvh = HashingHelper.CalcularHash(datos);

                ArrayList parametros = new ArrayList
                {
                    new SqlParameter("@Tabla", "Reserva"),
                    new SqlParameter("@Id", int.Parse(pObject.id)),
                    new SqlParameter("@DVH", dvh)
                };

                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
        }

        public void Baja(int pId)
        {
            ArrayList al = new ArrayList
            {
                new SqlParameter("@CodigoReserva", pId)
            };

            dao.Escribir("sp_Baja_Reserva", al);

            var reserva = Consulta().FirstOrDefault(r => r.id == pId.ToString());
            if (reserva != null)
            {
                string datos = $"{reserva.id}|{reserva.Cancha.id}|{reserva.Cliente.id}|{reserva.Fecha:yyyy-MM-ddTHH:mm:ss}|{reserva.Hora:hh\\:mm\\:ss}|{reserva.Pagado}|{reserva.Cancelada}";
                string dvh = HashingHelper.CalcularHash(datos);

                ArrayList parametros = new ArrayList
                {
                    new SqlParameter("@Tabla", "Reserva"),
                    new SqlParameter("@Id", int.Parse(reserva.id)),
                    new SqlParameter("@DVH", dvh)
                };

                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
        }

        public List<BeReserva> Consulta()
        {
            string storeListReserva = "sp_Listar_Reserva";
            DataTable dt = dao.Leer(storeListReserva);
            List<BeReserva> lReserva = new List<BeReserva>();

            MapperCancha mCancha = new MapperCancha();
            List<BeCancha> lCancha = mCancha.Consulta();
            MapperCliente mCliente = new MapperCliente();
            List<BeCliente> lCliente = mCliente.Consulta();

            foreach (DataRow dr in dt.Rows)
            {
                BeReserva aux = new BeReserva(dr.ItemArray);

                string idCancha = dr["CodigoCancha"].ToString();
                string idCliente = dr["CodigoClient"].ToString();

                aux.Cancha = lCancha.Find(x => x.id.ToString() == idCancha);
                aux.Cliente = lCliente.Find(x => x.id.ToString() == idCliente);

                lReserva.Add(aux);
            }
            return lReserva;
        }

        public List<BeReserva> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeReserva pObject)
        {
            throw new NotImplementedException(); 
        }

        public void ActualizarPago(string idReserva, bool pagado)
        {
            string updatePago = "sp_Actualizar_Pago_Reserva";
            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@IdReserva", Convert.ToInt32(idReserva)),
                new SqlParameter("@Pagado", pagado)
            };
            dao.Escribir(updatePago, parametros);
        }

        public void CancelarReserva(int idReserva)
        {
            string sp = "sp_Cancelar_Reserva";
            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@CodigoReserva", idReserva)
            };
            dao.Escribir(sp, parametros);

            var reserva = Consulta().FirstOrDefault(r => r.id == idReserva.ToString());
            if (reserva != null)
            {
                reserva.Cancelada = true;

                string datos = $"{reserva.id}|{reserva.Cancha.id}|{reserva.Cliente.id}|{reserva.Fecha:yyyy-MM-ddTHH:mm:ss}|{reserva.Hora:hh\\:mm\\:ss}|{reserva.Pagado}|{reserva.Cancelada}";
                string dvh = HashingHelper.CalcularHash(datos);

                ArrayList al = new ArrayList
                {
                    new SqlParameter("@Tabla", "Reserva"),
                    new SqlParameter("@Id", idReserva),
                    new SqlParameter("@DVH", dvh)
                };
                dao.Escribir("sp_Actualizar_DVH", al);
            }
        }
        public void ActualizarDVH(BeReserva r)
        {
            string idCancha = r.Cancha != null ? r.Cancha.id.ToString() : "0";
            string idCliente = r.Cliente != null ? r.Cliente.id.ToString() : "0";

            string datos = $"{r.id}|{idCancha}|{idCliente}|{r.Fecha:yyyy-MM-ddTHH:mm:ss}|{r.Hora:hh\\:mm\\:ss}|{r.Pagado}|{r.Cancelada}";
            string dvh = HashingHelper.CalcularHash(datos);

            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@Tabla", "Reserva"),
                new SqlParameter("@Id", int.Parse(r.id)),
                new SqlParameter("@DVH", dvh)
            };

            dao.Escribir("sp_Actualizar_DVH", parametros);
        }

    }
}
