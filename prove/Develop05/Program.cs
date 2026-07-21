using System;

class Program
{
    static void Main(string[] args)
    {
        Quests quests = new Quests();

        // myQuest.CreateQuest();
        // Console.WriteLine(myQuest.GetDisplayString());
        // Console.WriteLine($"Points: {points}");
        
        // points += myQuest.RecordEvent();
        // Console.WriteLine(myQuest.GetDisplayString());
        // Console.WriteLine($"Points: {points}");

        Menu menu = new Menu();
        int response = 0;
        while (response != 6)
        {
            Console.WriteLine($"\nPoints: {quests.GetPoints()}");
            response = menu.ProcessMainMenu();
            switch (response)
            {
                case 1: // TODO: Create Quest
                    CreateQuest(menu, quests);
                    break;
                case 2: // TODO: List Quests
                    quests.ListQuests();
                    break;
                case 3: // TODO: Save Quests
                    quests.WriteToFile(Menu.GetFileName());
                    break;
                case 4: // TODO: Load Quests
                    quests.ReadFromFile(Menu.GetFileName());
                    break;
                case 5: // TODO: Record Event
                    quests.RecordEvent();
                    break;
                default:
                    break;
            }
        }
    }

    static void CreateQuest(Menu menu, Quests quests)
    {
        Quest newQuest = null;

        int response = menu.ProcessCreateQuestMenu();
        switch (response)
        {
            case 1: // TODO: Oneshot Quest
                newQuest = new OneshotQuest();
                break;
            case 2: // TODO: Eternal Quest
                newQuest = new EternalQuest();
                break;
            case 3: // TODO: Checklist Quest
                newQuest = new ChecklistQuest();
                break;
            default:
                break;
        }

        if (newQuest != null)
        {
            newQuest.CreateQuest();
            quests.AddQuest(newQuest);
        }
    }
}