using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";

        while(response.ToLower() != "quit")
        {
            // Clear the screen
            Console.Clear();

            // TODO: print the scripture
            Console.WriteLine("Proverbs 3:5-6: Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him and he shall direct thy paths.");
            Console.WriteLine();
            
            // TODO: hide a few random words

            // Get continue/quit input from user
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
        }
    }
}