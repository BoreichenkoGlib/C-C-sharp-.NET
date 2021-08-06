using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ClassLibrary
{
    public class EncryptDecrypt
    {
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static DESCryptoServiceProvider GenerateKey()
        {
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return desCrypto;
        }

        public static void EncryptFile(string sInputFilename, string sOutputFilename, DESCryptoServiceProvider sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = sKey.Key;
            DES.IV = sKey.IV;
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }

        public static void DecryptFile(string sInputFilename, string sOutputFilename, DESCryptoServiceProvider sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = sKey.Key;
            DES.IV = sKey.IV;

            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            FileStream fsDecrypted = new FileStream(sOutputFilename, FileMode.Create);
            byte[] bytearrayinput = new byte[1024];
            int length;
            do
            {
                length = cryptostreamDecr.Read(bytearrayinput, 0, 1024);
                fsDecrypted.Write(bytearrayinput, 0, length);
            } while (length == 1024);
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }
    }
}