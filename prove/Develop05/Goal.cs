abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private bool _done = false;

    //Getters
    public string GetType()
    { return _type; }
    public string GetName()
    { return _name; }
    public string GetDesript()
    { return _description; }
    public bool GetDone()
    { return _done; }
    //Setters
    public void SetType(string type)
    { _type = type; }
    public void SetName(string name)
    { _name = name; }
    public void SetDescription(string description)
    { _description= description; }
    public void SetDone(bool done)
    { _done = done; }

    abstract public void DisplayGoal();
    abstract public void RecordEvent();
    abstract public void MakeGoal();
}