using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Quest myQuest = new Quest();
        myQuest.SetName();
        myQuest.SetDescription();
        myQuest.SetPointValue();
        Console.WriteLine(myQuest.GetDisplayString());
        myQuest.CompleteQuest();
        Console.WriteLine(myQuest.GetDisplayString());
    }
}