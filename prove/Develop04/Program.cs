using System;

class Program
{

    static void Main(string[] args)
    {
        // Activity myActivity = new Activity("Generic_Activity", "This is a generic activity, watch this fun little spinner");
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Menu menu = new Menu();

        int menuChoice = 1;
        while (menuChoice != 4)
        {
            Console.Clear();

            if (menuChoice == -1) // Unexpected input
            {
                Console.WriteLine("Unexpected input. Please provide a number matching one of the menu options.");
                Console.WriteLine();
            }

            menuChoice = menu.ParseMenu();

            switch (menuChoice)
            {
            case 1:
                breathing.RunActivity();
                break;
            
            case 2:
                reflection.RunActivity();
                break;

            case 3:
                listing.RunActivity();
                break;
            
            case 4:
                break;

            default:
                menuChoice = -1; // Error code for unexpected input
                break;
                
            }
        }

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Thank you for using the Mindfulness App!");
        Console.WriteLine();

    }
}