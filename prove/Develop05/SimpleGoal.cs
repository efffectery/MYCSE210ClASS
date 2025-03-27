class SimpleGoal : Goal
{
    public override void RecordEvent()
    { 
        SetDone(true); 
        IncreasePoints(GetPPC());   
    }

    public override void Display()
    {
        string done_string;
        if(GetDone() == true)
        { done_string = "[X]"; }
        else
        { done_string = "[ ]"; }
        Console.WriteLine($"{done_string} {GetType()}: {GetName()} {GetDesript()} {GetPPC()}");
    }
}