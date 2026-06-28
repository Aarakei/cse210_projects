class Menu
{
    private string _mainMenu =
    """
    Menu Options:
      1. Embark on a New Quest
      2. List Quests
      3. Save Quests
      4. Load Quests
      5. Record Event
      6. Quit
    Select a choice from the menu: 
    """;

    private string _createQuestMenu = """
    The types of available quests are:
      1. Oneshot Quest
      2. Eternal Quest
      3. Checklist Quest
    Which quest would you like to embark on? 
    """;

    public int ProcessMainMenu()
    {
        Console.Write(_mainMenu);
        return int.Parse(Console.ReadLine());
    }

    public int ProcessCreateQuestMenu()
    {
        Console.Write(_createQuestMenu);
        return int.Parse(Console.ReadLine());
    }
}