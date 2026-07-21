class EternalQuest : Quest
{
    public EternalQuest() : base()
    {
        
    }
    public EternalQuest(string name, string description, int pointValue, int timesCompleted) : base()
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isCompleted = false;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _pointValue;
    }

    public override string GetDisplayString()
    {
        return base.GetDisplayString() + $", times completed: {_timesCompleted}";
    }

    public override string CreateFileString(string sep)
    {
        
        string type = "eternal";
        string name = _name;
        string description = _description;
        string pointValue = _pointValue.ToString();
        string timesCompleted = _timesCompleted.ToString();
        return $"{type}{sep}{name}{sep}{description}{sep}{pointValue}{sep}{timesCompleted}\n";
    }
}