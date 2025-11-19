using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Calculator
    {
      
        static void Main(string[] args)
        {
            bool goAgain;
            do
            {
                double numA = 0;
                double numB = 0;
                double result = 0;
                String operation;
                String nextAttempt;
                Console.WriteLine("******************************");
                Console.WriteLine("Super Advanced Calculator 3000");
                Console.WriteLine("******************************");
                Console.WriteLine("");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();


                Console.WriteLine("Please enter first number: ");              
                numA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter second number: ");
                numB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("+ to add");
                Console.WriteLine("- to subtract");
                Console.WriteLine("* to multiply");
                Console.WriteLine("/ to divide");
                Console.Write("Input your choice here: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = numA + numB;
                        Console.WriteLine($"Result: {numA} + {numB} = {result}");
                        break;
                    case "-":
                        result = numA - numB;
                        Console.WriteLine($"Result: {numA} - {numB} = {result}");
                        break;
                    case "*":
                        result = numA * numB;
                        Console.WriteLine($"Result: {numA} * {numB} = {result}");
                        break;
                    case "/":
                        result = numA / numB;
                        Console.WriteLine($"Result: {numA} / {numB} = {result}");
                        break;
                    default:
                        Console.WriteLine("Incorrect input provided!");
                        break;
                }
                Console.WriteLine("Do you want to go again? (Y/N)");
                nextAttempt = Console.ReadLine().ToUpper();

                if (nextAttempt == "Y")
                {
                    goAgain = true;
                }
                else if (nextAttempt == "N")
                {
                    goAgain = false;
                }
                else
                {
                    goAgain = false;
                    Console.WriteLine("Invalid input...");
                }
            } while (goAgain == true);
            Console.WriteLine("Closing...");
        }
    }
}
