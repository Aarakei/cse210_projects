class Program
{
    public static void Main(string[] args)
    {
        // Hide the cursor
        Console.Clear();
        Console.CursorVisible = false;

        // Make space for the blinker
        int sleepTime = 250;
        int blinkSteps = 10;
        Console.Write(" ");

        // Blink the blinker
        for (int i = 0; i < blinkSteps; i++)
        {
            Console.Write("\b+");
            Thread.Sleep(sleepTime);
            Console.Write("\b-");
            Thread.Sleep(sleepTime);
        }

        // Erase the blinker
        Console.Write("\b ");

        // Give the cursor back
        Console.CursorVisible = true;
    }
}