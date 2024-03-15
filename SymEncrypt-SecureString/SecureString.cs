using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymEncrypt_SecureString
{
    /// <summary>
    /// a string that is encrypted in the memory
    /// </summary>
    public class SecureString
    {
        private byte[] m_key;
        private byte[] m_encryptedString;

        public SecureString(string value)
        {
            Value = value;
        }

        public string Value 
        { 
            get
            {
                // decript
                byte[] stringBytes = Xor(m_key, m_encryptedString);
                // convert byte array to string
                return getStringFromBytes(stringBytes); 
            }
            set
            { 
                // create random key
                m_key = getRandomBytes(value.Length);
                // convert string to byte array
                byte[] stringBytes = getBytesFromString(value);
                // encrypt
                m_encryptedString = Xor(m_key, stringBytes);  
            }
        }

        internal byte[] getRandomBytes(int length) 
        {
            return RandomNumberGenerator.GetBytes(length);
        }

        internal byte[] getBytesFromString(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }

        internal string getStringFromBytes(byte[] b)
        {
            return Encoding.ASCII.GetString(b); ;
        }

        internal byte[] Xor(byte[] a, byte[] b)
        {
            byte[] result = new byte[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (byte)(a[i] ^ b[i]);
            }
            return result;
        }

    }
}
