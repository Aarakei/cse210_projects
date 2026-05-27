class Reference
{
    private string _referenceString;

    public Reference(string book, int chapter, int verse)
    {
        _referenceString = $"{book} {chapter}:{verse}";
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _referenceString = $"{book} {chapter}:{startVerse}-{endVerse}";
    }

    public string GetReference()
    {
        return _referenceString;
    }

}