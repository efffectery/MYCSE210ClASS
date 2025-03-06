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
            string Name = parts[0];
            string Date = parts[1];
            string Prompt = parts[2]; 
            string Answer = parts[3]; 
            Console.WriteLine($"\n{Date}, {Prompt}\n{Answer}");
        }
    }
    
}