using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IABMC<T> where T : IEntity
    {
        void Alta(T pObject);
        void Baja(int pId);
        void Modificacion(T pObject);
        List<T> Consulta();
        List<T> ConsultaCondicional(string pCondicion, string pCondicion2 = null);
    }
}
