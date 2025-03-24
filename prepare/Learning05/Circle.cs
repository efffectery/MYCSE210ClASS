public class Circle : BaseShape
{
    double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double ComputeArea()
    {
        return Math.PI * _radius * _radius;
    }
}