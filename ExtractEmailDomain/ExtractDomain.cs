using System.Text.RegularExpressions;

namespace ExtractEmailDomain
{
    internal class ExtractDomain

    {

        //Write a method that extracts the domain from an email address.
        static void Main(string[] args)
        {
            string testEmail = "randomemail@random.com";

            if (IsEmailValid(testEmail))
            {
                string result = ExtractEmailDomain(testEmail);
                Console.WriteLine($"The email domain is {result}.");
            }
            else
            {
                Console.WriteLine($"{testEmail} is not a valid email address!");
            }
        }


        static string ExtractEmailDomain(string email)
        {
            var emailParts = email.Split('@');
            string emailBody = emailParts[0];
            string emailDomain = emailParts[1];

            return emailDomain;
        }

        static bool IsEmailValid(string email)
        {

            string allowedChars = @"^[A-Za-z0-9.\-_]+$"; // The email can only contain letters from A-Z, from a-z, numbers from 0-9 and some special chars - dot, dash, lower dash
            

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            if (email.Count(chars => chars == '@') != 1)
            {

                return false;

            }

            var emailParts = email.Split('@');
            string emailBody = emailParts[0];
            string emailDomain = emailParts[1];

            if (!Regex.IsMatch(emailBody, allowedChars))
            {
                return false;
            }

            if (!Regex.IsMatch(emailDomain, allowedChars))
            {
                return false;
            }

            if (!emailDomain.Contains("."))
            {
                return false;
            }

            if (emailDomain.StartsWith(".") || emailDomain.EndsWith("."))
            {
                return false;
            }
            return true;
        }

    }
}
