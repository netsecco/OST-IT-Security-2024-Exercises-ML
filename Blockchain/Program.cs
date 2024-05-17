namespace Blockchain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blockchain Test");
            createBlockChain();
            //checkBlockChain("B165CEA8CDC063A1840B266C86B4A13EA051EF2F");
        }

        public static void createBlockChain()
        {
            Console.WriteLine("Create Blockchain");
            Block b1 = new Block();
            b1.PreviousBlock = "null";
            Transaction t = new Transaction("Alice", "Bob", 1.23M);
            b1.Transactions.Add(t);
            t = new Transaction("Charlie", "Bob", 1M);
            b1.Transactions.Add(t);
            t = new Transaction("Bob", "Dave", 5.08778M);
            b1.Transactions.Add(t);
            Console.WriteLine("\n=== block 1 ===\n{0}", b1.ToString());
            string b1hash = b1.save();
            Console.WriteLine("saved block 1 (hash: {0})", b1hash);

            Block b2 = new Block();
            b2.PreviousBlock = b1hash;
            t = new Transaction("Alice", "Edi", 0.55M);
            b2.Transactions.Add(t);
            t = new Transaction("Bob", "Dave", 5.335M);
            b2.Transactions.Add(t);
            Console.WriteLine("\n=== block 2 ===\n{0}", b2.ToString());
            string b2hash = b2.save();
            Console.WriteLine("saved block 2 (hash: {0})", b2hash);

            Block b3 = new Block();
            b3.PreviousBlock = b2hash;
            t = new Transaction("Fred", "Bob", 4M);
            b3.Transactions.Add(t);
            t = new Transaction("Bob", "Alice", 2.222M);
            b3.Transactions.Add(t);
            t = new Transaction("Gil", "Dave", 0.00225M);
            b3.Transactions.Add(t);
            t = new Transaction("Edi", "Alice", 6.55M);
            b3.Transactions.Add(t); 
            Console.WriteLine("\n=== block 3 ===\n{0}", b3.ToString());
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

    }
}