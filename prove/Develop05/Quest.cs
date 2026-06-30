abstract class Quest
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _timesCompleted;
    protected bool _isCompleted;

    public Quest()
    {
        _name = "";
        _description = "";
        _pointValue = 0;
        _timesCompleted = 0;
        _isCompleted = false;
    }
    public Quest(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _timesCompleted = 0;
        _isCompleted = false;
    }

    protected void SetName()
    {
        Console.Write("What is the name of the quest: ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write($"Enter the description for {_name} quest: ");
        _description = Console.ReadLine();
    }

    protected void SetPointValue()
    {
        Console.Write($"Enter the points earned for {_name} quest: ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        return $"[{(_isCompleted ? "X" : " ")}] Name: {_name}, Description: {_description}, points earned on completion: {_pointValue}";
    }

    protected int CompleteQuest()
    {
        _isCompleted = true;
        return _pointValue;
    }

    public virtual void CreateQuest()
    {
        SetName();
        SetDescription();
        SetPointValue();
    }
    
    public abstract int RecordEvent();
}