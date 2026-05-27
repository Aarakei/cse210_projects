class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
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