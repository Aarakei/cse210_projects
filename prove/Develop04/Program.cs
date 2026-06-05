using System;

class Program
{

    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Generic_Activity", "This is a generic activity, watch this fun little spinner");

        myActivity.DisplayEnterMessage();

        Console.Clear();
        myActivity.DisplaySpinner(7);
        
        myActivity.DisplayExitMessage();

    }
}