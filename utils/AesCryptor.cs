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

        public static string crack(byte[] cipherToCrack, byte[] iv, ref byte[] key)
        {
            key[2]++;
            m_Aes.IV = iv;
            string clearText = "unknown";
            // key --> 16 bytes, bytes 3...15 = 0
            do
            {
                do
                {
                     do
                     {
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
                        key[2]++;
                    } while (key[2] > 0);
                    key[1]++;
                } while (key[1] > 0);
                key[0]++;
            } while (key[0] > 0);
            return "cleartext not found";
        }

        private static bool isPrintable(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsControl(s[i]))   
                    return false;
            }
            return true;
        }


    }
}
