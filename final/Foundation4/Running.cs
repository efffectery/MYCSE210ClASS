class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base (date, length)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()}): Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    public override float GetPace()
    {
        return (GetLength() / _distance);
    }

    public override float GetSpeed()
    {
        return ((_distance / GetLength()) * 60);
    }


}