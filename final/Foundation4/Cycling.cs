class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int length, float speed) : base (date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()}): Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
    public override float GetPace()
    {
        return (60 / GetDistance());
    }
    public override float GetDistance()
    {
        return ((GetLength() * _speed) / 60);

    }


}