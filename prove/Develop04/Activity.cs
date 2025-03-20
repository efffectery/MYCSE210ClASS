class Activity
{
    private int _activityLength;
    
    protected Random _random = new Random();

    public Activity()
    {

    }
    
    public void AskNSetActivityLength()
    {
        Console.WriteLine("How long should the duration of the activity be in seconds: ");
        string response = Console.ReadLine();
        _activityLength = int.Parse(response);
        Console.WriteLine("Prepare to Begin!");
        Pause(100);
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }
    
    public void StartingMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}\n\n{description}\n");
        AskNSetActivityLength();

    }
    public void EndingMessage(string name)
    {
        Console.WriteLine($"You just completed {name} in {_activityLength} seconds");
    }
    
    public void Pause(int time)
    {
        Thread.Sleep(time);        
    }
    
    public void LoadAnimation(int future)
    {
        DateTime endtime = DateTime.Now.AddSeconds(future);
        while(DateTime.Now < endtime)
        {
            Console.Write("\\");
            Pause(100);
            Console.Write("\b\b \b");
            Console.Write("|");
            Pause(100);
            Console.Write("\b \b");
            Console.Write("/");
            Pause(100);
            Console.Write("\b \b");
            Console.Write("-");
            Pause(100);
            Console.Write("\b \b");
        }
    }
    
    public void CountAnimation(int count)
    {
        while (count > 0)
        {
            Console.Write(count);
            Pause(1000);
            Console.Write("\b \b");
            count--;
        }
    }
    

}