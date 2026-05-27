using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Reference romans = new Reference("Romans",8,11);
        Reference proverbs = new Reference("Proverbs",3,5,6);
        Word hello = new Word("hello");
        Word goodbye = new Word("goodbye");

        while(response.ToLower() != "q")
        {
            // Clear the screen
            Console.Clear();

            // Print context
            Console.WriteLine("Enter 'q' to quit, press enter to remove words:\n");

            // TODO: print the scripture
            Console.WriteLine("Proverbs 3:5-6: Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him and he shall direct thy paths.");
            Console.WriteLine(romans.GetReference());
            Console.WriteLine(proverbs.GetReference());
            Console.WriteLine($"{hello.GetWord()} {goodbye.GetWord()}");
            Console.WriteLine();
            
            // TODO: hide a few random words
            if(response == "h")
            {
                hello.Hide();
            }
            if(response == "g")
            {
                goodbye.Hide();
            }
            
            // Get continue/quit input from user
            Console.Write(" > ");
            response = Console.ReadLine();
        }
    }
}