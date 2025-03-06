class Load()
{
    public void ReadFromFile()
    {

        Console.WriteLine("What file would you like to open? (Make sure to end the file in .txt) ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string Date = parts[0];
            string Prompt = parts[1]; 
            string Answer = parts[2]; 
            Console.WriteLine($"{Date}, {Prompt}\n{Answer}");
        }
    }
    
}