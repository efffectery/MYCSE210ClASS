using System.Runtime.ExceptionServices;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _startVerse;
    private string _endVerse;
    
    private string _reference;
    
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _reference = $"{_book} {_chapter}:{_verse}"; 
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}"; 
    }
    
    public string GetReference()
    {
        return _reference;
        
    }


}