namespace IfStatementsBonusHomework
{
    internal class LoginSystem
    {
        static void Main(string[] args)
        {
            var correctUsername = "username123";
            var correctPw = "password123";

            for (int i = 1; i <= 3; i++) 
            {
                Console.Write("Please enter your username: ");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("");

                if (inputUsername == correctUsername)
                {
                    for (int j = 1; j<=3; j++)
                    {
                        Console.Write("Please enter your password: ");
                        string inputPW = Console.ReadLine();
                        Console.WriteLine("");

                        if (inputPW == correctPw)
                        {
                            
                            Console.WriteLine("Successful login.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Incorrect password. {3 - j} attempts remaining.");

                            if(j >= 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You have been locked out.");
                            }
                        }
                    }
                    break;
                   
                } else
                {
                    Console.WriteLine($"Incorrect username. {3 - i} attempts remaining.");

                    if(i >= 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You have been locked out");
                    }
                }

            }
        } 
    }
}

