using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Servicios
{
    public class Encriptar
    {
        //public static string HashPassword(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}

        //public static bool VerifyPassword(string password, string hashedPassword)
        //{
        //    return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        //}

        public static string Encrypt(string pString)
        {
            UnicodeEncoding uCode = new UnicodeEncoding();
            byte[] byteSourceText = uCode.GetBytes(pString);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(byteSourceText);
            string salida = Convert.ToBase64String(result);
            return salida;
        }
        public static int Compare(string pString, string pStringEncrypted)
        {
            if (Encrypt(pString) == pStringEncrypted) { return 1; }
            else { return 0; }
        }
    }
}
