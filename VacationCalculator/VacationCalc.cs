namespace VacationCalculator
{
    internal class VacationCalc
    {
        static void Main(string[] args)
        {
            string budgetInput;
            double budget;
            string season;

            string[] seasonOptions = { "summer", "winter" };

            Console.Write("Please enter your budget: ");
            budgetInput = Console.ReadLine().Trim();

            if (double.TryParse(budgetInput, out budget))
            {

                Console.Write("Please enter when you will be travelling. Summer or Winter?: ");
                season = Console.ReadLine().Trim().ToLower();

                if (seasonOptions.Contains(season))
                {
                    if (season == "summer")
                    {
                        if (budget < 10)
                        {
                            Console.WriteLine("No money? Stay home.");
                        }
                        else if (budget >= 10 && budget <= 100)
                        {
                            Console.WriteLine("Somewhere in Bulgaria.");
                            Console.WriteLine($"Camp - {budget * 0.3 :F2} EUR");
                        }
                        else if (budget >= 100 && budget <= 1000)
                        {
                            Console.WriteLine("Somewhere in the Balkans.");
                            Console.WriteLine($"Camp - {budget * 0.4 :F2} EUR");
                        }
                        else if (budget > 1000 && budget <= 5000)
                        {
                            Console.WriteLine("Somewhere in Europe.");
                            Console.WriteLine($"Hotel - {budget * 0.9 :F2}  EUR");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }

                    if (season == "winter")
                    {
                        if (budget < 10)
                        {
                            Console.WriteLine("No money? Stay home.");
                        }
                        else if (budget >= 10 && budget <= 100)
                        {
                            Console.WriteLine("Somewhere in Bulgaria.");
                            Console.WriteLine($"Hotel - {budget * 0.7 :F2} EUR");
                        }
                        else if (budget >= 100 && budget <= 1000)
                        {
                            Console.WriteLine("Somewhere in the Balkans.");
                            Console.WriteLine($"Hotel - {budget * 0.8 :F2} EUR");
                        }
                        else if (budget > 1000 && budget <= 5000)
                        {
                            Console.WriteLine("Somewhere in Europe.");
                            Console.WriteLine($"Hotel - {budget * 0.9 :F2} EUR");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid inpuut. No vacation for you.");
                }

            } else
            {
                Console.WriteLine("Invalid input. Please enter a number!");
            }
        }
    }
}
