using System.Security.Cryptography;


namespace CryptoCurrency
{
    public class Participant
    {
        private byte[] m_privateKey;
        private byte[] m_publicKey;
        
        public Participant(string frendlyName)
        {
            FriendlyName = frendlyName;
            ECCurve curve = ECCurve.CreateFromFriendlyName("secp192r1");
            using (ECDsaCng dsa = new ECDsaCng(curve))
            {
                m_publicKey = dsa.Key.Export(CngKeyBlobFormat.EccFullPublicBlob);
                m_privateKey = dsa.Key.Export(CngKeyBlobFormat.EccFullPrivateBlob);
            }
        }

        public string FriendlyName { get; set; }
        public string PublicKey
        {
            get
            {
                return Tools.ByteArrayToHexString(m_publicKey);
            }
         }

        public string sign(byte[] hash)
        {
            using (ECDsaCng dsa = new ECDsaCng(CngKey.Import(m_privateKey, CngKeyBlobFormat.EccFullPrivateBlob)))
            {
                return Tools.ByteArrayToHexString(dsa.SignHash(hash));
            }
        }


        public bool checkSignature(byte[] hash, string signature)
        {
            byte[] sig = Tools.HexStringToByteArray(signature);
            using (ECDsaCng dsa = new ECDsaCng(CngKey.Import(m_publicKey, CngKeyBlobFormat.EccFullPublicBlob)))
            {
                return dsa.VerifyHash(hash, sig);
            }
        }

        public override string ToString()
        {
            return FriendlyName + ":" + PublicKey;
        }

    }
}
