namespace StringEqualityComparison
{
    internal class StringEquality
    {

        //Create a method that compares two strings for equality, ignoring case sensitivity.
        static void Main(string[] args)
        {
            string string1 = "test";
            string string2 = "TEsT";

            StringCompare(string1, string2);
        }

        static void StringCompare (string s1, string s2)
        {
            if(s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The strings are equal!");
            }
            else
            {
                Console.WriteLine("The strings are not equal!");
            }
        }
    }
}
