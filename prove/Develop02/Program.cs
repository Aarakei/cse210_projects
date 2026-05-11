using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Program!");

        Menu menu = new Menu();

        while(true)
        {
            menu.Display();
            string response = menu.GetUserInput();
            if (response == "5")
            {
                break;
            }
            Console.WriteLine($"Your response was {response}");
            // int choice = int.Parse(response);
            // switch (choice)
            // {
            //     case 1:
            //         menu.Display();
            //         break;
            //     case 2:
            //         menu.Display();
            //         break;
            // }
        }
    }
}