using System;

class Program
{
    static void Main(string[] args)
    {
        Quest myQuest = new SimpleQuest();
        int points = 0;

        myQuest.CreateQuest();
        Console.WriteLine(myQuest.GetDisplayString());
        Console.WriteLine($"Points: {points}");
        
        points += myQuest.RecordEvent();
        Console.WriteLine(myQuest.GetDisplayString());
        Console.WriteLine($"Points: {points}");
    }
}