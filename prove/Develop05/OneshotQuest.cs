class OneshotQuest : Quest
{
    public OneshotQuest() : base ()
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