using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace CryptoCurrency
{
    public class Transaction
    {
        public Transaction() { }

        public Transaction(string from, string to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }

        public string From { get; set; }
        public string To { get; set; }

        public decimal Amount { get; set; }

        public string Signature { get; set; }

        [JsonIgnore]
        public byte[] Hash
        { 
            get
            {
                return Tools.ShaHash(From.ToString() + To.ToString() + Amount.ToString());
            }
        }

        public static bool checkSignature(byte[] hash, string signature, string publicKey)
        {
            byte[] sig = Tools.HexStringToByteArray(signature);
            byte[] pk = Tools.HexStringToByteArray(publicKey);
            using (ECDsaCng dsa = new ECDsaCng(CngKey.Import(pk, CngKeyBlobFormat.EccFullPublicBlob)))
            {
                return dsa.VerifyHash(hash, sig);
            }
        }

        public override string ToString()
        {
            string s = From + " -> " + To + " : " + Amount.ToString() + " Sig: " + Signature;
            return s;
        }
    }
}
