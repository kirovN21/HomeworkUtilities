namespace FindCentralChars
{
    internal class FindCentralChars
    {

        //C# Program to determine the middle characters of a string
        static void Main(string[] args)
        {
            bool isLengthOdd = false;
            bool isLengthEven = false;


            Console.Write("Please input a string: ");
            string input = Console.ReadLine()!;

            int length = input.Length;

            if (length % 2 == 0) 
            {
                isLengthEven = true;
            }

            else if (length % 2 != 0)
            {
                isLengthOdd = true; 
            }
           

            if (isLengthOdd)
            {
                char middleIndex = input[length / 2];
                Console.WriteLine(@$"The middle character is ""{middleIndex}"". ");
            }

            else if (isLengthEven)
            {
                char middleIndex1 = input[length / 2 - 1];
                char middleIndex2 = input[length / 2];
                Console.WriteLine(@$"The middle characters are ""{middleIndex1}{middleIndex2}"". ");
            }

        }
    }
}
