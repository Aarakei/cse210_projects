class Program
{
    static void Main(string[] args)
    {
        // initialize the menu and response loop
        Menu menu = new Menu();
        int response = 1;

        while(response != 0)
        {
            //Refresh the screen with the menu
            Console.Clear();
            menu.ShowMenu();
            
            // inform the user about the correct response type if the previous input was invalid
            if (response == -1)
            {
                Console.WriteLine("Invalid input. Please enter a number corresponding to one of the menu options.");
                Console.WriteLine();
                Console.Write("  > ");
            }

            // validate that the user's response can be converted to an integer
            string input = Console.ReadLine();
            if (input.All(char.IsDigit) && input != "")
            {
                response = int.Parse(input);
            }
            else
            {
                response = -1;
            }

            // get the correct scripture from the menu (will return null if response was 0 or invalid)
            Scripture scripture = (response) switch
            {
                1 => menu.AddScripture(GetScriptureFromUser()),
                _ => menu.GetScripture(response)
            };

            // don't try to memorize a scripture that doesn't exist
            if (scripture != null)
            {
                MemorizeScripture(scripture);
            }
            else if (response != 0)
            {
                response = -1;
            }

        }
    }

    static string PromptUser(string prompt = "", bool clearScreen = true)
    {
        if (clearScreen)
        {
            Console.Clear();
        }

        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("  > ");

        return Console.ReadLine();
    }

    static int GetInt(string prompt, bool clearScreen = true)
    {
        if(clearScreen)
        {
            Console.Clear();
        }

        while(true)
        {
            string input = PromptUser(prompt, false);

            // Make sure the user input a number
            if (input.All(char.IsNumber) && input != "")
            {
                return int.Parse(input);
            }

            // If the input was invalid
            if (clearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine("Invalid input. Please input a number.");
            Console.WriteLine();
            
        }
    }

    static Scripture GetScriptureFromUser()
    {
        while (true)
        {
            string book = PromptUser("What book is this scripture in?");

            int chapter = GetInt("What chapter is this scripture in?");

            int startVerse = GetInt("What is the first verse of the scripture reference?");

            int endVerse = GetInt("What is the last verse of the scripture reference?");
            
            string passage = PromptUser("What is the scripture passage?");

            // Use the correct constructor
            Scripture scripture;
            if (startVerse == endVerse)
            {
                scripture = new Scripture(book, chapter, startVerse, passage);
            }
            else
            {
                scripture = new Scripture(book, chapter, startVerse, endVerse, passage);
            }

            // Verify the scripture the user input was correct
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            string response = PromptUser("Is this correct? (y/n)",false).ToLower();

            if (response == "y" || response == "yes")
            {
                return scripture;
            }
        }
    }

    static void MemorizeScripture(Scripture scripture)
    {
        while(true)
        {
            // Clear the screen
            Console.Clear();

            // Print context
            Console.WriteLine("Enter 'q' to quit, press enter to remove words:\n");

            // print the scripture
            scripture.Display();
            Console.WriteLine();
            
            // Get continue/quit input from user
            Console.Write(" > ");
            string response = Console.ReadLine().ToLower();

            // hide a few random words
            if (!scripture.HasWordsRemaining() || response == "q")
            {
                // Quit the memorizer if the scripture is empty
                scripture.ShowAllWords();
                return;
            }
            else
            {
                scripture.HideWords();
            }
        }
    }
}