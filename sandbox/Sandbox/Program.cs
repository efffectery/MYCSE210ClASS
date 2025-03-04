class Program
{
    static void Main(string[] args)
    {

        Circle myCircle = new Circle(9);
        Cylinder myCylinder = new Cylinder(7.5, myCircle);
        Console.WriteLine($"the VOlume is {myCylinder.GetVolume()}");



    }
}