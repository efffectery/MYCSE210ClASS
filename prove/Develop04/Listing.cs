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
    
    public void StartActivityL()
    {
        Console.Clear();
        Random random = new Random();
        int randIndex = random.Next(_prompts.Length);
        Console.WriteLine(_prompts[randIndex] + "\n");
        CountAnimation(5);
    }
    
    public int ActualActivityL()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetActivityLength());
        int entered = 0;
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input != " ")
            {
               entered += 1; 
            }
        }
        return entered;
   }
    
    public void MainListing()
    {
        StartingMessage(_nameofActivity, _description);
        StartActivityL();
        ActualActivityL();
        EndingMessage(_nameofActivity);
    }
    
    

}