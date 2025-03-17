using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment write = new WritingAssignment("bella", "Making sandwitch", "The art of sandwhich making");
        Console.WriteLine(write.GetSummery());
        Console.WriteLine(write.GetWritingInfo());
        
        MathAssignment math = new MathAssignment("Steve", "trig", "7.3", "8-22");
        Console.WriteLine(math.GetSummery());
        Console.WriteLine(math.GetHomeWorkList());

    }
}