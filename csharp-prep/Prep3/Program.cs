using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        bool done = false;
        int counter = 0;
        while (done == false)
        {
            Console.Write("What is your Guess? ");
            int user_guess = int.Parse(Console.ReadLine());
            counter++;
            if (magic_num > user_guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_num < user_guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
                Console.WriteLine($"You Guessed {counter} times");
                done = true;
            }
        }
    }
}