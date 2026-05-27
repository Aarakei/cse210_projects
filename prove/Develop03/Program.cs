using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs",3,5,6,"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him and he shall direct thy paths.");
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
                // Quit the program if the scripture is empty
                return;
            }
        }
    }
}