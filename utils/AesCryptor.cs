using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public static class AesCryptor
    {
        private static Aes m_Aes = null;

        public static void init()
        {
            m_Aes = Aes.Create();
        }
        public static byte[] Key { get; set; }

        public static byte[] IV { get; set; }

        public static byte[] encrypt(string plainText)
        {
            m_Aes.Key = Helpers.resizeByteArray(Key, 16);
            m_Aes.IV = Helpers.resizeByteArray(IV, 16);

            // Create an encryptor to perform the stream transform.
            ICryptoTransform encryptor = m_Aes.CreateEncryptor();

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }

        }

        public static string decrypt(byte[] cipherText)
        {
            m_Aes.Key = Helpers.resizeByteArray(Key, 16);
            m_Aes.IV = Helpers.resizeByteArray(IV, 16);

            // Create a decryptor to perform the stream transform.
            ICryptoTransform decryptor = m_Aes.CreateDecryptor();

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {

                        // Read the decrypted bytes from the decrypting stream
                        // and place them in a string.
                        return srDecrypt.ReadToEnd();
                    }
                }
            }

        }

        public static string crack(byte[] cipherToCrack, byte[] iv, out byte[] key)
        {
            m_Aes.IV = iv;
            string clearText = "unknown";
            // key --> 16 bytes, bytes 3...15 = 0
            key = new byte[16];
            for (int a = 0; a <= 255; a++)
            {
                key[0] = (byte)a;
                for (int b = 0; b <= 255; b++)
                {
                    key[1] = (byte)b;
                    for (int c = 0; c <= 255; c++)
                    {
                        key[2] = (byte)c;
                        m_Aes.Key = key;
                        ICryptoTransform decryptor = m_Aes.CreateDecryptor();
                        try
                        {
                            // Create the streams used for decryption.
                            using (MemoryStream msDecrypt = new MemoryStream(cipherToCrack))
                            {
                                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                    {
                                        clearText = srDecrypt.ReadToEnd();
                                        if (isPrintable(clearText))
                                        {
                                            return clearText;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }

            }
            return "cleartext not found";
        }

        private static bool isPrintable(string s)
        {
            for (int i=0; i<s.Length; i++) 
            {
                if (Char.IsControl(s, i))
                    return false;
            }
            return true;
        }


    }
}
