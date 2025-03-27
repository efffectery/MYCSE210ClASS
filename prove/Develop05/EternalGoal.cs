class EternalGoal : Goal
{
    public override void RecordEvent()
    { SetDone(false); 
      IncreasePoints(GetPPC());   
    }
    public override void Display()
    {
        string done_string = "[ ]";
        Console.WriteLine($"{done_string} {GetType()}: {GetName} {GetDesript} {GetPPC()}");
    }
}