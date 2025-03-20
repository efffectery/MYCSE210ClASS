class Menu
{

    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("\t1. Start Breathing Activity (Takes At Least 10 Seconds)");
        Console.WriteLine("\t2. Start Reflecting Activity (Takes At Least 20 Seconds)");
        Console.WriteLine("\t3. Start Listing Activity (Takes as long as you enter your last entry)");
        Console.WriteLine("\t4. Quit");
        
        Console.WriteLine("What is your Choice?");
        return int.Parse(Console.ReadLine());
    }
}