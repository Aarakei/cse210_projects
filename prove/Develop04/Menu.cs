class Menu
{
    private string _menu;

    public Menu()
    {
        _menu = """
                Menu Options:
                    1. Start breathing activity
                    2. Start reflecting activity
                    3. Start listing activity
                    4. Quit
                Select a choice from the menu: 
                """;
    }

    public int ParseMenu()
    {
        Console.Write(_menu);
        return int.Parse(Console.ReadLine());
    }
}