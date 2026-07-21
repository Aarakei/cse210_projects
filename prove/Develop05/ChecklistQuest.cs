class ChecklistQuest : Quest
{
    private int _timesToComplete;
    private int _completionBonus;

    private void SetTimesToComplete()
    {
        Console.Write($"How many events does it take to complete {_name} quest: ");
        _timesToComplete = int.Parse(Console.ReadLine());
    }

    private void SetCompletionBonus()
    {
        Console.Write($"How many bonus points for completing {_name} quest: ");
        _completionBonus = int.Parse(Console.ReadLine());
    }

    public override void CreateQuest()
    {
        base.CreateQuest();
        SetTimesToComplete();
        SetCompletionBonus();
    }

    public override int RecordEvent()
    {
        if (_isCompleted)
            return 0;

        _timesCompleted++;

        if (_timesCompleted >= _timesToComplete)
        {
            _isCompleted = true;
            return _completionBonus + _pointValue;
        }

        return _pointValue;
    }

    public override string GetDisplayString()
    {
        return base.GetDisplayString() + $", completion bonus: {_completionBonus}, times to complete: {_timesToComplete}, times completed: {_timesCompleted}";
    }
}