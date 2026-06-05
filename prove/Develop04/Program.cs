using System;

class Program
{

    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Generic_Activity", "This is a generic activity, watch this fun little spinner");
        Breathing myBreathing = new Breathing();


        // myActivity.DisplayEnterMessage();

        // Console.Clear();
        // myActivity.DisplaySpinner(7);

        // myActivity.DisplayExitMessage();

        myBreathing.RunActivity();
    }
}