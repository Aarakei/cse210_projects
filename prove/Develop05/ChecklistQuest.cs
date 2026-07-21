class ChecklistQuest : Quest
{
    private int _timesToComplete;
    private int _completionBonus;

    public ChecklistQuest() : base()
    {
        
    }
    public ChecklistQuest(string name, string description, int pointValue, bool isCompleted, int timesCompleted, int timesToComplete, int completionBonus) : base()
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isCompleted = isCompleted;
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _completionBonus = completionBonus;
    }

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

    public override string CreateFileString(string sep)
    {
        string type = "checklist";
        string name = _name;
        string description = _description;
        string pointValue = _pointValue.ToString();
        string isCompleted = _isCompleted.ToString();
        string completionBonus = _completionBonus.ToString();
        string timesToComplete = _timesToComplete.ToString();
        string timesCompleted = _timesCompleted.ToString();
        return $"{type}{sep}{name}{sep}{description}{sep}{pointValue}{sep}{isCompleted}{sep}{completionBonus}{sep}{timesToComplete}{sep}{timesCompleted}";
    }
}