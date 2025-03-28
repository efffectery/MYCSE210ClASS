class Reflection: Activity
{
    private string _nameofActivity = "Reflecting Activity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string[] _propmets = 
    [
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    ];

    private string[] _reflects =
    [
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    ];

    public Reflection() : base()
    {

    }
    
    public void ActivityR()
    {
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetActivityLength());
        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int randIndex = random.Next(_propmets.Length);
            Console.WriteLine(_propmets[randIndex] + "\n");
            LoadAnimation(10);
            randIndex = random.Next(_reflects.Length);
            Console.WriteLine(_reflects[randIndex] + "\n");
            LoadAnimation(10);
        }
    }
    public void ReflectionMain()
    {
        StartingMessage(_nameofActivity, _description);
        ActivityR();
        EndingMessage(_nameofActivity);
    }
    

}