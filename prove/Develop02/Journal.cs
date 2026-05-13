using System.Security.Cryptography;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    string[] _prompts = ["Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?",];
    Random numberGenerator = new Random();
    string _separator = "~|~";

    public string GetRandomPrompt()
    {
        // Random numberGenerator = new Random();
        return _prompts[numberGenerator.Next(0,_prompts.Length)];
    }

    public void AddEntry(Entry journalEntry)
    {
        _entries.Add(journalEntry);
    }

    public Entry CreateEntry()
    {
        Entry entry = new Entry();

        string date = DateTime.Now.ToShortDateString();
        string prompt = this.GetRandomPrompt();
        string response = Menu.GetUserInput(prompt);

        entry.PopulateEntry(date, prompt, response);

        return entry;
    }

    public void WriteToFile(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string[] parts = line.Split(_separator);
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry journalEntry = new Entry();
            journalEntry.PopulateEntry(date, prompt, response);
            this.AddEntry(journalEntry);
        }
    }

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
}