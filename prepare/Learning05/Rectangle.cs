
class Rectangle : BaseShape
{
    double _width;
    double _length;

    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length= length;
    }

    public override double ComputeArea()
    {
        return _width * _length;
    }
}