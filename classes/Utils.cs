using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Encrypter.classes
{
    public class Utils
    {
        public static string Encrypt(string key, string text)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using( Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key,aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter((Stream)cryptoStream))
                        {
                            sw.Write(text);
                        }

                        array = ms.ToArray();
                    }
                }
            }
                return Convert.ToBase64String(array);
        }

        public static string Decrypt(string key, string text)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(text);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key,aes.IV);

                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    using (CryptoStream cs = new CryptoStream((Stream)ms,decryptor,CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader((Stream)cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static void toClipboard(string text)
        {
            Clipboard.SetText(text);
        }
    }
}
