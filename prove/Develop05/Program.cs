using System;

class Program
{
    static void Main(string[] args)
    {
        Quest myQuest = null;
        int points = 0;

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
            response = menu.ProcessMainMenu();
            switch (response)
            {
                case 1: // TODO: Create Quest
                    myQuest = CreateQuest(menu);
                    break;
                case 2: // TODO: List Quests
                    if (myQuest != null)
                        Console.WriteLine(myQuest.GetDisplayString());
                    break;
                case 3: // TODO: Save Quests
                    break;
                case 4: // TODO: Load Quests
                    break;
                case 5: // TODO: Record Event
                    break;
                default:
                    break;
            }
        }
    }

    static Quest CreateQuest(Menu menu)
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
                break;
            default:
                return null;
        }

        if (newQuest != null)
            newQuest.CreateQuest();
        
        return newQuest;
    }
}