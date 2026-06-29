class EternalQuest : Quest
{
    public override void CreateQuest()
    {
        SetName();
        SetDescription();
        SetPointValue();
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
}