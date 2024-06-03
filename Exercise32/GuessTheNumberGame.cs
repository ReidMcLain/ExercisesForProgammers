namespace Exercise32;

internal static class GuessTheNumberGame
{
    static void Main()
    {
        Console.WriteLine("Let's play Guess the Number.");
        bool keepPlaying = true;

        while (keepPlaying)
        {
            int maxRange = ChooseDifficulty();
            int secretNumber = new Random().Next(1, maxRange + 1);
            int guessCount = 0;
            int guess = 0;

            Console.Write($"I have my number. What's your guess? ");
            while (guess != secretNumber)
            {
                guessCount++;
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("That's not a valid number. Guess again: ");
                    continue;
                }

                if (guess < secretNumber)
                {
                    Console.Write("Too low. Guess again: ");
                }
                else if (guess > secretNumber)
                {
                    Console.Write("Too high. Guess again: ");
                }
            }

            Console.WriteLine($"You got it in {guessCount} guesses!");
            keepPlaying = AskToPlayAgain();
        }

        Console.WriteLine("Goodbye!");
    }

    static int ChooseDifficulty()
    {
        Console.Write("Pick a difficulty level (1, 2, or 3): ");
        int level;
        while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3)
        {
            Console.WriteLine("Please enter a valid difficulty level (1, 2, or 3): ");
        }

        switch (level)
        {
            case 1:
                return 10;
            case 2:
                return 100;
            case 3:
                return 1000;
            default:
                return 10;  // Default case, should never hit this because of the validation above
        }
    }

    static bool AskToPlayAgain()
    {
        Console.Write("Play again? (y/n): ");
        string answer = Console.ReadLine().Trim().ToLower();
        return answer.StartsWith("y");
    }
}

