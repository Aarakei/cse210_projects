using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Program!");

        Journal journal = new Journal();

        bool exit = false;

        while(exit == false)
        {
            Menu.Display();
            string response = Menu.GetUserInput();
            int choice = int.Parse(response);
            switch (choice)
            {
                // Write
                case 1:
                    journal.AddEntry(journal.CreateEntry());
                    break;
                
                // Display
                case 2:
                    journal.Display();
                    break;
                
                // Load
                case 3:
                    string loadFilename = Menu.GetUserInput("What is the name of the file you would like to load?");
                    journal.ReadFromFile(loadFilename);
                    break;

                // Save
                case 4:
                    string saveFilename = Menu.GetUserInput("What would you like to name the file?");
                    journal.WriteToFile(saveFilename);
                    break;

                // Quit
                case 5:
                    exit = true;
                    Menu.ShowUser("Thank you for using the Journal Program!");
                    break;
            }
        }
    }
}