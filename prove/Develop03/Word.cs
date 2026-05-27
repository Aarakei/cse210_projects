class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void Hide()
    {
        string hiddenWord = "";

        foreach (char c in _word)
        {
            hiddenWord += "_";
        }

        _word = hiddenWord;
    }
}