using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // Personally, I think a switch statement is better suited for this task, but I'll move on with if/else statements
        // char letter = grade switch
        // {
        //     >= 90 => 'A',
        //     >= 80 => 'B',
        //     >= 70 => 'C',
        //     >= 60 => 'D',
        //     < 60 => 'F',
        // };

        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        } else if (grade >= 80)
        {
            letter = 'B';
        } else if (grade >= 70)
        {
            letter = 'C';
        } else if (grade >= 60)
        {
            letter = 'D';
        } else
        {
            letter = 'F';
        }

        int lastDigit = grade % 10;
        // Apparently chars cannot be empty. Using the null character here to avoid showing a sign if there isn't one.
        char sign = '\0';

        if (lastDigit >= 7)
        {
            sign = '+';
        }
        if (lastDigit < 3)
        {
            sign = '-';
        }
        // No A+ allowed
        if (grade > 93)
        {
            sign = '\0';
        }
        // No F+ or F- allowed
        if (grade < 60)
        {
            sign = '\0';
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        } else
        {
            Console.WriteLine("Sorry you didn't pass. Better luck next time!");
        }

    }
}