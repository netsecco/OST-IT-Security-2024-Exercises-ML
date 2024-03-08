using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;

namespace utils
{
    public static class Helpers
    {
        public static string ByteArrayToHexString(byte[] ba, int start)
        {
            string hex = BitConverter.ToString(ba, start);
            return hex.Replace("-", "");
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            return ByteArrayToHexString(ba, 0);
        }

        public static byte[] Sha256(byte[] array)
        {
            var hashstring = new SHA256Managed();
            return hashstring.ComputeHash(array);
        }

        public static string Sha256(string text)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] hash = Sha256(data);
            return ByteArrayToHexString(hash);
        }
        public static string ByteToBin(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }

        public static string ByteToHex(byte b)
        {
            return Convert.ToString(b, 16).PadLeft(2, '0');
        }

        public static byte HexToByte(string hex)
        {
            return byte.Parse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }

        public static byte[] HexStringToByteArray(string HexString)
        {
            if (HexString.Length % 2 != 0)
                throw new Exception("Invalid HEX");
            byte[] retArray = new byte[HexString.Length / 2];
            for (int i = 0; i < retArray.Length; ++i)
            {
                retArray[i] = byte.Parse(HexString.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return retArray;
        }

        public static byte Xor(byte b1, byte b2)
        {
            return (byte)(b1 ^ b2);
        }
        public static string Base64Encode(string text)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            return Base64Encode(data);
        }

        public static string Base64Encode(byte[] data)
        {
            return Convert.ToBase64String(data);
        }

        public static byte[] Base64Decode(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            return data;
        }
        public static string Base64DecodeAsString(string text)
        {
            byte[] data = Base64Decode(text);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        public static byte[] resizeByteArray(byte[] data, int size)
        {
            byte[] newData = new byte[size];
            if (data.Length < size)
            {
                size = data.Length;
            }

            for (int i = 0; i < size; i++)
            {
                newData[i] = data[i];
            }
            return newData;
        }

    }
}
