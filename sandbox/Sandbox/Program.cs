using System;
using System.IO.Compression;

class Circle
{
    private double radius;

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


class Program
{
    static void Main(string[] args)
    {

        Circle myCircle = new Circle(9);
        //myCircle.DisplayValues();

        for (int i = 0; i < 10; i++)
        {
            myCircle.SetRadius(i);
            myCircle.DisplayValues();

        }

    }
}