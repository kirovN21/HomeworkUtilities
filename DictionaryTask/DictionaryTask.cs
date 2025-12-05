using System.Globalization;
using System.Runtime.CompilerServices;

namespace DictionaryTask
{

    //T8: Create a dictionary with country names as keys and capitals as values
    //T9: Access a value from the Dictionary using a key
    //T10: Iterate over a dictionary and print the kvps
    internal class DictionaryTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countriesAndCapitals = new Dictionary<string, string>();
            string input;

            Console.WriteLine(@"Input countries and their capitals, divided by "","" or type ""STOP"" to continue.");

            while ((input = Console.ReadLine()!) != "STOP")
            {
                string[] inputData = input.Split(", ").ToArray();

                if (!countriesAndCapitals.ContainsKey(inputData[0]))
                {
                    countriesAndCapitals.Add(inputData[0], inputData[1]);
                }
                else
                {
                    Console.WriteLine("This country is already in the dictionary! Input another country.");

                }
            }

            foreach (var kvp in countriesAndCapitals)
            {
                Console.WriteLine($"Country: {kvp.Key} > Capital: {kvp.Value}.");
            }
            

            
            var nameAndAge = new Dictionary<string, int>() 
            {
                { "Ivan", 32 },
                { "James", 23 },
                { "Barry", 45 },
                { "Loyd", 20 },
            };

            Console.WriteLine(nameAndAge["Ivan"]);



        } 
    }
}
