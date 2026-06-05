class Listing : Activity
{
    List<string> _prompts;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = ["Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?",
                    ];
    }

    public void RunActivity()
    {
        Console.Clear();
        int duration = DisplayEnterMessage();

        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine(GetRandomPrompt(_prompts));
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

        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"You listed {numItemsListed} items. ");
        DisplaySpinner(5);

        DisplayExitMessage();
        Console.CursorVisible = true;
    }
}