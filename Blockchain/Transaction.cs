using System.Text.Json.Serialization;

namespace Blockchain
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

        [JsonIgnore]
        public byte[] Hash
        { 
            get
            {
                return Tools.ShaHash(From.ToString() + To.ToString() + Amount.ToString());
            }
        }

        public override string ToString()
        {
            string s = From + " -> " + To + " : " + Amount.ToString();
            return s;
        }
    }
}
