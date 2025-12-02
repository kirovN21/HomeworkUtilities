namespace PalindromeCheck
{
    internal class PalindromeCheck
    {

        //Create a method that checks if a provided string is palindrome or not.
        static void Main(string[] args)
        {
            string testString = "racecar";

            if(PalindromeCheck(testString))
            {
                Console.WriteLine($"{testString} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{testString} is not a palindrome.");
            }
        }

        static bool PalindromeCheck(string inputString)
        {
            if (inputString == null)
            {
                return false;
            }

            int length = inputString.Length;

            for (int i = 0; i < length; i++)
            {
                if(inputString[i] != inputString[length - i - 1])
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
