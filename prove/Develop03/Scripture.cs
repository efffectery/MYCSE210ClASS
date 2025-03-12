class Scripture
{
    private List<Word> _words = new List<Word>(); 

    private string _reference;
    

    public Scripture(List<Word> words, string reference)
    {
       _words = words; 
       _reference = reference;
    }
    
    public List<Word> GetScripture()
    {
        return _words;
    }
    public string GetReference()
    {
        return _reference;
    }
    
}