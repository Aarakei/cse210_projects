using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int response = 1;
        while(response != 0)
        {
            Console.Clear();

            menu.ShowMenu();

            response = int.Parse(Console.ReadLine());

            Scripture scripture = (response) switch
            {
                0 => null,
                1 => menu.AddScripture(GetScriptureFromUser()),
                _ => menu.GetScripture(response)
            };

            if (scripture != null)
            {
                MemorizeScripture(scripture);
            }

        }
    }

    static string PromptUser(string prompt = "", bool clearScreen = true)
    {
        if (clearScreen)
        {
            Console.Clear();
        }
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("  > ");
        return Console.ReadLine();
    }
    static Scripture GetScriptureFromUser()
    {
        while (true)
        {
            string book = PromptUser("What book is this scripture in?");

            int chapter = int.Parse(PromptUser("What chapter is this scripture in?"));

            int startVerse = int.Parse(PromptUser("What is the first verse of the scripture reference?"));

            int endVerse = int.Parse(PromptUser("What is the last verse of the scripture reference?"));
            
            string passage = PromptUser("What is the scripture passage?");

            Scripture scripture;
            if (startVerse == endVerse)
            {
                scripture = new Scripture(book, chapter, startVerse, passage);
            }
            else
            {
                scripture = new Scripture(book, chapter, startVerse, endVerse, passage);
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            string response = PromptUser("Is this correct? (y/n)",false).ToLower();

            if (response == "y" || response == "yes")
            {
                return scripture;
            }
        }
    }

    static void MemorizeScripture(Scripture scripture)
    {
        string response = "";

        while(response.ToLower() != "q")
        {
            // Clear the screen
            Console.Clear();

            // Print context
            Console.WriteLine("Enter 'q' to quit, press enter to remove words:\n");

            // print the scripture
            scripture.Display();
            Console.WriteLine();
            
            // Get continue/quit input from user
            Console.Write(" > ");
            response = Console.ReadLine();

            // hide a few random words
            if (scripture.HasWordsRemaining())
            {
                scripture.HideWords();
            } else
            {
                // Quit the memorizer if the scripture is empty
                return;
            }
        }
    }
}