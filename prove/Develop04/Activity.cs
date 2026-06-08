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
        string[] spinner = ["-","\\","|","/"];
        Console.Write(" ");

        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        
        while(DateTime.Now < finishTime)
        {
            Console.Write($"\b{spinner[spinnerIndex]}");
            spinnerIndex = (spinnerIndex + 1) % 4;
            Thread.Sleep(500);
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

    public string GetRandomPrompt(List<string> prompts)
    {
        Random integerGenerator = new Random();
        return prompts[integerGenerator.Next(0,prompts.Count)];
    }
}