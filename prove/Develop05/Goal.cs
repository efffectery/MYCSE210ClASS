abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _pointsPerCompleation;
    private bool _done = false;
    private int _points = 0;

    //Getters
    public int GetPoints()
    { return _points; }
    public string GetType()
    { return _type; }
    public string GetName()
    { return _name; }
    public string GetDesript()
    { return _description; }
    public int GetPPC()
    { return _pointsPerCompleation; }
    public bool GetDone()
    { return _done; }
    //Setters
    public void SetType(string type)
    { _type = type; }
    public void SetName(string name)
    { _name = name; }
    public void SetDescription(string description)
    { _description= description; }
    public void SetPPC(int pPC)
    { _pointsPerCompleation = pPC;}
    public void SetDone(bool done)
    { _done = done; }
    public void IncreasePoints(int points)
    { _points += points; }

    abstract public void RecordEvent();
    virtual public int GetAD()
    { return 0; }
    virtual public int GetATD()
    { return 0; }
    virtual public int GetBonus()
    { return 0; }
    virtual public void SetAD(int ad)
    { }
    virtual public void SetATD(int atd)
    { }
    virtual public void SetBonus(int bonus)
    { } 
    abstract public void Display();

}