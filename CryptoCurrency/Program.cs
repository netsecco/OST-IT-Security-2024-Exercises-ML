namespace CryptoCurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crypto Currency Test");

            createBlockChain();
            //checkBlockChain("00000F5912B4019772EC9E97BFCF088CEF6AE66F");

            //Participant Alice = new Participant("Alice");
            //Participant Bob = new Participant("Bob");
            //Participant Charlie = new Participant("Charlie");

            //Transaction t = new Transaction();
            //t.From = Alice.PublicKey; 
            //t.To = Bob.PublicKey;
            //t.Amount = 1.23M;
            //// sign transaction with Alices private key
            //byte[] transactionHash = t.Hash;
            //t.Signature = Alice.sign(transactionHash);
            //Console.WriteLine("Transaction\n{0}", t.ToString());
            //// check signature
            //// T.From is Alices public key
            //bool sigOk = Transaction.checkSignature(t.Hash, t.Signature, t.From);
            //Console.WriteLine("Signature ok? {0}", sigOk);
        }

        public static void createBlockChain()
        {
            Participant Alice = new Participant("Alice");
            Participant Bob = new Participant("Bob");
            Participant Charlie = new Participant("Charlie");
            Participant Dave = new Participant("Dave");
            Participant Edi = new Participant("Edi");
            Participant Fred = new Participant("Fred");
            Participant Gil = new Participant("Gil");

            byte[] transactionHash = null;

            Console.WriteLine("Create Blockchain");
            Block b1 = new Block();
            b1.PreviousBlock = "null";
            
            Transaction t = new Transaction(Alice.PublicKey, Bob.PublicKey, 1.23M);
            transactionHash = t.Hash;
            t.Signature = Alice.sign(transactionHash);
            b1.Transactions.Add(t);

            t = new Transaction(Charlie.PublicKey, Bob.PublicKey, 1M);
            transactionHash = t.Hash;
            t.Signature = Charlie.sign(transactionHash);
            b1.Transactions.Add(t);

            t = new Transaction(Bob.PublicKey, Dave.PublicKey, 5.08778M);
            transactionHash = t.Hash;
            t.Signature = Bob.sign(transactionHash);
            b1.Transactions.Add(t);

            Console.WriteLine("\n=== block 1 ===\n{0}", b1.ToString());
            mineBlock(b1);
            string b1hash = b1.save();
            Console.WriteLine("saved block 1 (hash: {0})", b1hash);

            Block b2 = new Block();
            b2.PreviousBlock = b1hash;

            t = new Transaction(Alice.PublicKey, Edi.PublicKey, 0.55M);
            transactionHash = t.Hash;
            t.Signature = Alice.sign(transactionHash);
            b2.Transactions.Add(t);

            t = new Transaction(Bob.PublicKey, Dave.PublicKey, 5.335M);
            transactionHash = t.Hash;
            t.Signature = Bob.sign(transactionHash);
            b2.Transactions.Add(t);


            Console.WriteLine("\n=== block 2 ===\n{0}", b2.ToString());
            mineBlock(b2);
            string b2hash = b2.save();
            Console.WriteLine("saved block 2 (hash: {0})", b2hash);

            Block b3 = new Block();
            b3.PreviousBlock = b2hash;

            t = new Transaction(Fred.PublicKey, Bob.PublicKey, 4M);
            transactionHash = t.Hash;
            t.Signature = Fred.sign(transactionHash);
            b3.Transactions.Add(t);

            t = new Transaction(Bob.PublicKey, Alice.PublicKey, 2.222M);
            transactionHash = t.Hash;
            t.Signature = Bob.sign(transactionHash);
            b3.Transactions.Add(t);

            t = new Transaction(Gil.PublicKey, Dave.PublicKey, 0.00225M);
            transactionHash = t.Hash;
            t.Signature = Gil.sign(transactionHash);
            b3.Transactions.Add(t);

            t = new Transaction(Edi.PublicKey, Alice.PublicKey, 6.5533M);
            transactionHash = t.Hash;
            t.Signature = Edi.sign(transactionHash);
            b3.Transactions.Add(t);

            Console.WriteLine("\n=== block 3 ===\n{0}", b3.ToString());
            mineBlock(b3);
            string b3hash = b3.save();
            Console.WriteLine("saved block 3 (hash: {0})", b3hash);
        }

        public static void checkBlockChain(string newestBlock)
        {
            Console.WriteLine("Check Blockchain");
            Block block = Block.load(newestBlock);
            while (block != null)
            {
                Console.WriteLine(block.ToString());
                block = Block.load(block.PreviousBlock);
            }
        }

        public static void mineBlock(Block block)
        {
            UInt64 counter = 0;
            byte[] hash = block.getHash();
            // the first 16 bits must be 0
            while ((hash[0] + hash[1]) != 0) 
            {
                counter++;
                block.Nonse++;
                hash = block.getHash();
            }
            Console.WriteLine("needed {0} tries to solve cryptographic puzzle", counter);
        }

    }
}