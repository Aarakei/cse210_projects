class Menu
{
    List<string> _menuOptions = ["1. Write",
                                "2. Display",
                                "3. Load",
                                "4. Save",
                                "5. Quit"];

    public void Display()
    {
        Console.WriteLine("Please select one of the following options:");
        foreach(string option in _menuOptions)
        {
            Console.WriteLine(option);
        }
    }

    public string GetUserInput(string prompt = " > ")
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}