using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Be;
using Dal;
using Interface;

namespace Mapper
{
    public class MapperReserva : IABMC<BeReserva>
    {
        ArrayList al;
        Dao dao = new Dao();
        public void Alta(BeReserva pObject)
        {
            string storeAltaRerva = "sp_Alta_Reserva";
            al = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCancha";
            p1.Value = pObject.Cancha.id;
            p1.SqlDbType = SqlDbType.Int;
            al.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@CodigoCliente";
            p2.Value = pObject.Cliente.id;
            p2.SqlDbType = SqlDbType.Int;
            al.Add(p2);

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@Fecha";
            p3.Value = pObject.Fecha;
            p3.SqlDbType = SqlDbType.DateTime;
            al.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Hora";
            p4.Value = pObject.Hora;
            p4.SqlDbType = SqlDbType.Time;
            al.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Pagado";
            p5.Value = pObject.Pagado;
            p5.SqlDbType = SqlDbType.Bit;
            al.Add(p5);

            dao.Escribir(storeAltaRerva, al);
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeReserva> Consulta()
        {
            string storeListReserva = "sp_Listar_Reserva";
            DataTable dt = dao.Leer(storeListReserva);
            List<BeReserva> lReserva = new List<BeReserva>();
            MapperCancha cancha = new MapperCancha();
            List<BeCancha> lCancha = cancha.Consulta();
            lCancha.AddRange(new BeCancha[] {new BeCancha() { id = "1", Nombre = "Cancha 5 A", Precio = "1500"},
                                             new BeCancha() { id = "2", Nombre = "Cancha 5 B", Precio = "1500"},
                                             new BeCancha() { id = "3", Nombre = "Cancha 5 C", Precio = "1500"},
                                             new BeCancha() { id = "4", Nombre = "Cancha 7 A", Precio = "2000"},
                                             new BeCancha() { id = "5", Nombre = "Cancha 7 B", Precio = "2000"},
                                             new BeCancha() { id = "7", Nombre = "Cancha 7 C", Precio = "2000"},
                                             new BeCancha() { id = "8", Nombre = "Cancha 7 D", Precio = "2000"},
                                             new BeCancha() { id = "9", Nombre = "Cancha 11 A", Precio = "3000"},
                                             new BeCancha() { id = "10", Nombre = "Cancha 11 B", Precio = "3000"}});
            List<BeCliente> lCliente = new List<BeCliente>();
            MapperCliente mCliente = new MapperCliente();
            lCliente = mCliente.Consulta();

            foreach (DataRow dr in dt.Rows)
            {
                BeReserva aux = new BeReserva(dr.ItemArray);
                aux.Cancha = lCancha.Find(x => x.id == dr[1].ToString());
                aux.Cliente = lCliente.Find(x => x.id == dr[2].ToString());
                lReserva.Add(aux);
            }
            //string storeListReserva = "sp_Listar_Reserva";
            //DataTable dt = dao.Leer(storeListReserva);
            //List<BeReserva> lReserva = new List<BeReserva>();
            //MapperCancha mCancha = new MapperCancha();
            //List<BeCancha> lCancha = new List<BeCancha>();
            //lCancha = mCancha.Consulta();
            //MapperCliente mCliente = new MapperCliente();
            //List<BeCliente> lCliente = new List<BeCliente>();
            //lCliente = mCliente.Consulta();
            //foreach (DataRow dr in dt.Rows)
            //{

            //    BeReserva aux = new BeReserva(dr.ItemArray);
            //    aux.Cancha = lCancha.Find(x => x.id == dr[1].ToString());
            //    aux.Cliente = lCliente.Find(x => x.id == dr[2].ToString());
            //    lReserva.Add(aux);
            //}
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
            ArrayList parametros = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@IdReserva";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Value = idReserva;
            parametros.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Pagado";
            p2.SqlDbType = SqlDbType.Bit;
            p2.Value = pagado;
            parametros.Add(p2);

            dao.Escribir(updatePago, parametros);
        }
    }
}
