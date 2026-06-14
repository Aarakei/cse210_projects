class Reflection : Activity
{
    List<FlaggedString> _prompts;
    List<FlaggedString> _questions;

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = [new FlaggedString("Think of a time when you stood up for someone else."),
                    new FlaggedString("Think of a time when you did something really difficult."),
                    new FlaggedString("Think of a time when you helped someone in need."),
                    new FlaggedString("Think of a time when you did something truly selfless."),
                    ];
        
        _questions = [new FlaggedString("Why was this experience meaningful to you?"),
                    new FlaggedString("Have you ever done anything like this before?"),
                    new FlaggedString("How did you get started?"),
                    new FlaggedString("How did you feel when it was complete?"),
                    new FlaggedString("What made this time different than other times when you were not as successful?"),
                    new FlaggedString("What is your favorite thing about this experience?"),
                    new FlaggedString("What could you learn from this experience that applies to other situations?"),
                    new FlaggedString("What did you learn about yourself through this experience?"),
                    new FlaggedString("How can you keep this experience in mind in the future?"),
                    ];
    }

    public void RunActivity()
    {
        int duration = DisplayEnterMessage();
        Console.Clear();

        string prompt = GetRandomPrompt(_prompts);
        if (prompt == "")
        {
            return; // This shouldn't ever happen unless the prompt list is empty
        }

        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("Once you have an experience in mind, press enter to start reflecting.");
        Console.ReadLine();
        Console.Clear();

        Console.CursorVisible = false;
        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < finishTime)
        {
            string question = GetRandomPrompt(_questions);
            if (question == "") // If the all questions have been used
            {
                break;
            }
            Console.Write(question + " ");
            DisplaySpinner(15);
            Console.WriteLine("\n");
        }

        ResetFlags(_prompts);
        ResetFlags(_questions);

        Console.Clear();
        DisplayExitMessage();
        Console.CursorVisible = true;
    }
}