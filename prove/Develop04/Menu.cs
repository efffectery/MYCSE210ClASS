class Menu
{

    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("\t1. Start Breathing Activity");
        Console.WriteLine("\t2. Start Reflecting Activity");
        Console.WriteLine("\t3. Start Listing Activity");
        Console.WriteLine("\t4. Quit");
        
        Console.WriteLine("What is your Choice?");
        return int.Parse(Console.ReadLine());
    }
}