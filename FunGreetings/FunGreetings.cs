using System;
using System.ComponentModel;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FunGreetings
{
    internal class FunGreetings
    {

        //              Create a program that uses a method to generate fun greetings.
        //              Requirements:
        //                  •	Write a method called MagicGreeting that takes one parameter: the user’s name.
        //                  •	It should return a fun, randomized greeting, e.g.:
        //                  •	“Welcome, mighty < name > !”
        //                  •	“Greetings, traveler < name > !”
        //                  •	“Behold, the legendary<name> has arrived!”
        //                  •	In Main(), ask the user for their name.
        //                  •	Call the method and print the greeting.


        //Can we please show how to exclude already displayed greetings in the lecture, I tried doing it and did not manage to succeed :)

        static void Main(string[] args)
        {
            string playerName = " ";
            string greeting = " ";


            Console.WriteLine("A weary nomad approaches...What is thy name?");
            playerName = Console.ReadLine()!;
           
            greeting = MagicGreeting(playerName);
            Console.WriteLine(greeting);

        }

        static string MagicGreeting(string name)
        {
            bool goAgain = false;
            Random rnd = new Random();

           

           int randomChoice = rnd.Next(1, 4);

                if (randomChoice == 1)
                {
                    return "Welcome, mighty " + name + "!";
                }
                else if (randomChoice == 2)
               {
                    return "Greetings, traveller " + name + "!";
                }
                else if (randomChoice == 3)
                {
                   return "Behold, the legendary " + name + " has arrived!";
                }
                else
                {
                    return " ";
                }
        }
    }
}
