using System.Runtime.InteropServices;

class Activity
{

    private string _date;
    private int _lengthOfActivity;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthOfActivity = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _lengthOfActivity;
    }

    virtual public string GetSummary()
    {
        return "";
    }

    virtual public float GetDistance()
    {
        return 0;
    }
    virtual public float GetSpeed()
    {
        return 0;
    }
    virtual public float GetPace()
    {
        return 0;
    }




}