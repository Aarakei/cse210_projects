class Quests
{
    private List<Quest> _questList;
    private int _points;

    public Quests()
    {
        _questList = new List<Quest>();
        _points = 0;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void ListQuests()
    {
        Console.WriteLine();
        for (int i=0; i < _questList.Count(); i++)
        {
            Console.WriteLine($"  {i+1,2:D}. {_questList[i].GetDisplayString()}");
        }
    }

    public void AddQuest(Quest quest)
    {
        _questList.Add(quest);
    }

    public int RecordEvent()
    {
        if (_questList.Count() == 0)
        {
            Console.WriteLine("\nNo quests available! Embark on a new quest to begin your journey!");
            return 0;
        }

        Console.WriteLine("\nChoose an Event:");
        for (int i = 0; i < _questList.Count(); i++)
        {
            Console.WriteLine($"  {i+1,2:D}. {_questList[i].GetDisplayString()}");
        }
        Console.Write("Type the number corresponding to the event, or press 0 to cancel: ");

        int response = Menu.GetInteger();

        if (response == 0)
            return 0;

        if (response > _questList.Count())
            return 0;

        int pointsGained = _questList[response-1].RecordEvent();
        _points += pointsGained;
        return pointsGained;

    }



    
}