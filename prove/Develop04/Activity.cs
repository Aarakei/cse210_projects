class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int DisplayEnterMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long would you like this session to be (in seconds)?");
        Console.WriteLine();
        Console.Write("  > ");

        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void DisplayExitMessage()
    {
        Console.Clear();
        Console.CursorVisible = false;

        Console.Write("Well Done! ");
        DisplaySpinner(3);

        Console.WriteLine("\n");
        Console.Write($"You have completed {_duration} seconds of the {_name} activity. ");
        DisplaySpinner(3);
        Console.CursorVisible = true;
    }

    public void DisplaySpinner(int duration)
    {
        int spinnerIndex = 0;
        string animationString = "-\\|/";
        Console.Write(" ");

        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        
        while(DateTime.Now < finishTime)
        {
            Console.Write($"\b{animationString[spinnerIndex]}");
            spinnerIndex = (spinnerIndex + 1) % animationString.Length;
            Thread.Sleep(250);
        }

        Console.Write("\b ");
    }
    
    public void Countdown(string message, int duration)
    {
        Console.Write(message);
        Console.Write(" ");
        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < finishTime)
        {
            Console.Write($"\b{duration}");
            duration--;
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b ");
    }

    public string GetRandomPrompt(List<FlaggedString> prompts)
    {
        Random integerGenerator = new Random();

        List<int> availableIndices = new List<int>();
        for(int i = 0; i < prompts.Count(); i++)
        {
            if (prompts[i].GetIsUsed() == false)
            {
                availableIndices.Add(i);
            }
        }

        if (availableIndices.Count() == 0)
        {
            return ""; // empty string will be used to determine when all prompts have been used
        }

        int promptIndex = availableIndices[integerGenerator.Next(0,availableIndices.Count)];
        return prompts[promptIndex].GetString();
    }

    public void ResetFlags(List<FlaggedString> flaggedStrings)
    {
        foreach (FlaggedString flaggedString in flaggedStrings)
        {
            flaggedString.ResetFlag();
        }
    }
}