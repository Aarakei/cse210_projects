class Entry
{
    string _date;
    string _prompt;
    string _response;

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_response}");
    }

    public void populate_entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}