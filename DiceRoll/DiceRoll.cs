namespace DiceRoll
{
    internal class DiceRoll
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;
            int rounds = 5;

            Console.WriteLine("Let the dice battle begin!");
            Thread.Sleep(1000);

            for (int i = 1; i < rounds + 1; i++)
            {
                Console.WriteLine($"Round {i} begins! Rolling dice...");
                Thread.Sleep(1000);

                int playerRoll = RollDice();
                int enemyRoll = RollDice();

                BattleRound(playerRoll, enemyRoll);

                if (playerRoll > enemyRoll)
                {
                    playerScore++;
                }
                else if (enemyRoll > playerRoll)
                {
                    enemyScore++;
                }

                Console.WriteLine($"----- Current score - Player: {playerScore} || Enemy: {enemyScore} -----");
                Console.WriteLine(" ");

                if (playerScore == 3 || enemyScore == 3)
                {
                    break;
                }
            }
            AnnounceWinner(playerScore, enemyScore);
        }

        static int RollDice()
        {
            Random rnd = new Random();
            int diceRollResult = rnd.Next(1, 7);
            return diceRollResult;

        }

        static void BattleRound(int playerRoll, int enemyRoll)
        {
            if (playerRoll > enemyRoll)
            {
                Console.WriteLine($"The player rolled {playerRoll}. The enemy rolled {enemyRoll}.");
                Console.WriteLine("The player wins!");
                Console.WriteLine(" ");
            }
            else if (enemyRoll > playerRoll)
            {
                Console.WriteLine($"The player rolled {playerRoll}. The enemy rolled {enemyRoll}.");
                Console.WriteLine("The enemy wins!");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine($"The player rolled {playerRoll}. The enemy rolled {enemyRoll}.");
                Console.WriteLine("It's a tie!");
                Console.WriteLine(" ");
            }
        }

        static void AnnounceWinner(int playerScore, int enemyScore)
        {
            if (playerScore > enemyScore)
            {
                Console.WriteLine("Congratulations player, you win!");
            }
            else if (enemyScore > playerScore)
            {
                Console.WriteLine("Unfortunately the enemy won...");
            }
            else
            {
                Console.WriteLine("What a tie!");
            }
        }
    }
}
