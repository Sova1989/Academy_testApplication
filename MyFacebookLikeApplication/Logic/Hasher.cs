using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MyFacebookLikeApplication.Logic
{
    public class Hasher
    {
        public string GetHashString(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            StringBuilder hash = new StringBuilder();

            foreach (byte b in byteHash)
                hash.Append(string.Format("{0:x2}", b));

            return hash.ToString();
        }  
    }
}