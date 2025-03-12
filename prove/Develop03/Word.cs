using System.Runtime.InteropServices.Swift;

class Word
{
    private string _word;
    private bool _isHide;
    
    public Word(string word, bool isHide = false)
    {
        _word = word;
        _isHide = isHide;
    }
    
    public string HideWord()
    {
        _isHide = true;
        _word = string.Concat(_word.Select(c => "_"));
        return _word;
    }
    
    public bool getIsHide()
    {
        if (_isHide == true)
        {
            return true;
        }
        return false;
    }
    
    public void DisplayWord()
    {
        Console.Write($"{_word} ");
    }

}