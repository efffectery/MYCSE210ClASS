using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string verse = "6 In all thy ways acknowledge him, and he shall direct thy paths. 7 Be not wise in thine own eyes: fear the Lord, and depart from evil";
        List<string> words = new List<string>(verse.Split(' '));
        List<Word> scripture = new List<Word>();
        
        foreach(string word in words)
        {
            scripture.Add(new Word(word));
        }   
        
        Reference reference = new Reference("proverbs", "3", "5", "6");
        string stringReference = reference.GetReference();
        Scripture completeScripture = new Scripture(scripture, stringReference);
        
        bool notdone = true;
        while (notdone)
        {
            Console.Clear();
            Console.Write($"{stringReference}\n");
            foreach (Word word in completeScripture.GetScripture())
            {
                word.DisplayWord();
            }

            Console.WriteLine("\nTo remove words press enter, or enter in q to quit");
            string response = Console.ReadLine();

            if (response == "q")
            {
                notdone = false;
            }

            for (int i = 0; i <= 2; i++)
            {
                var visibleWords = completeScripture.GetScripture().Where(word => !word.getIsHide()).ToList();

                if (visibleWords.Count == 0) // Stop if no words left to hide
                {
                    Console.Clear();
                    notdone = false;
                    Console.WriteLine("Congradulations you have completed this scripture!");
                }

                else
                {
                    int index = random.Next(visibleWords.Count);
                    Word randitem = visibleWords[index]; 
                    randitem.HideWord();
                }
                
            }


        }

    }
}