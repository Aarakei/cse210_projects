using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string continueGame = "yes";
        while (continueGame == "yes")
        {
        int number = randomGenerator.Next(1,101);

        Console.WriteLine("\nWelcome to Guess the Magic Number!");

        int guess;
        int numGuesses = 0;
        do
        {
            Console.Write("Enter a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());
            numGuesses++;

            if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher!");
            }

        } while(guess != number);

        Console.WriteLine($"Great guessing! The number was {number}");
        Console.WriteLine($"You got it in {numGuesses} guesses!");
        Console.Write("Would you like to play again? (yes/no): ");

        continueGame = Console.ReadLine();
        }
    }
}