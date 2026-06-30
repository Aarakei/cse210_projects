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
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_isCompleted)
            return 0;

        if (_timesCompleted == _timesToComplete)
        {
            _isCompleted = true;
            return _completionBonus;
        }

        return _pointValue;
    }
        
}