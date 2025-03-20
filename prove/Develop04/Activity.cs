using System.ComponentModel.DataAnnotations;

class Activity
{
    private int _activityLength;

    public Activity()
    {

    }
    
    public void AskNSetActivityLength()
    {
        Console.WriteLine("How long should the duration of the activity be in seconds: ");
        string response = Console.ReadLine();
        _activityLength = int.Parse(response);
        Console.WriteLine("Prepare to Begin!");
        Pause(2000);
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }
    
    public void StartingMessage(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}\n\n{description}\n");
        AskNSetActivityLength();
    }
    public void EndingMessage(string name)
    {
        Console.Clear();
        Console.WriteLine($"You just completed {name} in {_activityLength} seconds");
        Pause(4000);
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