using System;

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        Breathing breath = new Breathing();
        Reflection reflect = new Reflection();
        Listing listing = new Listing();

        bool done = false;
        while (done != true)
        {
            int choice = menu.DisplayMenu();
            
            if (choice == 1)
            {
                breath.BreathMain();
            }
            else if (choice == 2)
            {
                reflect.ReflectionMain();
            }
            else if (choice == 3)
            {
                listing.MainListing();
            }
            else if (choice == 4)
            {
                done = true;
            }
            else
            {
                Console.WriteLine("You put in a illegal Value try again!");
                Environment.Exit(0);
            }
        }

    }
}