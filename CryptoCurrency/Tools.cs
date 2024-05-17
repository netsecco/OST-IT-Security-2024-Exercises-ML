using System.Globalization;
using System.Security.Cryptography;

namespace CryptoCurrency
{
    public static class Tools
    {
        public static string ByteArrayToHexString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba, 0);
            return hex.Replace("-", "");
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

        public static byte[] ShaHash(string data)
        {
            byte[] array = System.Text.Encoding.UTF8.GetBytes(data);
            SHA1 mySHA1 = SHA1.Create();
            return mySHA1.ComputeHash(array);
        }

        public static string ShaHashHex(string data)
        {
            byte[] hash = ShaHash(data);
            return ByteArrayToHexString(hash);
        }

        public static byte[] ShaHash(byte[] data)
        {
            SHA1 mySHA1 = SHA1.Create();
            return mySHA1.ComputeHash(data);
        }


    }
}
