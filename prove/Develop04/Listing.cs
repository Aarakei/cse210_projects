class Listing : Activity
{
    List<FlaggedString> _prompts;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = [new FlaggedString("Who are people that you appreciate?"),
                    new FlaggedString("What are personal strengths of yours?"),
                    new FlaggedString("Who are people that you have helped this week?"),
                    new FlaggedString("When have you felt the Holy Ghost this month?"),
                    new FlaggedString("Who are some of your personal heroes?"),
                    ];
    }

    public void RunActivity()
    {
        Console.Clear();
        int duration = DisplayEnterMessage();

        Console.Clear();
        Console.CursorVisible = false;

        string prompt = GetRandomPrompt(_prompts);
        if (prompt == "")
        {
            return;
        }

        Console.WriteLine(prompt);
        Console.WriteLine();
        Countdown("You may begin listing in ", 5);

        Console.CursorVisible = true;
        Console.CursorTop -= 1;
        Console.WriteLine("\rList as many items as you can!");

        int numItemsListed = 0;

        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < finishTime)
        {
            Console.WriteLine();
            Console.Write(" - ");
            Console.ReadLine();
            numItemsListed++;
        }

        ResetFlags(_prompts);

        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"You listed {numItemsListed} items. ");
        DisplaySpinner(5);

        DisplayExitMessage();
        Console.CursorVisible = true;
    }
}