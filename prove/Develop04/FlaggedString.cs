class FlaggedString
{
    private string _string;
    private bool _isUsed;

    public FlaggedString(string inputString)
    {
        _string = inputString;
        _isUsed = false;
    }

    public bool GetIsUsed()
    {
        return _isUsed;
    }

    public string GetString()
    {
        _isUsed = true;
        return _string;
    }

    public void ResetFlag()
    {
        _isUsed = false;
    }
}