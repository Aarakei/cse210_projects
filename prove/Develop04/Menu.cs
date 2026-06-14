class Menu
{
    private string _menu;

    public Menu()
    {
        _menu = """
                Menu Options:
                    1. Start breathing activity
                    2. Start reflecting activity
                    3. Start listing activity
                    4. Quit
                Select a choice from the menu: 
                """;
    }

    public int ParseMenu()
    {
        bool isValidInput = true;

        while(true) {

            Console.Write(_menu);

            if (isValidInput == false)
            {
                Console.WriteLine("\n\nInvalid input. Please input a number corresponding to one of the menu options.");
                Console.Write("  > ");
            }

            string response = Console.ReadLine();
            if (response.All(char.IsDigit))
            {
                return int.Parse(response);
            }

            isValidInput = false;
            Console.Clear();
        }
        
    }
}