class Reflection : Activity
{
    List<string> _prompts;
    List<string> _questions;

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless.",
                    ];
        
        _questions = ["Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?",
                    ];
    }

    public void RunActivity()
    {
        int duration = DisplayEnterMessage();
        Console.Clear();

        Console.WriteLine(GetRandomPrompt(_prompts));
        Console.WriteLine();
        Console.WriteLine("Once you have an experience in mind, press enter to start reflecting.");
        Console.ReadLine();
        Console.Clear();

        Console.CursorVisible = false;
        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < finishTime)
        {
            Console.Write(GetRandomPrompt(_questions) + " ");
            DisplaySpinner(15);
            Console.WriteLine("\n");
        }
        Console.Clear();

        DisplayExitMessage();
        Console.CursorVisible = true;
    }
}