using System.Security.Cryptography.X509Certificates;

namespace IfStatementsHomework
{
    internal class MainHomework
    {
        static void Main(string[] args)
        {

            //Age check program

            Console.Write("What is your age?: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age))
            {

                string message = AgeCheck(age);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            //Grade check program

            string[] subjects = { "math", "music", "geography" };

            Console.WriteLine("This year you studied Music, Geography and Math.");
            Console.WriteLine("Please choose one of the subjects above: ");
            string subjectInput = Console.ReadLine().Trim().ToLower();

            if (subjects.Contains(subjectInput))
            {
                Console.Write($"Please enter your grade in {subjectInput}: ");
                string gradeInput = Console.ReadLine();

                if (subjectInput == "math")
                {
                    if (double.TryParse(gradeInput, out double grade))
                    {
                        string message = GradeCheck(grade);
                        Console.WriteLine("Math class results: " + message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                if (subjectInput == "music")
                {
                    if (double.TryParse(gradeInput, out double grade))
                    {
                        string message = GradeCheck(grade);
                        Console.WriteLine("Music class results: " + message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }             
                } 

                if (subjectInput == "geography")
                {
                    if (double.TryParse(gradeInput, out double grade))
                    {
                        string message = GradeCheck(grade);
                        Console.WriteLine("Geography class results: " + message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
              
            }
        }

        public static string AgeCheck(int age) //This method will check a users age when called upon. I made it static, so I can call on it withot needing to make an object instance
        {

            if (age < 0)
            {
                return "You shouldn't exist, you're not born yet!";
            }

            else if (age == 0)
            {
                return "Maybe you're just a newborn, who knows.";
            }

            else if (age >= 1 && age < 14)
            {
                return "You're still very young, just starting life!";
            }

            else if (age >= 14 && age <= 17)
            {
                return "High school is stressful huh?";
            }

            else if (age >= 18 && age <= 120)
            {
                return "Congratulations, you're an adult!";
            }

            else
            {
                return "You're a record holder for being the oldest person! Call Guinness.";
            }
        }

        public static string GradeCheck(double grade) //This method will check a users grade and print out a passing message. The subject messages will be in a nested if in the Main method
        {
            if (grade < 2 || grade > 6)
            {
                return "This is not a valid grade.";
            }
            else if (grade >= 2 && grade <= 2.99)
            {
                return $"Your grade is {grade}, this unfortunately means you failed.";
            }
            else if (grade >= 3 && grade is <= 4.5)
            {
                return $"Your grade is {grade}.";
            }
            else if (grade > 4.5 && grade < 5.5)
            {
                return $"Your grade is {grade}.";
            }
            else if (grade >= 5.5 && grade <= 5.99)
            {
                return $"Almost a perfect grade - {grade}.";
            }
            else
            {
                return $"You have the best grade - {grade}";
            }
        }



    }
}

