class Menu
{
    static List<string> _menuOptions = ["1. Write",
                                "2. Display",
                                "3. Load",
                                "4. Save",
                                "5. Quit"];

    public static void Display()
    {
        Console.WriteLine("Please select one of the following options:");
        foreach(string option in Menu._menuOptions)
        {
            Console.WriteLine(option);
        }
    }

    public static string GetUserInput(string prompt = "")
    {
        if(prompt != "")
        {
            Console.WriteLine(prompt);
        }

        Console.Write(" > ");
        string response = Console.ReadLine();

        Console.WriteLine();
        return response;
    }

    public static void ShowUser(string message = "")
    {
        Console.WriteLine($"\n{message}");
    }
}