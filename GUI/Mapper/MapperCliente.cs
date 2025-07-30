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
using System.Threading.Tasks;

namespace Mapper
{
    public class MapperCliente : IABMC<BeCliente>
    {
        ArrayList arrayList;
        Dao dao = new Dao();

        public void Alta(BeCliente pObject)
        {
            string store = "sp_Cliente_Alta";
            arrayList = new ArrayList
    {
        new SqlParameter("@DNI", pObject.DNI),
        new SqlParameter("@Nombre", pObject.Nombre),
        new SqlParameter("@Telefono", pObject.Telefono),
        new SqlParameter("@Direccion", pObject.Direccion)
    };

            dao.Escribir(store, arrayList);

            var clienteInsertado = Consulta().LastOrDefault(c => c.DNI == pObject.DNI && c.Nombre == pObject.Nombre);
            if (clienteInsertado != null)
            {
                pObject.id = clienteInsertado.id;

                string concatenado = $"{pObject.id}|{pObject.DNI}|{pObject.Nombre}|{pObject.Telefono}|{pObject.Direccion}";
                string dvh = HashingHelper.CalcularHash(concatenado);

                ArrayList parametros = new ArrayList
                {
                    new SqlParameter("@Tabla", "Cliente"),
                    new SqlParameter("@Id", int.Parse(pObject.id)),
                    new SqlParameter("@DVH", dvh)
                };
                dao.Escribir("sp_Actualizar_DVH", parametros);
            }
        }


        public void Baja(int pId)
        {
            string storeBCliente = "sp_Cliente_Baja";
            arrayList = new ArrayList { new SqlParameter("@CodigoCliente", pId) };
            dao.Escribir(storeBCliente, arrayList);

            // Baja lógica en reservas (si aplica)
            string storeReserva = "sp_Baja_Reserva";
            dao.Escribir(storeReserva, arrayList);
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
            string store = "sp_Cliente_Modificar";
            arrayList = new ArrayList
            {
                new SqlParameter("@CodigoCliente", int.Parse(pObject.id)),
                new SqlParameter("@DNI", pObject.DNI),
                new SqlParameter("@Nombre", pObject.Nombre),
                new SqlParameter("@Telefono", pObject.Telefono),
                new SqlParameter("@Direccion", pObject.Direccion)
            };

            dao.Escribir(store, arrayList);

            string concatenado = $"{pObject.id}|{pObject.DNI}|{pObject.Nombre}|{pObject.Telefono}|{pObject.Direccion}";
            string dvh = HashingHelper.CalcularHash(concatenado);

            ArrayList parametros = new ArrayList
            {
                new SqlParameter("@Tabla", "Cliente"),
                new SqlParameter("@Id", int.Parse(pObject.id)),
                new SqlParameter("@DVH", dvh)
            };
            dao.Escribir("sp_Actualizar_DVH", parametros);
        }

        public string CalcularDVH(BeCliente cliente)
        {
            string datos = $"{cliente.id}|{cliente.DNI}|{cliente.Nombre}|{cliente.Telefono}|{cliente.Direccion}";
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(datos));
                return Convert.ToBase64String(hash);
            }
        }
    }
}