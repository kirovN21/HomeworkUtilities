namespace Task5
{
    internal class Task5
    {
        static void Main(string[] args)
        {
            // Print a multiplication table from 1 to 5 using nested for loops.

            int sizeOfTable = 5;

            for (int i = 1; i <= sizeOfTable; i++)
            {
                for (int j = 1; j <= sizeOfTable; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
