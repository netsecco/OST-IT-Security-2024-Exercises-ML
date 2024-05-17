using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CryptoCurrency
{
    public class Block
    {
        private const string PATH = @"c:\temp\blockchain\";
        public Block()
        {
            HashOk = true;
            Transactions = new List<Transaction>();
            Nonse = 0;
        }
        public string PreviousBlock { get; set; }

        public UInt64 Nonse { get; set; }

        [JsonIgnore]
        public bool HashOk { get; set; }

        public byte[] getHash()
        {
            string json = JsonSerializer.Serialize(this);
            return Tools.ShaHash(json);
        }

        public List<Transaction> Transactions { get; set; }

        public string save()
        {
            string json = JsonSerializer.Serialize(this);
            string hash = Tools.ShaHashHex(json);
            File.WriteAllText(PATH + hash, json);
            return hash;
        }

        public static Block load(string filename)
        {
            string origFilename = filename;
            filename = PATH + filename;
            if (File.Exists(filename))
            {
                string jsonFromFile = File.ReadAllText(filename);
                string hash = Tools.ShaHashHex(jsonFromFile);
                Block block = JsonSerializer.Deserialize<Block>(jsonFromFile);
                block.HashOk = (hash == origFilename);
                return block;
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("previous block: " + PreviousBlock);
            sb.AppendLine("hash ok:        " + HashOk);
            int i = 1;
            foreach (Transaction transaction in Transactions) 
            {
                bool sigOk = Transaction.checkSignature(transaction.Hash, transaction.Signature, transaction.From);
                sb.AppendLine("  Transaction " + i++.ToString()); 
                sb.Append("  ");
                sb.AppendLine(transaction.ToString());
                sb.Append("    ");
                sb.AppendLine("Transaction Signature is valid? " + sigOk.ToString());
            }

            return sb.ToString();
        }
    }
}
