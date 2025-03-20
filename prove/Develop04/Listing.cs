class Listing: Activity
{
    private string _nameofActivity = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string[] _prompts = 
    [
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    ];
    public Listing() : base()
    {

    }
    
    public void StartMessageL()
    {
        Console.Write("\n\n");
        StartingMessage(_nameofActivity, _description);
    }

    public void EndMessageL()
    {  
        Console.Write("\n\n");
        EndingMessage(_nameofActivity);
        Pause(3000);
    }
    
    public void StartActivityL()
    {
        Random random = new Random();
        int randIndex = random.Next(_prompts.Length);
        Console.WriteLine(_prompts[randIndex] + "\n");
        CountAnimation(5);
    }
    
    public int ActualActivityL()
    {
        int entered = 0;
        string input = Console.ReadLine();
        if (input != " ")
        {
           entered += 1; 
        }
        return entered;
   }
    
    public void MainListing()
    {
        StartMessageL();
        StartActivityL();
        int entered = 0;
        DateTime current = DateTime.Now;
        DateTime futureTime = current.AddSeconds(GetActivityLength() - 5);
        Console.Write("Start Entering Entries!");
        while (current < futureTime)
        {
            entered += ActualActivityL();
            current = DateTime.Now;
        }
        Console.WriteLine($"Nice you entered in {entered} entries");
        EndMessageL();
    }
    
    

}