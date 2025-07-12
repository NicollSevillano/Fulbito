using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperReserva : IABMC<BeReserva>
    {
        Dao dao = new Dao();

        public void Alta(BeReserva pObject)
        {
            string storeAltaRerva = "sp_Alta_Reserva";
            ArrayList al = new ArrayList();

            SqlParameter p1 = new SqlParameter("@CodigoCancha", pObject.Cancha.id);
            p1.SqlDbType = SqlDbType.Int;
            al.Add(p1);

            SqlParameter p2 = new SqlParameter("@CodigoClient", pObject.Cliente.id);
            p2.SqlDbType = SqlDbType.Int;
            al.Add(p2);

            SqlParameter p3 = new SqlParameter("@Fecha", pObject.Fecha);
            p3.SqlDbType = SqlDbType.DateTime;
            al.Add(p3);

            SqlParameter p4 = new SqlParameter("@Hora", pObject.Hora);
            p4.SqlDbType = SqlDbType.Time;
            al.Add(p4);

            SqlParameter p5 = new SqlParameter("@Pagado", pObject.Pagado);
            p5.SqlDbType = SqlDbType.Bit;
            al.Add(p5);

            dao.Escribir(storeAltaRerva, al);
        }

        public void Baja(int pId)
        {
            string storeBReserva = "sp_Baja_Reserva";
            var al = new ArrayList();

            SqlParameter p1 = new SqlParameter("@CodigoReserva", pId);
            p1.SqlDbType = SqlDbType.Int;
            al.Add(p1);
            dao.Escribir(storeBReserva, al);
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
            ArrayList parametros = new ArrayList();
            parametros.Add(new SqlParameter("@CodigoReserva", idReserva));
            dao.Escribir(sp, parametros);
        }

    }
}
