using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Servicios
{
    public class Seguridad
    {
        public static string EncryptSHA256(string pString)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(pString);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
