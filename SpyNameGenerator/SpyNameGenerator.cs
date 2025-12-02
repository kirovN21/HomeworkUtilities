using System.Security.Cryptography;

namespace SpyNameGenerator
{
    internal class SpyNameGenerator
    {

//          1.	Take the first 2 letters of the first name.
//          2.	Change the position of the 2 letters(the second becomes first and vice versa), example ‘ab’->’ba’
//          3.	Take the last 3 letters of the last name.
//          4.	Change the positions of the first and third letter, example: “sad” -> “das”.
//          5.	Concatenate both results from 2. and 4.
//          6.	Convert the result to uppercase.
//          7.	Bonus** Shift each letter 3 letters to the right, example:
//          “ANI” -> “DQL” 
//          if it happens that the letter is X, Y or Z -> start from the beginning of the alphabet
//          “ZORO” -> “CRUR”

        static void Main(string[] args)
        {
            string s1 = "James"; //AJ after rework
            string s2 = "Ivanov"; //VON after rework

            CreateCodeName(s1, s2);
           string result = EncryptName("AJVON", 3);
            Console.WriteLine( result);
        }

        static void CreateCodeName(string firstName, string lastName)
        {
            char[] firstNameChars = firstName.ToCharArray();
            char[] lastNameChars = lastName.ToCharArray();
            int lastNameLength = lastName.Length;

            SwapChars(firstNameChars, 0, 1);
            SwapChars(lastNameChars, lastNameLength - 1, lastNameLength - 3);

            string encodedFirstName = new string(firstNameChars);
            string encodedLastName = new string(lastNameChars);

            Console.Write("Your spy name is: ");
            Console.WriteLine((encodedFirstName.Substring(0, 2) + encodedLastName.Substring(lastNameLength - 3, 3)).ToUpper());

        }

        static void SwapChars(char[] array, int index1, int index2)
        {
            char temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        static string EncryptName(string name, int shift)
        {
            string cipherText = "";
            foreach (char c in name)
            {
                char shifted = (char)(((shift - 'a') % 26) + 'a');
                cipherText += shifted;
            }
            return cipherText;
        }
    }
}
