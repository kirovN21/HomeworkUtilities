namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            //Print names from array via foreach

            List<string> namesList = new List<string>();
            bool firstNameCheck = true;

            while (true)
            {
                if (firstNameCheck)
                {
                    Console.WriteLine("Please enter a name to add to list or write 'print' to print the names.");
                    string input = Console.ReadLine()!;
                    firstNameCheck = false;

                    if (input == "print")
                    {
                        Console.WriteLine("Printing...");
                        Console.WriteLine();
                        break;
                    }

                    namesList.Add(input);

                }
                else
                {
                    Console.WriteLine("Please write another name or 'print' to print the names.");
                    string input = Console.ReadLine()!;
                    if (input == "print")
                    {
                        Console.WriteLine("Printing...");
                        Console.WriteLine();
                        break;
                    }

                    namesList.Add(input);
                }
            }

            Console.WriteLine("The names you added are: ");

            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
