class ChecklistGoal : Goal
{
    private int _amountToDO;
    private int _amountDone;

    override public void DisplayGoal()
    {
        Console.WriteLine($"{GetType()}, {GetName()}, {GetDesript()}, {_amountDone}/{_amountToDO}");
    }
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
    }
    public override void MakeGoal()
    {

    }

}