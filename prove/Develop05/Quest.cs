class Quest
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _timesCompleted;
    protected bool _isCompleted;

    public Quest()
    {
        _type = "";
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
    }

    public void SetName()
    {
        Console.Write("What is the name of the quest: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write($"Enter the description for {_name} quest: ");
        _description = Console.ReadLine();
    }

    public void SetPointValue()
    {
        Console.Write($"Enter the points earned for {_name} quest: ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        return $"[{(_isCompleted ? "X" : " ")}] Name: {_name}, Description: {_description}, points earned on completion: {_pointValue}";
    }

    public int CompleteQuest()
    {
        _isCompleted = true;
        return _pointValue;
    }
}