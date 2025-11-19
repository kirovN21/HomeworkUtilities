using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeworkUtilities
{
    internal class Printer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a printer and I print stuff");

            const int constantInt = 5; //If I try and change it via constantInt = 10, it will throw an error, as constantInt is a constant and cannot be changed.

            var numA = 7;
            var numB = 2;
            Console.WriteLine(numA + numB);
            Console.WriteLine(numA * numB);
            Console.WriteLine(numA % numB);



            var numC = constantInt;
            numC = numA + numB; //I can change the value of numC, because it only equals the value of constantInt, it does not get it's const keyword

            Console.WriteLine(numC);

            var name = "Nikolay";
            var age = 50;

            Console.WriteLine(name + " " + age);
            Console.WriteLine($"My name is {name} and I am {age} years old.");

        }
    }
       
}
