using System;

class Circle
{
    public double radius;

    // Constuctor gets called everytime or used to init all created objects you make
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }   

    public double GetCircumfrance()
    {
        double Circumfrance = Math.PI * GetDiameter();
        return Circumfrance;
    }

    public double GetDiameter()
    {
        double Diameter = radius * 2;
        return Diameter;
    }

    public void SetRadius(double r)
    {
        radius = r;
    }

    public void DisplayValues()
    {
        Console.WriteLine(GetArea());
        Console.WriteLine(GetCircumfrance());
        Console.WriteLine(GetDiameter());
    }

}