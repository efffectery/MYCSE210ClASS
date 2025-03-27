class EternalGoal : Goal
{

    override public void DisplayGoal()
    {
        Console.WriteLine($"{GetType()}, {GetName()}, {GetDesript()}");
    }
    public override void RecordEvent()
    {
        SetDone(false);
    }

    public override void MakeGoal()
    {

    }

}