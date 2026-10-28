using System;

class SecretCodeBreaker
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            string secretCode = "";
            for (int i = 0; i < 4; i++)
            {
                secretCode += random.Next(0, 10).ToString();
            }

            int maxAttempts = 10;
            int remainingAttempts = maxAttempts;
            bool cracked = false;

            Console.WriteLine("\n=== Secret Code Breaker ===");
            Console.WriteLine("Crack the secret 4-digit code (digits 0-9).");
            Console.WriteLine($"You have {maxAttempts} attempts.\n");

            while (remainingAttempts > 0)
            {
                Console.Write($"[{remainingAttempts} left] Enter 4-digit guess: ");
                string guess = Console.ReadLine().Trim();

                if (guess.Length != 4 || !int.TryParse(guess, out _))
                {
                    Console.WriteLine("Invalid! Must be exactly 4 numeric digits.");
                    continue;
                }
                int exactMatches = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == secretCode[i])
                    {
                        exactMatches++;
                    }
                }

                remainingAttempts--;

                if (exactMatches == 4)
                {
                    cracked = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"Correct digits in correct position: {exactMatches}");
                }
            }

            if (cracked)
            {
                int attemptsUsed = maxAttempts - remainingAttempts;
                int score = (remainingAttempts + 1) * 10; // Faster crack = higher score

                Console.WriteLine($"\nAccess Granted! You cracked code [{secretCode}] in {attemptsUsed} attempt(s)!");
                Console.WriteLine($"Score: {score}/100");
            }
            else
            {
                Console.WriteLine($"\nMission Failed! The secret code was: {secretCode}");
                Console.WriteLine("Score: 0");
            }

            Console.Write("\nWould you like to try a new code? (y/n): ");
            string answer = Console.ReadLine().Trim().ToLower();
            playAgain = (answer == "y" || answer == "yes");
        }

        Console.WriteLine("Good luck next time!!!!!!");
    }
}

