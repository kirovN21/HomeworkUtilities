namespace NamesListTask
{
    internal class NamesList
    {

        //T6: Create a list of strings and add five names to it
        //T7: Remove an item from the list and  print the updated list
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 5 names for the List: ");

            List<string> names = AddName();
            PrintNames(names);
            RemoveNameAtRandom(names);
            PrintNames(names);

        }
        static List<string> AddName()
        {
            int inputCount = 0;
            List<string> names = new List<string>();

            while (inputCount < 5)
            {
                string input = Console.ReadLine()!;
                names.Add(input);
                inputCount++;
            }

            return names;
        }

        static void PrintNames(List<string> names)
        {
            Console.WriteLine("Alright! Let's print the names...");
            Thread.Sleep(1000);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();
        }

        static void RemoveNameAtRandom(List<string> names)
        {
            Random r = new Random();
            int index = r.Next(names.Count);
            Console.WriteLine($"Removing the unlucky: {names[index]}");
            names.RemoveAt(index);
            
        }
    }
}
