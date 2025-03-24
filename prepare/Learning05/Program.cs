using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

        List<BaseShape> bob = new List<BaseShape>();
        
        bob.Add(new Circle("black", 3.14));
        bob.Add(new Square("red", 10));
        bob.Add(new Rectangle("green", 10, 100));
        
        foreach (BaseShape item in bob)
        {
            Console.WriteLine(item.ComputeArea());
        }



    }
}