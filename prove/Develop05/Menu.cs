using System.Reflection.Metadata;

class Menu
{
    public int DeafaultMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        
        Console.WriteLine("Select a choice from the menu: ");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput < 1 | userInput > 6)
        {
            Console.WriteLine("You need to put in a Number in Range!");
            Environment.Exit(0);
        }
        return userInput;
    }

    public int CreateGoalMenu()
    {
        Console.Clear();
        Console.WriteLine("The Types Of Goals Are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Checklist Goal");
        Console.WriteLine("\t3. Eternal Goal");
        Console.WriteLine("What Goal Do You Want To Create?");
        int userChoice= int.Parse(Console.ReadLine());
        if (userChoice < 1 | userChoice > 3)
        {
            Console.WriteLine("You need to put in a Number in Range!");
            Environment.Exit(0);
        }
        return userChoice;
    }
}