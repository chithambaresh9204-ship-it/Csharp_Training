using System;

public class NumberGuessingGame
{
    public static void Main(String[]args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int targetNumber = random.Next(1, 101); 
            int maxAttempts = 10;
            int attemptsUsed = 0;
            bool hasWon = false;

            Console.WriteLine("Welcome to the Number Guessing Game");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine($"You have {maxAttempts} attempts to guess it.\n");

            while (attemptsUsed < maxAttempts)
            {
                Console.Write($"Attempt {attemptsUsed + 1}/{maxAttempts} - Enter your guess: ");
                int guess;

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input! Please enter a valid whole number.");
                    continue;
                }

                attemptsUsed++;

                if (guess == targetNumber)
                {
                    hasWon = true;
                    break;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }
            }

            if (hasWon)
            {
                
                int score = (maxAttempts - attemptsUsed + 1) * 10;
                Console.WriteLine($"\nCongratulations! You found the number in {attemptsUsed} attempt(s).");
                Console.WriteLine($"Your Score: {score}/70");
            }
            else
            {
                Console.WriteLine($"\nGame Over! You ran out of attempts. The number was: {targetNumber}");
                Console.WriteLine("Your Score: 0");
            }

            Console.Write("\nDo you want to play another round? (y/n): ");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = (response == "y" || response == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}
