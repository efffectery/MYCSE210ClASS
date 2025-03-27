class SimpleGoal : Goal
{
    override public void DisplayGoal()
    {
        Console.WriteLine($"{GetType()}, {GetName()}, {GetDesript()}");
    }
    public override void RecordEvent()
    {
            SetDone(true);
    }

    public override void MakeGoal()
    {

    }
}