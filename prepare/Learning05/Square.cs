
class Square: BaseShape
{
    double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double ComputeArea()
    {
        return _side * _side;
    }
}