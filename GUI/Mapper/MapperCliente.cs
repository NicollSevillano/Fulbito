using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Be;
using System.Collections;
using Dal;
using System.Data.SqlClient;
using System.Data;

namespace Mapper
{
    public class MapperCliente : IABMC<BeCliente>
    {
        ArrayList arrayList;
        Dao dao = new Dao();

        public void Alta(BeCliente pObject)
        {
            string storeACliente = "sp_Cliente_Alta";
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
            p3.ParameterName = "@Telefono";
            p3.Value = pObject.Telefono;
            p3.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p3);

            SqlParameter p4 = new SqlParameter();
            p4.ParameterName = "@Direccion";
            p4.Value = pObject.Direccion;
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            dao.Escribir(storeACliente, arrayList);
        }

        public void Baja(int pId)
        {
            string storeBCliente = "sp_Cliente_Baja";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCliente";
            p1.Value = pId;
            p1.SqlDbType = SqlDbType.Int;
            arrayList.Add(p1);

            dao.Escribir(storeBCliente, arrayList);
            storeBCliente = "sp_Baja_Reserva";
            dao.Escribir(storeBCliente, arrayList);
        }

        public List<BeCliente> Consulta()
        {
            string storeLCliente = "sp_Cliente_Listar";
            DataTable dt = dao.Leer(storeLCliente);
            List<BeCliente> lCliente = new List<BeCliente>();

            foreach (DataRow dr in dt.Rows)
            {
                BeCliente aux = new BeCliente(dr.ItemArray);
                lCliente.Add(aux);
            }
            return lCliente;
        }

        public List<BeCliente> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeCliente pObject)
        {
            string storeMCliente = "sp_Clinte_Modificar";
            arrayList = new ArrayList();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@CodigoCliente";
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
            p4.ParameterName = "@Telefono";
            p4.Value = pObject.Telefono;
            p4.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p4);

            SqlParameter p5 = new SqlParameter();
            p5.ParameterName = "@Direccion";
            p5.Value = pObject.Direccion;
            p5.SqlDbType = SqlDbType.NVarChar;
            arrayList.Add(p5);

            dao.Escribir(storeMCliente, arrayList);
        }
    }
}
