class DisplayCurrentJournalSession()
{
    private List<string> listEntries = MakeEntries.GetEntries();
    public void DisplayJournalEntries()
    {
        foreach (var entry in listEntries)
        {
            string[] parts = entry.Split("#");
            Console.WriteLine($"\n{parts[0]} {parts[1]} {parts[2]}\n{parts[3]}\n");
        }

    }

}