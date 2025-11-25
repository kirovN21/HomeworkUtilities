namespace Task7
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            // Loop through all numbers between N and 999 from the console, where N can be between (minus)1000 and 999, and prints even numbers, skip negatives, and stop at 999.

            int N;

            Console.WriteLine("Input a number please: ");

            string userInput = Console.ReadLine()!;

            if (int.TryParse(userInput, out N))
            {

                if (N < -1000 || N > 999)
                {
                    Console.WriteLine("Incorrect number range!");
                }
                else
                {
                    for (int i = N; i <= 999; i++)
                    {
                        if (i < 0)
                        {
                            continue;
                        }

                        if (i % 2 != 0)
                        {
                            continue;
                        }

                        Console.Write(i + " ");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
