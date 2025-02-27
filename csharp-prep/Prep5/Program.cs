using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int user_num = PromptUserNumber();
        int squared_num = SquareNumber(user_num);
        DisplayResult(squared_num, name);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your faviortie number? ");
        int user_fav_num = int.Parse(Console.ReadLine());
        return user_fav_num;
    }

    static int SquareNumber(int number_to_be_squared)
    {
        return number_to_be_squared * number_to_be_squared;
    }

    static void DisplayResult(int squared_num, string name)
    {
        Console.WriteLine($"{name}, the square root of your number is {squared_num}");
    }

}