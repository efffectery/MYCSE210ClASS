class Menu
{
    private List<string> menuItems = new List<string> {"1. Write", "2. Display Session", "3. Save", "4. Read", "5. Quit"};
    

    public void ShowMenu()
    {
        foreach (string item in menuItems)
        {
            Console.WriteLine(item);
        }
        
    }

}