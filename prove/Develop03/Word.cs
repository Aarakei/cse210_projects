class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord()
    {
        if (_isHidden)
        {
            string hiddenWord = "";

            foreach(char c in _word)
            {
                hiddenWord += "_";
            }

            return hiddenWord;
        }

        return _word;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Display()
    {
        Console.Write($"{GetWord()} ");
    }
}