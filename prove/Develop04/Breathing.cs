using System.IO.Compression;

class Breathing : Activity
{
    private string _nameofActivity = "Breathing Activity";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public Breathing() : base()
    {

    }
    
    public void StartMessageB()
    {
        Console.Write("\n\n");
        StartingMessage(_nameofActivity, _description);
    }
    
    public void EndMessageB()
    {
        Console.Write("\n\n");
        EndingMessage(_nameofActivity);
        Pause(3000);
    }
    
    public void StartActivityB()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...\n");
        LoadAnimation();
    }
    
    public void ActualActivityB(int count)
    {
        while (count > 0)
        {
            Console.Write("Breath in...");
            CountAnimation(6);
            Console.Write("\n");
            Console.Write("Now breath out...");
            CountAnimation(4);
            Console.Write("\n");
            count--;
        }
    }
    
    public void BreathMain()
    {
        StartMessageB();
        StartActivityB();
        ActualActivityB(GetActivityLength() / 10);
        EndMessageB();
    }
        
}
    

    