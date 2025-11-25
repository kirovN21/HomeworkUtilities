using System.Threading.Channels;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            // Ask the user for a number greater than 100 using a while loop, exit the loop when you print all numbers between 1 and the provided number.

            bool validNumCheck = false;
            int inputNum;

            do
            {
                Console.WriteLine("Please input a number greater than 100:");
                string userInput = Console.ReadLine()!;

                if (int.TryParse(userInput, out inputNum))
                {
                    if (inputNum > 100)
                    {
                        validNumCheck = true;
                    }
                    else if (inputNum == 100)
                    {
                        Console.WriteLine("Number is equal to 100!");
                    }
                    else
                    {
                        Console.WriteLine("Number must be greater than 100!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid Input!");
                    break;
                }
            } while (!validNumCheck);

            Console.WriteLine("Let's print some numbers now...");
            for (int i = 1; i <= inputNum; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
