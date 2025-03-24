public abstract class BaseShape
{
    private string _paperColor;
    
    public BaseShape(string color)
    {
        _paperColor = color;
    }
    
    public abstract double ComputeArea();
}