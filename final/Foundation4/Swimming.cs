class Swimming : Activity
{
    private float _numLaps;

    public Swimming(string date, int length, float numLaps) : base (date, length)
    {
        _numLaps = numLaps;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()}): Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    public override float GetDistance()
    {
        return (((_numLaps * 50) / 1000) * 0.62F);
    }
    public override float GetPace()
    {
        return (GetLength() / GetDistance());
    }

    public override float GetSpeed()
    {
        return (60 / GetPace());
    }

}