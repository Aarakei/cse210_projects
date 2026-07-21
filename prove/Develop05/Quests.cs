using System.Drawing;

class Quests
{
    private List<Quest> _questList;
    private int _points;
    private string _fileStringSeparator;

    public Quests()
    {
        _questList = new List<Quest>();
        _points = 0;
        _fileStringSeparator = "~|~";
    }

    public int GetPoints()
    {
        return _points;
    }

    public void ListQuests()
    {
        if (_questList.Count() == 0)
        {
            Console.WriteLine("\nYou haven't embarked on any quests. Press 1 to begin your journey!");
            return;
        }

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

    public void WriteToFile(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"points{_fileStringSeparator}{_points}");
            foreach(Quest quest in _questList)
            {
                outputFile.WriteLine(quest.CreateFileString(_fileStringSeparator));
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        _questList.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split(_fileStringSeparator);
            string type = parts[0];

            if (type == "points")
            {
                _points = int.Parse(parts[1]);
                continue;
            }

            string name = parts[1];
            string description = parts[2];
            int pointValue = int.Parse(parts[3]);
            bool isCompleted;
            int timesCompleted;
            switch (type)
            {
                case "oneshot":
                    isCompleted = bool.Parse(parts[4]);
                    _questList.Add(new OneshotQuest(name,description,pointValue,isCompleted));
                    break;
                
                case "eternal":
                    timesCompleted = int.Parse(parts[4]);
                    _questList.Add(new EternalQuest(name,description,pointValue,timesCompleted));
                    break;

                case "checklist":
                    isCompleted = bool.Parse(parts[4]);
                    int completionBonus = int.Parse(parts[5]);
                    int timesToComplete = int.Parse(parts[6]);
                    timesCompleted = int.Parse(parts[7]);
                    _questList.Add(new ChecklistQuest(name,description,pointValue,isCompleted,timesCompleted,timesToComplete,completionBonus));
                    break;
                
                default:
                    Console.WriteLine($"Couldn't properly parse line {line}");
                    break;
            }
        }
    }
}