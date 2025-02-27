using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 0;

        while (done == false)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            if (number == 0)
            {
                Console.WriteLine("\n\n");
                done = true;
            }
        } 

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            number += num;
        }

        float average = ((float)number) / numbers.Count;
        int maxnum = numbers.Max();

        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Biggest number is {maxnum}");
        Console.WriteLine($"The sum is {number} ");

    }
}