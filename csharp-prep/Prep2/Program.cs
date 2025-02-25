using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade percentage? ");
        int grade_percent = int.Parse(Console.ReadLine());

        string letter = "N/A";

        if (grade_percent >= 90)
        {
            letter = "A";
        }

        else if (grade_percent >= 80)
        {
            letter = "B";
        }

        else if (grade_percent >= 70)
        {
            letter = "C";
        }

        else if (grade_percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}!");

        if (grade_percent >= 70)
        {
            Console.WriteLine("You Pass!");
        } 

        else
        {
            Console.WriteLine("You Fail!");
        }

    }
}