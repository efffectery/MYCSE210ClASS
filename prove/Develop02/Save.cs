using System.IO;
using System;

class Save()
{
    private List<string> listEntries = MakeEntries.GetEntries();
    
    public void SaveToFile()
    {
        Console.WriteLine("\nWhat should the file name be? (make sure to end the name in .txt)");
        string fileName = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach (var entry in listEntries)
            {
                outputfile.WriteLine(entry);
            }

        }
        
    }

}