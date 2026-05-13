class Entry
{
    string _date;
    string _prompt;
    string _response;
    string _separator = "~|~";

    public void Display()
    {
        Menu.ShowUser($"{_date}: {_prompt}\n{_response}");
    }

    public void PopulateEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string CreateFileString()
    {
        return $"{_date}{_separator}{_prompt}{_separator}{_response}";
    }
}