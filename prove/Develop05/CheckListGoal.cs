class ChecklistGoal : Goal
{
    private int _amountToDO;
    private int _amountDone;
    private int _bonus;

    public override void RecordEvent()
    {
        if(GetDone() == false)
        {
            _amountDone++;
            if (_amountDone == _amountToDO)
            {
                SetDone(true);
            }
        }
        IncreasePoints(GetPPC());   
    }
    public override void Display()
    {
        string done_string;
        if(GetDone() == true)
        { done_string = "[X]"; }
        else
        { done_string = "[ ]"; }
        Console.WriteLine($"{done_string} {GetType()}: {GetName()} {GetDesript()} {GetPPC()} {GetBonus()} {GetAD()}/{GetATD()}");
    }
    public override int GetAD()
    { return _amountDone; }
    public override int GetATD()
    { return _amountToDO; }
    public override int GetBonus()
    { return _bonus; }
    public override void SetAD(int ad)
    { _amountDone = ad; } 
    public override void SetATD(int atd)
    { _amountToDO = atd; }
    public override void SetBonus(int bonus)
    { _bonus = bonus; }

}