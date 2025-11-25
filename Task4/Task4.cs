namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            //Repeat a prompt until the user enters 'n' using a do-while loop.

            bool exitCheck = false;
            string[] validAnswers = { "y","n" };

            do
            {
                Console.WriteLine("[INSERT RANDOM PROMPT]");
                Console.WriteLine("Do you want to continue? (y/n)");
                string userInput = Console.ReadLine().Trim().ToLower();

                if(validAnswers.Contains(userInput))
                {
                    if (userInput == "y")
                    {
                        Console.WriteLine("Let's gooo!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Bye bye!");
                        exitCheck = true;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
            } while (!exitCheck);
        }
    }
}
