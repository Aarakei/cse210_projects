class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void RunActivity()
    {
        int duration = DisplayEnterMessage();
        Console.Clear();

        DateTime finishTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < finishTime)
        {
            Countdown("Breath in... ", 4);
            Countdown("Breath out... ", 6);
        }

        DisplayExitMessage();
    }

}