using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace StudentNames
{
    internal class StudentNames
    {

        //T11: Create a program that stores student names and their scores using a Dictionary, then calculates and prints the average score.
        static void Main(string[] args)
        {
            Dictionary<string, double> studentNamesAndGrades = AddStudentsAndGrades();
            double averageGrades = CalculateAverageScore(studentNamesAndGrades);
            Console.WriteLine($"The average score for all students is: {averageGrades}");

        }

        static Dictionary<string, double> AddStudentsAndGrades()
        {
            Dictionary<string, double> studentScores = new Dictionary<string, double>();
            string name;
            double grade;
            string input;
            Console.WriteLine("Please enter a student name and their grade bellow: ");

            do
            {
                name = Console.ReadLine()!;
                grade = Double.Parse(Console.ReadLine()!);

                if (grade < 2 || grade > 6)
                {
                    Console.WriteLine("Grade must be between 2 and 6! Please try again...");
                }
                else
                {
                    studentScores.Add(name, grade);
                    Console.WriteLine($"{name} sucessfully added.");
                }

                Console.WriteLine("Do you want to add another student? (y/n)");
                input = Console.ReadLine()!.Trim().ToLower();

            } while (input == "y");

            Console.WriteLine("Student database updated sucessfully.");

            return studentScores;
        } 

        static double CalculateAverageScore(Dictionary<string, double> studentScores)
        {
            double sum = 0;
            foreach (var grade in studentScores.Values)
            {
                sum += grade;
            }
            return sum / studentScores.Count;
        }
    }
}
