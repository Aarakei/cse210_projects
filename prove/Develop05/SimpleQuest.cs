class SimpleQuest : Quest
{
    public SimpleQuest() : base ()
    {
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
}