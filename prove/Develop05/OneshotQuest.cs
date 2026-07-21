class OneshotQuest : Quest
{
    public OneshotQuest() : base ()
    {
    }

    public OneshotQuest(string name, string description, int pointValue, bool isCompleted) : base()
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isCompleted = isCompleted;
        _timesCompleted = 0;
    }

    public override void CreateQuest()
    {
        SetName();
        SetDescription();
        SetPointValue();
    }

    public override int RecordEvent()
    {
        return CompleteQuest();
    }

    public override string CreateFileString(string sep)
    {
        string type = "oneshot";
        string name = _name;
        string description = _description;
        string pointValue = _pointValue.ToString();
        string isCompleted = _isCompleted.ToString();
        return $"{type}{sep}{name}{sep}{description}{sep}{pointValue}{sep}{isCompleted}\n";
    }
}